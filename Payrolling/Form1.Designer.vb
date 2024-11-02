<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayroll
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnPrint = New MaterialSkin.Controls.MaterialButton()
        lblID = New MaterialSkin.Controls.MaterialLabel()
        lblName = New MaterialSkin.Controls.MaterialLabel()
        lblDepartment = New MaterialSkin.Controls.MaterialLabel()
        lblHourlyRate = New MaterialSkin.Controls.MaterialLabel()
        lblStartPeriod = New MaterialSkin.Controls.MaterialLabel()
        lblEndDate = New MaterialSkin.Controls.MaterialLabel()
        lblTotalDue = New MaterialSkin.Controls.MaterialLabel()
        lblTaxDue = New MaterialSkin.Controls.MaterialLabel()
        lblAccountNumber = New MaterialSkin.Controls.MaterialLabel()
        lblBankName = New MaterialSkin.Controls.MaterialLabel()
        btnPay = New MaterialSkin.Controls.MaterialButton()
        IDLabelText = New Label()
        NameLabelText = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton3 = New MaterialSkin.Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPrint.Depth = 0
        btnPrint.HighEmphasis = True
        btnPrint.Icon = Nothing
        btnPrint.Location = New Point(299, 393)
        btnPrint.Margin = New Padding(4, 6, 4, 6)
        btnPrint.MouseState = MaterialSkin.MouseState.HOVER
        btnPrint.Name = "btnPrint"
        btnPrint.NoAccentTextColor = Color.Empty
        btnPrint.Size = New Size(64, 36)
        btnPrint.TabIndex = 0
        btnPrint.Text = "Print"
        btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnPrint.UseAccentColor = False
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Depth = 0
        lblID.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblID.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblID.Location = New Point(16, 84)
        lblID.MouseState = MaterialSkin.MouseState.HOVER
        lblID.Name = "lblID"
        lblID.Size = New Size(20, 24)
        lblID.TabIndex = 1
        lblID.Text = "ID"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Depth = 0
        lblName.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblName.Location = New Point(299, 84)
        lblName.MouseState = MaterialSkin.MouseState.HOVER
        lblName.Name = "lblName"
        lblName.Size = New Size(54, 24)
        lblName.TabIndex = 2
        lblName.Text = "Name"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Depth = 0
        lblDepartment.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblDepartment.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblDepartment.Location = New Point(16, 131)
        lblDepartment.MouseState = MaterialSkin.MouseState.HOVER
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(107, 24)
        lblDepartment.TabIndex = 3
        lblDepartment.Text = "Department"
        ' 
        ' lblHourlyRate
        ' 
        lblHourlyRate.AutoSize = True
        lblHourlyRate.Depth = 0
        lblHourlyRate.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblHourlyRate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblHourlyRate.Location = New Point(299, 135)
        lblHourlyRate.MouseState = MaterialSkin.MouseState.HOVER
        lblHourlyRate.Name = "lblHourlyRate"
        lblHourlyRate.Size = New Size(105, 24)
        lblHourlyRate.TabIndex = 4
        lblHourlyRate.Text = "Hourly Rate"
        ' 
        ' lblStartPeriod
        ' 
        lblStartPeriod.AutoSize = True
        lblStartPeriod.Depth = 0
        lblStartPeriod.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblStartPeriod.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblStartPeriod.Location = New Point(16, 186)
        lblStartPeriod.MouseState = MaterialSkin.MouseState.HOVER
        lblStartPeriod.Name = "lblStartPeriod"
        lblStartPeriod.Size = New Size(92, 24)
        lblStartPeriod.TabIndex = 5
        lblStartPeriod.Text = "Start Date"
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Depth = 0
        lblEndDate.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblEndDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblEndDate.Location = New Point(299, 186)
        lblEndDate.MouseState = MaterialSkin.MouseState.HOVER
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(81, 24)
        lblEndDate.TabIndex = 6
        lblEndDate.Text = "End Date"
        ' 
        ' lblTotalDue
        ' 
        lblTotalDue.AutoSize = True
        lblTotalDue.Depth = 0
        lblTotalDue.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTotalDue.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblTotalDue.Location = New Point(16, 237)
        lblTotalDue.MouseState = MaterialSkin.MouseState.HOVER
        lblTotalDue.Name = "lblTotalDue"
        lblTotalDue.Size = New Size(104, 24)
        lblTotalDue.TabIndex = 7
        lblTotalDue.Text = "Gross Total"
        ' 
        ' lblTaxDue
        ' 
        lblTaxDue.AutoSize = True
        lblTaxDue.Depth = 0
        lblTaxDue.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTaxDue.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblTaxDue.Location = New Point(299, 237)
        lblTaxDue.MouseState = MaterialSkin.MouseState.HOVER
        lblTaxDue.Name = "lblTaxDue"
        lblTaxDue.Size = New Size(74, 24)
        lblTaxDue.TabIndex = 8
        lblTaxDue.Text = "Tax Due"
        ' 
        ' lblAccountNumber
        ' 
        lblAccountNumber.AutoSize = True
        lblAccountNumber.Depth = 0
        lblAccountNumber.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblAccountNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblAccountNumber.Location = New Point(299, 288)
        lblAccountNumber.MouseState = MaterialSkin.MouseState.HOVER
        lblAccountNumber.Name = "lblAccountNumber"
        lblAccountNumber.Size = New Size(150, 24)
        lblAccountNumber.TabIndex = 9
        lblAccountNumber.Text = "Account Number"
        ' 
        ' lblBankName
        ' 
        lblBankName.AutoSize = True
        lblBankName.Depth = 0
        lblBankName.Font = New Font("Roboto Medium", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblBankName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblBankName.Location = New Point(16, 288)
        lblBankName.MouseState = MaterialSkin.MouseState.HOVER
        lblBankName.Name = "lblBankName"
        lblBankName.Size = New Size(104, 24)
        lblBankName.TabIndex = 10
        lblBankName.Text = "Bank Name"
        ' 
        ' btnPay
        ' 
        btnPay.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPay.Depth = 0
        btnPay.HighEmphasis = True
        btnPay.Icon = Nothing
        btnPay.Location = New Point(168, 393)
        btnPay.Margin = New Padding(4, 6, 4, 6)
        btnPay.MouseState = MaterialSkin.MouseState.HOVER
        btnPay.Name = "btnPay"
        btnPay.NoAccentTextColor = Color.Empty
        btnPay.Size = New Size(64, 36)
        btnPay.TabIndex = 11
        btnPay.Text = "Pay"
        btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnPay.UseAccentColor = False
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' IDLabelText
        ' 
        IDLabelText.BackColor = SystemColors.HighlightText
        IDLabelText.BorderStyle = BorderStyle.FixedSingle
        IDLabelText.Location = New Point(16, 108)
        IDLabelText.Margin = New Padding(3, 2, 3, 2)
        IDLabelText.Name = "IDLabelText"
        IDLabelText.Size = New Size(216, 23)
        IDLabelText.TabIndex = 13
        IDLabelText.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' NameLabelText
        ' 
        NameLabelText.BackColor = SystemColors.HighlightText
        NameLabelText.BorderStyle = BorderStyle.FixedSingle
        NameLabelText.Location = New Point(299, 110)
        NameLabelText.Margin = New Padding(3, 2, 3, 2)
        NameLabelText.Name = "NameLabelText"
        NameLabelText.Size = New Size(232, 23)
        NameLabelText.TabIndex = 14
        NameLabelText.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.HighlightText
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(16, 157)
        Label1.Margin = New Padding(3, 2, 3, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 23)
        Label1.TabIndex = 15
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.HighlightText
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Location = New Point(299, 161)
        Label2.Margin = New Padding(3, 2, 3, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 23)
        Label2.TabIndex = 16
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.BackColor = SystemColors.HighlightText
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Location = New Point(299, 263)
        Label5.Margin = New Padding(3, 2, 3, 2)
        Label5.Name = "Label5"
        Label5.Size = New Size(232, 23)
        Label5.TabIndex = 19
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.HighlightText
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Location = New Point(16, 263)
        Label6.Margin = New Padding(3, 2, 3, 2)
        Label6.Name = "Label6"
        Label6.Size = New Size(216, 23)
        Label6.TabIndex = 20
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.BackColor = SystemColors.HighlightText
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Location = New Point(16, 314)
        Label7.Margin = New Padding(3, 2, 3, 2)
        Label7.Name = "Label7"
        Label7.Size = New Size(216, 23)
        Label7.TabIndex = 21
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.BackColor = SystemColors.HighlightText
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Location = New Point(299, 314)
        Label8.Margin = New Padding(3, 2, 3, 2)
        Label8.Name = "Label8"
        Label8.Size = New Size(232, 23)
        Label8.TabIndex = 22
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(16, 211)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(216, 23)
        DateTimePicker1.TabIndex = 23
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(299, 211)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(232, 23)
        DateTimePicker2.TabIndex = 24
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSize = False
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.ForeColor = SystemColors.ControlLight
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(168, 441)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(195, 36)
        MaterialButton1.TabIndex = 25
        MaterialButton1.Text = "Clear"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.ForeColor = SystemColors.ControlLight
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(168, 345)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(64, 36)
        MaterialButton2.TabIndex = 26
        MaterialButton2.Text = "PREV"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton3
        ' 
        MaterialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton3.Depth = 0
        MaterialButton3.ForeColor = SystemColors.ControlLight
        MaterialButton3.HighEmphasis = True
        MaterialButton3.Icon = Nothing
        MaterialButton3.Location = New Point(299, 345)
        MaterialButton3.Margin = New Padding(4, 6, 4, 6)
        MaterialButton3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton3.Name = "MaterialButton3"
        MaterialButton3.NoAccentTextColor = Color.Empty
        MaterialButton3.Size = New Size(64, 36)
        MaterialButton3.TabIndex = 27
        MaterialButton3.Text = "Next"
        MaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton3.UseAccentColor = False
        MaterialButton3.UseVisualStyleBackColor = True
        ' 
        ' frmPayroll
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(553, 500)
        Controls.Add(MaterialButton3)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(NameLabelText)
        Controls.Add(IDLabelText)
        Controls.Add(btnPay)
        Controls.Add(lblBankName)
        Controls.Add(lblAccountNumber)
        Controls.Add(lblTaxDue)
        Controls.Add(lblTotalDue)
        Controls.Add(lblEndDate)
        Controls.Add(lblStartPeriod)
        Controls.Add(lblHourlyRate)
        Controls.Add(lblDepartment)
        Controls.Add(lblName)
        Controls.Add(lblID)
        Controls.Add(btnPrint)
        Name = "frmPayroll"
        Sizable = False
        Text = "Payroll Processor"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnPrint As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDepartment As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblHourlyRate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblStartPeriod As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblEndDate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTotalDue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTaxDue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAccountNumber As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblBankName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnPay As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IDLabelText As Label
    Friend WithEvents NameLabelText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton3 As MaterialSkin.Controls.MaterialButton

End Class
