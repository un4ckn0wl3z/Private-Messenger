Imports MySql.Data.MySqlClient ' import MySQL Client MoDule
Public Class editprofile

    Dim MySQLConnectionString = "server=127.0.0.1; user id=root; password=; database=db_priv8msg; Character Set=utf8;" ' ประกาศ connection string
    Dim MyConnection As New MySqlConnection ' สร้าง object สำหรับการเชื่อมต่อฐานข้อมูล
    Dim SQLDmd As New MySqlCommand ' สร้าง object สำหรับรัน SQL Command
    Dim datareader As MySqlDataReader ' สร้าง Datareader object

    Sub ExecuteQuery(query As String)  ' ประกาศ sub สำหรับใช้ Execute SQL Command โดยรับ SQL Command
        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        SQLDmd = New MySqlCommand(query, MyConnection) ' สร้าง SQL Command object
        MyConnection.Open() ' เปิดการเชื่อมต่อ
        SQLDmd.ExecuteNonQuery() ' Execute SQL Command 
        MyConnection.Close() ' ปิดการเชื่อมต่อ
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub editprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' เมื่อ form editprofile ถูกโหลดขึ้นมา

        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        Dim ReadUserdata As String = "SELECT * FROM tb_users WHERE username='" & My.Settings.Username & "'" ' ทำการ select ข้อมูลทุกอย่าง ของ User ที่ Login
        SQLDmd = New MySqlCommand(ReadUserdata, MyConnection) ' สร้าง SQL Command object
        MyConnection.Open() ' เปิดการเชื่อมต่อ
        datareader = SQLDmd.ExecuteReader ' Execute Reader
        datareader.Read() ' อ่านค่าใน Data Reader
        If datareader.HasRows Then ' ถ้ามี Data Reader มี record blah blah blah
            MetroTextBox2.Text = datareader.Item("fname").ToString ' กำหนด MetroTextBox2.Text ให้มีค่าเท่ากับ column "fname"
            MetroTextBox3.Text = datareader.Item("sname").ToString ' กำหนด MetroTextBox3.Text ให้มีค่าเท่ากับ column "sname"
            MetroTextBox4.Text = datareader.Item("password").ToString ' กำหนด MetroTextBox4.Text ให้มีค่าเท่ากับ column "password"
            MetroTextBox5.Text = datareader.Item("password").ToString ' กำหนด MetroTextBox5.Text ให้มีค่าเท่ากับ column "password"
            MetroTextBox6.Text = datareader.Item("email").ToString ' กำหนด MetroTextBox6.Text ให้มีค่าเท่ากับ column "email"
            If datareader.Item("gender").ToString = "Male" Then ' หากข้อมูลใน column gender มีค่าเป็น "Male" 
                MetroRadioButton1.Checked = True ' ให้ MetroRadioButton1.Checked = True
            Else ' หากไม่ใช่
                MetroRadioButton2.Checked = True ' ให้ MetroRadioButton2.Checked = True
            End If
        End If
        MyConnection.Close() ' ปิดการเชื่อมต่อ
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click ' ปุ่ม edit
        MetroTextBox2.ReadOnly = False ' ตั้ง MetroTextBox2.ReadOnly = False
        MetroTextBox3.ReadOnly = False ' ตั้ง MetroTextBox3.ReadOnly = False
        MetroTextBox4.ReadOnly = False ' ตั้ง MetroTextBox4.ReadOnly = False
        MetroTextBox5.ReadOnly = False ' ตั้ง MetroTextBox5.ReadOnly = False
        MetroTextBox6.ReadOnly = False ' ตั้ง MetroTextBox6.ReadOnly = False
        MetroButton1.Visible = False ' ตั้ง MetroButton1.Visible = False 
        MetroButton2.Visible = True ' ตั้ง MetroButton2.Visible = True
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click ' ปุ่ม save
        If MetroTextBox2.Text = "" Or MetroTextBox3.Text = "" Or MetroTextBox4.Text = "" Or MetroTextBox5.Text = "" Or MetroTextBox6.Text = "" Then ' หากมีค่าว่าง
            MessageBox.Show("Please enter your infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' ให้แจ้ง error
        ElseIf MetroTextBox4.Text <> MetroTextBox5.Text Then ' หากรหัสผ่านไม่ตรง
            MessageBox.Show("Password not Match.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' แจ้ง error
        Else
            Dim gender As String ' สร้าง ตัวแปรเก็บค่าเพศ
            If MetroRadioButton1.Checked = True Then ' หาก MetroRadioButton1.Checked = True
                gender = MetroRadioButton1.Text ' ให้เ gender = gender = MetroRadioButton1.Text
            Else ' หากไม่ใช่
                gender = MetroRadioButton2.Text ' ให้เ gender = gender = MetroRadioButton2.Text
            End If
            ' สร้าง SQL Command สำหรับการ Update ข้อมูล
            Dim updateUserProfile As String = "UPDATE tb_users Set fname='" & MetroTextBox2.Text & "',sname='" & MetroTextBox3.Text & "',password='" & MetroTextBox4.Text & "',email='" & MetroTextBox6.Text & "',gender='" & gender & "' WHERE username='" & My.Settings.Username & "'"
            Try
                ExecuteQuery(updateUserProfile) ' Execute SQL Command
                MessageBox.Show("Your Profile Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MetroTextBox2.ReadOnly = True ' ตั้ง MetroTextBox2.ReadOnly = True
                MetroTextBox3.ReadOnly = True ' ตั้ง MetroTextBox3.ReadOnly = True
                MetroTextBox4.ReadOnly = True ' ตั้ง MetroTextBox4.ReadOnly = True
                MetroTextBox5.ReadOnly = True ' ตั้ง MetroTextBox5.ReadOnly = True
                MetroTextBox6.ReadOnly = True ' ตั้ง MetroTextBox6.ReadOnly = True
                MetroButton2.Visible = False ' ตั้ง MetroButton2.Visible = False
                MetroButton1.Visible = True ' MetroButton1.Visible = True 
            Catch ex As Exception
                MessageBox.Show("Something Worng!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' หากมีข้อผิดพลาด ให้แจ้ง error
            End Try
        End If

        'MessageBox.Show("Saved your Profile.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class