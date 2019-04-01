Public Class RibTool

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        MonthCalendar1.MaxSelectionCount = 7
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub optionCalendarValues()
        MonthCalendar1.MaxSelectionCount = NumericUpDown5.Value
        If RadioButton1.Checked = True Then
            Globals.ThisWorkbook.Worksheets(1).cells(NumericUpDown2.Value, NumericUpDown1.Value).value = MonthCalendar1.SelectionStart.ToShortDateString()
        End If
        If RadioButton2.Checked = True Then
            Globals.ThisWorkbook.Worksheets(1).cells(NumericUpDown2.Value, NumericUpDown1.Value).value = MonthCalendar1.SelectionStart.ToShortDateString() & " - " & _
            MonthCalendar1.SelectionEnd.ToShortDateString()
        End If
        If RadioButton3.Checked = True Then
            Globals.ThisWorkbook.Worksheets(1).cells(NumericUpDown2.Value, NumericUpDown1.Value).value = MonthCalendar1.SelectionStart.ToShortDateString()
            Globals.ThisWorkbook.Worksheets(1).cells(NumericUpDown4.Value, NumericUpDown3.Value).value = MonthCalendar1.SelectionEnd.ToShortDateString()
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        optionCalendarValues()
    End Sub

    Private Sub controlOptions(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        LbC2_1.Visible = CBool(RadioButton3.Checked)
        LbC2_2.Visible = CBool(RadioButton3.Checked)
        NumericUpDown3.Visible = CBool(RadioButton3.Checked)
        NumericUpDown4.Visible = CBool(RadioButton3.Checked)
        LbSelection.Visible = CBool(RadioButton2.Checked) Or CBool(RadioButton3.Checked)
        NumericUpDown5.Visible = CBool(RadioButton2.Checked) Or CBool(RadioButton3.Checked)
    End Sub

    Private Sub MonthCalendar1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MonthCalendar1.MouseDown
        optionCalendarValues()
    End Sub
End Class
