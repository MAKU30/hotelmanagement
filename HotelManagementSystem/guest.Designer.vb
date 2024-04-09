<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(guest))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.dgvGuest = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.txtSearchGuest = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnSearch = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.tmrUpdateDB = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGuest
        '
        Me.dgvGuest.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvGuest.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGuest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGuest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvGuest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGuest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGuest.ColumnHeadersHeight = 40
        Me.dgvGuest.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvGuest.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvGuest.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvGuest.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvGuest.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvGuest.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgvGuest.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvGuest.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.dgvGuest.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dgvGuest.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvGuest.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgvGuest.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvGuest.CurrentTheme.Name = Nothing
        Me.dgvGuest.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvGuest.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvGuest.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvGuest.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvGuest.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGuest.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGuest.EnableHeadersVisualStyles = False
        Me.dgvGuest.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvGuest.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvGuest.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgvGuest.HeaderForeColor = System.Drawing.Color.White
        Me.dgvGuest.Location = New System.Drawing.Point(12, 120)
        Me.dgvGuest.Name = "dgvGuest"
        Me.dgvGuest.RowHeadersVisible = False
        Me.dgvGuest.RowTemplate.Height = 40
        Me.dgvGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGuest.Size = New System.Drawing.Size(1194, 632)
        Me.dgvGuest.TabIndex = 0
        Me.dgvGuest.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'txtSearchGuest
        '
        Me.txtSearchGuest.AcceptsReturn = False
        Me.txtSearchGuest.AcceptsTab = False
        Me.txtSearchGuest.AnimationSpeed = 200
        Me.txtSearchGuest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtSearchGuest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtSearchGuest.BackColor = System.Drawing.Color.Transparent
        Me.txtSearchGuest.BackgroundImage = CType(resources.GetObject("txtSearchGuest.BackgroundImage"), System.Drawing.Image)
        Me.txtSearchGuest.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtSearchGuest.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtSearchGuest.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchGuest.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtSearchGuest.BorderRadius = 1
        Me.txtSearchGuest.BorderThickness = 1
        Me.txtSearchGuest.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearchGuest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchGuest.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtSearchGuest.DefaultText = ""
        Me.txtSearchGuest.FillColor = System.Drawing.Color.White
        Me.txtSearchGuest.HideSelection = True
        Me.txtSearchGuest.IconLeft = Nothing
        Me.txtSearchGuest.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchGuest.IconPadding = 10
        Me.txtSearchGuest.IconRight = Nothing
        Me.txtSearchGuest.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchGuest.Lines = New String(-1) {}
        Me.txtSearchGuest.Location = New System.Drawing.Point(145, 62)
        Me.txtSearchGuest.MaxLength = 32767
        Me.txtSearchGuest.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtSearchGuest.Modified = False
        Me.txtSearchGuest.Multiline = False
        Me.txtSearchGuest.Name = "txtSearchGuest"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearchGuest.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchGuest.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearchGuest.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearchGuest.OnIdleState = StateProperties4
        Me.txtSearchGuest.Padding = New System.Windows.Forms.Padding(3)
        Me.txtSearchGuest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchGuest.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSearchGuest.PlaceholderText = "Enter text"
        Me.txtSearchGuest.ReadOnly = False
        Me.txtSearchGuest.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchGuest.SelectedText = ""
        Me.txtSearchGuest.SelectionLength = 0
        Me.txtSearchGuest.SelectionStart = 0
        Me.txtSearchGuest.ShortcutsEnabled = True
        Me.txtSearchGuest.Size = New System.Drawing.Size(260, 37)
        Me.txtSearchGuest.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtSearchGuest.TabIndex = 1
        Me.txtSearchGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearchGuest.TextMarginBottom = 0
        Me.txtSearchGuest.TextMarginLeft = 3
        Me.txtSearchGuest.TextMarginTop = 0
        Me.txtSearchGuest.TextPlaceholder = "Enter text"
        Me.txtSearchGuest.UseSystemPasswordChar = False
        Me.txtSearchGuest.WordWrap = True
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BunifuLabel1.Location = New System.Drawing.Point(24, 62)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(97, 36)
        Me.BunifuLabel1.TabIndex = 2
        Me.BunifuLabel1.Text = "Search : "
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
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
        Me.btnSearch.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnSearch.Location = New System.Drawing.Point(431, 62)
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
        Me.btnSearch.Size = New System.Drawing.Size(150, 36)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSearch.TextMarginLeft = 0
        Me.btnSearch.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnSearch.UseDefaultRadiusAndThickness = True
        '
        'tmrUpdateDB
        '
        Me.tmrUpdateDB.Enabled = True
        Me.tmrUpdateDB.Interval = 5000
        '
        'guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1218, 764)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.txtSearchGuest)
        Me.Controls.Add(Me.dgvGuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "guest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "guest"
        CType(Me.dgvGuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGuest As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents txtSearchGuest As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnSearch As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents tmrUpdateDB As Timer
End Class
