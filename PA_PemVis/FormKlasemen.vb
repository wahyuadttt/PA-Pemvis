Public Class FormKlasemen

    Private Sub FormKlasemen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilKlasemenPembalap()
        TampilKlasemenKonstruktor()
    End Sub

    Private Sub TampilKlasemenPembalap()
        dgvKlasemenPembalap.DataSource = Nothing
        dgvKlasemenPembalap.DataSource = GetKlasemenPembalap()

        If dgvKlasemenPembalap.Columns.Contains("nama") Then
            dgvKlasemenPembalap.Columns("nama").HeaderText = "Pembalap"
        End If

        If dgvKlasemenPembalap.Columns.Contains("namaTim") Then
            dgvKlasemenPembalap.Columns("namaTim").HeaderText = "Tim"
        End If

        If dgvKlasemenPembalap.Columns.Contains("totalPoin") Then
            dgvKlasemenPembalap.Columns("totalPoin").HeaderText = "Total Poin"
        End If

        dgvKlasemenPembalap.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub TampilKlasemenKonstruktor()
        dgvKlasemenKonstruktor.DataSource = Nothing
        dgvKlasemenKonstruktor.DataSource = GetKlasemenTim()

        If dgvKlasemenKonstruktor.Columns.Contains("namaTim") Then
            dgvKlasemenKonstruktor.Columns("namaTim").HeaderText = "Tim"
        End If

        If dgvKlasemenKonstruktor.Columns.Contains("totalPoin") Then
            dgvKlasemenKonstruktor.Columns("totalPoin").HeaderText = "Total Poin"
        End If

        dgvKlasemenKonstruktor.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click

        If IsAdmin Then
            DashboardAdmin.Show()
        Else
            DashboardUser.Show()
        End If

        Me.Hide()

    End Sub

End Class