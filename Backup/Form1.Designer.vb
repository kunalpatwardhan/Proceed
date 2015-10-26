<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
    Public WithEvents _Timer1_0 As System.Windows.Forms.Timer
	Public WithEvents Timer1 As Microsoft.VisualBasic.Compatibility.VB6.TimerArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me._Timer1_0 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New Microsoft.VisualBasic.Compatibility.VB6.TimerArray(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbl = New System.Windows.Forms.Label
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox_EnteredOptions = New System.Windows.Forms.ListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.ListBox_RND = New System.Windows.Forms.ListBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.TextBox_qst = New System.Windows.Forms.TextBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Button_Pass = New System.Windows.Forms.Button
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.Button_Submit = New System.Windows.Forms.Button
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Button_qst = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button_GiveUp = New System.Windows.Forms.Button
        Me.Label_Help = New System.Windows.Forms.Label
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Timer1_0
        '
        Me.Timer1.SetIndex(Me._Timer1_0, CType(0, Short))
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-2, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.ForeColor = System.Drawing.Color.White
        Me.lbl.Location = New System.Drawing.Point(3, 36)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(0, 14)
        Me.lbl.TabIndex = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'ListBox_EnteredOptions
        '
        Me.ListBox_EnteredOptions.FormattingEnabled = True
        Me.ListBox_EnteredOptions.ItemHeight = 14
        Me.ListBox_EnteredOptions.Location = New System.Drawing.Point(994, 141)
        Me.ListBox_EnteredOptions.Name = "ListBox_EnteredOptions"
        Me.ListBox_EnteredOptions.Size = New System.Drawing.Size(152, 340)
        Me.ListBox_EnteredOptions.TabIndex = 11
        Me.ListBox_EnteredOptions.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 31)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "load"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ListBox_RND
        '
        Me.ListBox_RND.FormattingEnabled = True
        Me.ListBox_RND.ItemHeight = 14
        Me.ListBox_RND.Location = New System.Drawing.Point(836, 141)
        Me.ListBox_RND.Name = "ListBox_RND"
        Me.ListBox_RND.Size = New System.Drawing.Size(152, 340)
        Me.ListBox_RND.TabIndex = 10
        Me.ListBox_RND.Visible = False
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(42, 4)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(152, 73)
        Me.dgv.TabIndex = 8
        Me.dgv.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Black
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(189, 57)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.Black
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(198, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(189, 57)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'TextBox_qst
        '
        Me.TextBox_qst.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox_qst.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TextBox_qst.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox_qst.Location = New System.Drawing.Point(292, 184)
        Me.TextBox_qst.Multiline = True
        Me.TextBox_qst.Name = "TextBox_qst"
        Me.TextBox_qst.ReadOnly = True
        Me.TextBox_qst.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_qst.Size = New System.Drawing.Size(459, 188)
        Me.TextBox_qst.TabIndex = 13
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.Black
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(3, 66)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(189, 57)
        Me.RadioButton3.TabIndex = 18
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Button_Pass
        '
        Me.Button_Pass.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Pass.ForeColor = System.Drawing.Color.White
        Me.Button_Pass.Location = New System.Drawing.Point(292, 561)
        Me.Button_Pass.Name = "Button_Pass"
        Me.Button_Pass.Size = New System.Drawing.Size(117, 29)
        Me.Button_Pass.TabIndex = 15
        Me.Button_Pass.Text = "Pass"
        Me.Button_Pass.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.Color.Black
        Me.RadioButton4.ForeColor = System.Drawing.Color.White
        Me.RadioButton4.Location = New System.Drawing.Point(198, 66)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(189, 57)
        Me.RadioButton4.TabIndex = 19
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'Button_Submit
        '
        Me.Button_Submit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Submit.ForeColor = System.Drawing.Color.White
        Me.Button_Submit.Location = New System.Drawing.Point(464, 561)
        Me.Button_Submit.Name = "Button_Submit"
        Me.Button_Submit.Size = New System.Drawing.Size(117, 29)
        Me.Button_Submit.TabIndex = 17
        Me.Button_Submit.Text = "Submit"
        Me.Button_Submit.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton5.ForeColor = System.Drawing.Color.White
        Me.RadioButton5.Location = New System.Drawing.Point(3, 129)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(89, 15)
        Me.RadioButton5.TabIndex = 20
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = False
        Me.RadioButton5.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(245, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(5, 461)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(797, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(6, 461)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(245, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(556, 10)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(246, 596)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 10)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton5, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(326, 394)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(390, 147)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'Button_qst
        '
        Me.Button_qst.BackColor = System.Drawing.Color.DarkGray
        Me.Button_qst.ForeColor = System.Drawing.Color.Black
        Me.Button_qst.Location = New System.Drawing.Point(42, 181)
        Me.Button_qst.Name = "Button_qst"
        Me.Button_qst.Size = New System.Drawing.Size(97, 30)
        Me.Button_qst.TabIndex = 26
        Me.Button_qst.Text = "Button3"
        Me.Button_qst.UseVisualStyleBackColor = False
        Me.Button_qst.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(472, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 29)
        Me.Label1.TabIndex = 27
        '
        'Button_GiveUp
        '
        Me.Button_GiveUp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_GiveUp.ForeColor = System.Drawing.Color.White
        Me.Button_GiveUp.Location = New System.Drawing.Point(634, 561)
        Me.Button_GiveUp.Name = "Button_GiveUp"
        Me.Button_GiveUp.Size = New System.Drawing.Size(117, 29)
        Me.Button_GiveUp.TabIndex = 28
        Me.Button_GiveUp.Text = "Give Up"
        Me.Button_GiveUp.UseVisualStyleBackColor = False
        '
        'Label_Help
        '
        Me.Label_Help.BackColor = System.Drawing.Color.Gray
        Me.Label_Help.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_Help.Location = New System.Drawing.Point(240, 659)
        Me.Label_Help.Name = "Label_Help"
        Me.Label_Help.Size = New System.Drawing.Size(562, 63)
        Me.Label_Help.TabIndex = 29
        Me.Label_Help.Text = "Help :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1028, 770)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label_Help)
        Me.Controls.Add(Me.Button_GiveUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_qst)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Submit)
        Me.Controls.Add(Me.Button_Pass)
        Me.Controls.Add(Me.TextBox_qst)
        Me.Controls.Add(Me.ListBox_EnteredOptions)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox_RND)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 30)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ListBox_EnteredOptions As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox_RND As System.Windows.Forms.ListBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox_qst As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button_Pass As System.Windows.Forms.Button
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Button_Submit As System.Windows.Forms.Button
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button_qst As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_GiveUp As System.Windows.Forms.Button
    Friend WithEvents Label_Help As System.Windows.Forms.Label
#End Region
End Class