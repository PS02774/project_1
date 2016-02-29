Imports System.Data.SqlClient

Public Class frmKhachHang
    Private Sub FillKH()
        Dim Sql As String =
            <sql>
                SELECT * FROM KhachHang
            </sql>
        Connect(Sql, "KhachHang")
        bsKhachHang.DataSource = ds.Tables("KhachHang")
        dgvKhachHang.DataSource = bsKhachHang
        bsKhachHang.ResetBindings(False)
    End Sub

    Private Sub dgvKhacHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgvKhachHang.SelectionChanged
        Try
            Dim RowView As DataRowView = bsKhachHang.Current
            Dim Row As DataRow = RowView.Row

            txtMaKhachHang.Text = Row("MaKhachHang")
            txtTenKhachHang.Text = Row("TenKhachHang")
            txtSoDienThoai.Text = Row("SoDienThoai")
            txtDiaChi.Text = Row("DiaChi")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
           <sql>
                insert into KhachHang(MaKhachHang, TenKhachHang, SoDienThoai, DiaChi)
                values (N'{0}', N'{1}', N'{2}', N'{3}')
            </sql>

        Sql = String.Format(Sql, txtMaKhachHang.Text, txtTenKhachHang.Text, txtSoDienThoai.Text, txtDiaChi.Text)

        ExecuteNonQuery(Sql)

        FillKH()

    End Sub

   
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click

        Dim Sql As String =
            <sql>
                UPDATE      KhachHang
                SET         TenKhachHang =N'{0}', SoDienThoai ={1}, DiaChi =N'{2}'
                WHERE        (MaKhachHang = N'{3}')
            </sql>

        Sql = String.Format(Sql, txtTenKhachHang.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtMaKhachHang.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
           <sql>
                DELETE FROM KhachHang
                WHERE        (KhachHang.MaKhachHang = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaKhachHang.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillKH()
    End Sub

   

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMaKhachHang.Clear()
        txtTenKhachHang.Clear()
        txtDiaChi.Clear()
        txtSoDienThoai.Clear()

    End Sub

    Private Sub bsKhachHang_CurrentChanged(sender As Object, e As EventArgs) Handles bsKhachHang.CurrentChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
