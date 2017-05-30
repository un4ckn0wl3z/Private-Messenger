Imports MySql.Data.MySqlClient ' import MySQL Module

Public Class Form1
    Dim MySQLConnectionString = "server=127.0.0.1; user id=root; password=; database=db_priv8msg; Character Set=utf8;" ' ประกาศ connection string
    Dim MyConnection As New MySqlConnection ' สร้าง object สำหรับการเชื่อมต่อฐานข้อมูล
    Dim SQLDmd As New MySqlCommand ' สร้าง object สำหรับรัน SQL Command
    Dim datareader As MySqlDataReader ' สร้าง Datareader object
    Sub ExecuteQuery(query As String) ' ประกาศ sub สำหรับใช้ Execute SQL Command โดยรับ SQL Command
        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        SQLDmd = New MySqlCommand(query, MyConnection) ' สร้าง SQL Command object
        MyConnection.Open() ' เปิดการเชื่อมต่อ
        SQLDmd.ExecuteNonQuery() ' Execute SQL Command 
        MyConnection.Close() ' ปิดการเชื่อมต่อ
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) ' ปุ่มลงทะเบียน เดิม
        Register_Form.Show() ' เมื่อผู้ใช้กดปุ่มสำหรับลงทะเบียนให้เปิด Register_Form()
        Me.Hide() ' และให้ซ่อน form ปัจจุบันไว้

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) ' ปุ่ม login เดิม
        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        Dim sql As String = "SELECT * FROM tb_users WHERE username='" & MetroTextBox1.Text & "'" ' ใช้ คำสั่ง SQL ในการดึง username ในฐานข้อมูล
        SQLDmd = New MySqlCommand(sql, MyConnection) ' สร้าง SQL Command object
        If MetroTextBox1.Text = "" Or MetroTextBox2.Text = "" Then ' หาก ผู้ใช้ไม่ได้ป้อนค่าให้กับ username และ password
            MessageBox.Show("Please enter Username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' ให้แจ้งเตือน Error
        Else
            Try ' try...catch block
                MyConnection.Open() ' เปิดการเชื่อมต่อ
                Dim rdr As MySqlDataReader = SQLDmd.ExecuteReader ' สร้าง DataReader Object และ ทำการ Execute
                rdr.Read() ' อ่านค่าในจาการ Execute Reader
                If rdr(1).ToString = MetroTextBox1.Text Then 'หากเจอข้อมูลใน username ในฐานข้อมูล
                    If rdr(2).ToString = MetroTextBox2.Text Then ' ตรวจสอบ password
                        My.Settings.Username = MetroTextBox1.Text ' หาก password ตรงกัน ให้ทำการเก็บ username ไว้ใน setting ที่ชื่อ Username
                        MessageBox.Show("Login Complete!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' และแสดงผล MessageBox บอกรายละเอียด
                        MyConnection.Close() ' ปิด Connection
                        Dim qeuryOnlineUpdate As String = "UPDATE tb_users Set online_status='t' WHERE username='" & My.Settings.Username & "'"
                        ExecuteQuery(qeuryOnlineUpdate) ' เมื่อข้อมูลผู้ใช้ถูกต้อง ให้ทำการ update ใน column online_status ของ user นั้นให้มีค่าเป็น "t" 
                        Chatwindows_form.Show() ' แล้วเปิด Chatwindows_form() ขึ้นมา
                        Me.Hide() ' ทำการซ่อน form() ปัจจุบันไว้
                    Else
                        MessageBox.Show("Incorrect Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' หาก รหัสผ่านไม่ถูกต้อง ให้แจ้ง Error
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Login Failed, Username not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' หากไม้พบข้มูล username ให้แจ้ง error
            End Try
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click ' ปุ่ม login เดิม Metro
        MyConnection = New MySqlConnection(MySQLConnectionString)
        Dim sql As String = "SELECT * FROM tb_users WHERE username='" & MetroTextBox1.Text & "'"
        SQLDmd = New MySqlCommand(sql, MyConnection)
        If MetroTextBox1.Text = "" Or MetroTextBox2.Text = "" Then
            MessageBox.Show("Please enter Username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                MyConnection.Open()
                Dim rdr As MySqlDataReader = SQLDmd.ExecuteReader
                rdr.Read()
                If rdr(1).ToString = MetroTextBox1.Text Then
                    If rdr(2).ToString = MetroTextBox2.Text Then
                        My.Settings.Username = MetroTextBox1.Text
                        MessageBox.Show("Login Complete!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MyConnection.Close()
                        Dim qeuryOnlineUpdate As String = "UPDATE tb_users Set online_status='t' WHERE username='" & My.Settings.Username & "'"
                        ExecuteQuery(qeuryOnlineUpdate)
                        Chatwindows_form.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Incorrect Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Login Failed, Username not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click ' ปุ่มลงทะเบียน Metro
        Register_Form.Show()
        Me.Hide()
    End Sub

    Private Sub tbxUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles MetroTextBox1.Click

    End Sub
End Class
