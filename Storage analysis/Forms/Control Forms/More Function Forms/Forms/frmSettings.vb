Imports System.IO

Public Class frmSettings

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.SaveSource = FolderBrowserDialog1.SelectedPath
            Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Nothing
        My.Settings.SaveSource = Nothing
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.SaveSource
        NumericUpDown1.Value = My.Settings.PFontSize
        If My.Settings.DefaultFileCreation = 0 Then
            CheckBox1.Checked = False
            Label3.Enabled = False
            txtDRFC.Text = Nothing
            butDRFC.Enabled = False
            butDRFCreset.Enabled = False
        ElseIf My.Settings.DefaultFileCreation = 1 Then
            CheckBox1.Checked = True
            Label3.Enabled = True
            butDRFC.Enabled = True
            butDRFCreset.Enabled = True
            txtDRFC.Text = My.Settings.DefaultFileCreatorSource
        Else
        End If
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If NumericUpDown1.Value = Nothing Then
            NumericUpDown1.Value = 16
            My.Settings.PFontSize = 16
            My.Settings.Save()
            DefaultFileSavingSourceCheck()
            MsgBox("Changes Saved", vbOKOnly)
            Me.Close()
        Else
            If NumericUpDown1.Value <= 17 Then
                My.Settings.Save()
                DefaultFileSavingSourceCheck()
                MsgBox("Changes Saved", vbOKOnly)
                Me.Close()
            Else
                MsgBox("The maximum value for font size is 17 so kindly change it")
                NumericUpDown1.Value = 16
            End If

        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NumericUpDown1.Value = 16
        My.Settings.PFontSize = 16
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        My.Settings.PFontSize = NumericUpDown1.Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = Nothing
        My.Settings.SaveSource = Nothing
        NumericUpDown1.Value = 16
        My.Settings.PFontSize = 16
        txtDRFC.Text = Nothing
        My.Settings.DefaultFileCreatorSource = Nothing
        CheckBox1.Checked = False
        My.Settings.DefaultFileCreation = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            My.Settings.DefaultFileCreation = 1
            Label3.Enabled = True
            butDRFC.Enabled = True
            butDRFCreset.Enabled = True
        Else
            My.Settings.DefaultFileCreation = 0
            My.Settings.DefaultFileCreatorSource = Nothing
            Label3.Enabled = False
            butDRFC.Enabled = False
            txtDRFC.Text = Nothing
            butDRFCreset.Enabled = False
        End If
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub butDRFC_Click(sender As Object, e As EventArgs) Handles butDRFC.Click

        If FolderBrowserDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDRFC.Text = FolderBrowserDialog2.SelectedPath
            My.Settings.DefaultFileCreatorSource = FolderBrowserDialog2.SelectedPath
            Dim root As Environment.SpecialFolder = FolderBrowserDialog2.RootFolder
        End If
    End Sub

    Private Sub butDRFCreset_Click(sender As Object, e As EventArgs) Handles butDRFCreset.Click
        txtDRFC.Text = Nothing
        My.Settings.DefaultFileCreatorSource = Nothing
    End Sub

    Private Sub txtDRFC_TextChanged(sender As Object, e As EventArgs) Handles txtDRFC.TextChanged

    End Sub

    Private Sub butPageSetup_Click(sender As Object, e As EventArgs) Handles butPageSetup.Click
        Form1.PageSetupDialog1.Document = Form1.PrintDocument1
        Form1.PageSetupDialog1.Document.DefaultPageSettings.Color = False
        Form1.PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub DefaultFileSavingSourceCheck()
        If CheckBox1.Checked = False Then
            My.Settings.DefaultFileCreation = 0
        ElseIf CheckBox1.Checked = True Then
            My.Settings.DefaultFileCreation = 1

            Dim file As System.IO.StreamWriter

            If My.Settings.DefaultFileCreatorSource = Nothing Then
                file = My.Computer.FileSystem.OpenTextFileWriter("Save Location History" + ".txt", True)
                RichTextBox1.Text = "Default file creation source chnged on " + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + vbNewLine + "New Source : " + Application.StartupPath + " (Application Startup Path)" + vbNewLine
                file.WriteLine("" + RichTextBox1.Text)
                file.Close()

            Else
                file = My.Computer.FileSystem.OpenTextFileWriter("Save Location History" + ".txt", True)
                RichTextBox1.Text = "Default file creation source chnged on " + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + vbNewLine + "New Source : " + My.Settings.DefaultFileCreatorSource + vbNewLine
                file.WriteLine("" + RichTextBox1.Text)
                file.Close()

            End If
        Else

        End If

    End Sub
End Class