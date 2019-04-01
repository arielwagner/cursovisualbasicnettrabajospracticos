
Public Class ThisWorkbook

    Private Sub ThisWorkbook_Startup() Handles Me.Startup
        ActionsPane.Controls.Add(New RibTool)
    End Sub

    Private Sub ThisWorkbook_Shutdown() Handles Me.Shutdown
        ActionsPane.Dispose()
    End Sub
End Class
