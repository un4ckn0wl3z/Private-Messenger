<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Form
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_Form))
        Me.gbxGender = New System.Windows.Forms.GroupBox()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox6 = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxGender.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxGender
        '
        Me.gbxGender.Controls.Add(Me.MetroRadioButton2)
        Me.gbxGender.Controls.Add(Me.MetroRadioButton1)
        Me.gbxGender.Location = New System.Drawing.Point(423, 64)
        Me.gbxGender.Name = "gbxGender"
        Me.gbxGender.Size = New System.Drawing.Size(178, 81)
        Me.gbxGender.TabIndex = 16
        Me.gbxGender.TabStop = False
        Me.gbxGender.Text = "Gender"
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(48, 50)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(61, 15)
        Me.MetroRadioButton2.TabIndex = 33
        Me.MetroRadioButton2.Text = "Female"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Checked = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(48, 29)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(49, 15)
        Me.MetroRadioButton1.TabIndex = 32
        Me.MetroRadioButton1.TabStop = True
        Me.MetroRadioButton1.Text = "Male"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(69, 64)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "Enter Username:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(69, 112)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Enter Firstname:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(69, 154)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel3.TabIndex = 19
        Me.MetroLabel3.Text = "Enter Surname:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(69, 198)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel4.TabIndex = 20
        Me.MetroLabel4.Text = "Enter Password:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(69, 238)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel5.TabIndex = 21
        Me.MetroLabel5.Text = "Re-Enter Password:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(69, 274)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel6.TabIndex = 22
        Me.MetroLabel6.Text = "Enter Email:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(423, 177)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 23
        Me.MetroButton1.Text = "OK"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(525, 177)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 24
        Me.MetroButton2.Text = "Back"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(204, 64)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(177, 23)
        Me.MetroTextBox1.TabIndex = 25
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(204, 108)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(177, 23)
        Me.MetroTextBox2.TabIndex = 26
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = Nothing
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(204, 150)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.ShortcutsEnabled = True
        Me.MetroTextBox3.Size = New System.Drawing.Size(177, 23)
        Me.MetroTextBox3.TabIndex = 27
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox4
        '
        '
        '
        '
        Me.MetroTextBox4.CustomButton.Image = Nothing
        Me.MetroTextBox4.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.MetroTextBox4.CustomButton.Name = ""
        Me.MetroTextBox4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox4.CustomButton.TabIndex = 1
        Me.MetroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox4.CustomButton.UseSelectable = True
        Me.MetroTextBox4.CustomButton.Visible = False
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(204, 194)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.SelectionLength = 0
        Me.MetroTextBox4.SelectionStart = 0
        Me.MetroTextBox4.ShortcutsEnabled = True
        Me.MetroTextBox4.Size = New System.Drawing.Size(177, 23)
        Me.MetroTextBox4.TabIndex = 28
        Me.MetroTextBox4.UseSelectable = True
        Me.MetroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox5
        '
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = Nothing
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.Lines = New String(-1) {}
        Me.MetroTextBox5.Location = New System.Drawing.Point(204, 234)
        Me.MetroTextBox5.MaxLength = 32767
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.ShortcutsEnabled = True
        Me.MetroTextBox5.Size = New System.Drawing.Size(177, 23)
        Me.MetroTextBox5.TabIndex = 29
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox6
        '
        '
        '
        '
        Me.MetroTextBox6.CustomButton.Image = Nothing
        Me.MetroTextBox6.CustomButton.Location = New System.Drawing.Point(225, 1)
        Me.MetroTextBox6.CustomButton.Name = ""
        Me.MetroTextBox6.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox6.CustomButton.TabIndex = 1
        Me.MetroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox6.CustomButton.UseSelectable = True
        Me.MetroTextBox6.CustomButton.Visible = False
        Me.MetroTextBox6.Lines = New String(-1) {}
        Me.MetroTextBox6.Location = New System.Drawing.Point(204, 270)
        Me.MetroTextBox6.MaxLength = 32767
        Me.MetroTextBox6.Name = "MetroTextBox6"
        Me.MetroTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox6.SelectedText = ""
        Me.MetroTextBox6.SelectionLength = 0
        Me.MetroTextBox6.SelectionStart = 0
        Me.MetroTextBox6.ShortcutsEnabled = True
        Me.MetroTextBox6.Size = New System.Drawing.Size(247, 23)
        Me.MetroTextBox6.TabIndex = 30
        Me.MetroTextBox6.UseSelectable = True
        Me.MetroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox6.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Private_Messenger.My.Resources.Resources.Ph03nyx_Super_Mario_Paper_Bowser
        Me.PictureBox1.Location = New System.Drawing.Point(605, 287)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 28)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Register_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 323)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroTextBox6)
        Me.Controls.Add(Me.MetroTextBox5)
        Me.Controls.Add(Me.MetroTextBox4)
        Me.Controls.Add(Me.MetroTextBox3)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.gbxGender)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register_Form"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Register_Form"
        Me.gbxGender.ResumeLayout(False)
        Me.gbxGender.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxGender As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
