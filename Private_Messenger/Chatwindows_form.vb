Imports MySql.Data.MySqlClient ' import MySQL Client MoDule

Public Class Chatwindows_form

    Dim MySQLConnectionString = "server=127.0.0.1; user id=root; password=; database=db_priv8msg; Character Set=utf8;" ' ประกาศ connection string
    Dim MyConnection As New MySqlConnection ' สร้าง object สำหรับการเชื่อมต่อฐานข้อมูล
    Dim SQLDmd As New MySqlCommand ' สร้าง object สำหรับรัน SQL Command
    Dim datareader As MySqlDataReader ' สร้าง Datareader object


    Private Sub readfriends() ' สร้าง Sub สำหรับอ่านค่าเพื่อนใน chatroom ว่ามี user ไหน online อยู่บ้าง
        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        Dim queryOnlineFriends As String = "SELECT * FROM tb_users" ' select ค่า ทั้งหมดใน ตาราง tb_users
        SQLDmd = New MySqlCommand(queryOnlineFriends, MyConnection) ' สร้าง SQL Command object
        MyConnection.Open() ' เปิดการเชื่อมต่อ
        datareader = SQLDmd.ExecuteReader ' Execute Reader
        While datareader.Read() ' วนลูปในขณะที่กำลังอ่านค่าใน Data Reader
            If datareader(8).ToString = "t" Then ' หากค่าใน datareader(8) (column ที่ 9 ) มีค่าเป็น "t"
                lsbUserList.Items.Add(datareader(1).ToString + " - [ONLINE]") ' ให้นำค่าใน datareader(1) (Username) add เข้าไปใน lsbUserList และ ต่อ String ด้วย " - [ONLINE]"
            Else ' หากค่าใน datareader(8) (column ที่ 9 ) ไม่เท่ากับ "t"
                lsbUserList.Items.Add(datareader(1).ToString + " - [OFFLINE]") ' ให้นำค่าใน datareader(1) (Username) add เข้าไปใน lsbUserList และ ต่อ String ด้วย " - [OFFLINE]"
            End If
        End While
        datareader.Close() ' ปิด DataReader
    End Sub
    Private Sub reachuserinfo() ' สร้าง Sub สำหรับดึงข้อมูลของ User ที่ Login มาแสดงผล
        Dim readuserinfo As String = "SELECT * FROM tb_users WHERE username='" & My.Settings.Username & "'" ' select ค่าทั้งหมดใน tb_users ที่ username=ค่าใน setting
        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        SQLDmd = New MySqlCommand(readuserinfo, MyConnection) ' สร้าง SQL Command object
        MyConnection.Open() ' เปิดการเชื่อมต่อ
        datareader = SQLDmd.ExecuteReader ' Execute Reader
        datareader.Read() ' อ่านค่าใน Data Reader
        If datareader.HasRows Then ' ถ้ามี Data Reader มี record blah blah blah
            Label2.Text = datareader.Item("fname").ToString & " " & datareader.Item("sname").ToString ' กำหนดให้ Label2.Text = Firstname และ Lastname ของ user คนนั้น
            Label6.Text = datareader.Item("gender").ToString ' กำหนด Label6.Text ให้มีค่าเท่ากับเพศของ User คนนั้น
        End If
        MyConnection.Close() ' ปิดการเชื่อมต่อ
    End Sub

    Sub ExecuteQuery(query As String) ' ประกาศ sub สำหรับใช้ Execute SQL Command โดยรับ SQL Command
        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        SQLDmd = New MySqlCommand(query, MyConnection) ' สร้าง SQL Command object
        MyConnection.Open() ' เปิดการเชื่อมต่อ
        SQLDmd.ExecuteNonQuery() ' Execute SQL Command 
        MyConnection.Close() ' ปิดการเชื่อมต่อ
    End Sub
    Private Sub ReadChatData() ' สร้าง Sub สำหรับอ่านข้อมูลการแชท
        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        Dim cmdreadchat As String = "SELECT * FROM tb_chat" ' สร้างคำสั่ง SQL สำหรับดึงข้อมูลแชทใน DB 
        SQLDmd = New MySqlCommand(cmdreadchat, MyConnection) ' สร้าง SQL Command object
        MyConnection.Open() ' เปิดการเชื่อมต่อ
        datareader = SQLDmd.ExecuteReader ' Execute Reader
        While datareader.Read() ' ในขณะทีทำการอ่านข้อมูล
            If Not datareader(1).ToString = RtbxChatBox.Text Then ' หากข้อมูลใน datareader(1) (ข้อมูลแชท) ไม่เหมือนกับใน RtbxChatBox.Text
                RtbxChatBox.Text = datareader(1).ToString ' ให้กำหนดค่าใน RtbxChatBox.Text มีค่าเหมือนกันกับ ใน datareader(1) (ข้อมูลแชท)
            End If
        End While
        datareader.Close() ' ปิด datareader
    End Sub



    Private Sub Chatwindows_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '--------------------------------------------- เมื่อ  Chatwindows_form() ถูกโหลดขึ้นมาให้ดำเนินการดังนี้
        TmReadOnlineFrn.Enabled = True ' กำหนด TmReadOnlineFrn.Enabled = True (เริ่มการทำงานของ Timer ในการดึงรายการเพื่อนในระบบ)
        TmChatLog.Enabled = True ' กำ หนด TmChatLog.Enabled = True (เริ่มการทำงานของ Timer ในการดึงข้อมูลแชทในระบบ)
        Timer1.Enabled = True ' กำหนด  Timer1.Enabled = True (เริ่มการทำงานของ Timer สำหรับตัวนับเวลาและวันที่)
        lblUsername.Text = My.Settings.Username ' กำหนด  lblUsername.Text = Username ที่ login เข้ามาในระบบ ซึ่งได้ถูกเก็บไว้ใน My.Settings.Username อยู่แล้ว

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) ' ปุ่มอะไรซักอย่าง จำไม่ได้ แต่ตอนนี้ไม่ได้ใช้แล้ว :p
        readfriends()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick ' Timer1_tick
        lblTimeNow.Text = Now.ToLongTimeString ' ตั้งเวลาให้กับ lblTimeNow.Text
        lblDateNow.Text = Now.ToShortDateString ' ตั้งวันที่ให้กับ lblDateNow.Text
    End Sub

    Private Sub TmChatLog_Tick(sender As Object, e As EventArgs) Handles TmChatLog.Tick ' TmChatLog_Tick
        ReadChatData() ' เรียกใช้ Sub  ReadChatData() เพื่ออ่านข้อมูลการแชท
    End Sub



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) ' ดึงมาใส่ไว้แต่ไม่รู้จะทำอะไร จนตอนนี้ก็ไม่ได้ใช้แล้ว 

    End Sub

    Private Sub TmReadOnlineFrn_Tick(sender As Object, e As EventArgs) Handles TmReadOnlineFrn.Tick ' TmReadOnlineFrn_Tick
        lsbUserList.Items.Clear() ' เคลียร์ lsbUserList
        readfriends() ' อ่านรายการเพื่อนที่ออนไลน์ในระบบ
        reachuserinfo() ' อ่านข้อมูลของ user ที่ login อยู่ ณ ขณะนี้
    End Sub

    Private Sub lsbUserList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbUserList.SelectedIndexChanged ' lsbUserList.SelectedIndexChanged ไม่ได้ใช้แล้ว 

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub RtbxChatBox_textchanged() Handles RtbxChatBox.TextChanged
    '   RtbxChatBox.ScrollToCaret()
    'End Sub


    Private Sub RtbxChatBox_TextChanged(sender As Object, e As EventArgs) Handles RtbxChatBox.TextChanged ' เมื่อข้อความใน RtbxChatBox เปลี่ยนแปลง
        RtbxChatBox.SelectionStart() = RtbxChatBox.TextLength ' เปลี่ยนตำแหน่ง start ให้เท่ากับ RtbxChatBox.TextLength (ขนาดของข้อความ)
        RtbxChatBox.ScrollToCaret() ' Scroll RtbxChatBox ไปยัง ^
    End Sub

    Private Sub tbxMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxMsg.KeyDown ' หากมี event KeyDown ใน tbxMsg
        If e.KeyCode = Keys.Enter Then ' หากมีการกด Enter
            If tbxMsg.Text = "" Then ' หากไม่มีข้อความใน tbxMsg ก็ไม่ต้องทำอะไร
            Else
                ' หากมีข้อความใน tbxMsg ให้ทำการ update ค่าใน ตาราง chat
                RtbxChatBox.Text += vbNewLine & vbNewLine & "[" & lblDateNow.Text & "-" & lblTimeNow.Text & "]" & " - " & My.Settings.Username & ": " & tbxMsg.Text
                Dim updatechatlog As String = "UPDATE tb_chat SET chat='" & RtbxChatBox.Text & "'"
                ExecuteQuery(updatechatlog)
                tbxMsg.Text = "" ' เคลียร์ข้อความใน tbxMsg หลังจากกด Enter
            End If
        End If
    End Sub

    Private Sub tbxMsg_TextChanged(sender As Object, e As EventArgs) Handles tbxMsg.TextChanged ' ไม่ได้ใช้แล้ว

    End Sub

    Private Sub ViewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProfileToolStripMenuItem.Click ' หากมีการเรียกใช้ Context Menu ในการ ดู โปรไฟล์
        If lsbUserList.SelectedItems.Count = 0 Then ' หากยังไม่ได้เลือก item ที่จะดู
            MessageBox.Show("Please Select User for View!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' ให้แจ้ง error
        Else ' หากเลือกแล้ว
            Dim fix_name As String = lsbUserList.Items(lsbUserList.SelectedIndex) ' ให้ทำการเก็บค่า String ของ Item ที่เลือกไว้ในตัวแปร fix_name
            Dim namecut As String() = fix_name.Split(New Char() {" "c}) ' จากนั้นนำ fix_name มาทำการตัดคำออกเป็น array โดยใช้ Method Split() แยกชุด string ด้วย " " (ช่องว่าง)
            My.Settings.Username_view = namecut(0) ' เมื่อ split เสร็จแล้ว ให้ตั้งค่า Settings.Username_view เป็นชื่อของ User ที่เราจะดูโปรไฟล์ โดยนำมาจากผลลัพธ์การ split namecut(0)
            ViewUserProfilevb.Show()
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click ' ปุ่ม logout
        Dim qeuryLogoutUpdate As String = "UPDATE tb_users Set online_status='f' WHERE username='" & My.Settings.Username & "'" ' เซ็ตค่า online_status ของ user ที่กด logout เป็น "f"
        Try
            ExecuteQuery(qeuryLogoutUpdate) ' Execute SQL Command
            MessageBox.Show("Logout Complete!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' แสดงผล MessageBox แจ้งผลการ Logout
            Form1.Show() ' แสดงผล Form1
            Me.Close() ' ปิด form นี้
        Catch ex As Exception
            MessageBox.Show("Logout Failed!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' แสดงผล MessageBox แจ้งผลการ Logout
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click ' ทำงานเหมือนกับ tbxMsg_KeyDown()
        If tbxMsg.Text = "" Then
        Else
            RtbxChatBox.Text += vbNewLine & vbNewLine & "[" & lblDateNow.Text & "-" & lblTimeNow.Text & "]" & " - " & My.Settings.Username & ": " & tbxMsg.Text
            Dim updatechatlog As String = "UPDATE tb_chat SET chat='" & RtbxChatBox.Text & "'"
            ExecuteQuery(updatechatlog)
            tbxMsg.Text = ""
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        editprofile.Show()
    End Sub
End Class
