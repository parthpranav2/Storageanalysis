<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversions))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.lblU = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Byte (B)", "Kilobyte (KB)", "Megabyte (MB)", "Gigabyte (GB)", "Terabyte (TB)", "Petabyte (PB)", "Exabyte (EB)", "Zettabyte (ZB)", "Yottabyte (YB)"})
        Me.ListBox1.Location = New System.Drawing.Point(9, 12)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(134, 224)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Note : This calculation are for 1 unit of previous capacity unit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.Location = New System.Drawing.Point(192, 115)
        Me.lblresult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(29, 31)
        Me.lblresult.TabIndex = 2
        Me.lblresult.Text = "_"
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(168, 34)
        Me.txtinput.Margin = New System.Windows.Forms.Padding(2)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(215, 20)
        Me.txtinput.TabIndex = 3
        '
        'lblU
        '
        Me.lblU.AutoSize = True
        Me.lblU.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblU.Location = New System.Drawing.Point(423, 113)
        Me.lblU.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblU.Name = "lblU"
        Me.lblU.Size = New System.Drawing.Size(29, 31)
        Me.lblU.TabIndex = 4
        Me.lblU.Text = "_"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(168, 202)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 34)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmConversions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 251)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblU)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmConversions"
        Me.Text = "frmConversions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblresult As Label
    Friend WithEvents txtinput As TextBox
    Friend WithEvents lblU As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ImageList1 As ImageList
End Class
