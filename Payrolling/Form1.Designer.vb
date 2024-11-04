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
        lblID = New MaterialSkin.Controls.MaterialLabel()
        lblName = New MaterialSkin.Controls.MaterialLabel()
        DepartmentLabel = New MaterialSkin.Controls.MaterialLabel()
        HourlyRateLabel = New MaterialSkin.Controls.MaterialLabel()
        lblStartPeriod = New MaterialSkin.Controls.MaterialLabel()
        lblEndDate = New MaterialSkin.Controls.MaterialLabel()
        GrossTotalLabel = New MaterialSkin.Controls.MaterialLabel()
        TaxDueLabel = New MaterialSkin.Controls.MaterialLabel()
        lblAccountNumber = New MaterialSkin.Controls.MaterialLabel()
        lblBankName = New MaterialSkin.Controls.MaterialLabel()
        btnClear = New MaterialSkin.Controls.MaterialButton()
        lblTax = New Label()
        lblGross = New Label()
        dtpStart = New DateTimePicker()
        dtpEnd = New DateTimePicker()
        btnPlay = New MaterialSkin.Controls.MaterialButton()
        btnPreviousRecord = New MaterialSkin.Controls.MaterialButton()
        btnNextRecord = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        btnSearch = New MaterialSkin.Controls.MaterialButton()
        txtSearchBox = New TextBox()
        lblPayDate = New Label()
        PayDateLabel = New MaterialSkin.Controls.MaterialLabel()
        lblDaysWorked = New Label()
        DaysWorkedLabel = New MaterialSkin.Controls.MaterialLabel()
        btnCalcPay = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        lblNetTotal = New Label()
        NetTotalLabel = New MaterialSkin.Controls.MaterialLabel()
        lblFirstName = New TextBox()
        lblSecondName = New TextBox()
        lblDepartment = New TextBox()
        lblPosition = New TextBox()
        lblRate = New TextBox()
        lblAccNo = New TextBox()
        lblBank = New TextBox()
        IDLabelText = New TextBox()
        SuspendLayout()
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Depth = 0
        lblID.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblID.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblID.Location = New Point(449, 76)
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
        lblName.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblName.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        lblName.Location = New Point(18, 113)
        lblName.MouseState = MaterialSkin.MouseState.HOVER
        lblName.Name = "lblName"
        lblName.Size = New Size(71, 17)
        lblName.TabIndex = 2
        lblName.Text = "First Name"
        ' 
        ' DepartmentLabel
        ' 
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Depth = 0
        DepartmentLabel.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        DepartmentLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        DepartmentLabel.Location = New Point(18, 169)
        DepartmentLabel.MouseState = MaterialSkin.MouseState.HOVER
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New Size(77, 17)
        DepartmentLabel.TabIndex = 3
        DepartmentLabel.Text = "Department"
        ' 
        ' HourlyRateLabel
        ' 
        HourlyRateLabel.AutoSize = True
        HourlyRateLabel.Depth = 0
        HourlyRateLabel.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        HourlyRateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        HourlyRateLabel.Location = New Point(20, 220)
        HourlyRateLabel.MouseState = MaterialSkin.MouseState.HOVER
        HourlyRateLabel.Name = "HourlyRateLabel"
        HourlyRateLabel.Size = New Size(76, 17)
        HourlyRateLabel.TabIndex = 4
        HourlyRateLabel.Text = "Hourly Rate"
        ' 
        ' lblStartPeriod
        ' 
        lblStartPeriod.AutoSize = True
        lblStartPeriod.Depth = 0
        lblStartPeriod.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblStartPeriod.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        lblStartPeriod.Location = New Point(17, 272)
        lblStartPeriod.MouseState = MaterialSkin.MouseState.HOVER
        lblStartPeriod.Name = "lblStartPeriod"
        lblStartPeriod.Size = New Size(65, 17)
        lblStartPeriod.TabIndex = 5
        lblStartPeriod.Text = "Start Date"
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Depth = 0
        lblEndDate.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblEndDate.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        lblEndDate.Location = New Point(299, 272)
        lblEndDate.MouseState = MaterialSkin.MouseState.HOVER
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(58, 17)
        lblEndDate.TabIndex = 6
        lblEndDate.Text = "End Date"
        ' 
        ' GrossTotalLabel
        ' 
        GrossTotalLabel.AutoSize = True
        GrossTotalLabel.Depth = 0
        GrossTotalLabel.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        GrossTotalLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        GrossTotalLabel.Location = New Point(296, 333)
        GrossTotalLabel.MouseState = MaterialSkin.MouseState.HOVER
        GrossTotalLabel.Name = "GrossTotalLabel"
        GrossTotalLabel.Size = New Size(75, 17)
        GrossTotalLabel.TabIndex = 7
        GrossTotalLabel.Text = "Gross Total"
        ' 
        ' TaxDueLabel
        ' 
        TaxDueLabel.AutoSize = True
        TaxDueLabel.Depth = 0
        TaxDueLabel.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        TaxDueLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        TaxDueLabel.Location = New Point(17, 393)
        TaxDueLabel.MouseState = MaterialSkin.MouseState.HOVER
        TaxDueLabel.Name = "TaxDueLabel"
        TaxDueLabel.Size = New Size(53, 17)
        TaxDueLabel.TabIndex = 8
        TaxDueLabel.Text = "Tax Due"
        ' 
        ' lblAccountNumber
        ' 
        lblAccountNumber.AutoSize = True
        lblAccountNumber.Depth = 0
        lblAccountNumber.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblAccountNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        lblAccountNumber.Location = New Point(296, 444)
        lblAccountNumber.MouseState = MaterialSkin.MouseState.HOVER
        lblAccountNumber.Name = "lblAccountNumber"
        lblAccountNumber.Size = New Size(107, 17)
        lblAccountNumber.TabIndex = 9
        lblAccountNumber.Text = "Account Number"
        ' 
        ' lblBankName
        ' 
        lblBankName.AutoSize = True
        lblBankName.Depth = 0
        lblBankName.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblBankName.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        lblBankName.Location = New Point(17, 446)
        lblBankName.MouseState = MaterialSkin.MouseState.HOVER
        lblBankName.Name = "lblBankName"
        lblBankName.Size = New Size(74, 17)
        lblBankName.TabIndex = 10
        lblBankName.Text = "Bank Name"
        ' 
        ' btnClear
        ' 
        btnClear.AutoSize = False
        btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnClear.Depth = 0
        btnClear.HighEmphasis = True
        btnClear.Icon = Nothing
        btnClear.Location = New Point(173, 619)
        btnClear.Margin = New Padding(4, 6, 4, 6)
        btnClear.MouseState = MaterialSkin.MouseState.HOVER
        btnClear.Name = "btnClear"
        btnClear.NoAccentTextColor = Color.Empty
        btnClear.Size = New Size(191, 36)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnClear.UseAccentColor = False
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblTax
        ' 
        lblTax.BackColor = SystemColors.Control
        lblTax.BorderStyle = BorderStyle.Fixed3D
        lblTax.Location = New Point(17, 419)
        lblTax.Margin = New Padding(3, 2, 3, 2)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(221, 23)
        lblTax.TabIndex = 19
        lblTax.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblGross
        ' 
        lblGross.BackColor = SystemColors.Control
        lblGross.BorderStyle = BorderStyle.Fixed3D
        lblGross.Location = New Point(296, 359)
        lblGross.Margin = New Padding(3, 2, 3, 2)
        lblGross.Name = "lblGross"
        lblGross.Size = New Size(234, 23)
        lblGross.TabIndex = 20
        lblGross.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpStart
        ' 
        dtpStart.Format = DateTimePickerFormat.Short
        dtpStart.Location = New Point(17, 297)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(221, 23)
        dtpStart.TabIndex = 23
        ' 
        ' dtpEnd
        ' 
        dtpEnd.Format = DateTimePickerFormat.Short
        dtpEnd.Location = New Point(298, 297)
        dtpEnd.Name = "dtpEnd"
        dtpEnd.Size = New Size(230, 23)
        dtpEnd.TabIndex = 24
        ' 
        ' btnPlay
        ' 
        btnPlay.AutoSize = False
        btnPlay.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPlay.BackColor = Color.Lime
        btnPlay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPlay.Depth = 0
        btnPlay.ForeColor = SystemColors.ControlLight
        btnPlay.HighEmphasis = True
        btnPlay.Icon = Nothing
        btnPlay.Location = New Point(269, 571)
        btnPlay.Margin = New Padding(4, 6, 4, 6)
        btnPlay.MouseState = MaterialSkin.MouseState.HOVER
        btnPlay.Name = "btnPlay"
        btnPlay.NoAccentTextColor = Color.Empty
        btnPlay.Size = New Size(95, 36)
        btnPlay.TabIndex = 25
        btnPlay.Text = "Generate Slip"
        btnPlay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnPlay.UseAccentColor = False
        btnPlay.UseVisualStyleBackColor = False
        ' 
        ' btnPreviousRecord
        ' 
        btnPreviousRecord.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPreviousRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPreviousRecord.Depth = 0
        btnPreviousRecord.ForeColor = SystemColors.ControlLight
        btnPreviousRecord.HighEmphasis = True
        btnPreviousRecord.Icon = Nothing
        btnPreviousRecord.Location = New Point(174, 523)
        btnPreviousRecord.Margin = New Padding(4, 6, 4, 6)
        btnPreviousRecord.MouseState = MaterialSkin.MouseState.HOVER
        btnPreviousRecord.Name = "btnPreviousRecord"
        btnPreviousRecord.NoAccentTextColor = Color.Empty
        btnPreviousRecord.Size = New Size(64, 36)
        btnPreviousRecord.TabIndex = 26
        btnPreviousRecord.Text = "PREV"
        btnPreviousRecord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnPreviousRecord.UseAccentColor = False
        btnPreviousRecord.UseVisualStyleBackColor = True
        ' 
        ' btnNextRecord
        ' 
        btnNextRecord.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnNextRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnNextRecord.Depth = 0
        btnNextRecord.ForeColor = SystemColors.ControlLight
        btnNextRecord.HighEmphasis = True
        btnNextRecord.Icon = Nothing
        btnNextRecord.Location = New Point(301, 523)
        btnNextRecord.Margin = New Padding(4, 6, 4, 6)
        btnNextRecord.MouseState = MaterialSkin.MouseState.HOVER
        btnNextRecord.Name = "btnNextRecord"
        btnNextRecord.NoAccentTextColor = Color.Empty
        btnNextRecord.Size = New Size(64, 36)
        btnNextRecord.TabIndex = 27
        btnNextRecord.Text = "Next"
        btnNextRecord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnNextRecord.UseAccentColor = False
        btnNextRecord.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        MaterialLabel1.Location = New Point(301, 113)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(70, 17)
        MaterialLabel1.TabIndex = 28
        MaterialLabel1.Text = "Last Name"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        MaterialLabel2.Location = New Point(300, 169)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(54, 17)
        MaterialLabel2.TabIndex = 30
        MaterialLabel2.Text = "Position"
        ' 
        ' btnSearch
        ' 
        btnSearch.AutoSize = False
        btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSearch.Depth = 0
        btnSearch.FlatStyle = FlatStyle.System
        btnSearch.HighEmphasis = True
        btnSearch.Icon = Nothing
        btnSearch.Location = New Point(173, 78)
        btnSearch.Margin = New Padding(4, 6, 4, 6)
        btnSearch.MouseState = MaterialSkin.MouseState.HOVER
        btnSearch.Name = "btnSearch"
        btnSearch.NoAccentTextColor = Color.Empty
        btnSearch.Size = New Size(65, 24)
        btnSearch.TabIndex = 32
        btnSearch.Text = "Search"
        btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSearch.UseAccentColor = False
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearchBox
        ' 
        txtSearchBox.Location = New Point(18, 80)
        txtSearchBox.Name = "txtSearchBox"
        txtSearchBox.Size = New Size(148, 23)
        txtSearchBox.TabIndex = 33
        ' 
        ' lblPayDate
        ' 
        lblPayDate.BackColor = SystemColors.Control
        lblPayDate.BorderStyle = BorderStyle.Fixed3D
        lblPayDate.Location = New Point(18, 359)
        lblPayDate.Margin = New Padding(3, 2, 3, 2)
        lblPayDate.Name = "lblPayDate"
        lblPayDate.Size = New Size(218, 23)
        lblPayDate.TabIndex = 35
        lblPayDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PayDateLabel
        ' 
        PayDateLabel.AutoSize = True
        PayDateLabel.Depth = 0
        PayDateLabel.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        PayDateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        PayDateLabel.Location = New Point(18, 333)
        PayDateLabel.MouseState = MaterialSkin.MouseState.HOVER
        PayDateLabel.Name = "PayDateLabel"
        PayDateLabel.Size = New Size(58, 17)
        PayDateLabel.TabIndex = 34
        PayDateLabel.Text = "Pay Date"
        ' 
        ' lblDaysWorked
        ' 
        lblDaysWorked.BackColor = SystemColors.Control
        lblDaysWorked.BorderStyle = BorderStyle.Fixed3D
        lblDaysWorked.ForeColor = SystemColors.InfoText
        lblDaysWorked.Location = New Point(475, 327)
        lblDaysWorked.Margin = New Padding(3, 2, 3, 2)
        lblDaysWorked.Name = "lblDaysWorked"
        lblDaysWorked.Size = New Size(55, 23)
        lblDaysWorked.TabIndex = 37
        lblDaysWorked.Text = "0"
        lblDaysWorked.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' DaysWorkedLabel
        ' 
        DaysWorkedLabel.AutoSize = True
        DaysWorkedLabel.Depth = 0
        DaysWorkedLabel.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        DaysWorkedLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        DaysWorkedLabel.Location = New Point(386, 333)
        DaysWorkedLabel.MouseState = MaterialSkin.MouseState.HOVER
        DaysWorkedLabel.Name = "DaysWorkedLabel"
        DaysWorkedLabel.Size = New Size(83, 17)
        DaysWorkedLabel.TabIndex = 36
        DaysWorkedLabel.Text = "Days Worked"
        ' 
        ' btnCalcPay
        ' 
        btnCalcPay.AutoSize = False
        btnCalcPay.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCalcPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnCalcPay.Depth = 0
        btnCalcPay.Font = New Font("Segoe UI", 6F)
        btnCalcPay.ForeColor = SystemColors.ControlLight
        btnCalcPay.HighEmphasis = True
        btnCalcPay.Icon = Nothing
        btnCalcPay.Location = New Point(173, 571)
        btnCalcPay.Margin = New Padding(4, 6, 4, 6)
        btnCalcPay.MouseState = MaterialSkin.MouseState.HOVER
        btnCalcPay.Name = "btnCalcPay"
        btnCalcPay.NoAccentTextColor = Color.Empty
        btnCalcPay.Size = New Size(91, 36)
        btnCalcPay.TabIndex = 38
        btnCalcPay.Text = "Calculate Pay"
        btnCalcPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnCalcPay.UseAccentColor = False
        btnCalcPay.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        MaterialLabel3.Location = New Point(20, 242)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(26, 17)
        MaterialLabel3.TabIndex = 39
        MaterialLabel3.Text = "KES"
        ' 
        ' lblNetTotal
        ' 
        lblNetTotal.BackColor = SystemColors.Control
        lblNetTotal.BorderStyle = BorderStyle.Fixed3D
        lblNetTotal.Location = New Point(296, 419)
        lblNetTotal.Margin = New Padding(3, 2, 3, 2)
        lblNetTotal.Name = "lblNetTotal"
        lblNetTotal.Size = New Size(234, 23)
        lblNetTotal.TabIndex = 41
        lblNetTotal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' NetTotalLabel
        ' 
        NetTotalLabel.AutoSize = True
        NetTotalLabel.Depth = 0
        NetTotalLabel.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        NetTotalLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        NetTotalLabel.Location = New Point(296, 393)
        NetTotalLabel.MouseState = MaterialSkin.MouseState.HOVER
        NetTotalLabel.Name = "NetTotalLabel"
        NetTotalLabel.Size = New Size(70, 17)
        NetTotalLabel.TabIndex = 40
        NetTotalLabel.Text = "Final Total"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.Location = New Point(17, 132)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(221, 23)
        lblFirstName.TabIndex = 42
        ' 
        ' lblSecondName
        ' 
        lblSecondName.Location = New Point(300, 132)
        lblSecondName.Name = "lblSecondName"
        lblSecondName.Size = New Size(226, 23)
        lblSecondName.TabIndex = 43
        ' 
        ' lblDepartment
        ' 
        lblDepartment.Location = New Point(18, 189)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(218, 23)
        lblDepartment.TabIndex = 44
        ' 
        ' lblPosition
        ' 
        lblPosition.Location = New Point(300, 189)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(226, 23)
        lblPosition.TabIndex = 45
        ' 
        ' lblRate
        ' 
        lblRate.Location = New Point(52, 236)
        lblRate.Name = "lblRate"
        lblRate.Size = New Size(184, 23)
        lblRate.TabIndex = 46
        ' 
        ' lblAccNo
        ' 
        lblAccNo.Location = New Point(296, 464)
        lblAccNo.Name = "lblAccNo"
        lblAccNo.Size = New Size(230, 23)
        lblAccNo.TabIndex = 47
        ' 
        ' lblBank
        ' 
        lblBank.Location = New Point(18, 464)
        lblBank.Name = "lblBank"
        lblBank.Size = New Size(218, 23)
        lblBank.TabIndex = 48
        ' 
        ' IDLabelText
        ' 
        IDLabelText.Location = New Point(475, 77)
        IDLabelText.Name = "IDLabelText"
        IDLabelText.Size = New Size(51, 23)
        IDLabelText.TabIndex = 49
        ' 
        ' frmPayroll
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(553, 681)
        Controls.Add(IDLabelText)
        Controls.Add(lblBank)
        Controls.Add(lblAccNo)
        Controls.Add(lblRate)
        Controls.Add(lblPosition)
        Controls.Add(lblDepartment)
        Controls.Add(lblSecondName)
        Controls.Add(lblFirstName)
        Controls.Add(lblNetTotal)
        Controls.Add(NetTotalLabel)
        Controls.Add(MaterialLabel3)
        Controls.Add(btnCalcPay)
        Controls.Add(lblDaysWorked)
        Controls.Add(DaysWorkedLabel)
        Controls.Add(lblPayDate)
        Controls.Add(PayDateLabel)
        Controls.Add(txtSearchBox)
        Controls.Add(btnSearch)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel1)
        Controls.Add(btnNextRecord)
        Controls.Add(btnPreviousRecord)
        Controls.Add(btnPlay)
        Controls.Add(dtpEnd)
        Controls.Add(dtpStart)
        Controls.Add(lblGross)
        Controls.Add(lblTax)
        Controls.Add(btnClear)
        Controls.Add(lblBankName)
        Controls.Add(lblAccountNumber)
        Controls.Add(TaxDueLabel)
        Controls.Add(GrossTotalLabel)
        Controls.Add(lblEndDate)
        Controls.Add(lblStartPeriod)
        Controls.Add(HourlyRateLabel)
        Controls.Add(DepartmentLabel)
        Controls.Add(lblName)
        Controls.Add(lblID)
        Name = "frmPayroll"
        Sizable = False
        Text = "Payroll Processor"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DepartmentLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents HourlyRateLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblStartPeriod As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblEndDate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GrossTotalLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TaxDueLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAccountNumber As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblBankName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnClear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblTax As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents btnPlay As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPreviousRecord As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNextRecord As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents lblPayDate As Label
    Friend WithEvents PayDateLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDaysWorked As Label
    Friend WithEvents DaysWorkedLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnCalcPay As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNetTotal As Label
    Friend WithEvents NetTotalLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFirstName As TextBox
    Friend WithEvents lblSecondName As TextBox
    Friend WithEvents lblDepartment As TextBox
    Friend WithEvents lblPosition As TextBox
    Friend WithEvents lblRate As TextBox
    Friend WithEvents lblAccNo As TextBox
    Friend WithEvents lblBank As TextBox
    Friend WithEvents IDLabelText As TextBox

End Class
