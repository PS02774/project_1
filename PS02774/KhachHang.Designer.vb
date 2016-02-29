<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.txtTenKhachHang = New System.Windows.Forms.TextBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvKhachHang = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bsKhachHang = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Khách Hàng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên Khách Hàng:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Số Điện Thoại:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Địa Chỉ:"
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtMaKhachHang.Location = New System.Drawing.Point(113, 16)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(100, 20)
        Me.txtMaKhachHang.TabIndex = 1
        Me.txtMaKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTenKhachHang
        '
        Me.txtTenKhachHang.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTenKhachHang.Location = New System.Drawing.Point(113, 51)
        Me.txtTenKhachHang.Name = "txtTenKhachHang"
        Me.txtTenKhachHang.Size = New System.Drawing.Size(100, 20)
        Me.txtTenKhachHang.TabIndex = 1
        Me.txtTenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSoDienThoai.Location = New System.Drawing.Point(113, 84)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(100, 20)
        Me.txtSoDienThoai.TabIndex = 1
        Me.txtSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaChi
        '
        Me.txtDiaChi.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDiaChi.Location = New System.Drawing.Point(113, 117)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(100, 20)
        Me.txtDiaChi.TabIndex = 1
        Me.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCapnhat
        '
        Me.btnCapnhat.Location = New System.Drawing.Point(243, 95)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(66, 27)
        Me.btnCapnhat.TabIndex = 2
        Me.btnCapnhat.Text = "Cập Nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(379, 21)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(65, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'dgvKhachHang
        '
        Me.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKhachHang.Location = New System.Drawing.Point(22, 154)
        Me.dgvKhachHang.Name = "dgvKhachHang"
        Me.dgvKhachHang.Size = New System.Drawing.Size(489, 151)
        Me.dgvKhachHang.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(379, 97)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(66, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(244, 19)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(65, 27)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PS02774.My.Resources.Resources.clear
        Me.PictureBox4.Location = New System.Drawing.Point(451, 76)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 61)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PS02774.My.Resources.Resources.delete
        Me.PictureBox3.Location = New System.Drawing.Point(451, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 50)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PS02774.My.Resources.Resources.update
        Me.PictureBox2.Location = New System.Drawing.Point(315, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 53)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.PS02774.My.Resources.Resources.adddddd
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(315, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'bsKhachHang
        '
        '
        'frmKhachHang
        '
        Me.AcceptButton = Me.btnThem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 337)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvKhachHang)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.txtTenKhachHang)
        Me.Controls.Add(Me.txtMaKhachHang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmKhachHang"
        Me.Text = "KhachHang"
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMaKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKhachHang As System.Windows.Forms.TextBox
    Friend WithEvents txtSoDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents btnCapnhat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents dgvKhachHang As System.Windows.Forms.DataGridView
    Friend WithEvents bsKhachHang As System.Windows.Forms.BindingSource
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
