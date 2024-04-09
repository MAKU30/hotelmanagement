<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkOut
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkOut))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.dgvCheckOut = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.btnSearch = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtSearchCheckOut = New Bunifu.UI.WinForms.BunifuTextBox()
        CType(Me.dgvCheckOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCheckOut
        '
        Me.dgvCheckOut.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvCheckOut.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCheckOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCheckOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCheckOut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCheckOut.ColumnHeadersHeight = 40
        Me.dgvCheckOut.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCheckOut.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvCheckOut.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvCheckOut.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCheckOut.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvCheckOut.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgvCheckOut.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCheckOut.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.dgvCheckOut.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dgvCheckOut.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCheckOut.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgvCheckOut.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCheckOut.CurrentTheme.Name = Nothing
        Me.dgvCheckOut.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCheckOut.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvCheckOut.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvCheckOut.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCheckOut.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCheckOut.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCheckOut.EnableHeadersVisualStyles = False
        Me.dgvCheckOut.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCheckOut.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvCheckOut.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgvCheckOut.HeaderForeColor = System.Drawing.Color.White
        Me.dgvCheckOut.Location = New System.Drawing.Point(12, 89)
        Me.dgvCheckOut.Name = "dgvCheckOut"
        Me.dgvCheckOut.RowHeadersVisible = False
        Me.dgvCheckOut.RowTemplate.Height = 40
        Me.dgvCheckOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCheckOut.Size = New System.Drawing.Size(1194, 663)
        Me.dgvCheckOut.TabIndex = 0
        Me.dgvCheckOut.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
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
        Me.btnSearch.Location = New System.Drawing.Point(420, 32)
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
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSearch.TextMarginLeft = 0
        Me.btnSearch.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnSearch.UseDefaultRadiusAndThickness = True
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BunifuLabel1.Location = New System.Drawing.Point(13, 32)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(97, 36)
        Me.BunifuLabel1.TabIndex = 5
        Me.BunifuLabel1.Text = "Search : "
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtSearchCheckOut
        '
        Me.txtSearchCheckOut.AcceptsReturn = False
        Me.txtSearchCheckOut.AcceptsTab = False
        Me.txtSearchCheckOut.AnimationSpeed = 200
        Me.txtSearchCheckOut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtSearchCheckOut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtSearchCheckOut.BackColor = System.Drawing.Color.Transparent
        Me.txtSearchCheckOut.BackgroundImage = CType(resources.GetObject("txtSearchCheckOut.BackgroundImage"), System.Drawing.Image)
        Me.txtSearchCheckOut.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtSearchCheckOut.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtSearchCheckOut.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchCheckOut.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtSearchCheckOut.BorderRadius = 1
        Me.txtSearchCheckOut.BorderThickness = 1
        Me.txtSearchCheckOut.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearchCheckOut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchCheckOut.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtSearchCheckOut.DefaultText = ""
        Me.txtSearchCheckOut.FillColor = System.Drawing.Color.White
        Me.txtSearchCheckOut.HideSelection = True
        Me.txtSearchCheckOut.IconLeft = Nothing
        Me.txtSearchCheckOut.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchCheckOut.IconPadding = 10
        Me.txtSearchCheckOut.IconRight = Nothing
        Me.txtSearchCheckOut.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchCheckOut.Lines = New String(-1) {}
        Me.txtSearchCheckOut.Location = New System.Drawing.Point(134, 32)
        Me.txtSearchCheckOut.MaxLength = 32767
        Me.txtSearchCheckOut.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtSearchCheckOut.Modified = False
        Me.txtSearchCheckOut.Multiline = False
        Me.txtSearchCheckOut.Name = "txtSearchCheckOut"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearchCheckOut.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchCheckOut.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearchCheckOut.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtSearchCheckOut.OnIdleState = StateProperties4
        Me.txtSearchCheckOut.Padding = New System.Windows.Forms.Padding(3)
        Me.txtSearchCheckOut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchCheckOut.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtSearchCheckOut.PlaceholderText = "Enter text"
        Me.txtSearchCheckOut.ReadOnly = False
        Me.txtSearchCheckOut.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchCheckOut.SelectedText = ""
        Me.txtSearchCheckOut.SelectionLength = 0
        Me.txtSearchCheckOut.SelectionStart = 0
        Me.txtSearchCheckOut.ShortcutsEnabled = True
        Me.txtSearchCheckOut.Size = New System.Drawing.Size(260, 37)
        Me.txtSearchCheckOut.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtSearchCheckOut.TabIndex = 4
        Me.txtSearchCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearchCheckOut.TextMarginBottom = 0
        Me.txtSearchCheckOut.TextMarginLeft = 3
        Me.txtSearchCheckOut.TextMarginTop = 0
        Me.txtSearchCheckOut.TextPlaceholder = "Enter text"
        Me.txtSearchCheckOut.UseSystemPasswordChar = False
        Me.txtSearchCheckOut.WordWrap = True
        '
        'checkOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1218, 764)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.txtSearchCheckOut)
        Me.Controls.Add(Me.dgvCheckOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "checkOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "checkOut"
        CType(Me.dgvCheckOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCheckOut As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents btnSearch As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtSearchCheckOut As Bunifu.UI.WinForms.BunifuTextBox
End Class
