<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripKhachHang = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripNhanVien = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSanPham = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripKhachHang, Me.ToolStripNhanVien, Me.ToolStripSanPham})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(726, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripKhachHang
        '
        Me.ToolStripKhachHang.Name = "ToolStripKhachHang"
        Me.ToolStripKhachHang.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripKhachHang.Text = "Khách Hàng"
        '
        'ToolStripNhanVien
        '
        Me.ToolStripNhanVien.Name = "ToolStripNhanVien"
        Me.ToolStripNhanVien.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripNhanVien.Text = "Nhân Viên"
        '
        'ToolStripSanPham
        '
        Me.ToolStripSanPham.Name = "ToolStripSanPham"
        Me.ToolStripSanPham.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripSanPham.Text = "Sản Phẩm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(354, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 78)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "      Giảng viên: Lê Văn Phụng" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sinh viên: Huỳnh Nguyễn Gia Huy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              MS" & _
    "SV: PS02774" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PS02774.My.Resources.Resources.b
        Me.PictureBox1.Location = New System.Drawing.Point(22, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(324, 151)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 223)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMain"
        Me.Text = "PS02774"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripKhachHang As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripNhanVien As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSanPham As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
