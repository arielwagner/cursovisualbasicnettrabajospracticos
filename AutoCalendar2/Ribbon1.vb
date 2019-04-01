Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1

    Private Sub ToggleButton1_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles ToggleButton1.Click
        ToggleButton1.Label = IIf(ToggleButton1.Checked, "Activar", "Desactivar")
        Globals.ThisWorkbook.ActionsPane.Controls.Item(0).Visible = Not ToggleButton1.Checked
    End Sub
End Class
