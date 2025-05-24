Public Class Form1
    Dim From As Integer
    Dim Too As Integer
    Dim a As Integer
    Dim b As Integer
    Dim thousands As Decimal
    Dim num As Integer
    Dim final1 As Decimal
    Dim difference As Decimal
    Dim final As Decimal
    Dim initial As Integer
    Dim difference1 As Decimal

    Dim VIndustry As Decimal
    Dim Vsi As Decimal
    Dim VMP As Decimal
    Dim SLP As Decimal

    Dim filename As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInitial.SelectedIndexChanged
        If cmbInitial.Text = Nothing Or Me.cmbInitial.SelectedIndex = 11 Then
            txtInitial.Enabled = True
        Else
            txtInitial.Enabled = False
            initial = Val(cmbInitial.Text)
        End If
    End Sub

    Private Sub txtInitial_TextChanged(sender As Object, e As EventArgs) Handles txtInitial.TextChanged
        If txtInitial.Text = Nothing Then
            cmbInitial.Enabled = True
        Else
            cmbInitial.Enabled = False
            initial = Val(txtInitial.Text)
        End If

    End Sub

    Private Sub cmbFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFrom.SelectedIndexChanged
        If Me.cmbFrom.SelectedIndex = 0 Then
            From = 0
            If cmbTo.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbFrom.SelectedIndex = 1 Then
            From = 1
            If cmbTo.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbFrom.SelectedIndex = 2 Then
            From = 2
            If cmbTo.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbFrom.SelectedIndex = 3 Then
            From = 3
            If cmbTo.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbFrom.SelectedIndex = 4 Then
            From = 4
            If cmbTo.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbFrom.SelectedIndex = 5 Then
            From = 5
            If cmbTo.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbFrom.SelectedIndex = 6 Then
            From = 6
            If cmbTo.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbFrom.SelectedIndex = 7 Then
            From = 7
            If cmbTo.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbFrom.SelectedIndex = 8 Then
            From = 8
            If cmbTo.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = My.Settings.FormSize
        cmbDifferenceU.SelectedIndex = 0
    End Sub

    Private Sub cmbTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTo.SelectedIndexChanged
        If Me.cmbTo.SelectedIndex = 0 Then
            Too = 0
            If cmbFrom.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbTo.SelectedIndex = 1 Then
            Too = 1
            If cmbFrom.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbTo.SelectedIndex = 2 Then
            Too = 2
            If cmbFrom.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbTo.SelectedIndex = 3 Then
            Too = 3
            If cmbFrom.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbTo.SelectedIndex = 4 Then
            Too = 4
            If cmbFrom.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbTo.SelectedIndex = 5 Then
            Too = 5
            If cmbFrom.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbTo.SelectedIndex = 6 Then
            Too = 6
            If cmbFrom.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbTo.SelectedIndex = 7 Then
            Too = 7
            If cmbFrom.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        ElseIf Me.cmbTo.SelectedIndex = 8 Then
            Too = 8
            If cmbFrom.Text = Nothing Or (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Then
            Else
                ButEnabler()
            End If
        End If
    End Sub

    Private Sub butSolve_Click(sender As Object, e As EventArgs) Handles butSolve.Click
        Calculations()
        DefaultFileSavingWriter()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butReset.Click
        butSolve.Enabled = False
        butPrint.Enabled = False
        butSaveR.Enabled = False
        txtInitial.Text = Nothing
        cmbInitial.Text = Nothing
        cmbFrom.Text = Nothing
        cmbTo.Text = Nothing
        butSinSF.Enabled = False
        lblDpm.Visible = True
        cmbDifferenceU.SelectedIndex = 0
        lblFinal.Text = "_"
        lblFUnit.Text = ".."
        lblDifference.Text = "_"
        lblDunit.Text = ".."
        lblVMpercentage.Text = "_"
        lblSLpercentage.Text = "_"
        lblSExpected.Text = "_"

        From = Nothing
        Too = Nothing
        Vsi = Nothing
        VIndustry = Nothing
        a = Nothing
        b = Nothing
        thousands = Nothing
        num = Nothing
        final1 = Nothing
        difference = Nothing
        final = Nothing
        difference1 = Nothing
        initial = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles butMoreFunctions.Click
        My.Settings.Save()
        If (txtInitial.Text = Nothing And cmbInitial.Text = Nothing) Or cmbFrom.Text = Nothing Or cmbTo.Text = Nothing Or cmbDifferenceU.Text = Nothing Then
            MsgBox("All the functions may not be available as the calculations are remaining", vbExclamation + vbOKOnly)
            frmMoreFunctions.Show()
        Else
            Calculations()
            DefaultFileSavingWriter()
            frmMoreFunctions.Show()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles butSaveR.Click
        Calculations()
        frmTXTCreator.Show()
        DefaultFileSavingWriter()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        frmConversions.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) 
        frmConversions.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("The percentage of value for money is subjected for only storage ", vbExclamation)

    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If My.Settings.PFontSize = Nothing Or My.Settings.PFontSize = 16 Then
            Dim font As New Font("Consolas", 16, FontStyle.Regular)
            e.Graphics.DrawString(rtbResult.Text, font, Brushes.Black, 100, 100)
        Else
            Dim font As New Font("Consolas", My.Settings.PFontSize, FontStyle.Regular)
            e.Graphics.DrawString(rtbResult.Text, font, Brushes.Black, 100, 100)
        End If
    End Sub

    Private Sub rtbResult_TextChanged(sender As Object, e As EventArgs) Handles rtbResult.TextChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles butPrint.Click
        Calculations()
        DefaultFileSavingWriter()
        If txtInitial.Text = Nothing And cmbInitial.Text = Nothing Or cmbFrom.Text = Nothing Or cmbTo.Text = Nothing Or cmbDifferenceU.Text = Nothing Or lblFinal.Text = "_" Or lblDifference.Text = "_" Then
            PrintResult()
        Else
            PrintResult()

            PrintDialog1.Document = PrintDocument1
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PrintDocument1.Print()
            End If
        End If

    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles butPrintPreview.Click
        Calculations()
        If txtInitial.Text = Nothing And cmbInitial.Text = Nothing Or cmbFrom.Text = Nothing Or cmbTo.Text = Nothing Or cmbDifferenceU.Text = Nothing Or lblFinal.Text = "_" Or lblDifference.Text = "_" Then
            PrintResult()
        Else
            PrintResult()

            PrintPreviewDialog1.ShowDialog()
        End If

    End Sub
    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        If My.Settings.DefaultFileCreatorSource = Nothing Then
            System.Diagnostics.Process.Start("" + filename)
        Else
            System.Diagnostics.Process.Start("" + filename)
        End If

    End Sub







    Private Sub Calculations()
        IndustrialStorageCalculation()

        StorageExpected()

        If From = 0 And Too = 0 Then
            final = initial
        Else
            final1 = (initial * 1000 ^ From) / 1024 ^ From
            If From > Too Then
                num = From - Too
                thousands = 1024 ^ num
                final = final1 * thousands
                lblDunit.Text = ("B")
            ElseIf From = Too Then
                final = final1
                lblDunit.Text = ("B")
            ElseIf From < Too Then
                num = Too - From
                thousands = 1024 ^ num
                final = final1 / thousands
                lblDunit.Text = ("B")
            End If
        End If

        DifferenceCalculating()

        UnitsDisplaying()

        PercentageCalculation()

        OutputDisplaying()
    End Sub

    Private Sub UnitsDisplaying()

        If cmbDifferenceU.SelectedIndex = 0 Then
            lblDunit.Text = ("B")
        ElseIf cmbDifferenceU.SelectedIndex = 1 Then
            lblDunit.Text = ("KB")
        ElseIf cmbDifferenceU.SelectedIndex = 2 Then
            lblDunit.Text = ("MB")
        ElseIf cmbDifferenceU.SelectedIndex = 3 Then
            lblDunit.Text = ("GB")
        ElseIf cmbDifferenceU.SelectedIndex = 4 Then
            lblDunit.Text = ("TB")
        ElseIf cmbDifferenceU.SelectedIndex = 5 Then
            lblDunit.Text = ("PB")
        ElseIf cmbDifferenceU.SelectedIndex = 6 Then
            lblDunit.Text = ("EB")
        ElseIf cmbDifferenceU.SelectedIndex = 7 Then
            lblDunit.Text = ("ZB")
        ElseIf cmbDifferenceU.SelectedIndex = 8 Then
            lblDunit.Text = ("YB")
        End If

        If cmbTo.SelectedIndex = 0 Then
            lblFUnit.Text = "B"

        ElseIf cmbTo.SelectedIndex = 1 Then
            lblFUnit.Text = "KB"

        ElseIf cmbTo.SelectedIndex = 2 Then
            lblFUnit.Text = "MB"

        ElseIf cmbTo.SelectedIndex = 3 Then
            lblFUnit.Text = "GB"

        ElseIf cmbTo.SelectedIndex = 4 Then
            lblFUnit.Text = "TB"

        ElseIf cmbTo.SelectedIndex = 5 Then
            lblFUnit.Text = "PB"

        ElseIf cmbTo.SelectedIndex = 6 Then
            lblFUnit.Text = "EB"

        ElseIf cmbTo.SelectedIndex = 7 Then
            lblFUnit.Text = "ZB"

        ElseIf cmbTo.SelectedIndex = 8 Then
            lblFUnit.Text = "YB"

        End If

    End Sub

    Private Sub DifferenceCalculating()

        difference = (initial * (1024 ^ From)) - (initial * (1000 ^ From))

        If cmbDifferenceU.SelectedIndex = 0 Then
            difference1 = difference
        ElseIf cmbDifferenceU.SelectedIndex > 0 Then
            difference1 = difference / (1024 ^ cmbDifferenceU.SelectedIndex)
        End If

    End Sub

    Private Sub PercentageCalculation()
        VMP = (VIndustry / Vsi) * 100
        SLP = 100 - VMP
    End Sub

    Private Sub IndustrialStorageCalculation()
        VIndustry = initial * (1000 ^ From)
    End Sub

    Private Sub OutputDisplaying()
        lblSLpercentage.Text = Val(SLP)
        lblVMpercentage.Text = Val(VMP)
        lblDifference.Text = difference1
        lblFinal.Text = Val(final)
        lblSExpected.Text = Val(Vsi)
    End Sub


    Private Sub StorageExpected()
        If From = 0 Then
            Vsi = initial
        ElseIf From > 0 And From <= 8 Then
            Vsi = initial * (1024 ^ From)
        Else

        End If
    End Sub

    Private Sub DefaultFileSaving()
        Dim file As System.IO.StreamWriter

        If My.Settings.DefaultFileCreatorSource = Nothing Then
            file = My.Computer.FileSystem.OpenTextFileWriter("" + DateTime.Now.ToString("dd-MM-yyyy") + "_diff" + ".txt", True)

            filename = Application.StartupPath + "\" + DateTime.Now.ToString("dd-MM-yyyy") + "_diff" + ".txt"
            My.Settings.DefaultFileName = filename
            txtDefaultFileName.Text = filename

            file.WriteLine("" + txtDefaultFileWriter.Text)
            file.Close()

        Else
            file = My.Computer.FileSystem.OpenTextFileWriter("" + My.Settings.DefaultFileCreatorSource + "\" + DateTime.Now.ToString("dd-MM-yyyy") + "_diff" + ".txt", True)

            filename = "" + My.Settings.DefaultFileCreatorSource + "\" + DateTime.Now.ToString("dd-MM-yyyy") + "_diff" + ".txt"
            My.Settings.DefaultFileName = filename
            txtDefaultFileName.Text = filename

            file.WriteLine("" + txtDefaultFileWriter.Text)
            file.Close()

        End If
    End Sub

    Private Sub DefaultFileSavingWriter()
        If My.Settings.DefaultFileCreation = 1 Then
            If cmbInitial.Text = Nothing Then
                txtDefaultFileWriter.Text = (vbNewLine + vbNewLine + "" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + vbNewLine + vbNewLine + vbNewLine + "Inputs" + vbNewLine + vbNewLine + "Initial Storage : " + txtInitial.Text + " " + cmbFrom.Text + vbNewLine + vbNewLine + "Result" + vbNewLine + vbNewLine + "Storage Expected : " + lblSExpected.Text + " B" + vbNewLine + vbNewLine + "Storage Recived : " + lblFinal.Text + " " + lblFUnit.Text + " ±" + vbNewLine + vbNewLine + Label9.Text + " :" + vbNewLine + lblVMpercentage.Text + " %" + vbNewLine + vbNewLine + "Difference / Storage Loss : " + lblDifference.Text + " " + lblDunit.Text + " ±" + vbNewLine + vbNewLine + Label10.Text + " :" + vbNewLine + lblSLpercentage.Text + " %" + vbNewLine + "-------------------------------------------------")
                DefaultFileSaving()
                NotifyIcon1.ShowBalloonTip(3000, "Storage Analysis", "Default report updated", ToolTipIcon.Info)
            ElseIf txtInitial.Text = Nothing Then
                txtDefaultFileWriter.Text = (vbNewLine + vbNewLine + "" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + vbNewLine + vbNewLine + vbNewLine + "Inputs" + vbNewLine + vbNewLine + "Initial Storage : " + cmbInitial.Text + " " + cmbFrom.Text + vbNewLine + vbNewLine + "Result" + vbNewLine + vbNewLine + "Storage Expected : " + lblSExpected.Text + " B" + vbNewLine + vbNewLine + "Storage Recived : " + lblFinal.Text + " " + lblFUnit.Text + " ±" + vbNewLine + vbNewLine + Label9.Text + " :" + vbNewLine + lblVMpercentage.Text + " %" + vbNewLine + vbNewLine + "Difference / Storage Loss : " + lblDifference.Text + " " + lblDunit.Text + " ±" + vbNewLine + vbNewLine + Label10.Text + " :" + vbNewLine + lblSLpercentage.Text + " %" + vbNewLine + "-------------------------------------------------")
                DefaultFileSaving()
                NotifyIcon1.ShowBalloonTip(3000, "Storage Analysis", "Default report updated", ToolTipIcon.Info)
            Else
            End If
        ElseIf My.Settings.DefaultFileCreation = 0 Then

        Else
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles butSinSF.Click
        Too = 0
        cmbTo.SelectedIndex = 0
        cmbDifferenceU.SelectedIndex = 0

        Calculations()
    End Sub

    Private Sub PrintResult()
        If txtInitial.Text = Nothing And cmbInitial.Text = Nothing Or cmbFrom.Text = Nothing Or cmbTo.Text = Nothing Or cmbDifferenceU.Text = Nothing Or lblFinal.Text = "_" Or lblDifference.Text = "_" Then
            MsgBox("Some of the fields are left empty or you have not pressed the button " + butSolve.Text + " which is resulting into insufficient data which cannot be printed")
        Else
            MsgBox("Please do not print the results if they are not required")

            If cmbInitial.Text = Nothing Then
                rtbResult.Text = ("This document is printed by Storage Analysis (2020)" + vbNewLine + "" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm") + vbNewLine + vbNewLine + "Inputs" + vbNewLine + vbNewLine + vbNewLine + "Initial Storage : " + txtInitial.Text + " " + cmbFrom.Text + vbNewLine + vbNewLine + vbNewLine + "Result" + vbNewLine + vbNewLine + vbNewLine + "Storage Expected : " + lblSExpected.Text + " B" + vbNewLine + vbNewLine + "Storage Recived : " + lblFinal.Text + " " + lblFUnit.Text + " ±" + vbNewLine + vbNewLine + Label9.Text + " :" + vbNewLine + lblVMpercentage.Text + " %" + vbNewLine + vbNewLine + vbNewLine + vbNewLine + "Difference / Storage Loss : " + lblDifference.Text + " " + lblDunit.Text + " ±" + vbNewLine + vbNewLine + Label10.Text + " :" + vbNewLine + lblSLpercentage.Text + " %" + vbNewLine + vbNewLine + vbNewLine + vbNewLine + "Note : The percentage of value for money is subjected" + vbNewLine + "for only storage.")
            ElseIf txtInitial.Text = Nothing Then
                rtbResult.Text = ("This document is printed by Storage Analysis (2020)" + vbNewLine + "" + DateTime.Now.ToString("dd-MM-yyyy_hh-mm") + vbNewLine + vbNewLine + "Inputs" + vbNewLine + vbNewLine + vbNewLine + "Initial Storage : " + cmbInitial.Text + " " + cmbFrom.Text + vbNewLine + vbNewLine + vbNewLine + "Result" + vbNewLine + vbNewLine + vbNewLine + "Storage Expected : " + lblSExpected.Text + " B" + vbNewLine + vbNewLine + "Storage Recived : " + lblFinal.Text + " " + lblFUnit.Text + " ±" + vbNewLine + vbNewLine + Label9.Text + " :" + vbNewLine + lblVMpercentage.Text + " %" + vbNewLine + vbNewLine + +vbNewLine + vbNewLine + "Difference / Storage Loss : " + lblDifference.Text + " " + lblDunit.Text + " ±" + vbNewLine + vbNewLine + Label10.Text + " :" + vbNewLine + lblSLpercentage.Text + " %" + vbNewLine + vbNewLine + vbNewLine + vbNewLine + "Note : The percentage of value for money is subjected" + vbNewLine + "for only storage.")
            Else
            End If
        End If

    End Sub

    Private Sub ButEnabler()
        butSolve.Enabled = True
        butPrint.Enabled = True
        butSinSF.Enabled = True
        butSaveR.Enabled = True
        butPrintPreview.Enabled = True
    End Sub

    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MsgBox("Storage expected is only for Bytes because to give exact value of storage in the standard format", +vbExclamation)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

    End Sub

    Private Sub Form1_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
        My.Settings.FormSize = Me.Size()
        My.Settings.Save()
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        My.Settings.FormSize = Me.Size()
        My.Settings.Save()
    End Sub
End Class
