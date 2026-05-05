<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKlasemen
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        pnlHeaderAccent = New Panel()
        lblHeaderTitle = New Label()
        lblSubtitle = New Label()
        lblSeason = New Label()
        btnKembali = New Button()
        btnRefresh = New Button()
        pnlBody = New Panel()
        pnlPembalap = New Panel()
        pnlPembalaHeader = New Panel()
        lblTrophyDriver = New Label()
        lblPembalaTitle = New Label()
        lblPembalaSub = New Label()
        dgvKlasemenPembalap = New DataGridView()
        pnlKonstruktor = New Panel()
        pnlKonstrukHeader = New Panel()
        lblTrophyTeam = New Label()
        lblKonstrukTitle = New Label()
        lblKonstrukSub = New Label()
        dgvKlasemenKonstruktor = New DataGridView()
        pnlFooter = New Panel()
        lblFooterInfo = New Label()
        lblLastUpdate = New Label()
        pnlRedStripe = New Panel()
        Panel1 = New Panel()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlPembalap.SuspendLayout()
        pnlPembalaHeader.SuspendLayout()
        CType(dgvKlasemenPembalap, ComponentModel.ISupportInitialize).BeginInit()
        pnlKonstruktor.SuspendLayout()
        pnlKonstrukHeader.SuspendLayout()
        CType(dgvKlasemenKonstruktor, ComponentModel.ISupportInitialize).BeginInit()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlHeader.Controls.Add(pnlHeaderAccent)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblSeason)
        pnlHeader.Controls.Add(btnKembali)
        pnlHeader.Controls.Add(btnRefresh)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(2)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1024, 64)
        pnlHeader.TabIndex = 0
        ' 
        ' pnlHeaderAccent
        ' 
        pnlHeaderAccent.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlHeaderAccent.Dock = DockStyle.Bottom
        pnlHeaderAccent.Location = New Point(0, 62)
        pnlHeaderAccent.Margin = New Padding(2)
        pnlHeaderAccent.Name = "pnlHeaderAccent"
        pnlHeaderAccent.Size = New Size(1024, 2)
        pnlHeaderAccent.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.BackColor = Color.Transparent
        lblHeaderTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(11, -1)
        lblHeaderTitle.Margin = New Padding(2, 0, 2, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(264, 46)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "  KLASEMEN F1"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.BackColor = Color.Transparent
        lblSubtitle.Font = New Font("Segoe UI", 9.0F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        lblSubtitle.Location = New Point(16, 40)
        lblSubtitle.Margin = New Padding(2, 0, 2, 0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(313, 20)
        lblSubtitle.TabIndex = 2
        lblSubtitle.Text = "Drivers & Constructors Championship Standings"
        ' 
        ' lblSeason
        ' 
        lblSeason.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblSeason.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblSeason.ForeColor = Color.White
        lblSeason.Location = New Point(440, 16)
        lblSeason.Margin = New Padding(2, 0, 2, 0)
        lblSeason.Name = "lblSeason"
        lblSeason.Size = New Size(144, 32)
        lblSeason.TabIndex = 3
        lblSeason.Text = "SEASON 2025"
        lblSeason.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        btnKembali.Cursor = Cursors.Hand
        btnKembali.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(80), CByte(100))
        btnKembali.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 9.0F)
        btnKembali.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(190))
        btnKembali.Location = New Point(932, 16)
        btnKembali.Margin = New Padding(2)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(80, 27)
        btnKembali.TabIndex = 2
        btnKembali.Text = "KEMBALI"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(818, 16)
        btnRefresh.Margin = New Padding(2)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(102, 27)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = " REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        pnlBody.Controls.Add(pnlPembalap)
        pnlBody.Controls.Add(pnlKonstruktor)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 64)
        pnlBody.Margin = New Padding(2)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(8)
        pnlBody.Size = New Size(1024, 496)
        pnlBody.TabIndex = 1
        ' 
        ' pnlPembalap
        ' 
        pnlPembalap.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlPembalap.Controls.Add(pnlPembalaHeader)
        pnlPembalap.Controls.Add(dgvKlasemenPembalap)
        pnlPembalap.Location = New Point(8, 8)
        pnlPembalap.Margin = New Padding(2)
        pnlPembalap.Name = "pnlPembalap"
        pnlPembalap.Size = New Size(496, 456)
        pnlPembalap.TabIndex = 0
        ' 
        ' pnlPembalaHeader
        ' 
        pnlPembalaHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlPembalaHeader.Controls.Add(Panel1)
        pnlPembalaHeader.Controls.Add(lblTrophyDriver)
        pnlPembalaHeader.Controls.Add(lblPembalaTitle)
        pnlPembalaHeader.Controls.Add(lblPembalaSub)
        pnlPembalaHeader.Dock = DockStyle.Top
        pnlPembalaHeader.Location = New Point(0, 0)
        pnlPembalaHeader.Margin = New Padding(2)
        pnlPembalaHeader.Name = "pnlPembalaHeader"
        pnlPembalaHeader.Size = New Size(496, 66)
        pnlPembalaHeader.TabIndex = 0
        ' 
        ' lblTrophyDriver
        ' 
        lblTrophyDriver.AutoSize = True
        lblTrophyDriver.BackColor = Color.Transparent
        lblTrophyDriver.Font = New Font("Segoe UI", 18.0F)
        lblTrophyDriver.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblTrophyDriver.Location = New Point(8, 10)
        lblTrophyDriver.Margin = New Padding(2, 0, 2, 0)
        lblTrophyDriver.Name = "lblTrophyDriver"
        lblTrophyDriver.Size = New Size(59, 41)
        lblTrophyDriver.TabIndex = 0
        lblTrophyDriver.Text = "🏎"
        ' 
        ' lblPembalaTitle
        ' 
        lblPembalaTitle.AutoSize = True
        lblPembalaTitle.BackColor = Color.Transparent
        lblPembalaTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblPembalaTitle.ForeColor = Color.White
        lblPembalaTitle.Location = New Point(72, 2)
        lblPembalaTitle.Margin = New Padding(2, 0, 2, 0)
        lblPembalaTitle.Name = "lblPembalaTitle"
        lblPembalaTitle.Size = New Size(249, 30)
        lblPembalaTitle.TabIndex = 1
        lblPembalaTitle.Text = "KLASEMEN PEMBALAP"
        ' 
        ' lblPembalaSub
        ' 
        lblPembalaSub.AutoSize = True
        lblPembalaSub.BackColor = Color.Transparent
        lblPembalaSub.Font = New Font("Segoe UI", 8.0F)
        lblPembalaSub.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        lblPembalaSub.Location = New Point(72, 32)
        lblPembalaSub.Margin = New Padding(2, 0, 2, 0)
        lblPembalaSub.Name = "lblPembalaSub"
        lblPembalaSub.Size = New Size(144, 19)
        lblPembalaSub.TabIndex = 2
        lblPembalaSub.Text = "Drivers Championship"
        ' 
        ' dgvKlasemenPembalap
        ' 
        dgvKlasemenPembalap.AllowUserToAddRows = False
        dgvKlasemenPembalap.AllowUserToDeleteRows = False
        dgvKlasemenPembalap.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(48))
        dgvKlasemenPembalap.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvKlasemenPembalap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKlasemenPembalap.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvKlasemenPembalap.BorderStyle = BorderStyle.None
        dgvKlasemenPembalap.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvKlasemenPembalap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvKlasemenPembalap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvKlasemenPembalap.ColumnHeadersHeight = 40
        dgvKlasemenPembalap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.Padding = New Padding(6, 0, 6, 0)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvKlasemenPembalap.DefaultCellStyle = DataGridViewCellStyle3
        dgvKlasemenPembalap.EnableHeadersVisualStyles = False
        dgvKlasemenPembalap.GridColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        dgvKlasemenPembalap.Location = New Point(0, 48)
        dgvKlasemenPembalap.Margin = New Padding(2)
        dgvKlasemenPembalap.Name = "dgvKlasemenPembalap"
        dgvKlasemenPembalap.ReadOnly = True
        dgvKlasemenPembalap.RowHeadersVisible = False
        dgvKlasemenPembalap.RowHeadersWidth = 51
        dgvKlasemenPembalap.RowTemplate.Height = 40
        dgvKlasemenPembalap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKlasemenPembalap.Size = New Size(496, 408)
        dgvKlasemenPembalap.TabIndex = 1
        ' 
        ' pnlKonstruktor
        ' 
        pnlKonstruktor.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        pnlKonstruktor.Controls.Add(pnlKonstrukHeader)
        pnlKonstruktor.Controls.Add(dgvKlasemenKonstruktor)
        pnlKonstruktor.Location = New Point(516, 8)
        pnlKonstruktor.Margin = New Padding(2)
        pnlKonstruktor.Name = "pnlKonstruktor"
        pnlKonstruktor.Size = New Size(496, 456)
        pnlKonstruktor.TabIndex = 1
        ' 
        ' pnlKonstrukHeader
        ' 
        pnlKonstrukHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlKonstrukHeader.Controls.Add(pnlRedStripe)
        pnlKonstrukHeader.Controls.Add(lblTrophyTeam)
        pnlKonstrukHeader.Controls.Add(lblKonstrukTitle)
        pnlKonstrukHeader.Controls.Add(lblKonstrukSub)
        pnlKonstrukHeader.Dock = DockStyle.Top
        pnlKonstrukHeader.Location = New Point(0, 0)
        pnlKonstrukHeader.Margin = New Padding(2)
        pnlKonstrukHeader.Name = "pnlKonstrukHeader"
        pnlKonstrukHeader.Size = New Size(496, 66)
        pnlKonstrukHeader.TabIndex = 0
        ' 
        ' lblTrophyTeam
        ' 
        lblTrophyTeam.AutoSize = True
        lblTrophyTeam.BackColor = Color.Transparent
        lblTrophyTeam.Font = New Font("Segoe UI", 18.0F)
        lblTrophyTeam.ForeColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        lblTrophyTeam.Location = New Point(8, 10)
        lblTrophyTeam.Margin = New Padding(2, 0, 2, 0)
        lblTrophyTeam.Name = "lblTrophyTeam"
        lblTrophyTeam.Size = New Size(59, 41)
        lblTrophyTeam.TabIndex = 0
        lblTrophyTeam.Text = "🏁"
        ' 
        ' lblKonstrukTitle
        ' 
        lblKonstrukTitle.AutoSize = True
        lblKonstrukTitle.BackColor = Color.Transparent
        lblKonstrukTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblKonstrukTitle.ForeColor = Color.White
        lblKonstrukTitle.Location = New Point(70, 6)
        lblKonstrukTitle.Margin = New Padding(2, 0, 2, 0)
        lblKonstrukTitle.Name = "lblKonstrukTitle"
        lblKonstrukTitle.Size = New Size(292, 30)
        lblKonstrukTitle.TabIndex = 1
        lblKonstrukTitle.Text = "KLASEMEN KONSTRUKTOR"
        ' 
        ' lblKonstrukSub
        ' 
        lblKonstrukSub.AutoSize = True
        lblKonstrukSub.BackColor = Color.Transparent
        lblKonstrukSub.Font = New Font("Segoe UI", 8.0F)
        lblKonstrukSub.ForeColor = Color.FromArgb(CByte(140), CByte(140), CByte(155))
        lblKonstrukSub.Location = New Point(72, 35)
        lblKonstrukSub.Margin = New Padding(2, 0, 2, 0)
        lblKonstrukSub.Name = "lblKonstrukSub"
        lblKonstrukSub.Size = New Size(180, 19)
        lblKonstrukSub.TabIndex = 2
        lblKonstrukSub.Text = "Constructors Championship"
        ' 
        ' dgvKlasemenKonstruktor
        ' 
        dgvKlasemenKonstruktor.AllowUserToAddRows = False
        dgvKlasemenKonstruktor.AllowUserToDeleteRows = False
        dgvKlasemenKonstruktor.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(48))
        dgvKlasemenKonstruktor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvKlasemenKonstruktor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKlasemenKonstruktor.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        dgvKlasemenKonstruktor.BorderStyle = BorderStyle.None
        dgvKlasemenKonstruktor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvKlasemenKonstruktor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvKlasemenKonstruktor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvKlasemenKonstruktor.ColumnHeadersHeight = 40
        dgvKlasemenKonstruktor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.Padding = New Padding(6, 0, 6, 0)
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(50), CByte(50), CByte(65))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvKlasemenKonstruktor.DefaultCellStyle = DataGridViewCellStyle6
        dgvKlasemenKonstruktor.EnableHeadersVisualStyles = False
        dgvKlasemenKonstruktor.GridColor = Color.FromArgb(CByte(45), CByte(45), CByte(60))
        dgvKlasemenKonstruktor.Location = New Point(0, 48)
        dgvKlasemenKonstruktor.Margin = New Padding(2)
        dgvKlasemenKonstruktor.Name = "dgvKlasemenKonstruktor"
        dgvKlasemenKonstruktor.ReadOnly = True
        dgvKlasemenKonstruktor.RowHeadersVisible = False
        dgvKlasemenKonstruktor.RowHeadersWidth = 51
        dgvKlasemenKonstruktor.RowTemplate.Height = 40
        dgvKlasemenKonstruktor.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKlasemenKonstruktor.Size = New Size(496, 408)
        dgvKlasemenKonstruktor.TabIndex = 1
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(20))
        pnlFooter.Controls.Add(lblFooterInfo)
        pnlFooter.Controls.Add(lblLastUpdate)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 560)
        pnlFooter.Margin = New Padding(2)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(1024, 32)
        pnlFooter.TabIndex = 2
        ' 
        ' lblFooterInfo
        ' 
        lblFooterInfo.BackColor = Color.Transparent
        lblFooterInfo.Font = New Font("Segoe UI", 8.0F)
        lblFooterInfo.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(110))
        lblFooterInfo.Location = New Point(8, 0)
        lblFooterInfo.Margin = New Padding(2, 0, 2, 0)
        lblFooterInfo.Name = "lblFooterInfo"
        lblFooterInfo.Size = New Size(400, 32)
        lblFooterInfo.TabIndex = 0
        lblFooterInfo.Text = "Sistem Poin: P1=25 | P2=18 | P3=15 | P4=12 | P5=10 | P6=8 | P7=6 | P8=4 | P9=2 | P10=1"
        lblFooterInfo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblLastUpdate
        ' 
        lblLastUpdate.BackColor = Color.Transparent
        lblLastUpdate.Font = New Font("Segoe UI", 8.0F)
        lblLastUpdate.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(110))
        lblLastUpdate.Location = New Point(800, 0)
        lblLastUpdate.Margin = New Padding(2, 0, 2, 0)
        lblLastUpdate.Name = "lblLastUpdate"
        lblLastUpdate.Size = New Size(216, 32)
        lblLastUpdate.TabIndex = 1
        lblLastUpdate.Text = "Data bersifat Read-Only"
        lblLastUpdate.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlRedStripe
        ' 
        pnlRedStripe.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        pnlRedStripe.Location = New Point(-6, 0)
        pnlRedStripe.Margin = New Padding(2)
        pnlRedStripe.Name = "pnlRedStripe"
        pnlRedStripe.Size = New Size(10, 462)
        pnlRedStripe.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(225), CByte(6), CByte(0))
        Panel1.Location = New Point(-6, 2)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(10, 462)
        Panel1.TabIndex = 3
        ' 
        ' FormKlasemen
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(30))
        ClientSize = New Size(1024, 592)
        Controls.Add(pnlBody)
        Controls.Add(pnlFooter)
        Controls.Add(pnlHeader)
        Margin = New Padding(2)
        MinimumSize = New Size(884, 529)
        Name = "FormKlasemen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "F1 Race Management — Klasemen Championship"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlPembalap.ResumeLayout(False)
        pnlPembalaHeader.ResumeLayout(False)
        pnlPembalaHeader.PerformLayout()
        CType(dgvKlasemenPembalap, ComponentModel.ISupportInitialize).EndInit()
        pnlKonstruktor.ResumeLayout(False)
        pnlKonstrukHeader.ResumeLayout(False)
        pnlKonstrukHeader.PerformLayout()
        CType(dgvKlasemenKonstruktor, ComponentModel.ISupportInitialize).EndInit()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlHeaderAccent As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblSeason As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlPembalap As Panel
    Friend WithEvents pnlPembalaHeader As Panel
    Friend WithEvents lblTrophyDriver As Label
    Friend WithEvents lblPembalaTitle As Label
    Friend WithEvents lblPembalaSub As Label
    Friend WithEvents dgvKlasemenPembalap As DataGridView
    Friend WithEvents pnlKonstruktor As Panel
    Friend WithEvents pnlKonstrukHeader As Panel
    Friend WithEvents lblTrophyTeam As Label
    Friend WithEvents lblKonstrukTitle As Label
    Friend WithEvents lblKonstrukSub As Label
    Friend WithEvents dgvKlasemenKonstruktor As DataGridView
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblFooterInfo As Label
    Friend WithEvents lblLastUpdate As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlRedStripe As Panel
End Class