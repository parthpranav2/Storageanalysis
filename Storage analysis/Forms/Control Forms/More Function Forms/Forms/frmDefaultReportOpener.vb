Imports System.IO

Public Class frmDefaultReportOpener
    Dim filename1 As String
    Dim additional As Integer
    Private Sub frmDefaultReportOpener_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()

        If My.Settings.DefaultFileCreatorSource = Nothing Then
            SplitContainer5.SplitterDistance = 0
            lblNote.Visible = False
            linkNote.Visible = False
            LinkLabel1.Visible = False

            filename1 = My.Settings.DefaultFileName

            If My.Computer.FileSystem.FileExists(filename1) Then
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(filename1)
                TextBox1.Text = My.Settings.DefaultFileName
            Else
                RichTextBox1.Text = ("File not found. Please Select the file ")
                TextBox1.Text = "Error"
            End If
        Else
            SplitContainer5.SplitterDistance = 81
            lblNote.Visible = True
            linkNote.Visible = True
            LinkLabel1.Visible = True

            filename1 = My.Settings.DefaultFileName

            If My.Computer.FileSystem.FileExists(filename1) Then
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(filename1)
                TextBox1.Text = My.Settings.DefaultFileName
            Else
                RichTextBox1.Text = ("File not found. Please Select the file ")
                TextBox1.Text = "Error"
            End If
        End If

        ListBox1.Items.Clear()

        If My.Settings.DefaultFileCreatorSource = Nothing Then
            For Each filename As String In IO.Directory.GetFiles(Application.StartupPath, "*_diff.txt*")
                ListBox1.Items.Add(Path.GetFileName(filename))

            Next
        Else
            For Each filename As String In IO.Directory.GetFiles(My.Settings.DefaultFileCreatorSource, "*_diff.txt*")
                ListBox1.Items.Add(Path.GetFileName(filename))

            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        additional = 0
        ListBox1.Items.Clear()

        If My.Settings.DefaultFileCreatorSource = Nothing Then
            filename1 = Application.StartupPath + "\" + My.Settings.DefaultFileName
        Else
            filename1 = My.Settings.DefaultFileCreatorSource + "\" + My.Settings.DefaultFileName
        End If

        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(My.Settings.DefaultFileName)
        TextBox1.Text = My.Settings.DefaultFileName
        ListBox1.Items.Clear()

        If My.Settings.DefaultFileCreatorSource = Nothing Then
            For Each filename As String In IO.Directory.GetFiles(Application.StartupPath, "*_diff.txt*")
                ListBox1.Items.Add(Path.GetFileName(filename))

            Next
        Else
            For Each filename As String In IO.Directory.GetFiles(My.Settings.DefaultFileCreatorSource, "*_diff.txt*")
                ListBox1.Items.Add(Path.GetFileName(filename))

            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If My.Settings.DefaultFileCreatorSource = Nothing Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\" + ListBox1.SelectedItem.ToString + "")
            TextBox1.Text = ListBox1.SelectedItem.ToString
        Else
            If additional = 0 Then
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(My.Settings.DefaultFileCreatorSource + "\" + ListBox1.SelectedItem.ToString + "")
                TextBox1.Text = ListBox1.SelectedItem.ToString
            ElseIf additional = 1 Then
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\" + ListBox1.SelectedItem.ToString + "")
                TextBox1.Text = ListBox1.SelectedItem.ToString
            End If
        End If
    End Sub

    Public Sub refresh()
        ListBox1.Items.Clear()

        If My.Settings.DefaultFileCreatorSource = Nothing Then
            For Each filename As String In IO.Directory.GetFiles(Application.StartupPath, "*_diff.txt*")
                ListBox1.Items.Add(Path.GetFileName(filename))

            Next
        Else
            For Each filename As String In IO.Directory.GetFiles(My.Settings.DefaultFileCreatorSource, "*_diff.txt*")
                ListBox1.Items.Add(Path.GetFileName(filename))

            Next
        End If
    End Sub

    Private Sub linkNote_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkNote.LinkClicked
        ListBox1.Items.Clear()
        For Each filename As String In IO.Directory.GetFiles(Application.StartupPath, "*_diff.txt*")
            ListBox1.Items.Add(Path.GetFileName(filename))
            additional = 1
        Next
        MsgBox("The file list below has been updated")

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "\" + "Save Location History" + ".txt") Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\" + "Save Location History" + ".txt")
            TextBox1.Text = "History Saver File"
        Else
            RichTextBox1.Text = ("File did not found. Please try again later ")
            TextBox1.Text = "History File Error"
        End If
    End Sub
End Class