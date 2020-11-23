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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcookie = New System.Windows.Forms.TextBox()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlogs = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtuseragent = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numsleep = New System.Windows.Forms.NumericUpDown()
        CType(Me.numsleep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cookies Facebook"
        '
        'txtcookie
        '
        Me.txtcookie.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtcookie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcookie.ForeColor = System.Drawing.Color.Silver
        Me.txtcookie.Location = New System.Drawing.Point(15, 35)
        Me.txtcookie.Name = "txtcookie"
        Me.txtcookie.Size = New System.Drawing.Size(511, 20)
        Me.txtcookie.TabIndex = 1
        '
        'btnstop
        '
        Me.btnstop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnstop.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnstop.FlatAppearance.BorderSize = 0
        Me.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnstop.Image = CType(resources.GetObject("btnstop.Image"), System.Drawing.Image)
        Me.btnstop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnstop.Location = New System.Drawing.Point(410, 125)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(116, 24)
        Me.btnstop.TabIndex = 78
        Me.btnstop.Text = "STOP"
        Me.btnstop.UseVisualStyleBackColor = False
        '
        'btnstart
        '
        Me.btnstart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnstart.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnstart.FlatAppearance.BorderSize = 0
        Me.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnstart.Image = CType(resources.GetObject("btnstart.Image"), System.Drawing.Image)
        Me.btnstart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnstart.Location = New System.Drawing.Point(288, 125)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(116, 24)
        Me.btnstart.TabIndex = 77
        Me.btnstart.Text = "START"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 17)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "@2020 Tool By Nguyễn Đắc Tài, tienichmmo.net"
        '
        'txtlogs
        '
        Me.txtlogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtlogs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtlogs.Location = New System.Drawing.Point(15, 173)
        Me.txtlogs.Name = "txtlogs"
        Me.txtlogs.Size = New System.Drawing.Size(511, 158)
        Me.txtlogs.TabIndex = 82
        Me.txtlogs.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(516, 15)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "// Logs // ______________________________________________________________________" &
    "_____________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "UserAgent ( nếu có )"
        '
        'txtuseragent
        '
        Me.txtuseragent.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtuseragent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuseragent.ForeColor = System.Drawing.Color.Silver
        Me.txtuseragent.Location = New System.Drawing.Point(15, 78)
        Me.txtuseragent.Name = "txtuseragent"
        Me.txtuseragent.Size = New System.Drawing.Size(508, 20)
        Me.txtuseragent.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(13, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 17)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Thời gian nghỉ sau khi chọc 1 acc ( giây )"
        '
        'numsleep
        '
        Me.numsleep.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.numsleep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.numsleep.Location = New System.Drawing.Point(16, 121)
        Me.numsleep.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numsleep.Name = "numsleep"
        Me.numsleep.Size = New System.Drawing.Size(94, 20)
        Me.numsleep.TabIndex = 88
        Me.numsleep.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(538, 356)
        Me.Controls.Add(Me.numsleep)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtuseragent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlogs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.txtcookie)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Pokes Friend Facebook v1.0 | By Nguyễn Đắc Tài"
        CType(Me.numsleep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcookie As TextBox
    Friend WithEvents btnstop As Button
    Friend WithEvents btnstart As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlogs As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtuseragent As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents numsleep As NumericUpDown
End Class
