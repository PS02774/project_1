Imports System.Data.SqlClient

Public Class frmNhanVien
    Private Sub FillNhanVien()
        Dim Sql As String =
            <sql>
                SELECT * FROM NhanVien
            </sql>
        connect(Sql, "NhanVien")
        bsNhanVien.DataSource = ds.Tables("NhanVien")
        dgvNhanVien.DataSource = bsNhanVien
        bsNhanVien.ResetBindings(False)
    End Sub
    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillNhanVien()



    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Sql As String =
          <sql>
                insert into NhanVien(MaNhanVien, TenNhanVien, Password)
                values (N'{0}', N'{1}', N'{2}')
            </sql>

        Sql = String.Format(Sql, txtMaNhanVien.Text, txtTenNhanVien.Text, txtPass.Text)

        ExecuteNonQuery(Sql)

        FillNhanVien()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Sql As String =
           <sql>
                UPDATE      NhanVien
                SET         TenNhanVien =N'{0}', Password =N'{1}'
                WHERE        (MaNhanVien = N'{2}')
            </sql>

        Sql = String.Format(Sql, txtTenNhanVien.Text, txtPass.Text, txtMaNhanVien.Text)

        ExecuteNonQuery(Sql)

        FillNhanVien()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim Sql As String =
          <sql>
                DELETE FROM NhanVien
                WHERE        (NhanVien.MaNhanVien = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaNhanVien.Text)

        ExecuteNonQuery(Sql)

        FillNhanVien()
    End Sub

    Private Sub bsNhanVien_CurrentChanged(sender As Object, e As EventArgs) Handles bsNhanVien.CurrentChanged

    End Sub

    Private Sub dgvNhanVien_SelectionChanged(sender As Object, e As EventArgs) Handles dgvNhanVien.SelectionChanged
        Try
            Dim RowView As DataRowView = bsNhanVien.Current
            Dim Row As DataRow = RowView.Row

            txtMaNhanVien.Text = Row("MaNhanVien")
            txtTenNhanVien.Text = Row("TenNhanVien")
            txtPass.Text = Row("Password")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMaNhanVien.Clear()
        txtTenNhanVien.Clear()
        txtPass.Clear()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class