Public Class DashboardUser

    Private Sub DashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabMain.SelectedTab = tpPembalap
        TampilPembalap()
        TampilTim()
        TampilRace()
    End Sub

    Private Sub btnNavPembalap_Click(sender As Object, e As EventArgs) Handles btnNavPembalap.Click
        tabMain.SelectedTab = tpPembalap
    End Sub

    Private Sub btnNavTim_Click(sender As Object, e As EventArgs) Handles btnNavTim.Click
        tabMain.SelectedTab = tpTim
    End Sub

    Private Sub btnNavRace_Click(sender As Object, e As EventArgs) Handles btnNavRace.Click
        tabMain.SelectedTab = tpRace
    End Sub

    Private Sub btnLoginAdmin_Click(sender As Object, e As EventArgs) Handles btnLoginAdmin.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah Anda ingin login sebagai Admin?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            LoginAdmin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DashboardUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub TampilPembalap()
        dgvPembalap.DataSource = GetAllPembalap()
        dgvPembalap.ReadOnly = True

        If dgvPembalap.Columns.Contains("id") Then dgvPembalap.Columns("id").Visible = False
        If dgvPembalap.Columns.Contains("idTim") Then dgvPembalap.Columns("idTim").Visible = False

        If dgvPembalap.Columns.Contains("nama") Then dgvPembalap.Columns("nama").HeaderText = "Nama Pembalap"
        If dgvPembalap.Columns.Contains("negara") Then dgvPembalap.Columns("negara").HeaderText = "Negara"
        If dgvPembalap.Columns.Contains("nomor") Then dgvPembalap.Columns("nomor").HeaderText = "Nomor"
        If dgvPembalap.Columns.Contains("tim") Then dgvPembalap.Columns("tim").HeaderText = "Tim"
    End Sub

    Private Sub TampilTim()
        dgvTim.DataSource = GetAllTim()
        dgvTim.ReadOnly = True
        If dgvTim.Columns.Contains("id") Then dgvTim.Columns("id").Visible = False

        If dgvTim.Columns.Contains("namaTim") Then dgvTim.Columns("namaTim").HeaderText = "Nama Tim"
        If dgvTim.Columns.Contains("negara") Then dgvTim.Columns("negara").HeaderText = "Negara"
        If dgvTim.Columns.Contains("mesin") Then dgvTim.Columns("mesin").HeaderText = "Mesin"
        If dgvTim.Columns.Contains("chasis") Then dgvTim.Columns("chasis").HeaderText = "Chasis"
    End Sub

    Private Sub TampilRace()
        dgvRace.DataSource = GetAllRace()
        dgvRace.ReadOnly = True
        If dgvRace.Columns.Contains("id") Then dgvRace.Columns("id").Visible = False

        If dgvRace.Columns.Contains("namaRace") Then dgvRace.Columns("namaRace").HeaderText = "Nama Race"
        If dgvRace.Columns.Contains("lokasi") Then dgvRace.Columns("lokasi").HeaderText = "Lokasi"
        If dgvRace.Columns.Contains("tanggal") Then dgvRace.Columns("tanggal").HeaderText = "Tanggal"
        If dgvRace.Columns.Contains("putaran") Then dgvRace.Columns("putaran").HeaderText = "Putaran"
    End Sub

    Private Sub txtSearchPembalap_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPembalap.TextChanged
        If txtSearchPembalap.Text.Trim() = "" Then
            TampilPembalap()
        Else
            dgvPembalap.DataSource = SearchPembalap(txtSearchPembalap.Text.Trim())
            If dgvPembalap.Columns.Contains("id") Then dgvPembalap.Columns("id").Visible = False
            If dgvPembalap.Columns.Contains("idTim") Then dgvPembalap.Columns("idTim").Visible = False
        End If
    End Sub

    Private Sub txtSearchTim_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTim.TextChanged
        If txtSearchTim.Text.Trim() = "" Then
            TampilTim()
        Else
            dgvTim.DataSource = SearchTim(txtSearchTim.Text.Trim())
            If dgvTim.Columns.Contains("id") Then dgvTim.Columns("id").Visible = False
        End If
    End Sub

    Private Sub txtSearchRace_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRace.TextChanged
        If txtSearchRace.Text.Trim() = "" Then
            TampilRace()
        Else
            dgvRace.DataSource = SearchRace(txtSearchRace.Text.Trim())
            If dgvRace.Columns.Contains("id") Then dgvRace.Columns("id").Visible = False
        End If
    End Sub

End Class