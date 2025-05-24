<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInitial = New System.Windows.Forms.TextBox()
        Me.cmbInitial = New System.Windows.Forms.ComboBox()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.cmbTo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.lblDunit = New System.Windows.Forms.Label()
        Me.lblFpm = New System.Windows.Forms.Label()
        Me.lblDpm = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbDifferenceU = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblSExpected = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rtbResult = New System.Windows.Forms.RichTextBox()
        Me.txtDefaultFileWriter = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSLpercentage = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblVMpercentage = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblFUnit = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.butSinSF = New System.Windows.Forms.Button()
        Me.txtDefaultFileName = New System.Windows.Forms.TextBox()
        Me.butPrintPreview = New System.Windows.Forms.Button()
        Me.butSaveR = New System.Windows.Forms.Button()
        Me.butPrint = New System.Windows.Forms.Button()
        Me.butMoreFunctions = New System.Windows.Forms.Button()
        Me.butReset = New System.Windows.Forms.Button()
        Me.butSolve = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInitial
        '
        Me.txtInitial.Location = New System.Drawing.Point(140, 82)
        Me.txtInitial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInitial.Name = "txtInitial"
        Me.txtInitial.Size = New System.Drawing.Size(175, 20)
        Me.txtInitial.TabIndex = 1
        '
        'cmbInitial
        '
        Me.cmbInitial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInitial.FormattingEnabled = True
        Me.cmbInitial.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32", "64", "128", "256", "512", "1024", "(None)"})
        Me.cmbInitial.Location = New System.Drawing.Point(322, 82)
        Me.cmbInitial.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbInitial.Name = "cmbInitial"
        Me.cmbInitial.Size = New System.Drawing.Size(175, 21)
        Me.cmbInitial.TabIndex = 2
        '
        'cmbFrom
        '
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Items.AddRange(New Object() {"Byte (B)", "Kilobyte (KB)", "Megabyte (MB)", "Gigabyte (GB)", "Terabyte (TB)", "Petabyte (PB)", "Exabyte (EB)", "Zettabyte (ZB)", "Yottabyte (YB)"})
        Me.cmbFrom.Location = New System.Drawing.Point(175, 43)
        Me.cmbFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(170, 21)
        Me.cmbFrom.TabIndex = 1
        '
        'cmbTo
        '
        Me.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Items.AddRange(New Object() {"Byte (B)", "Kilobyte (KB)", "Megabyte (MB)", "Gigabyte (GB)", "Terabyte (TB)", "Petabyte (PB)", "Exabyte (EB)", "Zettabyte (ZB)", "Yottabyte (YB)"})
        Me.cmbTo.Location = New System.Drawing.Point(175, 76)
        Me.cmbTo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(170, 21)
        Me.cmbTo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Initial Storage capacity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(147, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(387, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Common"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "User Defined"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 397)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Storage Difference / Storage Loss"
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifference.Location = New System.Drawing.Point(44, 428)
        Me.lblDifference.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(42, 44)
        Me.lblDifference.TabIndex = 14
        Me.lblDifference.Text = "_"
        '
        'lblDunit
        '
        Me.lblDunit.AutoSize = True
        Me.lblDunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDunit.Location = New System.Drawing.Point(660, 445)
        Me.lblDunit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDunit.Name = "lblDunit"
        Me.lblDunit.Size = New System.Drawing.Size(22, 24)
        Me.lblDunit.TabIndex = 15
        Me.lblDunit.Text = ".."
        '
        'lblFpm
        '
        Me.lblFpm.AutoSize = True
        Me.lblFpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFpm.Location = New System.Drawing.Point(709, 184)
        Me.lblFpm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFpm.Name = "lblFpm"
        Me.lblFpm.Size = New System.Drawing.Size(31, 31)
        Me.lblFpm.TabIndex = 16
        Me.lblFpm.Text = "±"
        '
        'lblDpm
        '
        Me.lblDpm.AutoSize = True
        Me.lblDpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDpm.Location = New System.Drawing.Point(716, 445)
        Me.lblDpm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDpm.Name = "lblDpm"
        Me.lblDpm.Size = New System.Drawing.Size(22, 24)
        Me.lblDpm.TabIndex = 17
        Me.lblDpm.Text = "±"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtInitial)
        Me.GroupBox1.Controls.Add(Me.cmbInitial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 162)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capacity"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbDifferenceU)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbFrom)
        Me.GroupBox2.Controls.Add(Me.cmbTo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 173)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Units"
        '
        'cmbDifferenceU
        '
        Me.cmbDifferenceU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDifferenceU.FormattingEnabled = True
        Me.cmbDifferenceU.Items.AddRange(New Object() {"Byte (B) [Recommended]", "Kilobyte (KB)", "Megabyte (MB)", "Gigabyte (GB)", "Terabyte (TB)", "Petabyte (PB)", "Exabyte (EB)", "Zettabyte (ZB)", "Yottabyte (YB)"})
        Me.cmbDifferenceU.Location = New System.Drawing.Point(175, 109)
        Me.cmbDifferenceU.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDifferenceU.Name = "cmbDifferenceU"
        Me.cmbDifferenceU.Size = New System.Drawing.Size(170, 21)
        Me.cmbDifferenceU.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(105, 115)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Difference"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LinkLabel2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblSExpected)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.rtbResult)
        Me.GroupBox3.Controls.Add(Me.txtDefaultFileWriter)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lblSLpercentage)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblVMpercentage)
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblFinal)
        Me.GroupBox3.Controls.Add(Me.lblFUnit)
        Me.GroupBox3.Controls.Add(Me.lblDpm)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblFpm)
        Me.GroupBox3.Controls.Add(Me.lblDifference)
        Me.GroupBox3.Controls.Add(Me.lblDunit)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(754, 606)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Result"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(160, 18)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(30, 13)
        Me.LinkLabel2.TabIndex = 30
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Note"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 18)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Storage Expected (in Bytes)"
        '
        'lblSExpected
        '
        Me.lblSExpected.AutoSize = True
        Me.lblSExpected.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSExpected.Location = New System.Drawing.Point(44, 53)
        Me.lblSExpected.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSExpected.Name = "lblSExpected"
        Me.lblSExpected.Size = New System.Drawing.Size(51, 55)
        Me.lblSExpected.TabIndex = 28
        Me.lblSExpected.Text = "_"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(674, 77)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 31)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "B"
        '
        'rtbResult
        '
        Me.rtbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbResult.Enabled = False
        Me.rtbResult.Location = New System.Drawing.Point(306, 990)
        Me.rtbResult.Margin = New System.Windows.Forms.Padding(2)
        Me.rtbResult.Name = "rtbResult"
        Me.rtbResult.ReadOnly = True
        Me.rtbResult.Size = New System.Drawing.Size(228, 261)
        Me.rtbResult.TabIndex = 26
        Me.rtbResult.Text = ""
        Me.rtbResult.Visible = False
        '
        'txtDefaultFileWriter
        '
        Me.txtDefaultFileWriter.Enabled = False
        Me.txtDefaultFileWriter.Location = New System.Drawing.Point(311, 690)
        Me.txtDefaultFileWriter.Name = "txtDefaultFileWriter"
        Me.txtDefaultFileWriter.Size = New System.Drawing.Size(173, 205)
        Me.txtDefaultFileWriter.TabIndex = 25
        Me.txtDefaultFileWriter.Text = ""
        Me.txtDefaultFileWriter.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(660, 565)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 24)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "%"
        '
        'lblSLpercentage
        '
        Me.lblSLpercentage.AutoSize = True
        Me.lblSLpercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSLpercentage.Location = New System.Drawing.Point(44, 545)
        Me.lblSLpercentage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSLpercentage.Name = "lblSLpercentage"
        Me.lblSLpercentage.Size = New System.Drawing.Size(42, 44)
        Me.lblSLpercentage.TabIndex = 23
        Me.lblSLpercentage.Text = "_"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 509)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Storage Loss (Percentage)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(658, 303)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 31)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "%"
        '
        'lblVMpercentage
        '
        Me.lblVMpercentage.AutoSize = True
        Me.lblVMpercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVMpercentage.Location = New System.Drawing.Point(44, 286)
        Me.lblVMpercentage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVMpercentage.Name = "lblVMpercentage"
        Me.lblVMpercentage.Size = New System.Drawing.Size(51, 55)
        Me.lblVMpercentage.TabIndex = 20
        Me.lblVMpercentage.Text = "_"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(246, 249)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(30, 13)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Note"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 249)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Value for money / recived storage percentage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 125)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Final Storage capacity"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(44, 160)
        Me.lblFinal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(51, 55)
        Me.lblFinal.TabIndex = 11
        Me.lblFinal.Text = "_"
        '
        'lblFUnit
        '
        Me.lblFUnit.AutoSize = True
        Me.lblFUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFUnit.Location = New System.Drawing.Point(638, 180)
        Me.lblFUnit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFUnit.Name = "lblFUnit"
        Me.lblFUnit.Size = New System.Drawing.Size(32, 31)
        Me.lblFUnit.TabIndex = 12
        Me.lblFUnit.Text = ".."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.butSinSF)
        Me.GroupBox4.Controls.Add(Me.txtDefaultFileName)
        Me.GroupBox4.Controls.Add(Me.butPrintPreview)
        Me.GroupBox4.Controls.Add(Me.butSaveR)
        Me.GroupBox4.Controls.Add(Me.butPrint)
        Me.GroupBox4.Controls.Add(Me.butMoreFunctions)
        Me.GroupBox4.Controls.Add(Me.butReset)
        Me.GroupBox4.Controls.Add(Me.butSolve)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 263)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Controls"
        '
        'butSinSF
        '
        Me.butSinSF.Enabled = False
        Me.butSinSF.Location = New System.Drawing.Point(196, 59)
        Me.butSinSF.Margin = New System.Windows.Forms.Padding(2)
        Me.butSinSF.Name = "butSinSF"
        Me.butSinSF.Size = New System.Drawing.Size(129, 39)
        Me.butSinSF.TabIndex = 1
        Me.butSinSF.Text = "Solve in standard form"
        Me.butSinSF.UseVisualStyleBackColor = True
        '
        'txtDefaultFileName
        '
        Me.txtDefaultFileName.Enabled = False
        Me.txtDefaultFileName.Location = New System.Drawing.Point(203, 570)
        Me.txtDefaultFileName.Name = "txtDefaultFileName"
        Me.txtDefaultFileName.Size = New System.Drawing.Size(100, 20)
        Me.txtDefaultFileName.TabIndex = 8
        Me.txtDefaultFileName.Visible = False
        '
        'butPrintPreview
        '
        Me.butPrintPreview.Enabled = False
        Me.butPrintPreview.Location = New System.Drawing.Point(40, 111)
        Me.butPrintPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.butPrintPreview.Name = "butPrintPreview"
        Me.butPrintPreview.Size = New System.Drawing.Size(129, 39)
        Me.butPrintPreview.TabIndex = 4
        Me.butPrintPreview.Text = "Print Preview"
        Me.butPrintPreview.UseVisualStyleBackColor = True
        '
        'butSaveR
        '
        Me.butSaveR.Enabled = False
        Me.butSaveR.Location = New System.Drawing.Point(352, 111)
        Me.butSaveR.Margin = New System.Windows.Forms.Padding(2)
        Me.butSaveR.Name = "butSaveR"
        Me.butSaveR.Size = New System.Drawing.Size(129, 39)
        Me.butSaveR.TabIndex = 6
        Me.butSaveR.Text = "Save Results in text"
        Me.butSaveR.UseVisualStyleBackColor = True
        '
        'butPrint
        '
        Me.butPrint.Enabled = False
        Me.butPrint.Location = New System.Drawing.Point(196, 111)
        Me.butPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.butPrint.Name = "butPrint"
        Me.butPrint.Size = New System.Drawing.Size(129, 39)
        Me.butPrint.TabIndex = 5
        Me.butPrint.Text = "Print"
        Me.butPrint.UseVisualStyleBackColor = True
        '
        'butMoreFunctions
        '
        Me.butMoreFunctions.Location = New System.Drawing.Point(196, 165)
        Me.butMoreFunctions.Margin = New System.Windows.Forms.Padding(2)
        Me.butMoreFunctions.Name = "butMoreFunctions"
        Me.butMoreFunctions.Size = New System.Drawing.Size(129, 39)
        Me.butMoreFunctions.TabIndex = 7
        Me.butMoreFunctions.Text = "More Functions"
        Me.butMoreFunctions.UseVisualStyleBackColor = True
        '
        'butReset
        '
        Me.butReset.Location = New System.Drawing.Point(352, 59)
        Me.butReset.Margin = New System.Windows.Forms.Padding(2)
        Me.butReset.Name = "butReset"
        Me.butReset.Size = New System.Drawing.Size(129, 39)
        Me.butReset.TabIndex = 2
        Me.butReset.Text = "Reset"
        Me.butReset.UseVisualStyleBackColor = True
        '
        'butSolve
        '
        Me.butSolve.Enabled = False
        Me.butSolve.Location = New System.Drawing.Point(40, 59)
        Me.butSolve.Margin = New System.Windows.Forms.Padding(2)
        Me.butSolve.Name = "butSolve"
        Me.butSolve.Size = New System.Drawing.Size(129, 39)
        Me.butSolve.TabIndex = 0
        Me.butSolve.Text = "Get The Result"
        Me.butSolve.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1278, 606)
        Me.SplitContainer1.SplitterDistance = 520
        Me.SplitContainer1.TabIndex = 10
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Size = New System.Drawing.Size(520, 606)
        Me.SplitContainer2.SplitterDistance = 339
        Me.SplitContainer2.TabIndex = 18
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer3.Size = New System.Drawing.Size(520, 339)
        Me.SplitContainer3.SplitterDistance = 162
        Me.SplitContainer3.TabIndex = 0
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 606)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Electronic storage analysis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtInitial As TextBox
    Friend WithEvents cmbInitial As ComboBox
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDifference As Label
    Friend WithEvents lblDunit As Label
    Friend WithEvents lblFpm As Label
    Friend WithEvents lblDpm As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmbDifferenceU As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblVMpercentage As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblSLpercentage As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDefaultFileWriter As RichTextBox
    Friend WithEvents rtbResult As RichTextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents butPrintPreview As Button
    Friend WithEvents butSaveR As Button
    Friend WithEvents butPrint As Button
    Friend WithEvents butMoreFunctions As Button
    Friend WithEvents butReset As Button
    Friend WithEvents butSolve As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents txtDefaultFileName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblSExpected As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblFUnit As Label
    Friend WithEvents butSinSF As Button
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
