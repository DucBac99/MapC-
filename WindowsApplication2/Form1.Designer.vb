<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.myMap = New GMap.NET.WindowsForms.GMapControl()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clear_BTN = New System.Windows.Forms.Button()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.COMport_LBL = New System.Windows.Forms.Label()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tracking = New System.Windows.Forms.Button()
        Me.TextLAT = New System.Windows.Forms.RichTextBox()
        Me.TextLON = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Checklast = New System.Windows.Forms.Button()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'myMap
        '
        Me.myMap.Bearing = 0!
        Me.myMap.CanDragMap = True
        Me.myMap.EmptyTileColor = System.Drawing.Color.Navy
        Me.myMap.GrayScaleMode = False
        Me.myMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.myMap.LevelsKeepInMemmory = 5
        Me.myMap.Location = New System.Drawing.Point(560, 103)
        Me.myMap.MarkersEnabled = True
        Me.myMap.MaxZoom = 2
        Me.myMap.MinZoom = 2
        Me.myMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.myMap.Name = "myMap"
        Me.myMap.NegativeMode = False
        Me.myMap.PolygonsEnabled = True
        Me.myMap.RetryLoadTile = 0
        Me.myMap.RoutesEnabled = True
        Me.myMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.myMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.myMap.ShowTileGridLines = False
        Me.myMap.Size = New System.Drawing.Size(406, 381)
        Me.myMap.TabIndex = 1
        Me.myMap.Zoom = 0R
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(868, 512)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(75, 23)
        Me.btnMove.TabIndex = 2
        Me.btnMove.Text = "Button1"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'tmr1
        '
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(557, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(41, 13)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Định Vị"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clear_BTN)
        Me.GroupBox1.Controls.Add(Me.Timer_LBL)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.COMport_LBL)
        Me.GroupBox1.Controls.Add(Me.comPort_ComboBox)
        Me.GroupBox1.Controls.Add(Me.connect_BTN)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(330, 499)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kết Nối Thiết Bị"
        '
        'clear_BTN
        '
        Me.clear_BTN.Location = New System.Drawing.Point(9, 96)
        Me.clear_BTN.Name = "clear_BTN"
        Me.clear_BTN.Size = New System.Drawing.Size(75, 23)
        Me.clear_BTN.TabIndex = 28
        Me.clear_BTN.Text = "CLEAR"
        Me.clear_BTN.UseVisualStyleBackColor = True
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(176, 20)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(88, 20)
        Me.Timer_LBL.TabIndex = 31
        Me.Timer_LBL.Text = "Timer: OFF"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox1.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 128)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(322, 366)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        '
        'COMport_LBL
        '
        Me.COMport_LBL.AutoSize = True
        Me.COMport_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_LBL.Location = New System.Drawing.Point(5, 24)
        Me.COMport_LBL.Name = "COMport_LBL"
        Me.COMport_LBL.Size = New System.Drawing.Size(92, 20)
        Me.COMport_LBL.TabIndex = 25
        Me.COMport_LBL.Text = "COM PORT"
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(5, 48)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(161, 28)
        Me.comPort_ComboBox.TabIndex = 26
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(171, 46)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(144, 28)
        Me.connect_BTN.TabIndex = 27
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Tracking
        '
        Me.Tracking.Location = New System.Drawing.Point(851, 52)
        Me.Tracking.Margin = New System.Windows.Forms.Padding(2)
        Me.Tracking.Name = "Tracking"
        Me.Tracking.Size = New System.Drawing.Size(115, 32)
        Me.Tracking.TabIndex = 7
        Me.Tracking.Text = "Tracking"
        Me.Tracking.UseVisualStyleBackColor = True
        '
        'TextLAT
        '
        Me.TextLAT.BackColor = System.Drawing.SystemColors.Info
        Me.TextLAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLAT.Location = New System.Drawing.Point(576, 49)
        Me.TextLAT.Name = "TextLAT"
        Me.TextLAT.Size = New System.Drawing.Size(132, 34)
        Me.TextLAT.TabIndex = 32
        Me.TextLAT.Text = ""
        '
        'TextLON
        '
        Me.TextLON.BackColor = System.Drawing.SystemColors.Info
        Me.TextLON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLON.Location = New System.Drawing.Point(714, 49)
        Me.TextLON.Name = "TextLON"
        Me.TextLON.Size = New System.Drawing.Size(132, 34)
        Me.TextLON.TabIndex = 33
        Me.TextLON.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.White
        Me.RichTextBox2.Location = New System.Drawing.Point(344, 54)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(189, 43)
        Me.RichTextBox2.TabIndex = 32
        Me.RichTextBox2.Text = ""
        '
        'Checklast
        '
        Me.Checklast.Location = New System.Drawing.Point(344, 25)
        Me.Checklast.Name = "Checklast"
        Me.Checklast.Size = New System.Drawing.Size(75, 23)
        Me.Checklast.TabIndex = 34
        Me.Checklast.Text = "KIỂM TRA"
        Me.Checklast.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox3.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.ForeColor = System.Drawing.Color.White
        Me.RichTextBox3.Location = New System.Drawing.Point(344, 103)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(189, 43)
        Me.RichTextBox3.TabIndex = 35
        Me.RichTextBox3.Text = ""
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox4.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.ForeColor = System.Drawing.Color.White
        Me.RichTextBox4.Location = New System.Drawing.Point(344, 152)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(189, 43)
        Me.RichTextBox4.TabIndex = 36
        Me.RichTextBox4.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "KIỂM TRA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1000, 626)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Checklast)
        Me.Controls.Add(Me.TextLON)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.TextLAT)
        Me.Controls.Add(Me.Tracking)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.myMap)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Phần Mềm Theo Dõi Khách Du Lịch - Nguyễn Đức Bắc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myMap As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents COMport_LBL As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents clear_BTN As Button
    Friend WithEvents connect_BTN As Button
    Friend WithEvents Tracking As Button
    Friend WithEvents TextLAT As RichTextBox
    Friend WithEvents TextLON As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Checklast As Button
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
