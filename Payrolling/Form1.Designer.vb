﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        DepartmentLabel = New MaterialSkin.Controls.MaterialLabel()
        HourlyRateLabel = New MaterialSkin.Controls.MaterialLabel()
        lblStartPeriod = New MaterialSkin.Controls.MaterialLabel()
        lblEndDate = New MaterialSkin.Controls.MaterialLabel()
        lblTotalDue = New MaterialSkin.Controls.MaterialLabel()
        lblTaxDue = New MaterialSkin.Controls.MaterialLabel()
        lblAccountNumber = New MaterialSkin.Controls.MaterialLabel()
        lblBankName = New MaterialSkin.Controls.MaterialLabel()
        btnClear = New MaterialSkin.Controls.MaterialButton()
        IDLabelText = New Label()
        lblFirstName = New Label()
        lblDepartment = New Label()
        lblRate = New Label()
        lblTax = New Label()
        lblGross = New Label()
        lblBank = New Label()
        lblAccNo = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        btnPlay = New MaterialSkin.Controls.MaterialButton()
        btnPreviousRecord = New MaterialSkin.Controls.MaterialButton()
        btnNextRecord = New MaterialSkin.Controls.MaterialButton()
        lblSecondName = New Label()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        lblPosition = New Label()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        btnSearch = New MaterialSkin.Controls.MaterialButton()
        TextBox1 = New TextBox()
        lblPayDate = New Label()
        PayDate = New MaterialSkin.Controls.MaterialLabel()
        SuspendLayout()
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPrint.Depth = 0
        btnPrint.HighEmphasis = True
        btnPrint.Icon = Nothing
        btnPrint.Location = New Point(305, 540)
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
        lblName.Location = New Point(18, 106)
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
        DepartmentLabel.Location = New Point(18, 162)
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
        HourlyRateLabel.Location = New Point(20, 213)
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
        lblEndDate.Location = New Point(300, 272)
        lblEndDate.MouseState = MaterialSkin.MouseState.HOVER
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(58, 17)
        lblEndDate.TabIndex = 6
        lblEndDate.Text = "End Date"
        ' 
        ' lblTotalDue
        ' 
        lblTotalDue.AutoSize = True
        lblTotalDue.Depth = 0
        lblTotalDue.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTotalDue.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        lblTotalDue.Location = New Point(17, 395)
        lblTotalDue.MouseState = MaterialSkin.MouseState.HOVER
        lblTotalDue.Name = "lblTotalDue"
        lblTotalDue.Size = New Size(75, 17)
        lblTotalDue.TabIndex = 7
        lblTotalDue.Text = "Gross Total"
        ' 
        ' lblTaxDue
        ' 
        lblTaxDue.AutoSize = True
        lblTaxDue.Depth = 0
        lblTaxDue.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTaxDue.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        lblTaxDue.Location = New Point(300, 395)
        lblTaxDue.MouseState = MaterialSkin.MouseState.HOVER
        lblTaxDue.Name = "lblTaxDue"
        lblTaxDue.Size = New Size(53, 17)
        lblTaxDue.TabIndex = 8
        lblTaxDue.Text = "Tax Due"
        ' 
        ' lblAccountNumber
        ' 
        lblAccountNumber.AutoSize = True
        lblAccountNumber.Depth = 0
        lblAccountNumber.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblAccountNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        lblAccountNumber.Location = New Point(300, 446)
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
        btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnClear.Depth = 0
        btnClear.HighEmphasis = True
        btnClear.Icon = Nothing
        btnClear.Location = New Point(173, 540)
        btnClear.Margin = New Padding(4, 6, 4, 6)
        btnClear.MouseState = MaterialSkin.MouseState.HOVER
        btnClear.Name = "btnClear"
        btnClear.NoAccentTextColor = Color.Empty
        btnClear.Size = New Size(66, 36)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnClear.UseAccentColor = False
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' IDLabelText
        ' 
        IDLabelText.BackColor = SystemColors.HighlightText
        IDLabelText.BorderStyle = BorderStyle.FixedSingle
        IDLabelText.Location = New Point(475, 76)
        IDLabelText.Margin = New Padding(3, 2, 3, 2)
        IDLabelText.Name = "IDLabelText"
        IDLabelText.Size = New Size(55, 23)
        IDLabelText.TabIndex = 13
        IDLabelText.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblFirstName
        ' 
        lblFirstName.BackColor = SystemColors.HighlightText
        lblFirstName.BorderStyle = BorderStyle.FixedSingle
        lblFirstName.Location = New Point(18, 132)
        lblFirstName.Margin = New Padding(3, 2, 3, 2)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(220, 23)
        lblFirstName.TabIndex = 14
        lblFirstName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDepartment
        ' 
        lblDepartment.BackColor = SystemColors.HighlightText
        lblDepartment.BorderStyle = BorderStyle.FixedSingle
        lblDepartment.Location = New Point(18, 188)
        lblDepartment.Margin = New Padding(3, 2, 3, 2)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(220, 23)
        lblDepartment.TabIndex = 15
        lblDepartment.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblRate
        ' 
        lblRate.BackColor = SystemColors.HighlightText
        lblRate.BorderStyle = BorderStyle.FixedSingle
        lblRate.Location = New Point(20, 239)
        lblRate.Margin = New Padding(3, 2, 3, 2)
        lblRate.Name = "lblRate"
        lblRate.Size = New Size(218, 23)
        lblRate.TabIndex = 16
        lblRate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTax
        ' 
        lblTax.BackColor = SystemColors.HighlightText
        lblTax.BorderStyle = BorderStyle.FixedSingle
        lblTax.Location = New Point(300, 421)
        lblTax.Margin = New Padding(3, 2, 3, 2)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(232, 23)
        lblTax.TabIndex = 19
        lblTax.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblGross
        ' 
        lblGross.BackColor = SystemColors.HighlightText
        lblGross.BorderStyle = BorderStyle.FixedSingle
        lblGross.Location = New Point(17, 421)
        lblGross.Margin = New Padding(3, 2, 3, 2)
        lblGross.Name = "lblGross"
        lblGross.Size = New Size(221, 23)
        lblGross.TabIndex = 20
        lblGross.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBank
        ' 
        lblBank.BackColor = SystemColors.HighlightText
        lblBank.BorderStyle = BorderStyle.FixedSingle
        lblBank.Location = New Point(17, 472)
        lblBank.Margin = New Padding(3, 2, 3, 2)
        lblBank.Name = "lblBank"
        lblBank.Size = New Size(221, 23)
        lblBank.TabIndex = 21
        lblBank.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblAccNo
        ' 
        lblAccNo.BackColor = SystemColors.HighlightText
        lblAccNo.BorderStyle = BorderStyle.FixedSingle
        lblAccNo.Location = New Point(300, 472)
        lblAccNo.Margin = New Padding(3, 2, 3, 2)
        lblAccNo.Name = "lblAccNo"
        lblAccNo.Size = New Size(232, 23)
        lblAccNo.TabIndex = 22
        lblAccNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(17, 297)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(221, 23)
        DateTimePicker1.TabIndex = 23
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(300, 297)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(232, 23)
        DateTimePicker2.TabIndex = 24
        ' 
        ' btnPlay
        ' 
        btnPlay.AutoSize = False
        btnPlay.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPlay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPlay.Depth = 0
        btnPlay.ForeColor = SystemColors.ControlLight
        btnPlay.HighEmphasis = True
        btnPlay.Icon = Nothing
        btnPlay.Location = New Point(173, 636)
        btnPlay.Margin = New Padding(4, 6, 4, 6)
        btnPlay.MouseState = MaterialSkin.MouseState.HOVER
        btnPlay.Name = "btnPlay"
        btnPlay.NoAccentTextColor = Color.Empty
        btnPlay.Size = New Size(196, 36)
        btnPlay.TabIndex = 25
        btnPlay.Text = "PAY"
        btnPlay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnPlay.UseAccentColor = False
        btnPlay.UseVisualStyleBackColor = True
        ' 
        ' btnPreviousRecord
        ' 
        btnPreviousRecord.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPreviousRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnPreviousRecord.Depth = 0
        btnPreviousRecord.ForeColor = SystemColors.ControlLight
        btnPreviousRecord.HighEmphasis = True
        btnPreviousRecord.Icon = Nothing
        btnPreviousRecord.Location = New Point(174, 588)
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
        btnNextRecord.Location = New Point(305, 588)
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
        ' lblSecondName
        ' 
        lblSecondName.BackColor = SystemColors.HighlightText
        lblSecondName.BorderStyle = BorderStyle.FixedSingle
        lblSecondName.Location = New Point(301, 132)
        lblSecondName.Margin = New Padding(3, 2, 3, 2)
        lblSecondName.Name = "lblSecondName"
        lblSecondName.Size = New Size(231, 23)
        lblSecondName.TabIndex = 29
        lblSecondName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        MaterialLabel1.Location = New Point(301, 106)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(70, 17)
        MaterialLabel1.TabIndex = 28
        MaterialLabel1.Text = "Last Name"
        ' 
        ' lblPosition
        ' 
        lblPosition.BackColor = SystemColors.HighlightText
        lblPosition.BorderStyle = BorderStyle.FixedSingle
        lblPosition.Location = New Point(300, 188)
        lblPosition.Margin = New Padding(3, 2, 3, 2)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(232, 23)
        lblPosition.TabIndex = 31
        lblPosition.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        MaterialLabel2.Location = New Point(300, 162)
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(18, 80)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(148, 23)
        TextBox1.TabIndex = 33
        ' 
        ' lblPayDate
        ' 
        lblPayDate.BackColor = SystemColors.HighlightText
        lblPayDate.BorderStyle = BorderStyle.FixedSingle
        lblPayDate.Location = New Point(18, 359)
        lblPayDate.Margin = New Padding(3, 2, 3, 2)
        lblPayDate.Name = "lblPayDate"
        lblPayDate.Size = New Size(218, 23)
        lblPayDate.TabIndex = 35
        lblPayDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PayDate
        ' 
        PayDate.AutoSize = True
        PayDate.Depth = 0
        PayDate.Font = New Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        PayDate.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        PayDate.Location = New Point(18, 333)
        PayDate.MouseState = MaterialSkin.MouseState.HOVER
        PayDate.Name = "PayDate"
        PayDate.Size = New Size(58, 17)
        PayDate.TabIndex = 34
        PayDate.Text = "Pay Date"
        ' 
        ' frmPayroll
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(553, 681)
        Controls.Add(lblPayDate)
        Controls.Add(PayDate)
        Controls.Add(TextBox1)
        Controls.Add(btnSearch)
        Controls.Add(lblPosition)
        Controls.Add(MaterialLabel2)
        Controls.Add(lblSecondName)
        Controls.Add(MaterialLabel1)
        Controls.Add(btnNextRecord)
        Controls.Add(btnPreviousRecord)
        Controls.Add(btnPlay)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(lblAccNo)
        Controls.Add(lblBank)
        Controls.Add(lblGross)
        Controls.Add(lblTax)
        Controls.Add(lblRate)
        Controls.Add(lblDepartment)
        Controls.Add(lblFirstName)
        Controls.Add(IDLabelText)
        Controls.Add(btnClear)
        Controls.Add(lblBankName)
        Controls.Add(lblAccountNumber)
        Controls.Add(lblTaxDue)
        Controls.Add(lblTotalDue)
        Controls.Add(lblEndDate)
        Controls.Add(lblStartPeriod)
        Controls.Add(HourlyRateLabel)
        Controls.Add(DepartmentLabel)
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
    Friend WithEvents DepartmentLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents HourlyRateLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblStartPeriod As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblEndDate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTotalDue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTaxDue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAccountNumber As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblBankName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnClear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IDLabelText As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents lblBank As Label
    Friend WithEvents lblAccNo As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btnPlay As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPreviousRecord As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNextRecord As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblSecondName As Label
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPosition As Label
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPayDate As Label
    Friend WithEvents PayDate As MaterialSkin.Controls.MaterialLabel

End Class
