<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rooms
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rooms))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.dgvRooms = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.btnSearch = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.txtSearchRooms = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.tmrUpdateDB = New System.Windows.Forms.Timer(Me.components)
        Me.btnDebug = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRooms
        '
        Me.dgvRooms.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvRooms.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRooms.ColumnHeadersHeight = 40
        Me.dgvRooms.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRooms.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvRooms.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRooms.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRooms.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvRooms.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgvRooms.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRooms.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.dgvRooms.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dgvRooms.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRooms.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgvRooms.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRooms.CurrentTheme.Name = Nothing
        Me.dgvRooms.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRooms.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvRooms.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRooms.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRooms.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRooms.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRooms.EnableHeadersVisualStyles = False
        Me.dgvRooms.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRooms.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvRooms.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgvRooms.HeaderForeColor = System.Drawing.Color.White
        Me.dgvRooms.Location = New System.Drawing.Point(12, 121)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.RowHeadersVisible = False
        Me.dgvRooms.RowTemplate.Height = 40
        Me.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRooms.Size = New System.Drawing.Size(1194, 631)
        Me.dgvRooms.TabIndex = 0
        Me.dgvRooms.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'btnSearch
        '
        Me.btnSearch.AllowAnimations = True
        Me.btnSearch.AllowMouseEffects = True
        Me.btnSearch.AllowToggling = False
        Me.btnSearch.AnimationSpeed = 200
        Me.btnSearch.AutoGenerateColors = False
        Me.btnSearch.AutoRoundBorders = False
        Me.btnSearch.AutoSizeLeftIcon = True
        Me.btnSearch.AutoSizeRightIcon = True
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackColor1 = System.Drawing.Color.Maroon
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnSearch.ButtonText = "Search"
        Me.btnSearch.ButtonTextMarginLeft = 0
        Me.btnSearch.ColorContrastOnClick = 45
        Me.btnSearch.ColorContrastOnHover = 45
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnSearch.CustomizableEdges = BorderEdges1
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSearch.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSearch.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnSearch.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnSearch.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnSearch.IconMarginLeft = 11
        Me.btnSearch.IconPadding = 10
        Me.btnSearch.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnSearch.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnSearch.IconSize = 25
        Me.btnSearch.IdleBorderColor = System.Drawing.Color.Maroon
        Me.btnSearch.IdleBorderRadius = 1
        Me.btnSearch.IdleBorderThickness = 1
        Me.btnSearch.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnSearch.IdleIconLeftImage = Nothing
        Me.btnSearch.IdleIconRightImage = Nothing
        Me.btnSearch.IndicateFocus = False
        Me.btnSearch.Location = New System.Drawing.Point(432, 65)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSearch.OnDisabledState.BorderRadius = 1
        Me.btnSearch.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnSearch.OnDisabledState.BorderThickness = 1
        Me.btnSearch.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSearch.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnSearch.OnDisabledState.IconLeftImage = Nothing
        Me.btnSearch.OnDisabledState.IconRightImage = Nothing
        Me.btnSearch.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.onHoverState.BorderRadius = 1
        Me.btnSearch.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnSearch.onHoverState.BorderThickness = 1
        Me.btnSearch.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnSearch.onHoverState.IconLeftImage = Nothing
        Me.btnSearch.onHoverState.IconRightImage = Nothing
        Me.btnSearch.OnIdleState.BorderColor = System.Drawing.Color.Maroon
        Me.btnSearch.OnIdleState.BorderRadius = 1
        Me.btnSearch.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnSearch.OnIdleState.BorderThickness = 1
        Me.btnSearch.OnIdleState.FillColor = System.Drawing.Color.Maroon
        Me.btnSearch.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnSearch.OnIdleState.IconLeftImage = Nothing
        Me.btnSearch.OnIdleState.IconRightImage = Nothing
        Me.btnSearch.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnSearch.OnPressedState.BorderRadius = 1
        Me.btnSearch.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnSearch.OnPressedState.BorderThickness = 1
        Me.btnSearch.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnSearch.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnSearch.OnPressedState.IconLeftImage = Nothing
        Me.btnSearch.OnPressedState.IconRightImage = Nothing
        Me.btnSearch.Size = New System.Drawing.Size(150, 37)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSearch.TextMarginLeft = 0
        Me.btnSearch.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnSearch.UseDefaultRadiusAndThickness = True
        '
        'txtSearchRooms
        '
        Me.txtSearchRooms.AcceptsReturn = False
        Me.txtSearchRooms.AcceptsTab = False
        Me.txtSearchRooms.AnimationSpeed = 200
        Me.txtSearchRooms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtSearchRooms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtSearchRooms.BackColor = System.Drawing.Color.Transparent
        Me.txtSearchRooms.BackgroundImage = CType(resources.GetObject("txtSearchRooms.BackgroundImage"), System.Drawing.Image)
        Me.txtSearchRooms.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtSearchRooms.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtSearchRooms.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchRooms.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtSearchRooms.BorderRadius = 1
        Me.txtSearchRooms.BorderThickness = 1
        Me.txtSearchRooms.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearchRooms.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchRooms.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtSearchRooms.DefaultText = ""
        Me.txtSearchRooms.FillColor = System.Drawing.Color.White
        Me.txtSearchRooms.HideSelection = True
        Me.txtSearchRooms.IconLeft = Nothing
        Me.txtSearchRooms.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchRooms.IconPadding = 10
        Me.txtSearchRooms.IconRight = Nothing
        Me.txtSearchRooms.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchRooms.Lines = New String(-1) {}
        Me.txtSearchRooms.Location = New System.Drawing.Point(154, 65)
        Me.txtSearchRooms.MaxLength = 32767
        Me.txtSearchRooms.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtSearchRooms.Modified = False
        Me.txtSearchRooms.Multiline = False
        Me.txtSearchRooms.Name = "txtSearchRooms"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearchRooms.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchRooms.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearchRooms.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearchRooms.OnIdleState = StateProperties4
        Me.txtSearchRooms.Padding = New System.Windows.Forms.Padding(3)
        Me.txtSearchRooms.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchRooms.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSearchRooms.PlaceholderText = "Enter text"
        Me.txtSearchRooms.ReadOnly = False
        Me.txtSearchRooms.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchRooms.SelectedText = ""
        Me.txtSearchRooms.SelectionLength = 0
        Me.txtSearchRooms.SelectionStart = 0
        Me.txtSearchRooms.ShortcutsEnabled = True
        Me.txtSearchRooms.Size = New System.Drawing.Size(260, 37)
        Me.txtSearchRooms.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtSearchRooms.TabIndex = 2
        Me.txtSearchRooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearchRooms.TextMarginBottom = 0
        Me.txtSearchRooms.TextMarginLeft = 3
        Me.txtSearchRooms.TextMarginTop = 0
        Me.txtSearchRooms.TextPlaceholder = "Enter text"
        Me.txtSearchRooms.UseSystemPasswordChar = False
        Me.txtSearchRooms.WordWrap = True
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BunifuLabel1.Location = New System.Drawing.Point(34, 65)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(97, 36)
        Me.BunifuLabel1.TabIndex = 3
        Me.BunifuLabel1.Text = "Search : "
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'tmrUpdateDB
        '
        Me.tmrUpdateDB.Enabled = True
        Me.tmrUpdateDB.Interval = 5000
        '
        'btnDebug
        '
        Me.btnDebug.AllowAnimations = True
        Me.btnDebug.AllowMouseEffects = True
        Me.btnDebug.AllowToggling = False
        Me.btnDebug.AnimationSpeed = 200
        Me.btnDebug.AutoGenerateColors = False
        Me.btnDebug.AutoRoundBorders = False
        Me.btnDebug.AutoSizeLeftIcon = True
        Me.btnDebug.AutoSizeRightIcon = True
        Me.btnDebug.BackColor = System.Drawing.Color.Transparent
        Me.btnDebug.BackColor1 = System.Drawing.Color.Maroon
        Me.btnDebug.BackgroundImage = CType(resources.GetObject("btnDebug.BackgroundImage"), System.Drawing.Image)
        Me.btnDebug.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnDebug.ButtonText = "NULL Names"
        Me.btnDebug.ButtonTextMarginLeft = 0
        Me.btnDebug.ColorContrastOnClick = 45
        Me.btnDebug.ColorContrastOnHover = 45
        Me.btnDebug.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnDebug.CustomizableEdges = BorderEdges2
        Me.btnDebug.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDebug.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDebug.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDebug.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnDebug.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnDebug.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnDebug.ForeColor = System.Drawing.Color.White
        Me.btnDebug.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDebug.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnDebug.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnDebug.IconMarginLeft = 11
        Me.btnDebug.IconPadding = 10
        Me.btnDebug.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDebug.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnDebug.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnDebug.IconSize = 25
        Me.btnDebug.IdleBorderColor = System.Drawing.Color.Maroon
        Me.btnDebug.IdleBorderRadius = 1
        Me.btnDebug.IdleBorderThickness = 1
        Me.btnDebug.IdleFillColor = System.Drawing.Color.Maroon
        Me.btnDebug.IdleIconLeftImage = Nothing
        Me.btnDebug.IdleIconRightImage = Nothing
        Me.btnDebug.IndicateFocus = False
        Me.btnDebug.Location = New System.Drawing.Point(1056, 64)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDebug.OnDisabledState.BorderRadius = 1
        Me.btnDebug.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnDebug.OnDisabledState.BorderThickness = 1
        Me.btnDebug.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDebug.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnDebug.OnDisabledState.IconLeftImage = Nothing
        Me.btnDebug.OnDisabledState.IconRightImage = Nothing
        Me.btnDebug.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDebug.onHoverState.BorderRadius = 1
        Me.btnDebug.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnDebug.onHoverState.BorderThickness = 1
        Me.btnDebug.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDebug.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnDebug.onHoverState.IconLeftImage = Nothing
        Me.btnDebug.onHoverState.IconRightImage = Nothing
        Me.btnDebug.OnIdleState.BorderColor = System.Drawing.Color.Maroon
        Me.btnDebug.OnIdleState.BorderRadius = 1
        Me.btnDebug.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnDebug.OnIdleState.BorderThickness = 1
        Me.btnDebug.OnIdleState.FillColor = System.Drawing.Color.Maroon
        Me.btnDebug.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnDebug.OnIdleState.IconLeftImage = Nothing
        Me.btnDebug.OnIdleState.IconRightImage = Nothing
        Me.btnDebug.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnDebug.OnPressedState.BorderRadius = 1
        Me.btnDebug.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnDebug.OnPressedState.BorderThickness = 1
        Me.btnDebug.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnDebug.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnDebug.OnPressedState.IconLeftImage = Nothing
        Me.btnDebug.OnPressedState.IconRightImage = Nothing
        Me.btnDebug.Size = New System.Drawing.Size(150, 37)
        Me.btnDebug.TabIndex = 4
        Me.btnDebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDebug.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDebug.TextMarginLeft = 0
        Me.btnDebug.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnDebug.UseDefaultRadiusAndThickness = True
        '
        'rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1218, 764)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.txtSearchRooms)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvRooms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rooms"
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRooms As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents btnSearch As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents txtSearchRooms As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents tmrUpdateDB As Timer
    Friend WithEvents btnDebug As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
