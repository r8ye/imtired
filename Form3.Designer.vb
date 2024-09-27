<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.pnlForm3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCalculator = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGrades = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGradingSystemTitle = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.cbX = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblProgram = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubjects = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGrades = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProgram = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSubj1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSubj2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSubj3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSubj4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtG1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtG2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtG3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtG4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGwa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRemarks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCalc = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblResults = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlForm3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlForm3
        '
        Me.pnlForm3.Controls.Add(Me.btnUser)
        Me.pnlForm3.Controls.Add(Me.btnCalculator)
        Me.pnlForm3.Controls.Add(Me.btnGrades)
        Me.pnlForm3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlForm3.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.pnlForm3.FillColor2 = System.Drawing.Color.Thistle
        Me.pnlForm3.Location = New System.Drawing.Point(0, 511)
        Me.pnlForm3.Name = "pnlForm3"
        Me.pnlForm3.ShadowDecoration.Parent = Me.pnlForm3
        Me.pnlForm3.Size = New System.Drawing.Size(929, 59)
        Me.pnlForm3.TabIndex = 24
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUser.BorderRadius = 10
        Me.btnUser.CheckedState.Parent = Me.btnUser
        Me.btnUser.CustomImages.Parent = Me.btnUser
        Me.btnUser.FillColor = System.Drawing.Color.White
        Me.btnUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUser.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnUser.HoverState.Parent = Me.btnUser
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.Location = New System.Drawing.Point(376, 18)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.ShadowDecoration.Parent = Me.btnUser
        Me.btnUser.Size = New System.Drawing.Size(52, 29)
        Me.btnUser.TabIndex = 2
        '
        'btnCalculator
        '
        Me.btnCalculator.BackColor = System.Drawing.Color.Transparent
        Me.btnCalculator.BorderRadius = 10
        Me.btnCalculator.CheckedState.Parent = Me.btnCalculator
        Me.btnCalculator.CustomImages.Parent = Me.btnCalculator
        Me.btnCalculator.FillColor = System.Drawing.Color.White
        Me.btnCalculator.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCalculator.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnCalculator.HoverState.Parent = Me.btnCalculator
        Me.btnCalculator.Image = CType(resources.GetObject("btnCalculator.Image"), System.Drawing.Image)
        Me.btnCalculator.Location = New System.Drawing.Point(448, 18)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.ShadowDecoration.Parent = Me.btnCalculator
        Me.btnCalculator.Size = New System.Drawing.Size(52, 29)
        Me.btnCalculator.TabIndex = 1
        '
        'btnGrades
        '
        Me.btnGrades.BackColor = System.Drawing.Color.Transparent
        Me.btnGrades.BorderRadius = 10
        Me.btnGrades.CheckedState.Parent = Me.btnGrades
        Me.btnGrades.CustomImages.Parent = Me.btnGrades
        Me.btnGrades.FillColor = System.Drawing.Color.White
        Me.btnGrades.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGrades.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnGrades.HoverState.Parent = Me.btnGrades
        Me.btnGrades.Image = CType(resources.GetObject("btnGrades.Image"), System.Drawing.Image)
        Me.btnGrades.Location = New System.Drawing.Point(519, 18)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.ShadowDecoration.Parent = Me.btnGrades
        Me.btnGrades.Size = New System.Drawing.Size(52, 29)
        Me.btnGrades.TabIndex = 0
        '
        'btnGradingSystemTitle
        '
        Me.btnGradingSystemTitle.BackColor = System.Drawing.Color.Transparent
        Me.btnGradingSystemTitle.BorderRadius = 20
        Me.btnGradingSystemTitle.CheckedState.Parent = Me.btnGradingSystemTitle
        Me.btnGradingSystemTitle.CustomImages.Parent = Me.btnGradingSystemTitle
        Me.btnGradingSystemTitle.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnGradingSystemTitle.FillColor2 = System.Drawing.Color.Thistle
        Me.btnGradingSystemTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGradingSystemTitle.ForeColor = System.Drawing.Color.White
        Me.btnGradingSystemTitle.HoverState.Parent = Me.btnGradingSystemTitle
        Me.btnGradingSystemTitle.Location = New System.Drawing.Point(12, 12)
        Me.btnGradingSystemTitle.Name = "btnGradingSystemTitle"
        Me.btnGradingSystemTitle.ShadowDecoration.Parent = Me.btnGradingSystemTitle
        Me.btnGradingSystemTitle.Size = New System.Drawing.Size(186, 44)
        Me.btnGradingSystemTitle.TabIndex = 25
        Me.btnGradingSystemTitle.Text = "Grading System"
        '
        'cbX
        '
        Me.cbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbX.BackColor = System.Drawing.Color.Transparent
        Me.cbX.FillColor = System.Drawing.Color.Transparent
        Me.cbX.HoverState.Parent = Me.cbX
        Me.cbX.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.cbX.Location = New System.Drawing.Point(902, 0)
        Me.cbX.Name = "cbX"
        Me.cbX.ShadowDecoration.Parent = Me.cbX
        Me.cbX.Size = New System.Drawing.Size(27, 29)
        Me.cbX.TabIndex = 26
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.lblName.Location = New System.Drawing.Point(57, 100)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 23)
        Me.lblName.TabIndex = 27
        Me.lblName.Text = "NAME"
        '
        'lblProgram
        '
        Me.lblProgram.BackColor = System.Drawing.Color.White
        Me.lblProgram.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.lblProgram.Location = New System.Drawing.Point(640, 100)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(82, 23)
        Me.lblProgram.TabIndex = 30
        Me.lblProgram.Text = "PROGRAM"
        '
        'lblSubjects
        '
        Me.lblSubjects.BackColor = System.Drawing.Color.White
        Me.lblSubjects.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjects.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.lblSubjects.Location = New System.Drawing.Point(233, 167)
        Me.lblSubjects.Name = "lblSubjects"
        Me.lblSubjects.Size = New System.Drawing.Size(61, 19)
        Me.lblSubjects.TabIndex = 31
        Me.lblSubjects.Text = "SUBJECTS"
        '
        'lblGrades
        '
        Me.lblGrades.BackColor = System.Drawing.Color.White
        Me.lblGrades.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrades.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.lblGrades.Location = New System.Drawing.Point(570, 167)
        Me.lblGrades.Name = "lblGrades"
        Me.lblGrades.Size = New System.Drawing.Size(52, 19)
        Me.lblGrades.TabIndex = 32
        Me.lblGrades.Text = "GRADES"
        '
        'txtName
        '
        Me.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtName.BorderRadius = 10
        Me.txtName.BorderThickness = 2
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.Parent = Me.txtName
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.FocusedState.Parent = Me.txtName
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.HoverState.Parent = Me.txtName
        Me.txtName.Location = New System.Drawing.Point(115, 95)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtName.PlaceholderText = ""
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.Size = New System.Drawing.Size(433, 34)
        Me.txtName.TabIndex = 37
        '
        'txtProgram
        '
        Me.txtProgram.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtProgram.BorderRadius = 10
        Me.txtProgram.BorderThickness = 2
        Me.txtProgram.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProgram.DefaultText = ""
        Me.txtProgram.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProgram.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProgram.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProgram.DisabledState.Parent = Me.txtProgram
        Me.txtProgram.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProgram.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProgram.FocusedState.Parent = Me.txtProgram
        Me.txtProgram.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgram.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtProgram.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProgram.HoverState.Parent = Me.txtProgram
        Me.txtProgram.Location = New System.Drawing.Point(729, 95)
        Me.txtProgram.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProgram.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtProgram.PlaceholderText = ""
        Me.txtProgram.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProgram.SelectedText = ""
        Me.txtProgram.ShadowDecoration.Parent = Me.txtProgram
        Me.txtProgram.Size = New System.Drawing.Size(142, 34)
        Me.txtProgram.TabIndex = 38
        Me.txtProgram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubj1
        '
        Me.txtSubj1.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtSubj1.BorderRadius = 10
        Me.txtSubj1.BorderThickness = 2
        Me.txtSubj1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubj1.DefaultText = ""
        Me.txtSubj1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubj1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubj1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubj1.DisabledState.Parent = Me.txtSubj1
        Me.txtSubj1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubj1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubj1.FocusedState.Parent = Me.txtSubj1
        Me.txtSubj1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtSubj1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubj1.HoverState.Parent = Me.txtSubj1
        Me.txtSubj1.Location = New System.Drawing.Point(57, 213)
        Me.txtSubj1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubj1.Name = "txtSubj1"
        Me.txtSubj1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubj1.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtSubj1.PlaceholderText = ""
        Me.txtSubj1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubj1.SelectedText = ""
        Me.txtSubj1.ShadowDecoration.Parent = Me.txtSubj1
        Me.txtSubj1.Size = New System.Drawing.Size(408, 34)
        Me.txtSubj1.TabIndex = 39
        Me.txtSubj1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubj2
        '
        Me.txtSubj2.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtSubj2.BorderRadius = 10
        Me.txtSubj2.BorderThickness = 2
        Me.txtSubj2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubj2.DefaultText = ""
        Me.txtSubj2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubj2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubj2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubj2.DisabledState.Parent = Me.txtSubj2
        Me.txtSubj2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubj2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubj2.FocusedState.Parent = Me.txtSubj2
        Me.txtSubj2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtSubj2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubj2.HoverState.Parent = Me.txtSubj2
        Me.txtSubj2.Location = New System.Drawing.Point(57, 266)
        Me.txtSubj2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubj2.Name = "txtSubj2"
        Me.txtSubj2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubj2.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtSubj2.PlaceholderText = ""
        Me.txtSubj2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubj2.SelectedText = ""
        Me.txtSubj2.ShadowDecoration.Parent = Me.txtSubj2
        Me.txtSubj2.Size = New System.Drawing.Size(408, 34)
        Me.txtSubj2.TabIndex = 40
        Me.txtSubj2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubj3
        '
        Me.txtSubj3.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtSubj3.BorderRadius = 10
        Me.txtSubj3.BorderThickness = 2
        Me.txtSubj3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubj3.DefaultText = ""
        Me.txtSubj3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubj3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubj3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubj3.DisabledState.Parent = Me.txtSubj3
        Me.txtSubj3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubj3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubj3.FocusedState.Parent = Me.txtSubj3
        Me.txtSubj3.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtSubj3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubj3.HoverState.Parent = Me.txtSubj3
        Me.txtSubj3.Location = New System.Drawing.Point(57, 322)
        Me.txtSubj3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubj3.Name = "txtSubj3"
        Me.txtSubj3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubj3.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtSubj3.PlaceholderText = ""
        Me.txtSubj3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubj3.SelectedText = ""
        Me.txtSubj3.ShadowDecoration.Parent = Me.txtSubj3
        Me.txtSubj3.Size = New System.Drawing.Size(408, 34)
        Me.txtSubj3.TabIndex = 41
        Me.txtSubj3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubj4
        '
        Me.txtSubj4.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtSubj4.BorderRadius = 10
        Me.txtSubj4.BorderThickness = 2
        Me.txtSubj4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubj4.DefaultText = ""
        Me.txtSubj4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubj4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubj4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubj4.DisabledState.Parent = Me.txtSubj4
        Me.txtSubj4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubj4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubj4.FocusedState.Parent = Me.txtSubj4
        Me.txtSubj4.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtSubj4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubj4.HoverState.Parent = Me.txtSubj4
        Me.txtSubj4.Location = New System.Drawing.Point(57, 379)
        Me.txtSubj4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubj4.Name = "txtSubj4"
        Me.txtSubj4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubj4.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtSubj4.PlaceholderText = ""
        Me.txtSubj4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubj4.SelectedText = ""
        Me.txtSubj4.ShadowDecoration.Parent = Me.txtSubj4
        Me.txtSubj4.Size = New System.Drawing.Size(408, 34)
        Me.txtSubj4.TabIndex = 42
        Me.txtSubj4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtG1
        '
        Me.txtG1.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtG1.BorderRadius = 10
        Me.txtG1.BorderThickness = 2
        Me.txtG1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtG1.DefaultText = ""
        Me.txtG1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtG1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtG1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtG1.DisabledState.Parent = Me.txtG1
        Me.txtG1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtG1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtG1.FocusedState.Parent = Me.txtG1
        Me.txtG1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtG1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtG1.HoverState.Parent = Me.txtG1
        Me.txtG1.Location = New System.Drawing.Point(519, 213)
        Me.txtG1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtG1.Name = "txtG1"
        Me.txtG1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtG1.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtG1.PlaceholderText = ""
        Me.txtG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtG1.SelectedText = ""
        Me.txtG1.ShadowDecoration.Parent = Me.txtG1
        Me.txtG1.Size = New System.Drawing.Size(142, 34)
        Me.txtG1.TabIndex = 43
        Me.txtG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtG2
        '
        Me.txtG2.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtG2.BorderRadius = 10
        Me.txtG2.BorderThickness = 2
        Me.txtG2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtG2.DefaultText = ""
        Me.txtG2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtG2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtG2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtG2.DisabledState.Parent = Me.txtG2
        Me.txtG2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtG2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtG2.FocusedState.Parent = Me.txtG2
        Me.txtG2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtG2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtG2.HoverState.Parent = Me.txtG2
        Me.txtG2.Location = New System.Drawing.Point(519, 266)
        Me.txtG2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtG2.Name = "txtG2"
        Me.txtG2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtG2.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtG2.PlaceholderText = ""
        Me.txtG2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtG2.SelectedText = ""
        Me.txtG2.ShadowDecoration.Parent = Me.txtG2
        Me.txtG2.Size = New System.Drawing.Size(142, 34)
        Me.txtG2.TabIndex = 44
        Me.txtG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtG3
        '
        Me.txtG3.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtG3.BorderRadius = 10
        Me.txtG3.BorderThickness = 2
        Me.txtG3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtG3.DefaultText = ""
        Me.txtG3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtG3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtG3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtG3.DisabledState.Parent = Me.txtG3
        Me.txtG3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtG3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtG3.FocusedState.Parent = Me.txtG3
        Me.txtG3.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtG3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtG3.HoverState.Parent = Me.txtG3
        Me.txtG3.Location = New System.Drawing.Point(519, 322)
        Me.txtG3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtG3.Name = "txtG3"
        Me.txtG3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtG3.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtG3.PlaceholderText = ""
        Me.txtG3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtG3.SelectedText = ""
        Me.txtG3.ShadowDecoration.Parent = Me.txtG3
        Me.txtG3.Size = New System.Drawing.Size(142, 34)
        Me.txtG3.TabIndex = 45
        Me.txtG3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtG4
        '
        Me.txtG4.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtG4.BorderRadius = 10
        Me.txtG4.BorderThickness = 2
        Me.txtG4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtG4.DefaultText = ""
        Me.txtG4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtG4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtG4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtG4.DisabledState.Parent = Me.txtG4
        Me.txtG4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtG4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtG4.FocusedState.Parent = Me.txtG4
        Me.txtG4.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtG4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtG4.HoverState.Parent = Me.txtG4
        Me.txtG4.Location = New System.Drawing.Point(519, 379)
        Me.txtG4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtG4.Name = "txtG4"
        Me.txtG4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtG4.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtG4.PlaceholderText = ""
        Me.txtG4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtG4.SelectedText = ""
        Me.txtG4.ShadowDecoration.Parent = Me.txtG4
        Me.txtG4.Size = New System.Drawing.Size(142, 34)
        Me.txtG4.TabIndex = 46
        Me.txtG4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGwa
        '
        Me.txtGwa.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtGwa.BorderRadius = 10
        Me.txtGwa.BorderThickness = 2
        Me.txtGwa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGwa.DefaultText = ""
        Me.txtGwa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGwa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGwa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGwa.DisabledState.Parent = Me.txtGwa
        Me.txtGwa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGwa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGwa.FocusedState.Parent = Me.txtGwa
        Me.txtGwa.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGwa.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtGwa.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGwa.HoverState.Parent = Me.txtGwa
        Me.txtGwa.Location = New System.Drawing.Point(729, 213)
        Me.txtGwa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGwa.Name = "txtGwa"
        Me.txtGwa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGwa.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtGwa.PlaceholderText = "GWA"
        Me.txtGwa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGwa.SelectedText = ""
        Me.txtGwa.ShadowDecoration.Parent = Me.txtGwa
        Me.txtGwa.Size = New System.Drawing.Size(142, 34)
        Me.txtGwa.TabIndex = 47
        Me.txtGwa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtRemarks.BorderRadius = 10
        Me.txtRemarks.BorderThickness = 2
        Me.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRemarks.DefaultText = ""
        Me.txtRemarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRemarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRemarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRemarks.DisabledState.Parent = Me.txtRemarks
        Me.txtRemarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRemarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRemarks.FocusedState.Parent = Me.txtRemarks
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.txtRemarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRemarks.HoverState.Parent = Me.txtRemarks
        Me.txtRemarks.Location = New System.Drawing.Point(729, 266)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRemarks.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txtRemarks.PlaceholderText = "REMARKS"
        Me.txtRemarks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRemarks.SelectedText = ""
        Me.txtRemarks.ShadowDecoration.Parent = Me.txtRemarks
        Me.txtRemarks.Size = New System.Drawing.Size(142, 34)
        Me.txtRemarks.TabIndex = 48
        Me.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.Transparent
        Me.btnCalc.BorderRadius = 10
        Me.btnCalc.CheckedState.Parent = Me.btnCalc
        Me.btnCalc.CustomImages.Parent = Me.btnCalc
        Me.btnCalc.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnCalc.FillColor2 = System.Drawing.Color.Thistle
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.White
        Me.btnCalc.HoverState.Parent = Me.btnCalc
        Me.btnCalc.Location = New System.Drawing.Point(519, 431)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.ShadowDecoration.BorderRadius = 15
        Me.btnCalc.ShadowDecoration.Color = System.Drawing.Color.Thistle
        Me.btnCalc.ShadowDecoration.Enabled = True
        Me.btnCalc.ShadowDecoration.Parent = Me.btnCalc
        Me.btnCalc.Size = New System.Drawing.Size(142, 34)
        Me.btnCalc.TabIndex = 49
        Me.btnCalc.Text = "CALCULATE"
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.Color.White
        Me.lblResults.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.lblResults.Location = New System.Drawing.Point(765, 167)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(54, 19)
        Me.lblResults.TabIndex = 50
        Me.lblResults.Text = "RESULTS"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(929, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtGwa)
        Me.Controls.Add(Me.txtG4)
        Me.Controls.Add(Me.txtG3)
        Me.Controls.Add(Me.txtG2)
        Me.Controls.Add(Me.txtG1)
        Me.Controls.Add(Me.txtSubj4)
        Me.Controls.Add(Me.txtSubj3)
        Me.Controls.Add(Me.txtSubj2)
        Me.Controls.Add(Me.txtSubj1)
        Me.Controls.Add(Me.txtProgram)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblGrades)
        Me.Controls.Add(Me.lblSubjects)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.cbX)
        Me.Controls.Add(Me.btnGradingSystemTitle)
        Me.Controls.Add(Me.pnlForm3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.pnlForm3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlForm3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCalculator As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGrades As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGradingSystemTitle As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents cbX As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblProgram As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubjects As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGrades As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProgram As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSubj1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSubj2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSubj3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSubj4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtG1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtG2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtG3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtG4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGwa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRemarks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCalc As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblResults As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
