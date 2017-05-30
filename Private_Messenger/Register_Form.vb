Imports MySql.Data.MySqlClient ' Import MySQL Module
Imports System.IO ' Import System.IO Module
Imports System.Text ' Import System.Text


Public Class Register_Form
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

    Private Sub Register_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Register Account" ' เมื่อ Register_Form ถูกโหลดขึ้นมาให้แก้ Text Property ของ Register_Form เป็น "Register Account"
    End Sub

    Private Sub btnChooseIMG_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click ' ปุ่ม save ข้อมูลลง DB
        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        If MetroTextBox1.Text = "" Or MetroTextBox2.Text = "" Or MetroTextBox3.Text = "" Or MetroTextBox4.Text = "" Or MetroTextBox5.Text = "" Or MetroTextBox6.Text = "" Then
            MessageBox.Show("Please enter your infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' หากผู้ใช้กรอกข้อมูลไม่ครบก็ให้แจ้งเตือน Error
        ElseIf MetroTextBox4.Text <> MetroTextBox5.Text Then ' หากการยืนยันรหัสผ่านไม่ตรงกัน ก็แจ้ง Error
            MessageBox.Show("Password not Match.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Err Message eiei
        Else
            Dim gender As String ' กำหนดตัวแปรไว้เก็บค่าเพศ
            If MetroRadioButton1.Checked = True Then ' หาก MetroRadioButton1 (เพศชาย) นั้นถูกติ๊กอยู่แล้ว
                gender = MetroRadioButton1.Text ' ให้เพศ เป็นเพศชาย
            Else
                gender = MetroRadioButton2.Text ' แต่หาก MetroRadioButton1 ไม่ถูกติ๊ก ให้เพศ เป็นเพศหญิง
            End If
            ' สร้าง SQL Command สำหรับ INSERT ข้อมูลลงใน DB 
            Dim sql As String = "INSERT INTO tb_users(username,password,fname,sname,email,gender) VALUES('" & MetroTextBox1.Text & "','" _
                                & MetroTextBox4.Text & "','" & MetroTextBox2.Text & "','" & MetroTextBox3.Text & "','" & MetroTextBox6.Text & "','" & gender & "')"
            SQLDmd = New MySqlCommand(sql, MyConnection) ' สร้าง SQL Command object
            Try ' Try . . Carch BLOCK
                MyConnection.Open() ' เปิดการเชื่อมต่อ
                datareader = SQLDmd.ExecuteReader ' Execute Reader
                MyConnection.Close() ' ปิดการเชื่อมต่อ
                MessageBox.Show("Register Complete!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' แจ้งผลการ ลงทะเบียน หากไม่มีข้อผิดพลาด
            Catch ex As Exception
                MessageBox.Show("This Username Already Registered!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error) ' หากมี Username อยู่ในระบบแล้ว ให้เด้ง Err
            End Try
        End If

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click ' ปุ่ม Back ไปหน้า Login
        Form1.MetroTextBox1.Text = MetroTextBox1.Text ' ส่งค่า Username จากการลงทะเบียน กลับไปยังหน้า Login
        Form1.MetroTextBox2.Text = MetroTextBox4.Text ' ส่งค่า Password จากการลงทะเบียน กลับไปยังหน้า Login
        Form1.Show() ' แสดง หน้า Login หรือ Form1()
        Me.Close() ' ปิด Form ลงทะเบียน
    End Sub



    Private Sub gbxGender_Enter(sender As Object, e As EventArgs) Handles gbxGender.Enter

    End Sub

    Private Sub MetroRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroRadioButton1.CheckedChanged

    End Sub
End Class