Imports Telerik.WinControls.UI
Imports Telerik.Charting
Imports System.Windows.Forms.DataVisualization.Charting

Public Class MainWindow
    Dim versionNumber = "1.0"
    Dim random As New Random()
    Dim tooltip2 As New ToolTip()
    Dim values As New List(Of Double)
    Dim sortedValues As New List(Of Double)
    Dim cancel = False

    Dim medianList As New List(Of Double)

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Text = "Data Generator v" & versionNumber
        UpdateAll()

    End Sub

    Private Sub UpdateAll()
        tooltip2.SetToolTip(copyCSVButton, "")
        minValUpDown.DecimalPlaces = If(decimalPlacesBox.Checked, maximumDecimalPlacesUpDown.Value, 0)
        maxValUpDown.DecimalPlaces = If(decimalPlacesBox.Checked, maximumDecimalPlacesUpDown.Value, 0)
        decimalPlacesGroupBox.Enabled = decimalPlacesBox.Checked
        minValUpDown.Maximum = maxValUpDown.Value
        maxValUpDown.Minimum = minValUpDown.Value
        minimumDecimalPercentageUpDown.Maximum = maximumDecimalPercentageUpDown.Value
        maximumDecimalPercentageUpDown.Minimum = minimumDecimalPercentageUpDown.Value
    End Sub

    Private Sub UpdateCharts()
        histogram.Series("seriesjuan").Points.Clear()
        Dim bars(histogramBarsSlider.Value) As Integer
        For i = 0 To histogramBarsSlider.Value - 1
            bars(i) = 0
        Next
        For Each val As Double In values
            Console.WriteLine("val " & val)
            Console.WriteLine("min " & sortedValues.Min)
            Console.WriteLine("max " & sortedValues.Max)
            bars((sortedValues.Max - val) \ histogramBarsSlider.Value) += 1
        Next
        For Each pt As Double In bars
            histogram.Series("seriesjuan").Points.AddY(pt)
        Next

        percentiles.Series("SeriesJuan").Points.Clear()
        For Each pt As Double In sortedValues
            percentiles.Series("SeriesJuan").Points.AddY(pt)
        Next
    End Sub

    Private Sub DecimalPlacesBox_CheckedChanged(sender As Object, e As EventArgs) Handles decimalPlacesBox.CheckedChanged
        UpdateAll()
    End Sub

    Private Sub DecimalPlacesUpDown_ValueChanged(sender As Object, e As EventArgs)
        UpdateAll()
    End Sub

    Private Sub MaximumDecimalPlacesUpDown_ValueChanged(sender As Object, e As EventArgs) Handles maximumDecimalPlacesUpDown.ValueChanged
        UpdateAll()
    End Sub

    Private Sub MinimumDecimalPercentageUpDown_ValueChanged(sender As Object, e As EventArgs) Handles minimumDecimalPercentageUpDown.ValueChanged
        UpdateAll()
    End Sub

    Private Sub MaximumDecimalPercentageUpDown_ValueChanged(sender As Object, e As EventArgs) Handles maximumDecimalPercentageUpDown.ValueChanged
        UpdateAll()
    End Sub

    Private Sub copyCSVButton_Click(sender As Object, e As EventArgs) Handles copyCSVButton.Click
        UpdateAll()
        If (Not String.IsNullOrEmpty(outputBox.Text)) Then
            My.Computer.Clipboard.SetText(outputBox.Text)

            tooltip2.AutomaticDelay = Integer.MaxValue
            tooltip2.ToolTipTitle = ""
            tooltip2.UseFading = True
            tooltip2.UseAnimation = True
            tooltip2.IsBalloon = True
            tooltip2.ShowAlways = False
            tooltip2.Show("Copied!", copyCSVButton)
        End If
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles generateButton.Click
        UpdateAll()

        medianList.Clear()
        For i = 0 To nModalUpDown.Value - 1
            medianList.Add(random.Next)
        Next

        cancelButton.Visible = True
        outputBox.Clear()
        outputBoxSorted.Clear()
        sortedValues.Clear()
        values.Clear()
        outputBox.Enabled = False
        outputBoxSorted.Enabled = False
        progressBar.Visible = True
        progressBar.Value = 0
        Dim arbitraryPercentage = 0.95
        For i As Integer = 0 To numPointsUpDown.Value - 1
            If (Not cancel) Then
                If (flatCurveRadio.Checked) Then
                    Dim decimalPercentage = random.Next(minimumDecimalPercentageUpDown.Value, maximumDecimalPercentageUpDown.Value) / 100

                    Dim isDecimaled = (random.NextDouble < decimalPercentage) And decimalPlacesBox.Checked

                    Dim actualNumber As Double
                    actualNumber = minValUpDown.Value + If(maxValUpDown.Value - minValUpDown.Value > 0, random.Next(0, 2), 0) + (random.NextDouble * (maxValUpDown.Value - minValUpDown.Value))
                    actualNumber = Math.Floor(actualNumber)

                    If actualNumber = maxValUpDown.Value And isDecimaled Then
                        actualNumber -= 1
                    End If

                    Dim decimalNumbers = Math.Floor(random.Next(minValUpDown.Value Mod 1 * Math.Pow(10, maximumDecimalPlacesUpDown.Value), Math.Pow(10, maximumDecimalPlacesUpDown.Value + 1) - 1))
                    decimalNumbers /= Math.Pow(10, maximumDecimalPlacesUpDown.Value)

                    Dim final = actualNumber + If(decimalPlacesBox.Checked And maximumDecimalPlacesUpDown.Value > 0 And isDecimaled, decimalNumbers, 0)
                    values.Add(final)
                    outputBox.Text += final & vbNewLine
                Else
                    Dim skewMargin = 0.1
                    Dim skewPoint = skewMargin + random.NextDouble * (0.5 - (skewMargin * 2))
                    If rightButton.Checked Then

                    ElseIf leftButton.Checked Then
                        skewPoint += 0.5
                    ElseIf randomButton.Checked Then
                        skewPoint = random.NextDouble
                    ElseIf noneButton.Checked Then
                        skewPoint = 0.5
                    End If
                End If
                Application.DoEvents()
                    progressBar.Value = arbitraryPercentage * ((i + 1) / numPointsUpDown.Value) * 100

                Else
                    cancel = False
                cancelButton.Visible = False
                progressBar.Visible = False
                outputBox.Clear()
                outputBox.Enabled = True
                outputBoxSorted.Clear()
                outputBoxSorted.Enabled = True
                values.Clear()
                sortedValues.Clear()
                Exit Sub
            End If
        Next

        outputBox.Enabled = True

        sortedValues = values.ToList()
        sortedValues.Sort()
        progressBar.Value = (arbitraryPercentage * 100) + (1 - arbitraryPercentage) * (40 / 100)
        For Each val As Double In sortedValues
            outputBoxSorted.Text += val & vbNewLine
            progressBar.Value = (arbitraryPercentage * 100) + ((1 - arbitraryPercentage) * (outputBoxSorted.Lines.Length / sortedValues.Count) * 100)
            Application.DoEvents()
        Next
        progressBar.Value = 100
        progressBar.Visible = False
        cancelButton.Visible = False
        outputBoxSorted.Enabled = True

        'Time for chart
        UpdateCharts()
        OneVarStats()

    End Sub

    Private Sub MinValUpDown_ValueChanged(sender As Object, e As EventArgs) Handles minValUpDown.ValueChanged
        UpdateAll()
    End Sub

    Private Sub NumPointsUpDown_ValueChanged(sender As Object, e As EventArgs) Handles numPointsUpDown.ValueChanged
        UpdateAll()
    End Sub

    Private Sub MaxValUpDown_ValueChanged(sender As Object, e As EventArgs) Handles maxValUpDown.ValueChanged
        UpdateAll()
    End Sub

    Private Sub SeedBox_TextChanged(sender As Object, e As EventArgs) Handles seedBox.TextChanged
        random = New Random(seedBox.Text.GetHashCode)
        UpdateAll()
    End Sub

    Private Sub MinimumDecimalPlacesUpDown_ValueChanged(sender As Object, e As EventArgs)
        UpdateAll()
    End Sub

    Private Sub BellCurveRadio_CheckedChanged(sender As Object, e As EventArgs) Handles bellCurveRadio.CheckedChanged
        UpdateAll()
        bellCurveRadio.Checked = False
        flatCurveRadio.Checked = True
    End Sub

    Private Sub CopyCSVSortedButton_Click(sender As Object, e As EventArgs) Handles copyCSVSortedButton.Click
        UpdateAll()
        If (Not String.IsNullOrEmpty(outputBoxSorted.Text)) Then
            My.Computer.Clipboard.SetText(outputBoxSorted.Text)

            tooltip2.AutomaticDelay = Integer.MaxValue
            tooltip2.ToolTipTitle = ""
            tooltip2.UseFading = True
            tooltip2.UseAnimation = True
            tooltip2.IsBalloon = True
            tooltip2.ShowAlways = False
            tooltip2.Show("Copied!", copyCSVSortedButton)
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        cancel = True
    End Sub

    Private Sub LeftButton_CheckedChanged(sender As Object, e As EventArgs) Handles leftButton.CheckedChanged
        UpdateAll()
    End Sub

    Private Sub RightButton_CheckedChanged(sender As Object, e As EventArgs) Handles rightButton.CheckedChanged
        UpdateAll()
    End Sub

    Private Sub RandomButton_CheckedChanged(sender As Object, e As EventArgs) Handles randomButton.CheckedChanged
        UpdateAll()
    End Sub

    Private Sub NoneButton_CheckedChanged(sender As Object, e As EventArgs) Handles noneButton.CheckedChanged
        UpdateAll()
    End Sub

    Private Sub ExtremeTrackBar_Scroll(sender As Object, e As EventArgs) Handles extremeTrackBar.Scroll
        UpdateAll()
    End Sub

    Private Sub NModalUpDown_ValueChanged(sender As Object, e As EventArgs) Handles nModalUpDown.ValueChanged
        UpdateAll()
    End Sub

    Private Sub OneVarStats()
        Dim mean = values.Sum / values.Count
        meanLabel.Text = ("Mean  " & mean).Substring(0, Math.Min(15, mean.ToString.Length + 6))
        sumLabel.Text = "Σx  " & values.Sum
        Dim squares As New List(Of Double)
        For Each num In values
            squares.Add(Math.Pow(num, 2))
        Next
        sumSquaresLabel.Text = "Σx²  " & squares.Sum
        Dim stdDev As New List(Of Double)
        For Each num In values
            stdDev.Add(Math.Pow(num - mean, 2))
        Next
        Dim mean2 = stdDev.Sum / stdDev.Count
        stdDevLabel.Text = "σx  " & Math.Pow(mean2, 0.5)


    End Sub

    Private Sub HistogramBarsSlider_Scroll(sender As Object, e As EventArgs) Handles histogramBarsSlider.Scroll
        UpdateAll()
        UpdateCharts()
    End Sub
End Class
