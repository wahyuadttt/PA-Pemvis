<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardAdmin
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        lblAdminBadge = New Label()
        btnKeluar = New Button()
        pnlSidebar = New Panel()
        btnNavHasil = New Button()
        pnlSidebarTop = New Panel()
        lblMenuTitle = New Label()
        btnNavPembalap = New Button()
        btnNavTim = New Button()
        btnNavRace = New Button()
        pnlSidebarDivider = New Panel()
        btnNavKlasemen = New Button()
        pnlContent = New Panel()
        ErrorProvider1 = New ErrorProvider(components)
        tpHasil = New TabPage()
        cbPilihRace = New ComboBox()
        Label1 = New Label()
        dgvHasilRace = New DataGridView()
        cbRaceHasil = New ComboBox()
        Label2 = New Label()
        cbPembalapHasil = New ComboBox()
        Label3 = New Label()
        txtTimHasil = New TextBox()
        Label4 = New Label()
        txtPosisi = New TextBox()
        Label5 = New Label()
        txtGap = New TextBox()
        Label6 = New Label()
        cbStatusFinish = New ComboBox()
        Label7 = New Label()
        chkFastestLap = New CheckBox()
        txtPoinHasil = New TextBox()
        Label9 = New Label()
        btnBatalHasil = New Button()
        btnHapusHasil = New Button()
        btnUbahHasil = New Button()
        btnSimpanHasil = New Button()
        tpRace = New TabPage()
        pnlGridRace = New Panel()
        dgvRace = New DataGridView()
        txtSearchRace = New TextBox()
        pnlInputRace = New Panel()
        pnlActionRace = New Panel()
        btnPrintRace = New Button()
        btnBatalRace = New Button()
        btnHapusRace = New Button()
        btnUbahRace = New Button()
        btnSimpanRace = New Button()
        txtPutaran = New TextBox()
        lblPutaran = New Label()
        dtpTanggal = New DateTimePicker()
        lblTanggal = New Label()
        txtLokasi = New TextBox()
        lblLokasi = New Label()
        txtNamaRace = New TextBox()
        lblNamaRace = New Label()
        lblPanelRace = New Label()
        tpTim = New TabPage()
        pnlGridTim = New Panel()
        dgvTim = New DataGridView()
        txtSearchTim = New TextBox()
        pnlInputTim = New Panel()
        pnlActionTim = New Panel()
        btnPrintTim = New Button()
        btnBatalTim = New Button()
        btnHapusTim = New Button()
        btnUbahTim = New Button()
        btnSimpanTim = New Button()
        txtChasis = New TextBox()
        lblChasis = New Label()
        txtMesin = New TextBox()
        lblMesin = New Label()
        txtNegaraTim = New TextBox()
        lblNegaraTim = New Label()
        txtNamaTim = New TextBox()
        lblNamaTim = New Label()
        btnPilihLogo = New Button()
        picLogoTim = New PictureBox()
        lblPanelTim = New Label()
        tpPembalap = New TabPage()
        pnlGridPembalap = New Panel()
        dgvPembalap = New DataGridView()
        txtSearchPembalap = New TextBox()
        pnlInputPembalap = New Panel()
        pnlActionPembalap = New Panel()
        btnPrintPembalap = New Button()
        btnBatalPembalap = New Button()
        btnHapusPembalap = New Button()
        btnUbahPembalap = New Button()
        btnSimpanPembalap = New Button()
        cbTim = New ComboBox()
        lblTimPembalap = New Label()
        txtNomor = New TextBox()
        lblNomor = New Label()
        txtNegaraPembalap = New TextBox()
        lblNegaraPembalap = New Label()
        txtNamaPembalap = New TextBox()
        lblNamaPembalap = New Label()
        lblPanelPembalap = New Label()
        tabMain = New TabControl()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        tpHasil.SuspendLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).BeginInit()
        tpRace.SuspendLayout()
        pnlGridRace.SuspendLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).BeginInit()
        pnlInputRace.SuspendLayout()
        pnlActionRace.SuspendLayout()
        tpTim.SuspendLayout()
        pnlGridTim.SuspendLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).BeginInit()
        pnlInputTim.SuspendLayout()
        pnlActionTim.SuspendLayout()
        CType(picLogoTim, ComponentModel.ISupportInitialize).BeginInit()
        tpPembalap.SuspendLayout()
        pnlGridPembalap.SuspendLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).BeginInit()
        pnlInputPembalap.SuspendLayout()
        pnlActionPembalap.SuspendLayout()
        tabMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblAdminBadge)
        pnlHeader.Controls.Add(btnKeluar)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1280, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 58)
        pnlHeaderAccent.Margin = New Padding(2)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1280, 2)
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(15, 10)
        lblHeaderTitle.Margin = New Padding(2, 0, 2, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(388, 45)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "F1 RACE MANAGEMENT"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.BackColor = Color.Transparent
        lblHeaderSub.Font = New Font("Segoe UI", 8F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblHeaderSub.Location = New Point(18, 38)
        lblHeaderSub.Margin = New Padding(2, 0, 2, 0)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(136, 21)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Admin Dashboard"
        ' 
        ' lblAdminBadge
        ' 
        lblAdminBadge.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblAdminBadge.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblAdminBadge.ForeColor = Color.White
        lblAdminBadge.Location = New Point(1048, 14)
        lblAdminBadge.Margin = New Padding(2, 0, 2, 0)
        lblAdminBadge.Name = "lblAdminBadge"
        lblAdminBadge.Size = New Size(108, 32)
        lblAdminBadge.TabIndex = 3
        lblAdminBadge.Text = "ADMIN"
        lblAdminBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnKeluar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(1160, 14)
        btnKeluar.Margin = New Padding(2)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(100, 32)
        btnKeluar.TabIndex = 99
        btnKeluar.Text = "KELUAR"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlSidebar.Controls.Add(btnNavHasil)
        pnlSidebar.Controls.Add(pnlSidebarTop)
        pnlSidebar.Controls.Add(lblMenuTitle)
        pnlSidebar.Controls.Add(btnNavPembalap)
        pnlSidebar.Controls.Add(btnNavTim)
        pnlSidebar.Controls.Add(btnNavRace)
        pnlSidebar.Controls.Add(pnlSidebarDivider)
        pnlSidebar.Controls.Add(btnNavKlasemen)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 60)
        pnlSidebar.Margin = New Padding(2)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(200, 700)
        pnlSidebar.TabIndex = 1
        ' 
        ' btnNavHasil
        ' 
        btnNavHasil.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavHasil.Cursor = Cursors.Hand
        btnNavHasil.FlatAppearance.BorderSize = 0
        btnNavHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavHasil.FlatStyle = FlatStyle.Flat
        btnNavHasil.Font = New Font("Segoe UI", 10F)
        btnNavHasil.ForeColor = Color.White
        btnNavHasil.Location = New Point(0, 250)
        btnNavHasil.Margin = New Padding(2)
        btnNavHasil.Name = "btnNavHasil"
        btnNavHasil.Size = New Size(200, 44)
        btnNavHasil.TabIndex = 6
        btnNavHasil.Text = "  📅  Hasil Race"
        btnNavHasil.TextAlign = ContentAlignment.MiddleLeft
        btnNavHasil.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarTop
        ' 
        pnlSidebarTop.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarTop.Location = New Point(0, 0)
        pnlSidebarTop.Margin = New Padding(2)
        pnlSidebarTop.Name = "pnlSidebarTop"
        pnlSidebarTop.Size = New Size(4, 700)
        pnlSidebarTop.TabIndex = 0
        ' 
        ' lblMenuTitle
        ' 
        lblMenuTitle.AutoSize = True
        lblMenuTitle.BackColor = Color.Transparent
        lblMenuTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblMenuTitle.Location = New Point(15, 20)
        lblMenuTitle.Margin = New Padding(2, 0, 2, 0)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New Size(159, 21)
        lblMenuTitle.TabIndex = 1
        lblMenuTitle.Text = "MANAJEMEN DATA"
        ' 
        ' btnNavPembalap
        ' 
        btnNavPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavPembalap.Cursor = Cursors.Hand
        btnNavPembalap.FlatAppearance.BorderSize = 0
        btnNavPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavPembalap.FlatStyle = FlatStyle.Flat
        btnNavPembalap.Font = New Font("Segoe UI", 10F)
        btnNavPembalap.ForeColor = Color.White
        btnNavPembalap.Location = New Point(0, 48)
        btnNavPembalap.Margin = New Padding(2)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(200, 44)
        btnNavPembalap.TabIndex = 1
        btnNavPembalap.Text = "  🏎  Pembalap"
        btnNavPembalap.TextAlign = ContentAlignment.MiddleLeft
        btnNavPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnNavTim
        ' 
        btnNavTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavTim.Cursor = Cursors.Hand
        btnNavTim.FlatAppearance.BorderSize = 0
        btnNavTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavTim.FlatStyle = FlatStyle.Flat
        btnNavTim.Font = New Font("Segoe UI", 10F)
        btnNavTim.ForeColor = Color.White
        btnNavTim.Location = New Point(0, 92)
        btnNavTim.Margin = New Padding(2)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(200, 44)
        btnNavTim.TabIndex = 2
        btnNavTim.Text = "  🏁  Konstruktor"
        btnNavTim.TextAlign = ContentAlignment.MiddleLeft
        btnNavTim.UseVisualStyleBackColor = False
        ' 
        ' btnNavRace
        ' 
        btnNavRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavRace.Cursor = Cursors.Hand
        btnNavRace.FlatAppearance.BorderSize = 0
        btnNavRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavRace.FlatStyle = FlatStyle.Flat
        btnNavRace.Font = New Font("Segoe UI", 10F)
        btnNavRace.ForeColor = Color.White
        btnNavRace.Location = New Point(0, 136)
        btnNavRace.Margin = New Padding(2)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(200, 44)
        btnNavRace.TabIndex = 3
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarDivider
        ' 
        pnlSidebarDivider.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlSidebarDivider.Location = New Point(15, 192)
        pnlSidebarDivider.Margin = New Padding(2)
        pnlSidebarDivider.Name = "pnlSidebarDivider"
        pnlSidebarDivider.Size = New Size(170, 1)
        pnlSidebarDivider.TabIndex = 4
        ' 
        ' btnNavKlasemen
        ' 
        btnNavKlasemen.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnNavKlasemen.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnNavKlasemen.Location = New Point(0, 202)
        btnNavKlasemen.Margin = New Padding(2)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(200, 44)
        btnNavKlasemen.TabIndex = 5
        btnNavKlasemen.Text = "  🏆  Klasemen"
        btnNavKlasemen.TextAlign = ContentAlignment.MiddleLeft
        btnNavKlasemen.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlContent.Controls.Add(tabMain)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(200, 60)
        pnlContent.Margin = New Padding(2)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1080, 700)
        pnlContent.TabIndex = 2
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' tpHasil
        ' 
        tpHasil.Controls.Add(btnSimpanHasil)
        tpHasil.Controls.Add(btnUbahHasil)
        tpHasil.Controls.Add(btnHapusHasil)
        tpHasil.Controls.Add(btnBatalHasil)
        tpHasil.Controls.Add(Label9)
        tpHasil.Controls.Add(txtPoinHasil)
        tpHasil.Controls.Add(txtGap)
        tpHasil.Controls.Add(txtPosisi)
        tpHasil.Controls.Add(txtTimHasil)
        tpHasil.Controls.Add(chkFastestLap)
        tpHasil.Controls.Add(Label7)
        tpHasil.Controls.Add(cbStatusFinish)
        tpHasil.Controls.Add(Label6)
        tpHasil.Controls.Add(Label5)
        tpHasil.Controls.Add(Label4)
        tpHasil.Controls.Add(Label3)
        tpHasil.Controls.Add(cbPembalapHasil)
        tpHasil.Controls.Add(Label2)
        tpHasil.Controls.Add(cbRaceHasil)
        tpHasil.Controls.Add(dgvHasilRace)
        tpHasil.Controls.Add(Label1)
        tpHasil.Controls.Add(cbPilihRace)
        tpHasil.Location = New Point(4, 40)
        tpHasil.Name = "tpHasil"
        tpHasil.Padding = New Padding(3)
        tpHasil.Size = New Size(1072, 656)
        tpHasil.TabIndex = 3
        tpHasil.Text = "Hasil"
        tpHasil.UseVisualStyleBackColor = True
        ' 
        ' cbPilihRace
        ' 
        cbPilihRace.FormattingEnabled = True
        cbPilihRace.Location = New Point(299, 52)
        cbPilihRace.Name = "cbPilihRace"
        cbPilihRace.Size = New Size(182, 33)
        cbPilihRace.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(299, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 25)
        Label1.TabIndex = 1
        Label1.Text = "Pilih Race"
        ' 
        ' dgvHasilRace
        ' 
        dgvHasilRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHasilRace.Location = New Point(299, 96)
        dgvHasilRace.Name = "dgvHasilRace"
        dgvHasilRace.RowHeadersWidth = 62
        dgvHasilRace.Size = New Size(765, 476)
        dgvHasilRace.TabIndex = 2
        ' 
        ' cbRaceHasil
        ' 
        cbRaceHasil.FormattingEnabled = True
        cbRaceHasil.Location = New Point(34, 52)
        cbRaceHasil.Name = "cbRaceHasil"
        cbRaceHasil.Size = New Size(182, 33)
        cbRaceHasil.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 25)
        Label2.TabIndex = 4
        Label2.Text = "Grand Prix"
        ' 
        ' cbPembalapHasil
        ' 
        cbPembalapHasil.FormattingEnabled = True
        cbPembalapHasil.Location = New Point(34, 129)
        cbPembalapHasil.Name = "cbPembalapHasil"
        cbPembalapHasil.Size = New Size(182, 33)
        cbPembalapHasil.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 25)
        Label3.TabIndex = 6
        Label3.Text = "Pembalap"
        ' 
        ' txtTimHasil
        ' 
        txtTimHasil.BackColor = SystemColors.ControlDarkDark
        txtTimHasil.Location = New Point(34, 201)
        txtTimHasil.Name = "txtTimHasil"
        txtTimHasil.ReadOnly = True
        txtTimHasil.Size = New Size(150, 31)
        txtTimHasil.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 25)
        Label4.TabIndex = 8
        Label4.Text = "Tim"
        ' 
        ' txtPosisi
        ' 
        txtPosisi.BackColor = SystemColors.ControlDarkDark
        txtPosisi.Location = New Point(34, 273)
        txtPosisi.Name = "txtPosisi"
        txtPosisi.Size = New Size(56, 31)
        txtPosisi.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 25)
        Label5.TabIndex = 10
        Label5.Text = "Posisi"
        ' 
        ' txtGap
        ' 
        txtGap.BackColor = SystemColors.ControlDarkDark
        txtGap.Location = New Point(134, 273)
        txtGap.Name = "txtGap"
        txtGap.Size = New Size(150, 31)
        txtGap.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(140, 245)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 25)
        Label6.TabIndex = 12
        Label6.Text = "Gap"
        ' 
        ' cbStatusFinish
        ' 
        cbStatusFinish.FormattingEnabled = True
        cbStatusFinish.Items.AddRange(New Object() {"Finish", "DNF", "DNS"})
        cbStatusFinish.Location = New Point(37, 357)
        cbStatusFinish.Name = "cbStatusFinish"
        cbStatusFinish.Size = New Size(107, 33)
        cbStatusFinish.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(34, 329)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 25)
        Label7.TabIndex = 14
        Label7.Text = "Status Finish"
        ' 
        ' chkFastestLap
        ' 
        chkFastestLap.AutoSize = True
        chkFastestLap.Location = New Point(159, 357)
        chkFastestLap.Name = "chkFastestLap"
        chkFastestLap.Size = New Size(125, 29)
        chkFastestLap.TabIndex = 16
        chkFastestLap.Text = "Fastest Lap"
        chkFastestLap.UseVisualStyleBackColor = True
        ' 
        ' txtPoinHasil
        ' 
        txtPoinHasil.BackColor = SystemColors.ControlDarkDark
        txtPoinHasil.Location = New Point(37, 438)
        txtPoinHasil.Name = "txtPoinHasil"
        txtPoinHasil.ReadOnly = True
        txtPoinHasil.Size = New Size(150, 31)
        txtPoinHasil.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(37, 410)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 25)
        Label9.TabIndex = 18
        Label9.Text = "Poin"
        ' 
        ' btnBatalHasil
        ' 
        btnBatalHasil.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalHasil.Cursor = Cursors.Hand
        btnBatalHasil.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalHasil.FlatStyle = FlatStyle.Flat
        btnBatalHasil.Font = New Font("Segoe UI", 9F)
        btnBatalHasil.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalHasil.Location = New Point(152, 539)
        btnBatalHasil.Margin = New Padding(2)
        btnBatalHasil.Name = "btnBatalHasil"
        btnBatalHasil.Size = New Size(100, 34)
        btnBatalHasil.TabIndex = 22
        btnBatalHasil.Text = "BATAL"
        btnBatalHasil.UseVisualStyleBackColor = False
        ' 
        ' btnHapusHasil
        ' 
        btnHapusHasil.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusHasil.Cursor = Cursors.Hand
        btnHapusHasil.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusHasil.FlatStyle = FlatStyle.Flat
        btnHapusHasil.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapusHasil.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusHasil.Location = New Point(37, 539)
        btnHapusHasil.Margin = New Padding(2)
        btnHapusHasil.Name = "btnHapusHasil"
        btnHapusHasil.Size = New Size(100, 34)
        btnHapusHasil.TabIndex = 21
        btnHapusHasil.Text = "HAPUS"
        btnHapusHasil.UseVisualStyleBackColor = False
        ' 
        ' btnUbahHasil
        ' 
        btnUbahHasil.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahHasil.Cursor = Cursors.Hand
        btnUbahHasil.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahHasil.FlatStyle = FlatStyle.Flat
        btnUbahHasil.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbahHasil.ForeColor = Color.White
        btnUbahHasil.Location = New Point(152, 495)
        btnUbahHasil.Margin = New Padding(2)
        btnUbahHasil.Name = "btnUbahHasil"
        btnUbahHasil.Size = New Size(100, 34)
        btnUbahHasil.TabIndex = 20
        btnUbahHasil.Text = "UBAH"
        btnUbahHasil.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanHasil
        ' 
        btnSimpanHasil.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanHasil.Cursor = Cursors.Hand
        btnSimpanHasil.FlatAppearance.BorderSize = 0
        btnSimpanHasil.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanHasil.FlatStyle = FlatStyle.Flat
        btnSimpanHasil.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanHasil.ForeColor = Color.White
        btnSimpanHasil.Location = New Point(37, 495)
        btnSimpanHasil.Margin = New Padding(2)
        btnSimpanHasil.Name = "btnSimpanHasil"
        btnSimpanHasil.Size = New Size(100, 34)
        btnSimpanHasil.TabIndex = 19
        btnSimpanHasil.Text = "SIMPAN"
        btnSimpanHasil.UseVisualStyleBackColor = False
        ' 
        ' tpRace
        ' 
        tpRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpRace.Controls.Add(pnlInputRace)
        tpRace.Controls.Add(pnlGridRace)
        tpRace.Location = New Point(4, 40)
        tpRace.Margin = New Padding(2)
        tpRace.Name = "tpRace"
        tpRace.Size = New Size(1072, 656)
        tpRace.TabIndex = 2
        tpRace.Text = "  Jadwal Race  "
        ' 
        ' pnlGridRace
        ' 
        pnlGridRace.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridRace.Controls.Add(txtSearchRace)
        pnlGridRace.Controls.Add(dgvRace)
        pnlGridRace.Location = New Point(260, 8)
        pnlGridRace.Margin = New Padding(2)
        pnlGridRace.Name = "pnlGridRace"
        pnlGridRace.Size = New Size(804, 640)
        pnlGridRace.TabIndex = 1
        ' 
        ' dgvRace
        ' 
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvRace.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        dgvRace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRace.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvRace.BorderStyle = BorderStyle.None
        dgvRace.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRace.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvRace.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvRace.ColumnHeadersHeight = 36
        dgvRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.White
        DataGridViewCellStyle9.Padding = New Padding(4)
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle9.SelectionForeColor = Color.White
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvRace.DefaultCellStyle = DataGridViewCellStyle9
        dgvRace.EnableHeadersVisualStyles = False
        dgvRace.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvRace.Location = New Point(10, 50)
        dgvRace.Margin = New Padding(2)
        dgvRace.Name = "dgvRace"
        dgvRace.RowHeadersVisible = False
        dgvRace.RowHeadersWidth = 51
        dgvRace.RowTemplate.Height = 32
        dgvRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRace.Size = New Size(784, 580)
        dgvRace.TabIndex = 1
        ' 
        ' txtSearchRace
        ' 
        txtSearchRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchRace.BorderStyle = BorderStyle.FixedSingle
        txtSearchRace.Font = New Font("Segoe UI", 10F)
        txtSearchRace.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchRace.Location = New Point(10, 10)
        txtSearchRace.Margin = New Padding(2)
        txtSearchRace.Name = "txtSearchRace"
        txtSearchRace.Size = New Size(784, 34)
        txtSearchRace.TabIndex = 0
        txtSearchRace.Text = "🔍  Cari jadwal race..."
        ' 
        ' pnlInputRace
        ' 
        pnlInputRace.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlInputRace.Controls.Add(lblPanelRace)
        pnlInputRace.Controls.Add(lblNamaRace)
        pnlInputRace.Controls.Add(txtNamaRace)
        pnlInputRace.Controls.Add(lblLokasi)
        pnlInputRace.Controls.Add(txtLokasi)
        pnlInputRace.Controls.Add(lblTanggal)
        pnlInputRace.Controls.Add(dtpTanggal)
        pnlInputRace.Controls.Add(lblPutaran)
        pnlInputRace.Controls.Add(txtPutaran)
        pnlInputRace.Controls.Add(pnlActionRace)
        pnlInputRace.Location = New Point(8, 8)
        pnlInputRace.Margin = New Padding(2)
        pnlInputRace.Name = "pnlInputRace"
        pnlInputRace.Size = New Size(240, 640)
        pnlInputRace.TabIndex = 0
        ' 
        ' pnlActionRace
        ' 
        pnlActionRace.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionRace.Controls.Add(btnSimpanRace)
        pnlActionRace.Controls.Add(btnUbahRace)
        pnlActionRace.Controls.Add(btnHapusRace)
        pnlActionRace.Controls.Add(btnBatalRace)
        pnlActionRace.Controls.Add(btnPrintRace)
        pnlActionRace.Location = New Point(0, 440)
        pnlActionRace.Margin = New Padding(2)
        pnlActionRace.Name = "pnlActionRace"
        pnlActionRace.Size = New Size(240, 200)
        pnlActionRace.TabIndex = 10
        ' 
        ' btnPrintRace
        ' 
        btnPrintRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintRace.Cursor = Cursors.Hand
        btnPrintRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.FlatStyle = FlatStyle.Flat
        btnPrintRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnPrintRace.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.Location = New Point(10, 100)
        btnPrintRace.Margin = New Padding(2)
        btnPrintRace.Name = "btnPrintRace"
        btnPrintRace.Size = New Size(215, 34)
        btnPrintRace.TabIndex = 9
        btnPrintRace.Text = "🖨  PRINT DOKUMEN"
        btnPrintRace.UseVisualStyleBackColor = False
        ' 
        ' btnBatalRace
        ' 
        btnBatalRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalRace.Cursor = Cursors.Hand
        btnBatalRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalRace.FlatStyle = FlatStyle.Flat
        btnBatalRace.Font = New Font("Segoe UI", 9F)
        btnBatalRace.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalRace.Location = New Point(125, 54)
        btnBatalRace.Margin = New Padding(2)
        btnBatalRace.Name = "btnBatalRace"
        btnBatalRace.Size = New Size(100, 34)
        btnBatalRace.TabIndex = 8
        btnBatalRace.Text = "BATAL"
        btnBatalRace.UseVisualStyleBackColor = False
        ' 
        ' btnHapusRace
        ' 
        btnHapusRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusRace.Cursor = Cursors.Hand
        btnHapusRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusRace.FlatStyle = FlatStyle.Flat
        btnHapusRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapusRace.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusRace.Location = New Point(10, 54)
        btnHapusRace.Margin = New Padding(2)
        btnHapusRace.Name = "btnHapusRace"
        btnHapusRace.Size = New Size(100, 34)
        btnHapusRace.TabIndex = 7
        btnHapusRace.Text = "HAPUS"
        btnHapusRace.UseVisualStyleBackColor = False
        ' 
        ' btnUbahRace
        ' 
        btnUbahRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahRace.Cursor = Cursors.Hand
        btnUbahRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahRace.FlatStyle = FlatStyle.Flat
        btnUbahRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbahRace.ForeColor = Color.White
        btnUbahRace.Location = New Point(125, 10)
        btnUbahRace.Margin = New Padding(2)
        btnUbahRace.Name = "btnUbahRace"
        btnUbahRace.Size = New Size(100, 34)
        btnUbahRace.TabIndex = 6
        btnUbahRace.Text = "UBAH"
        btnUbahRace.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanRace
        ' 
        btnSimpanRace.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanRace.Cursor = Cursors.Hand
        btnSimpanRace.FlatAppearance.BorderSize = 0
        btnSimpanRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanRace.FlatStyle = FlatStyle.Flat
        btnSimpanRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanRace.ForeColor = Color.White
        btnSimpanRace.Location = New Point(10, 10)
        btnSimpanRace.Margin = New Padding(2)
        btnSimpanRace.Name = "btnSimpanRace"
        btnSimpanRace.Size = New Size(100, 34)
        btnSimpanRace.TabIndex = 5
        btnSimpanRace.Text = "SIMPAN"
        btnSimpanRace.UseVisualStyleBackColor = False
        ' 
        ' txtPutaran
        ' 
        txtPutaran.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtPutaran.BorderStyle = BorderStyle.FixedSingle
        txtPutaran.Font = New Font("Segoe UI", 10F)
        txtPutaran.ForeColor = Color.White
        txtPutaran.Location = New Point(12, 260)
        txtPutaran.Margin = New Padding(2)
        txtPutaran.Name = "txtPutaran"
        txtPutaran.Size = New Size(214, 34)
        txtPutaran.TabIndex = 4
        ' 
        ' lblPutaran
        ' 
        lblPutaran.AutoSize = True
        lblPutaran.Font = New Font("Segoe UI", 8F)
        lblPutaran.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblPutaran.Location = New Point(12, 242)
        lblPutaran.Margin = New Padding(2, 0, 2, 0)
        lblPutaran.Name = "lblPutaran"
        lblPutaran.Size = New Size(149, 21)
        lblPutaran.TabIndex = 4
        lblPutaran.Text = "PUTARAN (ROUND)"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        dtpTanggal.CalendarForeColor = Color.White
        dtpTanggal.CalendarMonthBackground = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dtpTanggal.CalendarTitleBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        dtpTanggal.CalendarTitleForeColor = Color.White
        dtpTanggal.Font = New Font("Segoe UI", 10F)
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(12, 196)
        dtpTanggal.Margin = New Padding(2)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(215, 34)
        dtpTanggal.TabIndex = 3
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 8F)
        lblTanggal.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblTanggal.Location = New Point(12, 178)
        lblTanggal.Margin = New Padding(2, 0, 2, 0)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(79, 21)
        lblTanggal.TabIndex = 3
        lblTanggal.Text = "TANGGAL"
        ' 
        ' txtLokasi
        ' 
        txtLokasi.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtLokasi.BorderStyle = BorderStyle.FixedSingle
        txtLokasi.Font = New Font("Segoe UI", 10F)
        txtLokasi.ForeColor = Color.White
        txtLokasi.Location = New Point(12, 132)
        txtLokasi.Margin = New Padding(2)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(214, 34)
        txtLokasi.TabIndex = 2
        ' 
        ' lblLokasi
        ' 
        lblLokasi.AutoSize = True
        lblLokasi.Font = New Font("Segoe UI", 8F)
        lblLokasi.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblLokasi.Location = New Point(12, 114)
        lblLokasi.Margin = New Padding(2, 0, 2, 0)
        lblLokasi.Name = "lblLokasi"
        lblLokasi.Size = New Size(130, 21)
        lblLokasi.TabIndex = 2
        lblLokasi.Text = "SIRKUIT / LOKASI"
        ' 
        ' txtNamaRace
        ' 
        txtNamaRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaRace.BorderStyle = BorderStyle.FixedSingle
        txtNamaRace.Font = New Font("Segoe UI", 10F)
        txtNamaRace.ForeColor = Color.White
        txtNamaRace.Location = New Point(12, 68)
        txtNamaRace.Margin = New Padding(2)
        txtNamaRace.Name = "txtNamaRace"
        txtNamaRace.Size = New Size(214, 34)
        txtNamaRace.TabIndex = 1
        ' 
        ' lblNamaRace
        ' 
        lblNamaRace.AutoSize = True
        lblNamaRace.Font = New Font("Segoe UI", 8F)
        lblNamaRace.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaRace.Location = New Point(12, 50)
        lblNamaRace.Margin = New Padding(2, 0, 2, 0)
        lblNamaRace.Name = "lblNamaRace"
        lblNamaRace.Size = New Size(150, 21)
        lblNamaRace.TabIndex = 1
        lblNamaRace.Text = "NAMA GRAND PRIX"
        ' 
        ' lblPanelRace
        ' 
        lblPanelRace.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelRace.Dock = DockStyle.Top
        lblPanelRace.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPanelRace.ForeColor = Color.White
        lblPanelRace.Location = New Point(0, 0)
        lblPanelRace.Margin = New Padding(2, 0, 2, 0)
        lblPanelRace.Name = "lblPanelRace"
        lblPanelRace.Size = New Size(240, 32)
        lblPanelRace.TabIndex = 0
        lblPanelRace.Text = "  DATA RACE"
        lblPanelRace.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tpTim
        ' 
        tpTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpTim.Controls.Add(pnlInputTim)
        tpTim.Controls.Add(pnlGridTim)
        tpTim.Location = New Point(4, 40)
        tpTim.Margin = New Padding(2)
        tpTim.Name = "tpTim"
        tpTim.Size = New Size(1072, 656)
        tpTim.TabIndex = 1
        tpTim.Text = "  Konstruktor  "
        ' 
        ' pnlGridTim
        ' 
        pnlGridTim.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridTim.Controls.Add(txtSearchTim)
        pnlGridTim.Controls.Add(dgvTim)
        pnlGridTim.Location = New Point(260, 8)
        pnlGridTim.Margin = New Padding(2)
        pnlGridTim.Name = "pnlGridTim"
        pnlGridTim.Size = New Size(804, 640)
        pnlGridTim.TabIndex = 1
        ' 
        ' dgvTim
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvTim.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvTim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTim.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvTim.BorderStyle = BorderStyle.None
        dgvTim.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTim.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvTim.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvTim.ColumnHeadersHeight = 36
        dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.Padding = New Padding(4)
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvTim.DefaultCellStyle = DataGridViewCellStyle6
        dgvTim.EnableHeadersVisualStyles = False
        dgvTim.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvTim.Location = New Point(10, 50)
        dgvTim.Margin = New Padding(2)
        dgvTim.Name = "dgvTim"
        dgvTim.RowHeadersVisible = False
        dgvTim.RowHeadersWidth = 51
        dgvTim.RowTemplate.Height = 32
        dgvTim.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTim.Size = New Size(784, 580)
        dgvTim.TabIndex = 1
        ' 
        ' txtSearchTim
        ' 
        txtSearchTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchTim.BorderStyle = BorderStyle.FixedSingle
        txtSearchTim.Font = New Font("Segoe UI", 10F)
        txtSearchTim.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchTim.Location = New Point(10, 10)
        txtSearchTim.Margin = New Padding(2)
        txtSearchTim.Name = "txtSearchTim"
        txtSearchTim.Size = New Size(784, 34)
        txtSearchTim.TabIndex = 0
        txtSearchTim.Text = "🔍  Cari tim konstruktor..."
        ' 
        ' pnlInputTim
        ' 
        pnlInputTim.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlInputTim.Controls.Add(lblPanelTim)
        pnlInputTim.Controls.Add(picLogoTim)
        pnlInputTim.Controls.Add(btnPilihLogo)
        pnlInputTim.Controls.Add(lblNamaTim)
        pnlInputTim.Controls.Add(txtNamaTim)
        pnlInputTim.Controls.Add(lblNegaraTim)
        pnlInputTim.Controls.Add(txtNegaraTim)
        pnlInputTim.Controls.Add(lblMesin)
        pnlInputTim.Controls.Add(txtMesin)
        pnlInputTim.Controls.Add(lblChasis)
        pnlInputTim.Controls.Add(txtChasis)
        pnlInputTim.Controls.Add(pnlActionTim)
        pnlInputTim.Location = New Point(8, 8)
        pnlInputTim.Margin = New Padding(2)
        pnlInputTim.Name = "pnlInputTim"
        pnlInputTim.Size = New Size(240, 640)
        pnlInputTim.TabIndex = 0
        ' 
        ' pnlActionTim
        ' 
        pnlActionTim.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionTim.Controls.Add(btnSimpanTim)
        pnlActionTim.Controls.Add(btnUbahTim)
        pnlActionTim.Controls.Add(btnHapusTim)
        pnlActionTim.Controls.Add(btnBatalTim)
        pnlActionTim.Controls.Add(btnPrintTim)
        pnlActionTim.Location = New Point(0, 440)
        pnlActionTim.Margin = New Padding(2)
        pnlActionTim.Name = "pnlActionTim"
        pnlActionTim.Size = New Size(240, 200)
        pnlActionTim.TabIndex = 10
        ' 
        ' btnPrintTim
        ' 
        btnPrintTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintTim.Cursor = Cursors.Hand
        btnPrintTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintTim.FlatStyle = FlatStyle.Flat
        btnPrintTim.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnPrintTim.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintTim.Location = New Point(10, 100)
        btnPrintTim.Margin = New Padding(2)
        btnPrintTim.Name = "btnPrintTim"
        btnPrintTim.Size = New Size(215, 34)
        btnPrintTim.TabIndex = 10
        btnPrintTim.Text = "🖨  PRINT DOKUMEN"
        btnPrintTim.UseVisualStyleBackColor = False
        ' 
        ' btnBatalTim
        ' 
        btnBatalTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalTim.Cursor = Cursors.Hand
        btnBatalTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalTim.FlatStyle = FlatStyle.Flat
        btnBatalTim.Font = New Font("Segoe UI", 9F)
        btnBatalTim.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalTim.Location = New Point(125, 54)
        btnBatalTim.Margin = New Padding(2)
        btnBatalTim.Name = "btnBatalTim"
        btnBatalTim.Size = New Size(100, 34)
        btnBatalTim.TabIndex = 9
        btnBatalTim.Text = "BATAL"
        btnBatalTim.UseVisualStyleBackColor = False
        ' 
        ' btnHapusTim
        ' 
        btnHapusTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusTim.Cursor = Cursors.Hand
        btnHapusTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusTim.FlatStyle = FlatStyle.Flat
        btnHapusTim.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapusTim.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusTim.Location = New Point(10, 54)
        btnHapusTim.Margin = New Padding(2)
        btnHapusTim.Name = "btnHapusTim"
        btnHapusTim.Size = New Size(100, 34)
        btnHapusTim.TabIndex = 8
        btnHapusTim.Text = "HAPUS"
        btnHapusTim.UseVisualStyleBackColor = False
        ' 
        ' btnUbahTim
        ' 
        btnUbahTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahTim.Cursor = Cursors.Hand
        btnUbahTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahTim.FlatStyle = FlatStyle.Flat
        btnUbahTim.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbahTim.ForeColor = Color.White
        btnUbahTim.Location = New Point(125, 10)
        btnUbahTim.Margin = New Padding(2)
        btnUbahTim.Name = "btnUbahTim"
        btnUbahTim.Size = New Size(100, 34)
        btnUbahTim.TabIndex = 7
        btnUbahTim.Text = "UBAH"
        btnUbahTim.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanTim
        ' 
        btnSimpanTim.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanTim.Cursor = Cursors.Hand
        btnSimpanTim.FlatAppearance.BorderSize = 0
        btnSimpanTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanTim.FlatStyle = FlatStyle.Flat
        btnSimpanTim.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanTim.ForeColor = Color.White
        btnSimpanTim.Location = New Point(10, 10)
        btnSimpanTim.Margin = New Padding(2)
        btnSimpanTim.Name = "btnSimpanTim"
        btnSimpanTim.Size = New Size(100, 34)
        btnSimpanTim.TabIndex = 6
        btnSimpanTim.Text = "SIMPAN"
        btnSimpanTim.UseVisualStyleBackColor = False
        ' 
        ' txtChasis
        ' 
        txtChasis.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtChasis.BorderStyle = BorderStyle.FixedSingle
        txtChasis.Font = New Font("Segoe UI", 10F)
        txtChasis.ForeColor = Color.White
        txtChasis.Location = New Point(12, 368)
        txtChasis.Margin = New Padding(2)
        txtChasis.Name = "txtChasis"
        txtChasis.Size = New Size(214, 34)
        txtChasis.TabIndex = 5
        ' 
        ' lblChasis
        ' 
        lblChasis.AutoSize = True
        lblChasis.Font = New Font("Segoe UI", 8F)
        lblChasis.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblChasis.Location = New Point(12, 350)
        lblChasis.Margin = New Padding(2, 0, 2, 0)
        lblChasis.Name = "lblChasis"
        lblChasis.Size = New Size(63, 21)
        lblChasis.TabIndex = 5
        lblChasis.Text = "CHASIS"
        ' 
        ' txtMesin
        ' 
        txtMesin.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtMesin.BorderStyle = BorderStyle.FixedSingle
        txtMesin.Font = New Font("Segoe UI", 10F)
        txtMesin.ForeColor = Color.White
        txtMesin.Location = New Point(12, 306)
        txtMesin.Margin = New Padding(2)
        txtMesin.Name = "txtMesin"
        txtMesin.Size = New Size(214, 34)
        txtMesin.TabIndex = 4
        ' 
        ' lblMesin
        ' 
        lblMesin.AutoSize = True
        lblMesin.Font = New Font("Segoe UI", 8F)
        lblMesin.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblMesin.Location = New Point(12, 288)
        lblMesin.Margin = New Padding(2, 0, 2, 0)
        lblMesin.Name = "lblMesin"
        lblMesin.Size = New Size(57, 21)
        lblMesin.TabIndex = 4
        lblMesin.Text = "MESIN"
        ' 
        ' txtNegaraTim
        ' 
        txtNegaraTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNegaraTim.BorderStyle = BorderStyle.FixedSingle
        txtNegaraTim.Font = New Font("Segoe UI", 10F)
        txtNegaraTim.ForeColor = Color.White
        txtNegaraTim.Location = New Point(12, 244)
        txtNegaraTim.Margin = New Padding(2)
        txtNegaraTim.Name = "txtNegaraTim"
        txtNegaraTim.Size = New Size(214, 34)
        txtNegaraTim.TabIndex = 3
        ' 
        ' lblNegaraTim
        ' 
        lblNegaraTim.AutoSize = True
        lblNegaraTim.Font = New Font("Segoe UI", 8F)
        lblNegaraTim.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNegaraTim.Location = New Point(12, 226)
        lblNegaraTim.Margin = New Padding(2, 0, 2, 0)
        lblNegaraTim.Name = "lblNegaraTim"
        lblNegaraTim.Size = New Size(71, 21)
        lblNegaraTim.TabIndex = 3
        lblNegaraTim.Text = "NEGARA"
        ' 
        ' txtNamaTim
        ' 
        txtNamaTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaTim.BorderStyle = BorderStyle.FixedSingle
        txtNamaTim.Font = New Font("Segoe UI", 10F)
        txtNamaTim.ForeColor = Color.White
        txtNamaTim.Location = New Point(12, 182)
        txtNamaTim.Margin = New Padding(2)
        txtNamaTim.Name = "txtNamaTim"
        txtNamaTim.Size = New Size(214, 34)
        txtNamaTim.TabIndex = 2
        ' 
        ' lblNamaTim
        ' 
        lblNamaTim.AutoSize = True
        lblNamaTim.Font = New Font("Segoe UI", 8F)
        lblNamaTim.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaTim.Location = New Point(12, 165)
        lblNamaTim.Margin = New Padding(2, 0, 2, 0)
        lblNamaTim.Name = "lblNamaTim"
        lblNamaTim.Size = New Size(86, 21)
        lblNamaTim.TabIndex = 2
        lblNamaTim.Text = "NAMA TIM"
        ' 
        ' btnPilihLogo
        ' 
        btnPilihLogo.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnPilihLogo.Cursor = Cursors.Hand
        btnPilihLogo.FlatAppearance.BorderSize = 0
        btnPilihLogo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPilihLogo.FlatStyle = FlatStyle.Flat
        btnPilihLogo.Font = New Font("Segoe UI", 8F)
        btnPilihLogo.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnPilihLogo.Location = New Point(55, 128)
        btnPilihLogo.Margin = New Padding(2)
        btnPilihLogo.Name = "btnPilihLogo"
        btnPilihLogo.Size = New Size(130, 24)
        btnPilihLogo.TabIndex = 1
        btnPilihLogo.Text = "Pilih Logo..."
        btnPilihLogo.UseVisualStyleBackColor = False
        ' 
        ' picLogoTim
        ' 
        picLogoTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        picLogoTim.BorderStyle = BorderStyle.FixedSingle
        picLogoTim.Location = New Point(55, 42)
        picLogoTim.Margin = New Padding(2)
        picLogoTim.Name = "picLogoTim"
        picLogoTim.Size = New Size(130, 80)
        picLogoTim.SizeMode = PictureBoxSizeMode.Zoom
        picLogoTim.TabIndex = 0
        picLogoTim.TabStop = False
        ' 
        ' lblPanelTim
        ' 
        lblPanelTim.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelTim.Dock = DockStyle.Top
        lblPanelTim.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPanelTim.ForeColor = Color.White
        lblPanelTim.Location = New Point(0, 0)
        lblPanelTim.Margin = New Padding(2, 0, 2, 0)
        lblPanelTim.Name = "lblPanelTim"
        lblPanelTim.Size = New Size(240, 32)
        lblPanelTim.TabIndex = 0
        lblPanelTim.Text = "  DATA KONSTRUKTOR"
        lblPanelTim.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tpPembalap
        ' 
        tpPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpPembalap.Controls.Add(pnlInputPembalap)
        tpPembalap.Controls.Add(pnlGridPembalap)
        tpPembalap.Location = New Point(4, 40)
        tpPembalap.Margin = New Padding(2)
        tpPembalap.Name = "tpPembalap"
        tpPembalap.Size = New Size(1072, 656)
        tpPembalap.TabIndex = 0
        tpPembalap.Text = "  Pembalap  "
        ' 
        ' pnlGridPembalap
        ' 
        pnlGridPembalap.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridPembalap.Controls.Add(txtSearchPembalap)
        pnlGridPembalap.Controls.Add(dgvPembalap)
        pnlGridPembalap.Location = New Point(260, 8)
        pnlGridPembalap.Margin = New Padding(2)
        pnlGridPembalap.Name = "pnlGridPembalap"
        pnlGridPembalap.Size = New Size(804, 640)
        pnlGridPembalap.TabIndex = 1
        ' 
        ' dgvPembalap
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(38), CByte(38), CByte(52))
        dgvPembalap.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvPembalap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPembalap.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvPembalap.BorderStyle = BorderStyle.None
        dgvPembalap.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPembalap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvPembalap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvPembalap.ColumnHeadersHeight = 36
        dgvPembalap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.Padding = New Padding(4)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvPembalap.DefaultCellStyle = DataGridViewCellStyle3
        dgvPembalap.EnableHeadersVisualStyles = False
        dgvPembalap.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvPembalap.Location = New Point(10, 50)
        dgvPembalap.Margin = New Padding(2)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.RowHeadersVisible = False
        dgvPembalap.RowHeadersWidth = 51
        dgvPembalap.RowTemplate.Height = 32
        dgvPembalap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembalap.Size = New Size(784, 580)
        dgvPembalap.TabIndex = 1
        ' 
        ' txtSearchPembalap
        ' 
        txtSearchPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchPembalap.BorderStyle = BorderStyle.FixedSingle
        txtSearchPembalap.Font = New Font("Segoe UI", 10F)
        txtSearchPembalap.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchPembalap.Location = New Point(10, 10)
        txtSearchPembalap.Margin = New Padding(2)
        txtSearchPembalap.Name = "txtSearchPembalap"
        txtSearchPembalap.Size = New Size(784, 34)
        txtSearchPembalap.TabIndex = 0
        txtSearchPembalap.Text = "🔍  Cari pembalap..."
        ' 
        ' pnlInputPembalap
        ' 
        pnlInputPembalap.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlInputPembalap.Controls.Add(lblPanelPembalap)
        pnlInputPembalap.Controls.Add(lblNamaPembalap)
        pnlInputPembalap.Controls.Add(txtNamaPembalap)
        pnlInputPembalap.Controls.Add(lblNegaraPembalap)
        pnlInputPembalap.Controls.Add(txtNegaraPembalap)
        pnlInputPembalap.Controls.Add(lblNomor)
        pnlInputPembalap.Controls.Add(txtNomor)
        pnlInputPembalap.Controls.Add(lblTimPembalap)
        pnlInputPembalap.Controls.Add(cbTim)
        pnlInputPembalap.Controls.Add(pnlActionPembalap)
        pnlInputPembalap.Location = New Point(8, 8)
        pnlInputPembalap.Margin = New Padding(2)
        pnlInputPembalap.Name = "pnlInputPembalap"
        pnlInputPembalap.Size = New Size(240, 640)
        pnlInputPembalap.TabIndex = 0
        ' 
        ' pnlActionPembalap
        ' 
        pnlActionPembalap.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionPembalap.Controls.Add(btnSimpanPembalap)
        pnlActionPembalap.Controls.Add(btnUbahPembalap)
        pnlActionPembalap.Controls.Add(btnHapusPembalap)
        pnlActionPembalap.Controls.Add(btnBatalPembalap)
        pnlActionPembalap.Controls.Add(btnPrintPembalap)
        pnlActionPembalap.Location = New Point(0, 440)
        pnlActionPembalap.Margin = New Padding(2)
        pnlActionPembalap.Name = "pnlActionPembalap"
        pnlActionPembalap.Size = New Size(240, 200)
        pnlActionPembalap.TabIndex = 10
        ' 
        ' btnPrintPembalap
        ' 
        btnPrintPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintPembalap.Cursor = Cursors.Hand
        btnPrintPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintPembalap.FlatStyle = FlatStyle.Flat
        btnPrintPembalap.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnPrintPembalap.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintPembalap.Location = New Point(10, 100)
        btnPrintPembalap.Margin = New Padding(2)
        btnPrintPembalap.Name = "btnPrintPembalap"
        btnPrintPembalap.Size = New Size(215, 34)
        btnPrintPembalap.TabIndex = 9
        btnPrintPembalap.Text = "🖨  PRINT DOKUMEN"
        btnPrintPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnBatalPembalap
        ' 
        btnBatalPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalPembalap.Cursor = Cursors.Hand
        btnBatalPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalPembalap.FlatStyle = FlatStyle.Flat
        btnBatalPembalap.Font = New Font("Segoe UI", 9F)
        btnBatalPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalPembalap.Location = New Point(125, 54)
        btnBatalPembalap.Margin = New Padding(2)
        btnBatalPembalap.Name = "btnBatalPembalap"
        btnBatalPembalap.Size = New Size(100, 34)
        btnBatalPembalap.TabIndex = 8
        btnBatalPembalap.Text = "BATAL"
        btnBatalPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnHapusPembalap
        ' 
        btnHapusPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusPembalap.Cursor = Cursors.Hand
        btnHapusPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusPembalap.FlatStyle = FlatStyle.Flat
        btnHapusPembalap.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapusPembalap.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusPembalap.Location = New Point(10, 54)
        btnHapusPembalap.Margin = New Padding(2)
        btnHapusPembalap.Name = "btnHapusPembalap"
        btnHapusPembalap.Size = New Size(100, 34)
        btnHapusPembalap.TabIndex = 7
        btnHapusPembalap.Text = "HAPUS"
        btnHapusPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnUbahPembalap
        ' 
        btnUbahPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahPembalap.Cursor = Cursors.Hand
        btnUbahPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahPembalap.FlatStyle = FlatStyle.Flat
        btnUbahPembalap.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbahPembalap.ForeColor = Color.White
        btnUbahPembalap.Location = New Point(125, 10)
        btnUbahPembalap.Margin = New Padding(2)
        btnUbahPembalap.Name = "btnUbahPembalap"
        btnUbahPembalap.Size = New Size(100, 34)
        btnUbahPembalap.TabIndex = 6
        btnUbahPembalap.Text = "UBAH"
        btnUbahPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanPembalap
        ' 
        btnSimpanPembalap.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanPembalap.Cursor = Cursors.Hand
        btnSimpanPembalap.FlatAppearance.BorderSize = 0
        btnSimpanPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanPembalap.FlatStyle = FlatStyle.Flat
        btnSimpanPembalap.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanPembalap.ForeColor = Color.White
        btnSimpanPembalap.Location = New Point(10, 10)
        btnSimpanPembalap.Margin = New Padding(2)
        btnSimpanPembalap.Name = "btnSimpanPembalap"
        btnSimpanPembalap.Size = New Size(100, 34)
        btnSimpanPembalap.TabIndex = 5
        btnSimpanPembalap.Text = "SIMPAN"
        btnSimpanPembalap.UseVisualStyleBackColor = False
        ' 
        ' cbTim
        ' 
        cbTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        cbTim.DropDownStyle = ComboBoxStyle.DropDownList
        cbTim.FlatStyle = FlatStyle.Flat
        cbTim.Font = New Font("Segoe UI", 10F)
        cbTim.ForeColor = Color.White
        cbTim.FormattingEnabled = True
        cbTim.Location = New Point(12, 265)
        cbTim.Margin = New Padding(2)
        cbTim.Name = "cbTim"
        cbTim.Size = New Size(215, 36)
        cbTim.TabIndex = 4
        ' 
        ' lblTimPembalap
        ' 
        lblTimPembalap.AutoSize = True
        lblTimPembalap.Font = New Font("Segoe UI", 8F)
        lblTimPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblTimPembalap.Location = New Point(12, 245)
        lblTimPembalap.Margin = New Padding(2, 0, 2, 0)
        lblTimPembalap.Name = "lblTimPembalap"
        lblTimPembalap.Size = New Size(158, 21)
        lblTimPembalap.TabIndex = 4
        lblTimPembalap.Text = "KONSTRUKTOR / TIM"
        ' 
        ' txtNomor
        ' 
        txtNomor.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNomor.BorderStyle = BorderStyle.FixedSingle
        txtNomor.Font = New Font("Segoe UI", 10F)
        txtNomor.ForeColor = Color.White
        txtNomor.Location = New Point(12, 200)
        txtNomor.Margin = New Padding(2)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(214, 34)
        txtNomor.TabIndex = 3
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.Font = New Font("Segoe UI", 8F)
        lblNomor.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNomor.Location = New Point(12, 180)
        lblNomor.Margin = New Padding(2, 0, 2, 0)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(120, 21)
        lblNomor.TabIndex = 3
        lblNomor.Text = "NOMOR BALAP"
        ' 
        ' txtNegaraPembalap
        ' 
        txtNegaraPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNegaraPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNegaraPembalap.Font = New Font("Segoe UI", 10F)
        txtNegaraPembalap.ForeColor = Color.White
        txtNegaraPembalap.Location = New Point(12, 135)
        txtNegaraPembalap.Margin = New Padding(2)
        txtNegaraPembalap.Name = "txtNegaraPembalap"
        txtNegaraPembalap.Size = New Size(214, 34)
        txtNegaraPembalap.TabIndex = 2
        ' 
        ' lblNegaraPembalap
        ' 
        lblNegaraPembalap.AutoSize = True
        lblNegaraPembalap.Font = New Font("Segoe UI", 8F)
        lblNegaraPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNegaraPembalap.Location = New Point(12, 115)
        lblNegaraPembalap.Margin = New Padding(2, 0, 2, 0)
        lblNegaraPembalap.Name = "lblNegaraPembalap"
        lblNegaraPembalap.Size = New Size(71, 21)
        lblNegaraPembalap.TabIndex = 2
        lblNegaraPembalap.Text = "NEGARA"
        ' 
        ' txtNamaPembalap
        ' 
        txtNamaPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNamaPembalap.Font = New Font("Segoe UI", 10F)
        txtNamaPembalap.ForeColor = Color.White
        txtNamaPembalap.Location = New Point(12, 70)
        txtNamaPembalap.Margin = New Padding(2)
        txtNamaPembalap.Name = "txtNamaPembalap"
        txtNamaPembalap.Size = New Size(214, 34)
        txtNamaPembalap.TabIndex = 1
        ' 
        ' lblNamaPembalap
        ' 
        lblNamaPembalap.AutoSize = True
        lblNamaPembalap.Font = New Font("Segoe UI", 8F)
        lblNamaPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaPembalap.Location = New Point(12, 50)
        lblNamaPembalap.Margin = New Padding(2, 0, 2, 0)
        lblNamaPembalap.Name = "lblNamaPembalap"
        lblNamaPembalap.Size = New Size(137, 21)
        lblNamaPembalap.TabIndex = 1
        lblNamaPembalap.Text = "NAMA PEMBALAP"
        ' 
        ' lblPanelPembalap
        ' 
        lblPanelPembalap.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelPembalap.Dock = DockStyle.Top
        lblPanelPembalap.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPanelPembalap.ForeColor = Color.White
        lblPanelPembalap.Location = New Point(0, 0)
        lblPanelPembalap.Margin = New Padding(2, 0, 2, 0)
        lblPanelPembalap.Name = "lblPanelPembalap"
        lblPanelPembalap.Size = New Size(240, 32)
        lblPanelPembalap.TabIndex = 0
        lblPanelPembalap.Text = "  DATA PEMBALAP"
        lblPanelPembalap.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tabMain
        ' 
        tabMain.Appearance = TabAppearance.FlatButtons
        tabMain.Controls.Add(tpPembalap)
        tabMain.Controls.Add(tpTim)
        tabMain.Controls.Add(tpRace)
        tabMain.Controls.Add(tpHasil)
        tabMain.Dock = DockStyle.Fill
        tabMain.ItemSize = New Size(130, 36)
        tabMain.Location = New Point(0, 0)
        tabMain.Margin = New Padding(2)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(1080, 700)
        tabMain.TabIndex = 0
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        ClientSize = New Size(1280, 760)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        Margin = New Padding(2)
        MinimumSize = New Size(1100, 647)
        Name = "DashboardAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Admin Dashboard"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        tpHasil.ResumeLayout(False)
        tpHasil.PerformLayout()
        CType(dgvHasilRace, ComponentModel.ISupportInitialize).EndInit()
        tpRace.ResumeLayout(False)
        pnlGridRace.ResumeLayout(False)
        pnlGridRace.PerformLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).EndInit()
        pnlInputRace.ResumeLayout(False)
        pnlInputRace.PerformLayout()
        pnlActionRace.ResumeLayout(False)
        tpTim.ResumeLayout(False)
        pnlGridTim.ResumeLayout(False)
        pnlGridTim.PerformLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).EndInit()
        pnlInputTim.ResumeLayout(False)
        pnlInputTim.PerformLayout()
        pnlActionTim.ResumeLayout(False)
        CType(picLogoTim, ComponentModel.ISupportInitialize).EndInit()
        tpPembalap.ResumeLayout(False)
        pnlGridPembalap.ResumeLayout(False)
        pnlGridPembalap.PerformLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).EndInit()
        pnlInputPembalap.ResumeLayout(False)
        pnlInputPembalap.PerformLayout()
        pnlActionPembalap.ResumeLayout(False)
        tabMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    ' === DEKLARASI VARIABEL ===
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents lblAdminBadge As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlSidebarTop As Panel
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents btnNavPembalap As Button
    Friend WithEvents btnNavTim As Button
    Friend WithEvents btnNavRace As Button
    Friend WithEvents pnlSidebarDivider As Panel
    Friend WithEvents btnNavKlasemen As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnNavHasil As Button
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tpPembalap As TabPage
    Friend WithEvents pnlInputPembalap As Panel
    Friend WithEvents lblPanelPembalap As Label
    Friend WithEvents lblNamaPembalap As Label
    Friend WithEvents txtNamaPembalap As TextBox
    Friend WithEvents lblNegaraPembalap As Label
    Friend WithEvents txtNegaraPembalap As TextBox
    Friend WithEvents lblNomor As Label
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents lblTimPembalap As Label
    Friend WithEvents cbTim As ComboBox
    Friend WithEvents pnlActionPembalap As Panel
    Friend WithEvents btnSimpanPembalap As Button
    Friend WithEvents btnUbahPembalap As Button
    Friend WithEvents btnHapusPembalap As Button
    Friend WithEvents btnBatalPembalap As Button
    Friend WithEvents btnPrintPembalap As Button
    Friend WithEvents pnlGridPembalap As Panel
    Friend WithEvents txtSearchPembalap As TextBox
    Friend WithEvents dgvPembalap As DataGridView
    Friend WithEvents tpTim As TabPage
    Friend WithEvents pnlInputTim As Panel
    Friend WithEvents lblPanelTim As Label
    Friend WithEvents picLogoTim As PictureBox
    Friend WithEvents btnPilihLogo As Button
    Friend WithEvents lblNamaTim As Label
    Friend WithEvents txtNamaTim As TextBox
    Friend WithEvents lblNegaraTim As Label
    Friend WithEvents txtNegaraTim As TextBox
    Friend WithEvents lblMesin As Label
    Friend WithEvents txtMesin As TextBox
    Friend WithEvents lblChasis As Label
    Friend WithEvents txtChasis As TextBox
    Friend WithEvents pnlActionTim As Panel
    Friend WithEvents btnSimpanTim As Button
    Friend WithEvents btnUbahTim As Button
    Friend WithEvents btnHapusTim As Button
    Friend WithEvents btnBatalTim As Button
    Friend WithEvents btnPrintTim As Button
    Friend WithEvents pnlGridTim As Panel
    Friend WithEvents txtSearchTim As TextBox
    Friend WithEvents dgvTim As DataGridView
    Friend WithEvents tpRace As TabPage
    Friend WithEvents pnlInputRace As Panel
    Friend WithEvents lblPanelRace As Label
    Friend WithEvents lblNamaRace As Label
    Friend WithEvents txtNamaRace As TextBox
    Friend WithEvents lblLokasi As Label
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents lblTanggal As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lblPutaran As Label
    Friend WithEvents txtPutaran As TextBox
    Friend WithEvents pnlActionRace As Panel
    Friend WithEvents btnSimpanRace As Button
    Friend WithEvents btnUbahRace As Button
    Friend WithEvents btnHapusRace As Button
    Friend WithEvents btnBatalRace As Button
    Friend WithEvents btnPrintRace As Button
    Friend WithEvents pnlGridRace As Panel
    Friend WithEvents txtSearchRace As TextBox
    Friend WithEvents dgvRace As DataGridView
    Friend WithEvents tpHasil As TabPage
    Friend WithEvents btnSimpanHasil As Button
    Friend WithEvents btnUbahHasil As Button
    Friend WithEvents btnHapusHasil As Button
    Friend WithEvents btnBatalHasil As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPoinHasil As TextBox
    Friend WithEvents txtGap As TextBox
    Friend WithEvents txtPosisi As TextBox
    Friend WithEvents txtTimHasil As TextBox
    Friend WithEvents chkFastestLap As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbStatusFinish As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbPembalapHasil As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbRaceHasil As ComboBox
    Friend WithEvents dgvHasilRace As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPilihRace As ComboBox
End Class