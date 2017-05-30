Imports MySql.Data.MySqlClient ' Import MySQL Module
Imports System.IO ' Import System.IO Module
Imports System.Text ' Import System.Text
Public Class ViewUserProfilevb
    Dim MySQLConnectionString = "server=127.0.0.1; user id=root; password=; database=db_priv8msg; Character Set=utf8;" ' ประกาศ connection string
    Dim MyConnection As New MySqlConnection ' สร้าง object สำหรับการเชื่อมต่อฐานข้อมูล
    Dim SQLDmd As New MySqlCommand ' สร้าง object สำหรับรัน SQL Command
    Dim datareader As MySqlDataReader ' สร้าง Datareader object

    Private Sub ViewUserProfilevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' เมื่อ form ถูกโหลดขึ้นมา
        Me.Text = My.Settings.Username_view + "'s Profile." ' กำหนดให้ text ของ form นี้ เท่ากับตัวแปร My.Settings.Username_view

        MyConnection = New MySqlConnection(MySQLConnectionString) ' สร้าง Connection Object ตามที้่ระบุไว้ใน Connection String
        Dim ReadUserdata As String = "SELECT * FROM tb_users WHERE username='" & My.Settings.Username_view & "'" ' ดึงข้อมูลในตาราง tb_users ทั้งหมดของ user ที่เราจะดูโปรไฟล์
        SQLDmd = New MySqlCommand(ReadUserdata, MyConnection) ' สร้าง SQL Command object
        MyConnection.Open() ' เปิดการเชื่อมต่อ
        datareader = SQLDmd.ExecuteReader ' Execute Reader
        datareader.Read() ' อ่านค่าใน datareader
        If datareader.HasRows Then ' หาก datareader มีข้อมูล
            MetroTextBox1.Text = datareader.Item("username").ToString ' ให้ MetroTextBox1.Text = datareader.Item("username").ToString
            MetroTextBox2.Text = datareader.Item("fname").ToString ' ให้ MetroTextBox2.Text = datareader.Item("fname").ToString
            MetroTextBox3.Text = datareader.Item("sname").ToString ' ให้ MetroTextBox3.Text = datareader.Item("sname").ToString
            MetroTextBox5.Text = datareader.Item("email").ToString ' ให้ MetroTextBox5.Text = datareader.Item("email").ToString
            MetroTextBox4.Text = datareader.Item("gender").ToString ' ให้ MetroTextBox4.Text = datareader.Item("gender").ToString
        End If
        MyConnection.Close() ' ปิดการเชื่อมต่อ
        My.Settings.Username_view = "" ' เคลียร์ค่าใน My.Settings.Username_view
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class