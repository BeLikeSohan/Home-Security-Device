<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.glow4 = New System.Windows.Forms.PictureBox()
        Me.glow3 = New System.Windows.Forms.PictureBox()
        Me.glow2 = New System.Windows.Forms.PictureBox()
        Me.glow_cp = New System.Windows.Forms.PictureBox()
        Me.glow1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.room4 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.room3 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.room2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.room1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cpanel = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.security = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadialMenu1 = New DevComponents.DotNetBar.RadialMenu()
        Me.restart = New DevComponents.DotNetBar.RadialMenuItem()
        Me.about = New DevComponents.DotNetBar.RadialMenuItem()
        Me.exit_btn = New DevComponents.DotNetBar.RadialMenuItem()
        Me.contacts = New DevComponents.DotNetBar.RadialMenuItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.status = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.glow4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glow_cp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home Security"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Digital"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Science Fair 2017"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.glow4)
        Me.GroupBox1.Controls.Add(Me.glow3)
        Me.GroupBox1.Controls.Add(Me.glow2)
        Me.GroupBox1.Controls.Add(Me.glow_cp)
        Me.GroupBox1.Controls.Add(Me.glow1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 393)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Visualizer"
        '
        'glow4
        '
        Me.glow4.Image = Global.HomeSecurity.My.Resources.Resources.glow21
        Me.glow4.Location = New System.Drawing.Point(460, 200)
        Me.glow4.Name = "glow4"
        Me.glow4.Size = New System.Drawing.Size(129, 69)
        Me.glow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.glow4.TabIndex = 5
        Me.glow4.TabStop = False
        '
        'glow3
        '
        Me.glow3.Image = Global.HomeSecurity.My.Resources.Resources.glow21
        Me.glow3.Location = New System.Drawing.Point(36, 200)
        Me.glow3.Name = "glow3"
        Me.glow3.Size = New System.Drawing.Size(129, 69)
        Me.glow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.glow3.TabIndex = 4
        Me.glow3.TabStop = False
        '
        'glow2
        '
        Me.glow2.Image = Global.HomeSecurity.My.Resources.Resources.glow_light2
        Me.glow2.Location = New System.Drawing.Point(464, 53)
        Me.glow2.Name = "glow2"
        Me.glow2.Size = New System.Drawing.Size(125, 58)
        Me.glow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.glow2.TabIndex = 3
        Me.glow2.TabStop = False
        '
        'glow_cp
        '
        Me.glow_cp.Image = Global.HomeSecurity.My.Resources.Resources.glow_light2
        Me.glow_cp.Location = New System.Drawing.Point(258, 53)
        Me.glow_cp.Name = "glow_cp"
        Me.glow_cp.Size = New System.Drawing.Size(125, 58)
        Me.glow_cp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.glow_cp.TabIndex = 2
        Me.glow_cp.TabStop = False
        '
        'glow1
        '
        Me.glow1.Image = Global.HomeSecurity.My.Resources.Resources.glow_light2
        Me.glow1.Location = New System.Drawing.Point(40, 53)
        Me.glow1.Name = "glow1"
        Me.glow1.Size = New System.Drawing.Size(125, 58)
        Me.glow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.glow1.TabIndex = 1
        Me.glow1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HomeSecurity.My.Resources.Resources.model
        Me.PictureBox1.Location = New System.Drawing.Point(7, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(614, 312)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.room4)
        Me.GroupBox2.Controls.Add(Me.room3)
        Me.GroupBox2.Controls.Add(Me.room2)
        Me.GroupBox2.Controls.Add(Me.room1)
        Me.GroupBox2.Controls.Add(Me.cpanel)
        Me.GroupBox2.Location = New System.Drawing.Point(644, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 183)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control Light"
        '
        'room4
        '
        '
        '
        '
        Me.room4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.room4.Location = New System.Drawing.Point(254, 137)
        Me.room4.Name = "room4"
        Me.room4.Size = New System.Drawing.Size(100, 23)
        Me.room4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.room4.TabIndex = 8
        Me.room4.Text = "Room 4"
        '
        'room3
        '
        '
        '
        '
        Me.room3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.room3.Location = New System.Drawing.Point(254, 20)
        Me.room3.Name = "room3"
        Me.room3.Size = New System.Drawing.Size(100, 23)
        Me.room3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.room3.TabIndex = 8
        Me.room3.Text = "Room 3"
        '
        'room2
        '
        '
        '
        '
        Me.room2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.room2.Location = New System.Drawing.Point(7, 137)
        Me.room2.Name = "room2"
        Me.room2.Size = New System.Drawing.Size(100, 23)
        Me.room2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.room2.TabIndex = 2
        Me.room2.Text = "Room 2"
        '
        'room1
        '
        '
        '
        '
        Me.room1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.room1.Location = New System.Drawing.Point(7, 77)
        Me.room1.Name = "room1"
        Me.room1.Size = New System.Drawing.Size(100, 23)
        Me.room1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.room1.TabIndex = 1
        Me.room1.Text = "Room 1"
        '
        'cpanel
        '
        '
        '
        '
        Me.cpanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cpanel.Location = New System.Drawing.Point(7, 20)
        Me.cpanel.Name = "cpanel"
        Me.cpanel.Size = New System.Drawing.Size(100, 23)
        Me.cpanel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cpanel.TabIndex = 0
        Me.cpanel.Text = "Control Panel"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.security)
        Me.GroupBox3.Location = New System.Drawing.Point(644, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 64)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Security"
        '
        'security
        '
        '
        '
        '
        Me.security.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.security.Location = New System.Drawing.Point(7, 19)
        Me.security.Name = "security"
        Me.security.Size = New System.Drawing.Size(206, 31)
        Me.security.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.security.TabIndex = 0
        Me.security.Text = "Enable Security"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(759, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 6
        '
        'RadialMenu1
        '
        Me.RadialMenu1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.restart, Me.about, Me.exit_btn, Me.contacts})
        Me.RadialMenu1.Location = New System.Drawing.Point(970, 27)
        Me.RadialMenu1.Name = "RadialMenu1"
        Me.RadialMenu1.Size = New System.Drawing.Size(28, 28)
        Me.RadialMenu1.Symbol = ""
        Me.RadialMenu1.TabIndex = 7
        Me.RadialMenu1.Text = "RadialMenu1"
        '
        'restart
        '
        Me.restart.Name = "restart"
        Me.restart.Text = "Restart"
        '
        'about
        '
        Me.about.Name = "about"
        Me.about.Text = "About"
        '
        'exit_btn
        '
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Text = "Exit"
        '
        'contacts
        '
        Me.contacts.Name = "contacts"
        Me.contacts.Text = "Contact"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.status)
        Me.GroupBox4.Location = New System.Drawing.Point(644, 339)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(380, 134)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Font = New System.Drawing.Font("Lucida Fax", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.status.Location = New System.Drawing.Point(137, 57)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(97, 42)
        Me.status.TabIndex = 0
        Me.status.Text = "Safe"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1038, 355)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(155, 20)
        Me.TextBox2.TabIndex = 11
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(1038, 86)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(155, 263)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1031, 480)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.RadialMenu1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Home Security System - Science Fair 2017"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.glow4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glow_cp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadialMenu1 As DevComponents.DotNetBar.RadialMenu
    Friend WithEvents restart As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents about As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents exit_btn As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents room4 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents room3 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents room2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents room1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cpanel As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents security As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents status As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents glow1 As System.Windows.Forms.PictureBox
    Friend WithEvents glow3 As System.Windows.Forms.PictureBox
    Friend WithEvents glow2 As System.Windows.Forms.PictureBox
    Friend WithEvents glow_cp As System.Windows.Forms.PictureBox
    Friend WithEvents glow4 As System.Windows.Forms.PictureBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents contacts As DevComponents.DotNetBar.RadialMenuItem

End Class
