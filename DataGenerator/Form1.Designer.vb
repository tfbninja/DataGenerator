<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.numPointsUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.decimalPlacesGroupBox = New System.Windows.Forms.GroupBox()
        Me.percentageGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.maximumDecimalPercentageUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minimumDecimalPercentageUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maximumDecimalPlacesUpDown = New System.Windows.Forms.NumericUpDown()
        Me.decimalPlacesBox = New System.Windows.Forms.CheckBox()
        Me.outputBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.copyCSVButton = New System.Windows.Forms.Button()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.seedBox = New System.Windows.Forms.TextBox()
        Me.Seed = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.minValUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.maxValUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.distributionGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.flatCurveRadio = New System.Windows.Forms.RadioButton()
        Me.bellCurveRadio = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nModalUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.extremeTrackBar = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.noneButton = New System.Windows.Forms.RadioButton()
        Me.randomButton = New System.Windows.Forms.RadioButton()
        Me.leftButton = New System.Windows.Forms.RadioButton()
        Me.rightButton = New System.Windows.Forms.RadioButton()
        Me.outputBoxSorted = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.copyCSVSortedButton = New System.Windows.Forms.Button()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.percentiles = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.histogram = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.stdDevLabel = New System.Windows.Forms.Label()
        Me.sumSquaresLabel = New System.Windows.Forms.Label()
        Me.sumLabel = New System.Windows.Forms.Label()
        Me.meanLabel = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.histogramBarsSlider = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.numPointsUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.decimalPlacesGroupBox.SuspendLayout()
        Me.percentageGroupBox.SuspendLayout()
        CType(Me.maximumDecimalPercentageUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimumDecimalPercentageUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximumDecimalPlacesUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minValUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxValUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.distributionGroupBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nModalUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.extremeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.percentiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.histogram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.histogramBarsSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numPointsUpDown
        '
        Me.numPointsUpDown.Location = New System.Drawing.Point(166, 62)
        Me.numPointsUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numPointsUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPointsUpDown.Name = "numPointsUpDown"
        Me.numPointsUpDown.Size = New System.Drawing.Size(89, 20)
        Me.numPointsUpDown.TabIndex = 0
        Me.numPointsUpDown.ThousandsSeparator = True
        Me.numPointsUpDown.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of data points"
        '
        'decimalPlacesGroupBox
        '
        Me.decimalPlacesGroupBox.Controls.Add(Me.percentageGroupBox)
        Me.decimalPlacesGroupBox.Controls.Add(Me.Label3)
        Me.decimalPlacesGroupBox.Controls.Add(Me.maximumDecimalPlacesUpDown)
        Me.decimalPlacesGroupBox.Location = New System.Drawing.Point(6, 206)
        Me.decimalPlacesGroupBox.Name = "decimalPlacesGroupBox"
        Me.decimalPlacesGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.decimalPlacesGroupBox.Size = New System.Drawing.Size(276, 122)
        Me.decimalPlacesGroupBox.TabIndex = 4
        Me.decimalPlacesGroupBox.TabStop = False
        Me.decimalPlacesGroupBox.Text = "Decimal places"
        '
        'percentageGroupBox
        '
        Me.percentageGroupBox.Controls.Add(Me.Label6)
        Me.percentageGroupBox.Controls.Add(Me.maximumDecimalPercentageUpDown)
        Me.percentageGroupBox.Controls.Add(Me.Label5)
        Me.percentageGroupBox.Controls.Add(Me.minimumDecimalPercentageUpDown)
        Me.percentageGroupBox.Location = New System.Drawing.Point(9, 50)
        Me.percentageGroupBox.Name = "percentageGroupBox"
        Me.percentageGroupBox.Size = New System.Drawing.Size(261, 67)
        Me.percentageGroupBox.TabIndex = 8
        Me.percentageGroupBox.TabStop = False
        Me.percentageGroupBox.Text = "Percentage with decimal places"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Maximum percentage"
        '
        'maximumDecimalPercentageUpDown
        '
        Me.maximumDecimalPercentageUpDown.Location = New System.Drawing.Point(184, 40)
        Me.maximumDecimalPercentageUpDown.Name = "maximumDecimalPercentageUpDown"
        Me.maximumDecimalPercentageUpDown.Size = New System.Drawing.Size(71, 20)
        Me.maximumDecimalPercentageUpDown.TabIndex = 11
        Me.maximumDecimalPercentageUpDown.ThousandsSeparator = True
        Me.maximumDecimalPercentageUpDown.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Minimum percentage"
        '
        'minimumDecimalPercentageUpDown
        '
        Me.minimumDecimalPercentageUpDown.Location = New System.Drawing.Point(184, 14)
        Me.minimumDecimalPercentageUpDown.Name = "minimumDecimalPercentageUpDown"
        Me.minimumDecimalPercentageUpDown.Size = New System.Drawing.Size(71, 20)
        Me.minimumDecimalPercentageUpDown.TabIndex = 9
        Me.minimumDecimalPercentageUpDown.ThousandsSeparator = True
        Me.minimumDecimalPercentageUpDown.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Maximum decimal places"
        '
        'maximumDecimalPlacesUpDown
        '
        Me.maximumDecimalPlacesUpDown.Location = New System.Drawing.Point(199, 21)
        Me.maximumDecimalPlacesUpDown.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.maximumDecimalPlacesUpDown.Name = "maximumDecimalPlacesUpDown"
        Me.maximumDecimalPlacesUpDown.Size = New System.Drawing.Size(71, 20)
        Me.maximumDecimalPlacesUpDown.TabIndex = 4
        Me.maximumDecimalPlacesUpDown.ThousandsSeparator = True
        Me.maximumDecimalPlacesUpDown.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'decimalPlacesBox
        '
        Me.decimalPlacesBox.AutoSize = True
        Me.decimalPlacesBox.Location = New System.Drawing.Point(6, 183)
        Me.decimalPlacesBox.Name = "decimalPlacesBox"
        Me.decimalPlacesBox.Size = New System.Drawing.Size(98, 17)
        Me.decimalPlacesBox.TabIndex = 5
        Me.decimalPlacesBox.Text = "Decimal places"
        Me.decimalPlacesBox.UseVisualStyleBackColor = True
        '
        'outputBox
        '
        Me.outputBox.Location = New System.Drawing.Point(776, 114)
        Me.outputBox.Multiline = True
        Me.outputBox.Name = "outputBox"
        Me.outputBox.ReadOnly = True
        Me.outputBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.outputBox.Size = New System.Drawing.Size(123, 307)
        Me.outputBox.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(773, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Output"
        '
        'copyCSVButton
        '
        Me.copyCSVButton.Location = New System.Drawing.Point(776, 427)
        Me.copyCSVButton.Name = "copyCSVButton"
        Me.copyCSVButton.Size = New System.Drawing.Size(92, 23)
        Me.copyCSVButton.TabIndex = 8
        Me.copyCSVButton.Text = "Copy as CSV"
        Me.copyCSVButton.UseVisualStyleBackColor = True
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(650, 114)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(103, 54)
        Me.generateButton.TabIndex = 9
        Me.generateButton.Text = "Generate"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'seedBox
        '
        Me.seedBox.Location = New System.Drawing.Point(156, 66)
        Me.seedBox.Name = "seedBox"
        Me.seedBox.Size = New System.Drawing.Size(126, 20)
        Me.seedBox.TabIndex = 10
        '
        'Seed
        '
        Me.Seed.AutoSize = True
        Me.Seed.Location = New System.Drawing.Point(6, 69)
        Me.Seed.Name = "Seed"
        Me.Seed.Size = New System.Drawing.Size(32, 13)
        Me.Seed.TabIndex = 11
        Me.Seed.Text = "Seed"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Minimum value"
        Me.ToolTip1.SetToolTip(Me.Label8, "(Inclusive)")
        '
        'minValUpDown
        '
        Me.minValUpDown.DecimalPlaces = 6
        Me.minValUpDown.Location = New System.Drawing.Point(156, 14)
        Me.minValUpDown.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.minValUpDown.Minimum = New Decimal(New Integer() {100000000, 0, 0, -2147483648})
        Me.minValUpDown.Name = "minValUpDown"
        Me.minValUpDown.Size = New System.Drawing.Size(126, 20)
        Me.minValUpDown.TabIndex = 12
        Me.minValUpDown.ThousandsSeparator = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Maximum value"
        Me.ToolTip1.SetToolTip(Me.Label9, "(Inclusive)")
        '
        'maxValUpDown
        '
        Me.maxValUpDown.DecimalPlaces = 6
        Me.maxValUpDown.Location = New System.Drawing.Point(156, 40)
        Me.maxValUpDown.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.maxValUpDown.Minimum = New Decimal(New Integer() {100000000, 0, 0, -2147483648})
        Me.maxValUpDown.Name = "maxValUpDown"
        Me.maxValUpDown.Size = New System.Drawing.Size(126, 20)
        Me.maxValUpDown.TabIndex = 14
        Me.maxValUpDown.ThousandsSeparator = True
        Me.maxValUpDown.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'distributionGroupBox
        '
        Me.distributionGroupBox.Controls.Add(Me.GroupBox3)
        Me.distributionGroupBox.Controls.Add(Me.Label11)
        Me.distributionGroupBox.Controls.Add(Me.nModalUpDown)
        Me.distributionGroupBox.Controls.Add(Me.Label10)
        Me.distributionGroupBox.Controls.Add(Me.extremeTrackBar)
        Me.distributionGroupBox.Controls.Add(Me.GroupBox1)
        Me.distributionGroupBox.Location = New System.Drawing.Point(44, 85)
        Me.distributionGroupBox.Name = "distributionGroupBox"
        Me.distributionGroupBox.Size = New System.Drawing.Size(178, 336)
        Me.distributionGroupBox.TabIndex = 17
        Me.distributionGroupBox.TabStop = False
        Me.distributionGroupBox.Text = "Distribution controls"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.flatCurveRadio)
        Me.GroupBox3.Controls.Add(Me.bellCurveRadio)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(99, 65)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Curve"
        '
        'flatCurveRadio
        '
        Me.flatCurveRadio.AutoSize = True
        Me.flatCurveRadio.Checked = True
        Me.flatCurveRadio.Location = New System.Drawing.Point(6, 19)
        Me.flatCurveRadio.Name = "flatCurveRadio"
        Me.flatCurveRadio.Size = New System.Drawing.Size(42, 17)
        Me.flatCurveRadio.TabIndex = 27
        Me.flatCurveRadio.TabStop = True
        Me.flatCurveRadio.Text = "Flat"
        Me.flatCurveRadio.UseVisualStyleBackColor = True
        '
        'bellCurveRadio
        '
        Me.bellCurveRadio.AutoSize = True
        Me.bellCurveRadio.Location = New System.Drawing.Point(6, 42)
        Me.bellCurveRadio.Name = "bellCurveRadio"
        Me.bellCurveRadio.Size = New System.Drawing.Size(42, 17)
        Me.bellCurveRadio.TabIndex = 28
        Me.bellCurveRadio.Text = "Bell"
        Me.bellCurveRadio.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "N-Modal"
        '
        'nModalUpDown
        '
        Me.nModalUpDown.Location = New System.Drawing.Point(6, 305)
        Me.nModalUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nModalUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nModalUpDown.Name = "nModalUpDown"
        Me.nModalUpDown.Size = New System.Drawing.Size(48, 20)
        Me.nModalUpDown.TabIndex = 6
        Me.nModalUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Extremeness"
        '
        'extremeTrackBar
        '
        Me.extremeTrackBar.Location = New System.Drawing.Point(-1, 235)
        Me.extremeTrackBar.Maximum = 100
        Me.extremeTrackBar.Name = "extremeTrackBar"
        Me.extremeTrackBar.Size = New System.Drawing.Size(159, 45)
        Me.extremeTrackBar.TabIndex = 4
        Me.extremeTrackBar.TickFrequency = 5
        Me.extremeTrackBar.Value = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.noneButton)
        Me.GroupBox1.Controls.Add(Me.randomButton)
        Me.GroupBox1.Controls.Add(Me.leftButton)
        Me.GroupBox1.Controls.Add(Me.rightButton)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 111)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Skew"
        '
        'noneButton
        '
        Me.noneButton.AutoSize = True
        Me.noneButton.Checked = True
        Me.noneButton.Location = New System.Drawing.Point(19, 85)
        Me.noneButton.Name = "noneButton"
        Me.noneButton.Size = New System.Drawing.Size(51, 17)
        Me.noneButton.TabIndex = 21
        Me.noneButton.TabStop = True
        Me.noneButton.Text = "None"
        Me.noneButton.UseVisualStyleBackColor = True
        '
        'randomButton
        '
        Me.randomButton.AutoSize = True
        Me.randomButton.Location = New System.Drawing.Point(19, 62)
        Me.randomButton.Name = "randomButton"
        Me.randomButton.Size = New System.Drawing.Size(65, 17)
        Me.randomButton.TabIndex = 2
        Me.randomButton.TabStop = True
        Me.randomButton.Text = "Random"
        Me.randomButton.UseVisualStyleBackColor = True
        '
        'leftButton
        '
        Me.leftButton.AutoSize = True
        Me.leftButton.Location = New System.Drawing.Point(19, 16)
        Me.leftButton.Name = "leftButton"
        Me.leftButton.Size = New System.Drawing.Size(43, 17)
        Me.leftButton.TabIndex = 0
        Me.leftButton.TabStop = True
        Me.leftButton.Text = "Left"
        Me.leftButton.UseVisualStyleBackColor = True
        '
        'rightButton
        '
        Me.rightButton.AutoSize = True
        Me.rightButton.Location = New System.Drawing.Point(19, 39)
        Me.rightButton.Name = "rightButton"
        Me.rightButton.Size = New System.Drawing.Size(50, 17)
        Me.rightButton.TabIndex = 1
        Me.rightButton.TabStop = True
        Me.rightButton.Text = "Right"
        Me.rightButton.UseVisualStyleBackColor = True
        '
        'outputBoxSorted
        '
        Me.outputBoxSorted.Location = New System.Drawing.Point(905, 114)
        Me.outputBoxSorted.Multiline = True
        Me.outputBoxSorted.Name = "outputBoxSorted"
        Me.outputBoxSorted.ReadOnly = True
        Me.outputBoxSorted.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.outputBoxSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.outputBoxSorted.Size = New System.Drawing.Size(123, 307)
        Me.outputBoxSorted.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(902, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Sorted output"
        '
        'copyCSVSortedButton
        '
        Me.copyCSVSortedButton.Location = New System.Drawing.Point(905, 427)
        Me.copyCSVSortedButton.Name = "copyCSVSortedButton"
        Me.copyCSVSortedButton.Size = New System.Drawing.Size(92, 23)
        Me.copyCSVSortedButton.TabIndex = 20
        Me.copyCSVSortedButton.Text = "Copy as CSV"
        Me.copyCSVSortedButton.UseVisualStyleBackColor = True
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(776, 51)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(252, 23)
        Me.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressBar.TabIndex = 22
        Me.progressBar.Value = 20
        Me.progressBar.Visible = False
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.OrangeRed
        Me.cancelButton.Location = New System.Drawing.Point(650, 174)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(103, 54)
        Me.cancelButton.TabIndex = 23
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = False
        Me.cancelButton.Visible = False
        '
        'percentiles
        '
        ChartArea5.Name = "ChartArea1"
        Me.percentiles.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.percentiles.Legends.Add(Legend5)
        Me.percentiles.Location = New System.Drawing.Point(543, 487)
        Me.percentiles.Name = "percentiles"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "SeriesJuan"
        Series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.percentiles.Series.Add(Series5)
        Me.percentiles.Size = New System.Drawing.Size(485, 300)
        Me.percentiles.TabIndex = 24
        Me.percentiles.Text = "Histogram"
        Title5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title5.Name = "Title1"
        Title5.Text = "Cumulative Relative Frequency"
        Me.percentiles.Titles.Add(Title5)
        '
        'histogram
        '
        ChartArea6.Name = "ChartArea1"
        Me.histogram.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Histogram"
        Me.histogram.Legends.Add(Legend6)
        Me.histogram.Location = New System.Drawing.Point(35, 487)
        Me.histogram.Name = "histogram"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Histogram"
        Series6.Name = "seriesjuan"
        Series6.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.histogram.Series.Add(Series6)
        Me.histogram.Size = New System.Drawing.Size(485, 300)
        Me.histogram.TabIndex = 25
        Me.histogram.Text = "Histogram"
        Title6.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title6.Name = "Histogram"
        Title6.Text = "Histogram"
        Me.histogram.Titles.Add(Title6)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.stdDevLabel)
        Me.GroupBox2.Controls.Add(Me.sumSquaresLabel)
        Me.GroupBox2.Controls.Add(Me.sumLabel)
        Me.GroupBox2.Controls.Add(Me.meanLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(576, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(177, 113)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "One Variable Stats"
        '
        'stdDevLabel
        '
        Me.stdDevLabel.AutoSize = True
        Me.stdDevLabel.Location = New System.Drawing.Point(6, 70)
        Me.stdDevLabel.Name = "stdDevLabel"
        Me.stdDevLabel.Size = New System.Drawing.Size(44, 13)
        Me.stdDevLabel.TabIndex = 3
        Me.stdDevLabel.Text = "Std dev"
        '
        'sumSquaresLabel
        '
        Me.sumSquaresLabel.AutoSize = True
        Me.sumSquaresLabel.Location = New System.Drawing.Point(6, 53)
        Me.sumSquaresLabel.Name = "sumSquaresLabel"
        Me.sumSquaresLabel.Size = New System.Drawing.Size(80, 13)
        Me.sumSquaresLabel.TabIndex = 2
        Me.sumSquaresLabel.Text = "Sum of squares"
        '
        'sumLabel
        '
        Me.sumLabel.AutoSize = True
        Me.sumLabel.Location = New System.Drawing.Point(6, 37)
        Me.sumLabel.Name = "sumLabel"
        Me.sumLabel.Size = New System.Drawing.Size(28, 13)
        Me.sumLabel.TabIndex = 1
        Me.sumLabel.Text = "Sum"
        '
        'meanLabel
        '
        Me.meanLabel.AutoSize = True
        Me.meanLabel.Location = New System.Drawing.Point(6, 20)
        Me.meanLabel.Name = "meanLabel"
        Me.meanLabel.Size = New System.Drawing.Size(40, 13)
        Me.meanLabel.TabIndex = 0
        Me.meanLabel.Text = "Mean: "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.minValUpDown)
        Me.GroupBox4.Controls.Add(Me.maxValUpDown)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.seedBox)
        Me.GroupBox4.Controls.Add(Me.Seed)
        Me.GroupBox4.Controls.Add(Me.decimalPlacesBox)
        Me.GroupBox4.Controls.Add(Me.decimalPlacesGroupBox)
        Me.GroupBox4.Location = New System.Drawing.Point(282, 85)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(288, 336)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Optional"
        '
        'histogramBarsSlider
        '
        Me.histogramBarsSlider.Location = New System.Drawing.Point(35, 442)
        Me.histogramBarsSlider.Maximum = 20
        Me.histogramBarsSlider.Minimum = 1
        Me.histogramBarsSlider.Name = "histogramBarsSlider"
        Me.histogramBarsSlider.Size = New System.Drawing.Size(153, 45)
        Me.histogramBarsSlider.TabIndex = 28
        Me.histogramBarsSlider.Value = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Histogram bars"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 816)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.histogramBarsSlider)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.histogram)
        Me.Controls.Add(Me.percentiles)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.copyCSVSortedButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.outputBoxSorted)
        Me.Controls.Add(Me.distributionGroupBox)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.copyCSVButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.outputBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numPointsUpDown)
        Me.Name = "MainWindow"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Data Generator v"
        CType(Me.numPointsUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.decimalPlacesGroupBox.ResumeLayout(False)
        Me.decimalPlacesGroupBox.PerformLayout()
        Me.percentageGroupBox.ResumeLayout(False)
        Me.percentageGroupBox.PerformLayout()
        CType(Me.maximumDecimalPercentageUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimumDecimalPercentageUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximumDecimalPlacesUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minValUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxValUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.distributionGroupBox.ResumeLayout(False)
        Me.distributionGroupBox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nModalUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.extremeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.percentiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.histogram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.histogramBarsSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numPointsUpDown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents decimalPlacesGroupBox As GroupBox
    Friend WithEvents decimalPlacesBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents maximumDecimalPlacesUpDown As NumericUpDown
    Friend WithEvents percentageGroupBox As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents maximumDecimalPercentageUpDown As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents minimumDecimalPercentageUpDown As NumericUpDown
    Friend WithEvents outputBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents copyCSVButton As Button
    Friend WithEvents generateButton As Button
    Friend WithEvents seedBox As TextBox
    Friend WithEvents Seed As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents minValUpDown As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents maxValUpDown As NumericUpDown
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents distributionGroupBox As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents nModalUpDown As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents extremeTrackBar As TrackBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents noneButton As RadioButton
    Friend WithEvents randomButton As RadioButton
    Friend WithEvents leftButton As RadioButton
    Friend WithEvents rightButton As RadioButton
    Friend WithEvents outputBoxSorted As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents copyCSVSortedButton As Button
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents cancelButton As Button
    Friend WithEvents percentiles As DataVisualization.Charting.Chart
    Friend WithEvents histogram As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents stdDevLabel As Label
    Friend WithEvents sumSquaresLabel As Label
    Friend WithEvents sumLabel As Label
    Friend WithEvents meanLabel As Label
    Friend WithEvents flatCurveRadio As RadioButton
    Friend WithEvents bellCurveRadio As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents histogramBarsSlider As TrackBar
    Friend WithEvents Label4 As Label
End Class
