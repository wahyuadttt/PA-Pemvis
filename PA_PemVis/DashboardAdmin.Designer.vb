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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        lblAdminBadge = New Label()
        btnKeluar = New Button()
        pnlSidebar = New Panel()
        pnlSidebarTop = New Panel()
        lblMenuTitle = New Label()
        btnNavPembalap = New Button()
        btnNavTim = New Button()
        btnNavRace = New Button()
        pnlSidebarDivider = New Panel()
        btnNavKlasemen = New Button()
        pnlContent = New Panel()
        tabMain = New TabControl()
        tpPembalap = New TabPage()
        pnlInputPembalap = New Panel()
        lblPanelPembalap = New Label()
        lblNamaPembalap = New Label()
        txtNamaPembalap = New TextBox()
        lblNegaraPembalap = New Label()
        txtNegaraPembalap = New TextBox()
        lblNomor = New Label()
        txtNomor = New TextBox()
        lblTimPembalap = New Label()
        cbTim = New ComboBox()
        pnlActionPembalap = New Panel()
        btnSimpanPembalap = New Button()
        btnUbahPembalap = New Button()
        btnHapusPembalap = New Button()
        btnBatalPembalap = New Button()
        btnPrintPembalap = New Button()
        pnlGridPembalap = New Panel()
        txtSearchPembalap = New TextBox()
        dgvPembalap = New DataGridView()
        tpTim = New TabPage()
        pnlInputTim = New Panel()
        lblPanelTim = New Label()
        picLogoTim = New PictureBox()
        btnPilihLogo = New Button()
        lblNamaTim = New Label()
        txtNamaTim = New TextBox()
        lblNegaraTim = New Label()
        txtNegaraTim = New TextBox()
        lblMesin = New Label()
        txtMesin = New TextBox()
        lblChasis = New Label()
        txtChasis = New TextBox()
        pnlActionTim = New Panel()
        btnSimpanTim = New Button()
        btnUbahTim = New Button()
        btnHapusTim = New Button()
        btnBatalTim = New Button()
        btnPrintTim = New Button()
        pnlGridTim = New Panel()
        txtSearchTim = New TextBox()
        dgvTim = New DataGridView()
        tpRace = New TabPage()
        pnlInputRace = New Panel()
        lblPanelRace = New Label()
        lblNamaRace = New Label()
        txtNamaRace = New TextBox()
        lblLokasi = New Label()
        txtLokasi = New TextBox()
        lblTanggal = New Label()
        dtpTanggal = New DateTimePicker()
        lblPutaran = New Label()
        txtPutaran = New TextBox()
        pnlActionRace = New Panel()
        btnSimpanRace = New Button()
        btnUbahRace = New Button()
        btnHapusRace = New Button()
        btnBatalRace = New Button()
        btnPrintRace = New Button()
        pnlGridRace = New Panel()
        txtSearchRace = New TextBox()
        dgvRace = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        tabMain.SuspendLayout()
        tpPembalap.SuspendLayout()
        pnlInputPembalap.SuspendLayout()
        pnlActionPembalap.SuspendLayout()
        pnlGridPembalap.SuspendLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).BeginInit()
        tpTim.SuspendLayout()
        pnlInputTim.SuspendLayout()
        CType(picLogoTim, ComponentModel.ISupportInitialize).BeginInit()
        pnlActionTim.SuspendLayout()
        pnlGridTim.SuspendLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).BeginInit()
        tpRace.SuspendLayout()
        pnlInputRace.SuspendLayout()
        pnlActionRace.SuspendLayout()
        pnlGridRace.SuspendLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlHeader.Size = New Size(1024, 48)
        pnlHeader.TabIndex = 0
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 46)
        pnlHeaderAccent.Margin = New Padding(2)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1024, 2)
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(12, 8)
        lblHeaderTitle.Margin = New Padding(2, 0, 2, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(324, 37)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "F1 RACE MANAGEMENT"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.BackColor = Color.Transparent
        lblHeaderSub.Font = New Font("Segoe UI", 8.0F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblHeaderSub.Location = New Point(14, 30)
        lblHeaderSub.Margin = New Padding(2, 0, 2, 0)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(120, 19)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Admin Dashboard"
        ' 
        ' lblAdminBadge
        ' 
        lblAdminBadge.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblAdminBadge.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblAdminBadge.ForeColor = Color.White
        lblAdminBadge.Location = New Point(838, 11)
        lblAdminBadge.Margin = New Padding(2, 0, 2, 0)
        lblAdminBadge.Name = "lblAdminBadge"
        lblAdminBadge.Size = New Size(86, 26)
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
        btnKeluar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(928, 11)
        btnKeluar.Margin = New Padding(2)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(80, 26)
        btnKeluar.TabIndex = 99
        btnKeluar.Text = "KELUAR"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlSidebar.Controls.Add(pnlSidebarTop)
        pnlSidebar.Controls.Add(lblMenuTitle)
        pnlSidebar.Controls.Add(btnNavPembalap)
        pnlSidebar.Controls.Add(btnNavTim)
        pnlSidebar.Controls.Add(btnNavRace)
        pnlSidebar.Controls.Add(pnlSidebarDivider)
        pnlSidebar.Controls.Add(btnNavKlasemen)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 48)
        pnlSidebar.Margin = New Padding(2)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(160, 560)
        pnlSidebar.TabIndex = 1
        ' 
        ' pnlSidebarTop
        ' 
        pnlSidebarTop.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlSidebarTop.Location = New Point(0, 0)
        pnlSidebarTop.Margin = New Padding(2)
        pnlSidebarTop.Name = "pnlSidebarTop"
        pnlSidebarTop.Size = New Size(3, 560)
        pnlSidebarTop.TabIndex = 0
        ' 
        ' lblMenuTitle
        ' 
        lblMenuTitle.AutoSize = True
        lblMenuTitle.BackColor = Color.Transparent
        lblMenuTitle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblMenuTitle.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(135))
        lblMenuTitle.Location = New Point(12, 16)
        lblMenuTitle.Margin = New Padding(2, 0, 2, 0)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New Size(138, 19)
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
        btnNavPembalap.Font = New Font("Segoe UI", 10.0F)
        btnNavPembalap.ForeColor = Color.White
        btnNavPembalap.Location = New Point(0, 38)
        btnNavPembalap.Margin = New Padding(2)
        btnNavPembalap.Name = "btnNavPembalap"
        btnNavPembalap.Size = New Size(160, 35)
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
        btnNavTim.Font = New Font("Segoe UI", 10.0F)
        btnNavTim.ForeColor = Color.White
        btnNavTim.Location = New Point(0, 74)
        btnNavTim.Margin = New Padding(2)
        btnNavTim.Name = "btnNavTim"
        btnNavTim.Size = New Size(160, 35)
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
        btnNavRace.Font = New Font("Segoe UI", 10.0F)
        btnNavRace.ForeColor = Color.White
        btnNavRace.Location = New Point(0, 109)
        btnNavRace.Margin = New Padding(2)
        btnNavRace.Name = "btnNavRace"
        btnNavRace.Size = New Size(160, 35)
        btnNavRace.TabIndex = 3
        btnNavRace.Text = "  📅  Jadwal Race"
        btnNavRace.TextAlign = ContentAlignment.MiddleLeft
        btnNavRace.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarDivider
        ' 
        pnlSidebarDivider.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        pnlSidebarDivider.Location = New Point(12, 154)
        pnlSidebarDivider.Margin = New Padding(2)
        pnlSidebarDivider.Name = "pnlSidebarDivider"
        pnlSidebarDivider.Size = New Size(136, 1)
        pnlSidebarDivider.TabIndex = 4
        ' 
        ' btnNavKlasemen
        ' 
        btnNavKlasemen.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnNavKlasemen.Cursor = Cursors.Hand
        btnNavKlasemen.FlatAppearance.BorderSize = 0
        btnNavKlasemen.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(40), CByte(55))
        btnNavKlasemen.FlatStyle = FlatStyle.Flat
        btnNavKlasemen.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavKlasemen.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnNavKlasemen.Location = New Point(0, 162)
        btnNavKlasemen.Margin = New Padding(2)
        btnNavKlasemen.Name = "btnNavKlasemen"
        btnNavKlasemen.Size = New Size(160, 35)
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
        pnlContent.Location = New Point(160, 48)
        pnlContent.Margin = New Padding(2)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(864, 560)
        pnlContent.TabIndex = 2
        ' 
        ' tabMain
        ' 
        tabMain.Appearance = TabAppearance.FlatButtons
        tabMain.Controls.Add(tpPembalap)
        tabMain.Controls.Add(tpTim)
        tabMain.Controls.Add(tpRace)
        tabMain.Dock = DockStyle.Fill
        tabMain.ItemSize = New Size(130, 36)
        tabMain.Location = New Point(0, 0)
        tabMain.Margin = New Padding(2)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(864, 560)
        tabMain.TabIndex = 0
        ' 
        ' tpPembalap
        ' 
        tpPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpPembalap.Controls.Add(pnlInputPembalap)
        tpPembalap.Controls.Add(pnlGridPembalap)
        tpPembalap.Location = New Point(4, 40)
        tpPembalap.Margin = New Padding(2)
        tpPembalap.Name = "tpPembalap"
        tpPembalap.Size = New Size(856, 516)
        tpPembalap.TabIndex = 0
        tpPembalap.Text = "  Pembalap  "
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
        pnlInputPembalap.Location = New Point(6, 6)
        pnlInputPembalap.Margin = New Padding(2)
        pnlInputPembalap.Name = "pnlInputPembalap"
        pnlInputPembalap.Size = New Size(192, 512)
        pnlInputPembalap.TabIndex = 0
        ' 
        ' lblPanelPembalap
        ' 
        lblPanelPembalap.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelPembalap.Dock = DockStyle.Top
        lblPanelPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPanelPembalap.ForeColor = Color.White
        lblPanelPembalap.Location = New Point(0, 0)
        lblPanelPembalap.Margin = New Padding(2, 0, 2, 0)
        lblPanelPembalap.Name = "lblPanelPembalap"
        lblPanelPembalap.Size = New Size(192, 26)
        lblPanelPembalap.TabIndex = 0
        lblPanelPembalap.Text = "  DATA PEMBALAP"
        lblPanelPembalap.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNamaPembalap
        ' 
        lblNamaPembalap.AutoSize = True
        lblNamaPembalap.Font = New Font("Segoe UI", 8.0F)
        lblNamaPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaPembalap.Location = New Point(10, 40)
        lblNamaPembalap.Margin = New Padding(2, 0, 2, 0)
        lblNamaPembalap.Name = "lblNamaPembalap"
        lblNamaPembalap.Size = New Size(123, 19)
        lblNamaPembalap.TabIndex = 1
        lblNamaPembalap.Text = "NAMA PEMBALAP"
        ' 
        ' txtNamaPembalap
        ' 
        txtNamaPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNamaPembalap.Font = New Font("Segoe UI", 10.0F)
        txtNamaPembalap.ForeColor = Color.White
        txtNamaPembalap.Location = New Point(10, 56)
        txtNamaPembalap.Margin = New Padding(2)
        txtNamaPembalap.Name = "txtNamaPembalap"
        txtNamaPembalap.Size = New Size(172, 30)
        txtNamaPembalap.TabIndex = 1
        ' 
        ' lblNegaraPembalap
        ' 
        lblNegaraPembalap.AutoSize = True
        lblNegaraPembalap.Font = New Font("Segoe UI", 8.0F)
        lblNegaraPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNegaraPembalap.Location = New Point(10, 92)
        lblNegaraPembalap.Margin = New Padding(2, 0, 2, 0)
        lblNegaraPembalap.Name = "lblNegaraPembalap"
        lblNegaraPembalap.Size = New Size(62, 19)
        lblNegaraPembalap.TabIndex = 2
        lblNegaraPembalap.Text = "NEGARA"
        ' 
        ' txtNegaraPembalap
        ' 
        txtNegaraPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNegaraPembalap.BorderStyle = BorderStyle.FixedSingle
        txtNegaraPembalap.Font = New Font("Segoe UI", 10.0F)
        txtNegaraPembalap.ForeColor = Color.White
        txtNegaraPembalap.Location = New Point(10, 108)
        txtNegaraPembalap.Margin = New Padding(2)
        txtNegaraPembalap.Name = "txtNegaraPembalap"
        txtNegaraPembalap.Size = New Size(172, 30)
        txtNegaraPembalap.TabIndex = 2
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.Font = New Font("Segoe UI", 8.0F)
        lblNomor.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNomor.Location = New Point(10, 144)
        lblNomor.Margin = New Padding(2, 0, 2, 0)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(107, 19)
        lblNomor.TabIndex = 3
        lblNomor.Text = "NOMOR BALAP"
        ' 
        ' txtNomor
        ' 
        txtNomor.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNomor.BorderStyle = BorderStyle.FixedSingle
        txtNomor.Font = New Font("Segoe UI", 10.0F)
        txtNomor.ForeColor = Color.White
        txtNomor.Location = New Point(10, 160)
        txtNomor.Margin = New Padding(2)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(172, 30)
        txtNomor.TabIndex = 3
        ' 
        ' lblTimPembalap
        ' 
        lblTimPembalap.AutoSize = True
        lblTimPembalap.Font = New Font("Segoe UI", 8.0F)
        lblTimPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblTimPembalap.Location = New Point(10, 196)
        lblTimPembalap.Margin = New Padding(2, 0, 2, 0)
        lblTimPembalap.Name = "lblTimPembalap"
        lblTimPembalap.Size = New Size(139, 19)
        lblTimPembalap.TabIndex = 4
        lblTimPembalap.Text = "KONSTRUKTOR / TIM"
        ' 
        ' cbTim
        ' 
        cbTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        cbTim.DropDownStyle = ComboBoxStyle.DropDownList
        cbTim.FlatStyle = FlatStyle.Flat
        cbTim.Font = New Font("Segoe UI", 10.0F)
        cbTim.ForeColor = Color.White
        cbTim.FormattingEnabled = True
        cbTim.Location = New Point(10, 212)
        cbTim.Margin = New Padding(2)
        cbTim.Name = "cbTim"
        cbTim.Size = New Size(173, 31)
        cbTim.TabIndex = 4
        ' 
        ' pnlActionPembalap
        ' 
        pnlActionPembalap.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionPembalap.Controls.Add(btnSimpanPembalap)
        pnlActionPembalap.Controls.Add(btnUbahPembalap)
        pnlActionPembalap.Controls.Add(btnHapusPembalap)
        pnlActionPembalap.Controls.Add(btnBatalPembalap)
        pnlActionPembalap.Controls.Add(btnPrintPembalap)
        pnlActionPembalap.Location = New Point(0, 352)
        pnlActionPembalap.Margin = New Padding(2)
        pnlActionPembalap.Name = "pnlActionPembalap"
        pnlActionPembalap.Size = New Size(192, 160)
        pnlActionPembalap.TabIndex = 10
        ' 
        ' btnSimpanPembalap
        ' 
        btnSimpanPembalap.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanPembalap.Cursor = Cursors.Hand
        btnSimpanPembalap.FlatAppearance.BorderSize = 0
        btnSimpanPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanPembalap.FlatStyle = FlatStyle.Flat
        btnSimpanPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpanPembalap.ForeColor = Color.White
        btnSimpanPembalap.Location = New Point(8, 8)
        btnSimpanPembalap.Margin = New Padding(2)
        btnSimpanPembalap.Name = "btnSimpanPembalap"
        btnSimpanPembalap.Size = New Size(80, 27)
        btnSimpanPembalap.TabIndex = 5
        btnSimpanPembalap.Text = "SIMPAN"
        btnSimpanPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnUbahPembalap
        ' 
        btnUbahPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahPembalap.Cursor = Cursors.Hand
        btnUbahPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahPembalap.FlatStyle = FlatStyle.Flat
        btnUbahPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbahPembalap.ForeColor = Color.White
        btnUbahPembalap.Location = New Point(100, 8)
        btnUbahPembalap.Margin = New Padding(2)
        btnUbahPembalap.Name = "btnUbahPembalap"
        btnUbahPembalap.Size = New Size(80, 27)
        btnUbahPembalap.TabIndex = 6
        btnUbahPembalap.Text = "UBAH"
        btnUbahPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnHapusPembalap
        ' 
        btnHapusPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusPembalap.Cursor = Cursors.Hand
        btnHapusPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusPembalap.FlatStyle = FlatStyle.Flat
        btnHapusPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapusPembalap.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusPembalap.Location = New Point(8, 43)
        btnHapusPembalap.Margin = New Padding(2)
        btnHapusPembalap.Name = "btnHapusPembalap"
        btnHapusPembalap.Size = New Size(80, 27)
        btnHapusPembalap.TabIndex = 7
        btnHapusPembalap.Text = "HAPUS"
        btnHapusPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnBatalPembalap
        ' 
        btnBatalPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalPembalap.Cursor = Cursors.Hand
        btnBatalPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalPembalap.FlatStyle = FlatStyle.Flat
        btnBatalPembalap.Font = New Font("Segoe UI", 9.0F)
        btnBatalPembalap.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalPembalap.Location = New Point(100, 43)
        btnBatalPembalap.Margin = New Padding(2)
        btnBatalPembalap.Name = "btnBatalPembalap"
        btnBatalPembalap.Size = New Size(80, 27)
        btnBatalPembalap.TabIndex = 8
        btnBatalPembalap.Text = "BATAL"
        btnBatalPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnPrintPembalap
        ' 
        btnPrintPembalap.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintPembalap.Cursor = Cursors.Hand
        btnPrintPembalap.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintPembalap.FlatStyle = FlatStyle.Flat
        btnPrintPembalap.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnPrintPembalap.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintPembalap.Location = New Point(8, 80)
        btnPrintPembalap.Margin = New Padding(2)
        btnPrintPembalap.Name = "btnPrintPembalap"
        btnPrintPembalap.Size = New Size(172, 27)
        btnPrintPembalap.TabIndex = 9
        btnPrintPembalap.Text = "🖨  PRINT DOKUMEN"
        btnPrintPembalap.UseVisualStyleBackColor = False
        ' 
        ' pnlGridPembalap
        ' 
        pnlGridPembalap.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridPembalap.Controls.Add(txtSearchPembalap)
        pnlGridPembalap.Controls.Add(dgvPembalap)
        pnlGridPembalap.Location = New Point(208, 6)
        pnlGridPembalap.Margin = New Padding(2)
        pnlGridPembalap.Name = "pnlGridPembalap"
        pnlGridPembalap.Size = New Size(643, 512)
        pnlGridPembalap.TabIndex = 1
        ' 
        ' txtSearchPembalap
        ' 
        txtSearchPembalap.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchPembalap.BorderStyle = BorderStyle.FixedSingle
        txtSearchPembalap.Font = New Font("Segoe UI", 10.0F)
        txtSearchPembalap.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchPembalap.Location = New Point(8, 8)
        txtSearchPembalap.Margin = New Padding(2)
        txtSearchPembalap.Name = "txtSearchPembalap"
        txtSearchPembalap.Size = New Size(628, 30)
        txtSearchPembalap.TabIndex = 0
        txtSearchPembalap.Text = "🔍  Cari pembalap..."
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
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvPembalap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvPembalap.ColumnHeadersHeight = 36
        dgvPembalap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.Padding = New Padding(4)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvPembalap.DefaultCellStyle = DataGridViewCellStyle3
        dgvPembalap.EnableHeadersVisualStyles = False
        dgvPembalap.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvPembalap.Location = New Point(8, 40)
        dgvPembalap.Margin = New Padding(2)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.RowHeadersVisible = False
        dgvPembalap.RowHeadersWidth = 51
        dgvPembalap.RowTemplate.Height = 32
        dgvPembalap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPembalap.Size = New Size(627, 464)
        dgvPembalap.TabIndex = 1
        ' 
        ' tpTim
        ' 
        tpTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpTim.Controls.Add(pnlInputTim)
        tpTim.Controls.Add(pnlGridTim)
        tpTim.Location = New Point(4, 40)
        tpTim.Margin = New Padding(2)
        tpTim.Name = "tpTim"
        tpTim.Size = New Size(856, 516)
        tpTim.TabIndex = 1
        tpTim.Text = "  Konstruktor  "
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
        pnlInputTim.Location = New Point(6, 6)
        pnlInputTim.Margin = New Padding(2)
        pnlInputTim.Name = "pnlInputTim"
        pnlInputTim.Size = New Size(192, 512)
        pnlInputTim.TabIndex = 0
        ' 
        ' lblPanelTim
        ' 
        lblPanelTim.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelTim.Dock = DockStyle.Top
        lblPanelTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPanelTim.ForeColor = Color.White
        lblPanelTim.Location = New Point(0, 0)
        lblPanelTim.Margin = New Padding(2, 0, 2, 0)
        lblPanelTim.Name = "lblPanelTim"
        lblPanelTim.Size = New Size(192, 26)
        lblPanelTim.TabIndex = 0
        lblPanelTim.Text = "  DATA KONSTRUKTOR"
        lblPanelTim.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' picLogoTim
        ' 
        picLogoTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        picLogoTim.BorderStyle = BorderStyle.FixedSingle
        picLogoTim.Location = New Point(44, 34)
        picLogoTim.Margin = New Padding(2)
        picLogoTim.Name = "picLogoTim"
        picLogoTim.Size = New Size(104, 64)
        picLogoTim.SizeMode = PictureBoxSizeMode.Zoom
        picLogoTim.TabIndex = 0
        picLogoTim.TabStop = False
        ' 
        ' btnPilihLogo
        ' 
        btnPilihLogo.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnPilihLogo.Cursor = Cursors.Hand
        btnPilihLogo.FlatAppearance.BorderSize = 0
        btnPilihLogo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPilihLogo.FlatStyle = FlatStyle.Flat
        btnPilihLogo.Font = New Font("Segoe UI", 8.0F)
        btnPilihLogo.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnPilihLogo.Location = New Point(44, 102)
        btnPilihLogo.Margin = New Padding(2)
        btnPilihLogo.Name = "btnPilihLogo"
        btnPilihLogo.Size = New Size(104, 19)
        btnPilihLogo.TabIndex = 1
        btnPilihLogo.Text = "Pilih Logo..."
        btnPilihLogo.UseVisualStyleBackColor = False
        ' 
        ' lblNamaTim
        ' 
        lblNamaTim.AutoSize = True
        lblNamaTim.Font = New Font("Segoe UI", 8.0F)
        lblNamaTim.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaTim.Location = New Point(10, 132)
        lblNamaTim.Margin = New Padding(2, 0, 2, 0)
        lblNamaTim.Name = "lblNamaTim"
        lblNamaTim.Size = New Size(78, 19)
        lblNamaTim.TabIndex = 2
        lblNamaTim.Text = "NAMA TIM"
        ' 
        ' txtNamaTim
        ' 
        txtNamaTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaTim.BorderStyle = BorderStyle.FixedSingle
        txtNamaTim.Font = New Font("Segoe UI", 10.0F)
        txtNamaTim.ForeColor = Color.White
        txtNamaTim.Location = New Point(10, 146)
        txtNamaTim.Margin = New Padding(2)
        txtNamaTim.Name = "txtNamaTim"
        txtNamaTim.Size = New Size(172, 30)
        txtNamaTim.TabIndex = 2
        ' 
        ' lblNegaraTim
        ' 
        lblNegaraTim.AutoSize = True
        lblNegaraTim.Font = New Font("Segoe UI", 8.0F)
        lblNegaraTim.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNegaraTim.Location = New Point(10, 181)
        lblNegaraTim.Margin = New Padding(2, 0, 2, 0)
        lblNegaraTim.Name = "lblNegaraTim"
        lblNegaraTim.Size = New Size(62, 19)
        lblNegaraTim.TabIndex = 3
        lblNegaraTim.Text = "NEGARA"
        ' 
        ' txtNegaraTim
        ' 
        txtNegaraTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNegaraTim.BorderStyle = BorderStyle.FixedSingle
        txtNegaraTim.Font = New Font("Segoe UI", 10.0F)
        txtNegaraTim.ForeColor = Color.White
        txtNegaraTim.Location = New Point(10, 195)
        txtNegaraTim.Margin = New Padding(2)
        txtNegaraTim.Name = "txtNegaraTim"
        txtNegaraTim.Size = New Size(172, 30)
        txtNegaraTim.TabIndex = 3
        ' 
        ' lblMesin
        ' 
        lblMesin.AutoSize = True
        lblMesin.Font = New Font("Segoe UI", 8.0F)
        lblMesin.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblMesin.Location = New Point(10, 230)
        lblMesin.Margin = New Padding(2, 0, 2, 0)
        lblMesin.Name = "lblMesin"
        lblMesin.Size = New Size(50, 19)
        lblMesin.TabIndex = 4
        lblMesin.Text = "MESIN"
        ' 
        ' txtMesin
        ' 
        txtMesin.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtMesin.BorderStyle = BorderStyle.FixedSingle
        txtMesin.Font = New Font("Segoe UI", 10.0F)
        txtMesin.ForeColor = Color.White
        txtMesin.Location = New Point(10, 245)
        txtMesin.Margin = New Padding(2)
        txtMesin.Name = "txtMesin"
        txtMesin.Size = New Size(172, 30)
        txtMesin.TabIndex = 4
        ' 
        ' lblChasis
        ' 
        lblChasis.AutoSize = True
        lblChasis.Font = New Font("Segoe UI", 8.0F)
        lblChasis.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblChasis.Location = New Point(10, 280)
        lblChasis.Margin = New Padding(2, 0, 2, 0)
        lblChasis.Name = "lblChasis"
        lblChasis.Size = New Size(55, 19)
        lblChasis.TabIndex = 5
        lblChasis.Text = "CHASIS"
        ' 
        ' txtChasis
        ' 
        txtChasis.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtChasis.BorderStyle = BorderStyle.FixedSingle
        txtChasis.Font = New Font("Segoe UI", 10.0F)
        txtChasis.ForeColor = Color.White
        txtChasis.Location = New Point(10, 294)
        txtChasis.Margin = New Padding(2)
        txtChasis.Name = "txtChasis"
        txtChasis.Size = New Size(172, 30)
        txtChasis.TabIndex = 5
        ' 
        ' pnlActionTim
        ' 
        pnlActionTim.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionTim.Controls.Add(btnSimpanTim)
        pnlActionTim.Controls.Add(btnUbahTim)
        pnlActionTim.Controls.Add(btnHapusTim)
        pnlActionTim.Controls.Add(btnBatalTim)
        pnlActionTim.Controls.Add(btnPrintTim)
        pnlActionTim.Location = New Point(0, 352)
        pnlActionTim.Margin = New Padding(2)
        pnlActionTim.Name = "pnlActionTim"
        pnlActionTim.Size = New Size(192, 160)
        pnlActionTim.TabIndex = 10
        ' 
        ' btnSimpanTim
        ' 
        btnSimpanTim.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanTim.Cursor = Cursors.Hand
        btnSimpanTim.FlatAppearance.BorderSize = 0
        btnSimpanTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanTim.FlatStyle = FlatStyle.Flat
        btnSimpanTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpanTim.ForeColor = Color.White
        btnSimpanTim.Location = New Point(8, 8)
        btnSimpanTim.Margin = New Padding(2)
        btnSimpanTim.Name = "btnSimpanTim"
        btnSimpanTim.Size = New Size(80, 27)
        btnSimpanTim.TabIndex = 6
        btnSimpanTim.Text = "SIMPAN"
        btnSimpanTim.UseVisualStyleBackColor = False
        ' 
        ' btnUbahTim
        ' 
        btnUbahTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahTim.Cursor = Cursors.Hand
        btnUbahTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahTim.FlatStyle = FlatStyle.Flat
        btnUbahTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbahTim.ForeColor = Color.White
        btnUbahTim.Location = New Point(100, 8)
        btnUbahTim.Margin = New Padding(2)
        btnUbahTim.Name = "btnUbahTim"
        btnUbahTim.Size = New Size(80, 27)
        btnUbahTim.TabIndex = 7
        btnUbahTim.Text = "UBAH"
        btnUbahTim.UseVisualStyleBackColor = False
        ' 
        ' btnHapusTim
        ' 
        btnHapusTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusTim.Cursor = Cursors.Hand
        btnHapusTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusTim.FlatStyle = FlatStyle.Flat
        btnHapusTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapusTim.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusTim.Location = New Point(8, 43)
        btnHapusTim.Margin = New Padding(2)
        btnHapusTim.Name = "btnHapusTim"
        btnHapusTim.Size = New Size(80, 27)
        btnHapusTim.TabIndex = 8
        btnHapusTim.Text = "HAPUS"
        btnHapusTim.UseVisualStyleBackColor = False
        ' 
        ' btnBatalTim
        ' 
        btnBatalTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalTim.Cursor = Cursors.Hand
        btnBatalTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalTim.FlatStyle = FlatStyle.Flat
        btnBatalTim.Font = New Font("Segoe UI", 9.0F)
        btnBatalTim.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalTim.Location = New Point(100, 43)
        btnBatalTim.Margin = New Padding(2)
        btnBatalTim.Name = "btnBatalTim"
        btnBatalTim.Size = New Size(80, 27)
        btnBatalTim.TabIndex = 9
        btnBatalTim.Text = "BATAL"
        btnBatalTim.UseVisualStyleBackColor = False
        ' 
        ' btnPrintTim
        ' 
        btnPrintTim.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintTim.Cursor = Cursors.Hand
        btnPrintTim.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintTim.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintTim.FlatStyle = FlatStyle.Flat
        btnPrintTim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnPrintTim.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintTim.Location = New Point(8, 80)
        btnPrintTim.Margin = New Padding(2)
        btnPrintTim.Name = "btnPrintTim"
        btnPrintTim.Size = New Size(172, 27)
        btnPrintTim.TabIndex = 10
        btnPrintTim.Text = "🖨  PRINT DOKUMEN"
        btnPrintTim.UseVisualStyleBackColor = False
        ' 
        ' pnlGridTim
        ' 
        pnlGridTim.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridTim.Controls.Add(txtSearchTim)
        pnlGridTim.Controls.Add(dgvTim)
        pnlGridTim.Location = New Point(208, 6)
        pnlGridTim.Margin = New Padding(2)
        pnlGridTim.Name = "pnlGridTim"
        pnlGridTim.Size = New Size(643, 512)
        pnlGridTim.TabIndex = 1
        ' 
        ' txtSearchTim
        ' 
        txtSearchTim.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchTim.BorderStyle = BorderStyle.FixedSingle
        txtSearchTim.Font = New Font("Segoe UI", 10.0F)
        txtSearchTim.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchTim.Location = New Point(8, 8)
        txtSearchTim.Margin = New Padding(2)
        txtSearchTim.Name = "txtSearchTim"
        txtSearchTim.Size = New Size(628, 30)
        txtSearchTim.TabIndex = 0
        txtSearchTim.Text = "🔍  Cari tim konstruktor..."
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
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvTim.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvTim.ColumnHeadersHeight = 36
        dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.Padding = New Padding(4)
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvTim.DefaultCellStyle = DataGridViewCellStyle6
        dgvTim.EnableHeadersVisualStyles = False
        dgvTim.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvTim.Location = New Point(8, 40)
        dgvTim.Margin = New Padding(2)
        dgvTim.Name = "dgvTim"
        dgvTim.RowHeadersVisible = False
        dgvTim.RowHeadersWidth = 51
        dgvTim.RowTemplate.Height = 32
        dgvTim.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTim.Size = New Size(627, 464)
        dgvTim.TabIndex = 1
        ' 
        ' tpRace
        ' 
        tpRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        tpRace.Controls.Add(pnlInputRace)
        tpRace.Controls.Add(pnlGridRace)
        tpRace.Location = New Point(4, 40)
        tpRace.Margin = New Padding(2)
        tpRace.Name = "tpRace"
        tpRace.Size = New Size(856, 516)
        tpRace.TabIndex = 2
        tpRace.Text = "  Jadwal Race  "
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
        pnlInputRace.Location = New Point(6, 6)
        pnlInputRace.Margin = New Padding(2)
        pnlInputRace.Name = "pnlInputRace"
        pnlInputRace.Size = New Size(192, 512)
        pnlInputRace.TabIndex = 0
        ' 
        ' lblPanelRace
        ' 
        lblPanelRace.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblPanelRace.Dock = DockStyle.Top
        lblPanelRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPanelRace.ForeColor = Color.White
        lblPanelRace.Location = New Point(0, 0)
        lblPanelRace.Margin = New Padding(2, 0, 2, 0)
        lblPanelRace.Name = "lblPanelRace"
        lblPanelRace.Size = New Size(192, 26)
        lblPanelRace.TabIndex = 0
        lblPanelRace.Text = "  DATA RACE"
        lblPanelRace.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNamaRace
        ' 
        lblNamaRace.AutoSize = True
        lblNamaRace.Font = New Font("Segoe UI", 8.0F)
        lblNamaRace.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblNamaRace.Location = New Point(10, 40)
        lblNamaRace.Margin = New Padding(2, 0, 2, 0)
        lblNamaRace.Name = "lblNamaRace"
        lblNamaRace.Size = New Size(133, 19)
        lblNamaRace.TabIndex = 1
        lblNamaRace.Text = "NAMA GRAND PRIX"
        ' 
        ' txtNamaRace
        ' 
        txtNamaRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtNamaRace.BorderStyle = BorderStyle.FixedSingle
        txtNamaRace.Font = New Font("Segoe UI", 10.0F)
        txtNamaRace.ForeColor = Color.White
        txtNamaRace.Location = New Point(10, 54)
        txtNamaRace.Margin = New Padding(2)
        txtNamaRace.Name = "txtNamaRace"
        txtNamaRace.Size = New Size(172, 30)
        txtNamaRace.TabIndex = 1
        ' 
        ' lblLokasi
        ' 
        lblLokasi.AutoSize = True
        lblLokasi.Font = New Font("Segoe UI", 8.0F)
        lblLokasi.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblLokasi.Location = New Point(10, 91)
        lblLokasi.Margin = New Padding(2, 0, 2, 0)
        lblLokasi.Name = "lblLokasi"
        lblLokasi.Size = New Size(116, 19)
        lblLokasi.TabIndex = 2
        lblLokasi.Text = "SIRKUIT / LOKASI"
        ' 
        ' txtLokasi
        ' 
        txtLokasi.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtLokasi.BorderStyle = BorderStyle.FixedSingle
        txtLokasi.Font = New Font("Segoe UI", 10.0F)
        txtLokasi.ForeColor = Color.White
        txtLokasi.Location = New Point(10, 106)
        txtLokasi.Margin = New Padding(2)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(172, 30)
        txtLokasi.TabIndex = 2
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 8.0F)
        lblTanggal.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblTanggal.Location = New Point(10, 142)
        lblTanggal.Margin = New Padding(2, 0, 2, 0)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(70, 19)
        lblTanggal.TabIndex = 3
        lblTanggal.Text = "TANGGAL"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        dtpTanggal.CalendarForeColor = Color.White
        dtpTanggal.CalendarMonthBackground = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dtpTanggal.CalendarTitleBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        dtpTanggal.CalendarTitleForeColor = Color.White
        dtpTanggal.Font = New Font("Segoe UI", 10.0F)
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(10, 157)
        dtpTanggal.Margin = New Padding(2)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(173, 30)
        dtpTanggal.TabIndex = 3
        ' 
        ' lblPutaran
        ' 
        lblPutaran.AutoSize = True
        lblPutaran.Font = New Font("Segoe UI", 8.0F)
        lblPutaran.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblPutaran.Location = New Point(10, 194)
        lblPutaran.Margin = New Padding(2, 0, 2, 0)
        lblPutaran.Name = "lblPutaran"
        lblPutaran.Size = New Size(130, 19)
        lblPutaran.TabIndex = 4
        lblPutaran.Text = "PUTARAN (ROUND)"
        ' 
        ' txtPutaran
        ' 
        txtPutaran.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtPutaran.BorderStyle = BorderStyle.FixedSingle
        txtPutaran.Font = New Font("Segoe UI", 10.0F)
        txtPutaran.ForeColor = Color.White
        txtPutaran.Location = New Point(10, 208)
        txtPutaran.Margin = New Padding(2)
        txtPutaran.Name = "txtPutaran"
        txtPutaran.Size = New Size(172, 30)
        txtPutaran.TabIndex = 4
        ' 
        ' pnlActionRace
        ' 
        pnlActionRace.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(35))
        pnlActionRace.Controls.Add(btnSimpanRace)
        pnlActionRace.Controls.Add(btnUbahRace)
        pnlActionRace.Controls.Add(btnHapusRace)
        pnlActionRace.Controls.Add(btnBatalRace)
        pnlActionRace.Controls.Add(btnPrintRace)
        pnlActionRace.Location = New Point(0, 352)
        pnlActionRace.Margin = New Padding(2)
        pnlActionRace.Name = "pnlActionRace"
        pnlActionRace.Size = New Size(192, 160)
        pnlActionRace.TabIndex = 10
        ' 
        ' btnSimpanRace
        ' 
        btnSimpanRace.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnSimpanRace.Cursor = Cursors.Hand
        btnSimpanRace.FlatAppearance.BorderSize = 0
        btnSimpanRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(4), CByte(0))
        btnSimpanRace.FlatStyle = FlatStyle.Flat
        btnSimpanRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpanRace.ForeColor = Color.White
        btnSimpanRace.Location = New Point(8, 8)
        btnSimpanRace.Margin = New Padding(2)
        btnSimpanRace.Name = "btnSimpanRace"
        btnSimpanRace.Size = New Size(80, 27)
        btnSimpanRace.TabIndex = 5
        btnSimpanRace.Text = "SIMPAN"
        btnSimpanRace.UseVisualStyleBackColor = False
        ' 
        ' btnUbahRace
        ' 
        btnUbahRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnUbahRace.Cursor = Cursors.Hand
        btnUbahRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnUbahRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnUbahRace.FlatStyle = FlatStyle.Flat
        btnUbahRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbahRace.ForeColor = Color.White
        btnUbahRace.Location = New Point(100, 8)
        btnUbahRace.Margin = New Padding(2)
        btnUbahRace.Name = "btnUbahRace"
        btnUbahRace.Size = New Size(80, 27)
        btnUbahRace.TabIndex = 6
        btnUbahRace.Text = "UBAH"
        btnUbahRace.UseVisualStyleBackColor = False
        ' 
        ' btnHapusRace
        ' 
        btnHapusRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnHapusRace.Cursor = Cursors.Hand
        btnHapusRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnHapusRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnHapusRace.FlatStyle = FlatStyle.Flat
        btnHapusRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapusRace.ForeColor = Color.FromArgb(CByte(255), CByte(100), CByte(100))
        btnHapusRace.Location = New Point(8, 43)
        btnHapusRace.Margin = New Padding(2)
        btnHapusRace.Name = "btnHapusRace"
        btnHapusRace.Size = New Size(80, 27)
        btnHapusRace.TabIndex = 7
        btnHapusRace.Text = "HAPUS"
        btnHapusRace.UseVisualStyleBackColor = False
        ' 
        ' btnBatalRace
        ' 
        btnBatalRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        btnBatalRace.Cursor = Cursors.Hand
        btnBatalRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(100), CByte(120))
        btnBatalRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(60), CByte(80))
        btnBatalRace.FlatStyle = FlatStyle.Flat
        btnBatalRace.Font = New Font("Segoe UI", 9.0F)
        btnBatalRace.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnBatalRace.Location = New Point(100, 43)
        btnBatalRace.Margin = New Padding(2)
        btnBatalRace.Name = "btnBatalRace"
        btnBatalRace.Size = New Size(80, 27)
        btnBatalRace.TabIndex = 8
        btnBatalRace.Text = "BATAL"
        btnBatalRace.UseVisualStyleBackColor = False
        ' 
        ' btnPrintRace
        ' 
        btnPrintRace.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        btnPrintRace.Cursor = Cursors.Hand
        btnPrintRace.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.FlatStyle = FlatStyle.Flat
        btnPrintRace.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnPrintRace.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnPrintRace.Location = New Point(8, 80)
        btnPrintRace.Margin = New Padding(2)
        btnPrintRace.Name = "btnPrintRace"
        btnPrintRace.Size = New Size(172, 27)
        btnPrintRace.TabIndex = 9
        btnPrintRace.Text = "🖨  PRINT DOKUMEN"
        btnPrintRace.UseVisualStyleBackColor = False
        ' 
        ' pnlGridRace
        ' 
        pnlGridRace.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlGridRace.Controls.Add(txtSearchRace)
        pnlGridRace.Controls.Add(dgvRace)
        pnlGridRace.Location = New Point(208, 6)
        pnlGridRace.Margin = New Padding(2)
        pnlGridRace.Name = "pnlGridRace"
        pnlGridRace.Size = New Size(643, 512)
        pnlGridRace.TabIndex = 1
        ' 
        ' txtSearchRace
        ' 
        txtSearchRace.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        txtSearchRace.BorderStyle = BorderStyle.FixedSingle
        txtSearchRace.Font = New Font("Segoe UI", 10.0F)
        txtSearchRace.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        txtSearchRace.Location = New Point(8, 8)
        txtSearchRace.Margin = New Padding(2)
        txtSearchRace.Name = "txtSearchRace"
        txtSearchRace.Size = New Size(628, 30)
        txtSearchRace.TabIndex = 0
        txtSearchRace.Text = "🔍  Cari jadwal race..."
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
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvRace.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvRace.ColumnHeadersHeight = 36
        dgvRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle9.ForeColor = Color.White
        DataGridViewCellStyle9.Padding = New Padding(4)
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle9.SelectionForeColor = Color.White
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvRace.DefaultCellStyle = DataGridViewCellStyle9
        dgvRace.EnableHeadersVisualStyles = False
        dgvRace.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        dgvRace.Location = New Point(8, 40)
        dgvRace.Margin = New Padding(2)
        dgvRace.Name = "dgvRace"
        dgvRace.RowHeadersVisible = False
        dgvRace.RowHeadersWidth = 51
        dgvRace.RowTemplate.Height = 32
        dgvRace.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRace.Size = New Size(627, 464)
        dgvRace.TabIndex = 1
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        ClientSize = New Size(1024, 608)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        Margin = New Padding(2)
        MinimumSize = New Size(884, 529)
        Name = "DashboardAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Admin Dashboard"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        tabMain.ResumeLayout(False)
        tpPembalap.ResumeLayout(False)
        pnlInputPembalap.ResumeLayout(False)
        pnlInputPembalap.PerformLayout()
        pnlActionPembalap.ResumeLayout(False)
        pnlGridPembalap.ResumeLayout(False)
        pnlGridPembalap.PerformLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).EndInit()
        tpTim.ResumeLayout(False)
        pnlInputTim.ResumeLayout(False)
        pnlInputTim.PerformLayout()
        CType(picLogoTim, ComponentModel.ISupportInitialize).EndInit()
        pnlActionTim.ResumeLayout(False)
        pnlGridTim.ResumeLayout(False)
        pnlGridTim.PerformLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).EndInit()
        tpRace.ResumeLayout(False)
        pnlInputRace.ResumeLayout(False)
        pnlInputRace.PerformLayout()
        pnlActionRace.ResumeLayout(False)
        pnlGridRace.ResumeLayout(False)
        pnlGridRace.PerformLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class