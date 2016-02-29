Imports System.Data.SqlClient

Public Class frmSanPham
    Private Sub FillSanPham()
        Dim Sql As String =
            <sql>
                SELECT * FROM SanPham
            </sql>
        connect(Sql, "SanPham")
        bsSanPham.DataSource = ds.Tables("SanPham")
        dgvSanPham.DataSource = bsSanPham
        bsSanPham.ResetBindings(False)
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSanPham()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Sql As String =
         <sql>
                insert into SanPham(MaSanPham, TenSanPham, DonGia, Soluong, ChiTietSanPham)
                values (N'{0}', N'{1}',{2},{3},N'{4}')
            </sql>

        Sql = String.Format(Sql, txtMaSanPham.Text, txtTenSanPham.Text, txtDonGia.Text, txtSoLuong.Text, txtChiTiet.Text)

        ExecuteNonQuery(Sql)

        FillSanPham()
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim Sql As String =
         <sql>
                UPDATE      SanPham
                SET         TenSanPham =N'{0}', DonGia ={1}, SoLuong ={2}, ChiTietSanPham =N'{3}'
                WHERE        (MaSanPham = N'{4}')
            </sql>

        Sql = String.Format(Sql, txtTenSanPham.Text, txtDonGia.Text, txtSoLuong.Text, txtChiTiet.Text, txtMaSanPham.Text)

        ExecuteNonQuery(Sql)

        FillSanPham()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim Sql As String =
        <sql>
                DELETE FROM SanPham
                WHERE        (SanPham.MaSanPham = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaSanPham.Text)

        ExecuteNonQuery(Sql)

        FillSanPham()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMaSanPham.Clear()
        txtChiTiet.Clear()
        txtDonGia.Clear()
        txtTenSanPham.Clear()
        txtSoLuong.Clear()

    End Sub

    Private Sub dgvSanPham_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSanPham.SelectionChanged
        Try
            Dim RowView As DataRowView = bsSanPham.Current
            Dim Row As DataRow = RowView.Row

            txtMaSanPham.Text = Row("MaSanPham")
            txtTenSanPham.Text = Row("TenSanPham")
            txtDonGia.Text = Row("DonGia")
            txtSoLuong.Text = Row("SoLuong")
            txtChiTiet.Text = Row("ChiTietSanPham")


        Catch ex As Exception

        End Try
    End Sub
End Class
