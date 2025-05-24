Public Class frmTXTCreator

    Dim filenameP As String
    Dim filename As String
    Private Sub frmTXTCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NameDefiner()

    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click
        Dim file As System.IO.StreamWriter

        If txtNote.Text = Nothing Then
            If My.Settings.SaveSource = Nothing Then
                file = My.Computer.FileSystem.OpenTextFileWriter("" + txtFName.Text + ".txt", True)

                filename = txtFName.Text + ".txt"

                file.WriteLine("" + rtbResult.Text)
                file.Close()

                NotifyIcon1.ShowBalloonTip(3000, "Storage Analysis", "Your desired report created", ToolTipIcon.Info)

                MsgBox("File is Saved", +vbOKOnly)
            Else
                file = My.Computer.FileSystem.OpenTextFileWriter("" + My.Settings.SaveSource + "\" + txtFName.Text + ".txt", True)

                filename = "" + My.Settings.SaveSource + "\" + txtFName.Text + ".txt"

                file.WriteLine("" + rtbResult.Text)
                file.Close()

                NotifyIcon1.ShowBalloonTip(3000, "Storage Analysis", "Your desired report created", ToolTipIcon.Info)

                MsgBox("File is Saved", +vbOKOnly)

            End If
        Else
            MsgBox("Attention : The Note box is having some text in it which is not applied yet so kindly click on " + Button1.Text + " button to add it in the document or click on " + Button2.Text + " to clear it.", vbOKOnly + vbExclamation)
        End If

    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        System.Diagnostics.Process.Start("" + filename)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim note As String

        If txtNote.Text = Nothing Then

        Else
            MsgBox("Attention : The note will be applied to the document once clicked on " + Button1.Text + " and the action cannot be reversed." + vbNewLine + "To clear the note applied click on " + Button2.Text + " button", vbOKOnly)

            note = txtNote.Text

            rtbResult.Text = rtbResult.Text + vbNewLine + vbNewLine + "Note : " + note

            txtNote.Text = Nothing
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub NameDefiner()

        filenameP = DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss")
        If Form1.cmbInitial.Text = Nothing Then
            rtbResult.Text = ("This document is saved by Storage Analysis (2020)" + vbNewLine + "" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm") + vbNewLine + vbNewLine + "Inputs" + vbNewLine + vbNewLine + vbNewLine + "Storage Expected : " + Form1.lblSExpected.Text + " B" + vbNewLine + vbNewLine + "Storage Recived : " + Form1.txtInitial.Text + " " + Form1.cmbFrom.Text + vbNewLine + vbNewLine + vbNewLine + "Result" + vbNewLine + vbNewLine + vbNewLine + "Final Storage : " + Form1.lblFinal.Text + " " + Form1.lblFUnit.Text + " ±" + vbNewLine + vbNewLine + Form1.Label9.Text + " :" + vbNewLine + Form1.lblVMpercentage.Text + " %" + vbNewLine + vbNewLine + "Difference / Storage Loss : " + Form1.lblDifference.Text + " " + Form1.lblDunit.Text + " ±" + vbNewLine + vbNewLine + Form1.Label10.Text + " :" + vbNewLine + Form1.lblSLpercentage.Text + " %" + vbNewLine + vbNewLine + vbNewLine + vbNewLine + "Attention : The percentage of value for money is subjected" + vbNewLine + "for only storage.")
        ElseIf Form1.txtInitial.Text = Nothing Then
            rtbResult.Text = ("This document is saved by Storage Analysis (2020)" + vbNewLine + "" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm") + vbNewLine + vbNewLine + "Inputs" + vbNewLine + vbNewLine + vbNewLine + "Storage Expected : " + Form1.lblSExpected.Text + " B" + vbNewLine + vbNewLine + "Storage Recived : " + Form1.txtInitial.Text + " " + Form1.cmbFrom.Text + vbNewLine + vbNewLine + vbNewLine + "Result" + vbNewLine + vbNewLine + vbNewLine + "Final Storage : " + Form1.lblFinal.Text + " " + Form1.lblFUnit.Text + " ±" + vbNewLine + vbNewLine + Form1.Label9.Text + " :" + vbNewLine + Form1.lblVMpercentage.Text + " %" + vbNewLine + vbNewLine + "Difference / Storage Loss : " + Form1.lblDifference.Text + " " + Form1.lblDunit.Text + " ±" + vbNewLine + vbNewLine + Form1.Label10.Text + " :" + vbNewLine + Form1.lblSLpercentage.Text + " %" + vbNewLine + vbNewLine + vbNewLine + vbNewLine + "Attention : The percentage of value for money is subjected" + vbNewLine + "for only storage.")
        Else
            End If

        txtFName.Text = filenameP
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Attention : The note applied will be cleared permanantly !", vbOKOnly)

        NameDefiner()

        txtNote.Text = Nothing

    End Sub

End Class