Public Class frmMoreFunctions
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        frmConversions.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSettings.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmAboutUs.Show()

    End Sub

    Private Sub butPageSetup_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub butUC_Click(sender As Object, e As EventArgs) Handles butUC.Click
        frmConversions.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("DiskInfo.exe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmDefaultReportOpener.refresh()
        frmDefaultReportOpener.Show()

    End Sub
End Class