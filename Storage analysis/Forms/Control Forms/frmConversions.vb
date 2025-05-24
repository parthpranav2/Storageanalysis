Public Class frmConversions
    Dim out As Decimal
    Dim Inn As Decimal
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If txtinput.Text = Nothing Then
            If ListBox1.SelectedIndex = 0 Then
                lblU.Visible = False
                lblresult.Text = "8 Bits"
            ElseIf ListBox1.SelectedIndex = 1 Then
                lblU.Visible = False
                lblresult.Text = "1024 Bytes"
            ElseIf ListBox1.SelectedIndex = 2 Then
                lblU.Visible = False
                lblresult.Text = "1024 Kilobytes"
            ElseIf ListBox1.SelectedIndex = 3 Then
                lblU.Visible = False
                lblresult.Text = "1024 Megabytes"
            ElseIf ListBox1.SelectedIndex = 4 Then
                lblU.Visible = False
                lblresult.Text = "1024 Gigabytes"
            ElseIf ListBox1.SelectedIndex = 5 Then
                lblU.Visible = False
                lblresult.Text = "1024 Terabytes"
            ElseIf ListBox1.SelectedIndex = 6 Then
                lblU.Visible = False
                lblresult.Text = "1024 Petabytes"
            ElseIf ListBox1.SelectedIndex = 7 Then
                lblU.Visible = False
                lblresult.Text = "1024 Exabytes"
            ElseIf ListBox1.SelectedIndex = 8 Then
                lblU.Visible = False
                lblresult.Text = "1024 Zettabytes"
            End If

        Else
            If ListBox1.SelectedIndex = 0 Then
                lblU.Visible = True
                lblU.Text = "Bits"
                out = txtinput.Text * 8
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 1 Then
                lblU.Visible = True
                lblU.Text = "Bytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 2 Then
                lblU.Visible = True
                lblU.Text = "Kilobytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 3 Then
                lblU.Visible = True
                lblU.Text = "Megabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 4 Then
                lblU.Visible = True
                lblU.Text = "Gigabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 5 Then
                lblU.Visible = True
                lblU.Text = "Terabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 6 Then
                lblU.Visible = True
                lblU.Text = "Petabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 7 Then
                lblU.Visible = True
                lblU.Text = "Exabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 8 Then
                lblU.Visible = True
                lblU.Text = "Zettabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            End If
        End If
    End Sub

    Private Sub frmConversions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtinput_TextChanged(sender As Object, e As EventArgs) Handles txtinput.TextChanged
        If txtinput.Text = Nothing Then
            If ListBox1.SelectedIndex = 0 Then
                lblU.Visible = False
                lblresult.Text = "8 Bits"
            ElseIf ListBox1.SelectedIndex = 1 Then
                lblU.Visible = False
                lblresult.Text = "1024 Bytes"
            ElseIf ListBox1.SelectedIndex = 2 Then
                lblU.Visible = False
                lblresult.Text = "1024 Kilobytes"
            ElseIf ListBox1.SelectedIndex = 3 Then
                lblU.Visible = False
                lblresult.Text = "1024 Megabytes"
            ElseIf ListBox1.SelectedIndex = 4 Then
                lblU.Visible = False
                lblresult.Text = "1024 Gigabytes"
            ElseIf ListBox1.SelectedIndex = 5 Then
                lblU.Visible = False
                lblresult.Text = "1024 Terabytes"
            ElseIf ListBox1.SelectedIndex = 6 Then
                lblU.Visible = False
                lblresult.Text = "1024 Petabytes"
            ElseIf ListBox1.SelectedIndex = 7 Then
                lblU.Visible = False
                lblresult.Text = "1024 Exabytes"
            ElseIf ListBox1.SelectedIndex = 8 Then
                lblU.Visible = False
                lblresult.Text = "1024 Zettabytes"
            End If

        Else
            If ListBox1.SelectedIndex = 0 Then
                lblU.Visible = True
                lblU.Text = "Bits"
                out = txtinput.Text * 8
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 1 Then
                lblU.Visible = True
                lblU.Text = "Bytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 2 Then
                lblU.Visible = True
                lblU.Text = "Kilobytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 3 Then
                lblU.Visible = True
                lblU.Text = "Megabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 4 Then
                lblU.Visible = True
                lblU.Text = "Gigabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 5 Then
                lblU.Visible = True
                lblU.Text = "Terabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 6 Then
                lblU.Visible = True
                lblU.Text = "Petabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 7 Then
                lblU.Visible = True
                lblU.Text = "Exabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            ElseIf ListBox1.SelectedIndex = 8 Then
                lblU.Visible = True
                lblU.Text = "Zettabytes"
                out = txtinput.Text * 1024
                lblresult.Text = out
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.SelectedIndex = Nothing
        txtinput.Text = Nothing
        lblresult.Text = "_"
        lblU.Text = "_"
    End Sub
End Class