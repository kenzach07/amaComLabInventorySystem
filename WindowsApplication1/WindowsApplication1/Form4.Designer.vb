<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Label2 As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim PRODUCTLabel As System.Windows.Forms.Label
        Dim PRICELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.FUCKTHISSHIT1DataSet1 = New WindowsApplication1.FUCKTHISSHIT1DataSet1()
        Me.COMLAB1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMLAB1TableAdapter = New WindowsApplication1.FUCKTHISSHIT1DataSet1TableAdapters.COMLAB1TableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.FUCKTHISSHIT1DataSet1TableAdapters.TableAdapterManager()
        Me.PRODUCT_CODETextBox = New System.Windows.Forms.TextBox()
        Me.MANUFACTURERTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCTTextBox = New System.Windows.Forms.TextBox()
        Me.PRICETextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_ADDEDTextBox = New System.Windows.Forms.TextBox()
        Me.STATUSTextBox = New System.Windows.Forms.TextBox()
        Me.COMLAB1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        PRODUCTLabel = New System.Windows.Forms.Label()
        PRICELabel = New System.Windows.Forms.Label()
        CType(Me.FUCKTHISSHIT1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMLAB1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMLAB1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(231, 312)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(62, 16)
        Label2.TabIndex = 62
        Label2.Text = "STATUS:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Transparent
        IDLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.Color.White
        IDLabel.Location = New System.Drawing.Point(209, 107)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(95, 16)
        IDLabel.TabIndex = 58
        IDLabel.Text = "PRODUCT_ID:"
        '
        'PRODUCTLabel
        '
        PRODUCTLabel.AutoSize = True
        PRODUCTLabel.BackColor = System.Drawing.Color.Transparent
        PRODUCTLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PRODUCTLabel.ForeColor = System.Drawing.Color.White
        PRODUCTLabel.Location = New System.Drawing.Point(227, 207)
        PRODUCTLabel.Name = "PRODUCTLabel"
        PRODUCTLabel.Size = New System.Drawing.Size(74, 16)
        PRODUCTLabel.TabIndex = 59
        PRODUCTLabel.Text = "PRODUCT:"
        '
        'PRICELabel
        '
        PRICELabel.AutoSize = True
        PRICELabel.BackColor = System.Drawing.Color.Transparent
        PRICELabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PRICELabel.ForeColor = System.Drawing.Color.White
        PRICELabel.Location = New System.Drawing.Point(242, 261)
        PRICELabel.Name = "PRICELabel"
        PRICELabel.Size = New System.Drawing.Size(51, 16)
        PRICELabel.TabIndex = 60
        PRICELabel.Text = "PRICE:"
        '
        'FUCKTHISSHIT1DataSet1
        '
        Me.FUCKTHISSHIT1DataSet1.DataSetName = "FUCKTHISSHIT1DataSet1"
        Me.FUCKTHISSHIT1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMLAB1BindingSource
        '
        Me.COMLAB1BindingSource.DataMember = "COMLAB1"
        Me.COMLAB1BindingSource.DataSource = Me.FUCKTHISSHIT1DataSet1
        '
        'COMLAB1TableAdapter
        '
        Me.COMLAB1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.COMLAB1TableAdapter = Me.COMLAB1TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.FUCKTHISSHIT1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PRODUCT_CODETextBox
        '
        Me.PRODUCT_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "PRODUCT_CODE", True))
        Me.PRODUCT_CODETextBox.Location = New System.Drawing.Point(310, 103)
        Me.PRODUCT_CODETextBox.Name = "PRODUCT_CODETextBox"
        Me.PRODUCT_CODETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_CODETextBox.TabIndex = 2
        '
        'MANUFACTURERTextBox
        '
        Me.MANUFACTURERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "MANUFACTURER", True))
        Me.MANUFACTURERTextBox.Location = New System.Drawing.Point(310, 153)
        Me.MANUFACTURERTextBox.Name = "MANUFACTURERTextBox"
        Me.MANUFACTURERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MANUFACTURERTextBox.TabIndex = 4
        '
        'PRODUCTTextBox
        '
        Me.PRODUCTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "PRODUCT", True))
        Me.PRODUCTTextBox.Location = New System.Drawing.Point(310, 204)
        Me.PRODUCTTextBox.Name = "PRODUCTTextBox"
        Me.PRODUCTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCTTextBox.TabIndex = 6
        '
        'PRICETextBox
        '
        Me.PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "PRICE", True))
        Me.PRICETextBox.Location = New System.Drawing.Point(310, 255)
        Me.PRICETextBox.Name = "PRICETextBox"
        Me.PRICETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRICETextBox.TabIndex = 8
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(309, 67)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUANTITYTextBox.TabIndex = 10
        '
        'DATE_ADDEDTextBox
        '
        Me.DATE_ADDEDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "DATE ADDED", True))
        Me.DATE_ADDEDTextBox.Location = New System.Drawing.Point(190, 67)
        Me.DATE_ADDEDTextBox.Name = "DATE_ADDEDTextBox"
        Me.DATE_ADDEDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DATE_ADDEDTextBox.TabIndex = 12
        '
        'STATUSTextBox
        '
        Me.STATUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "STATUS", True))
        Me.STATUSTextBox.Location = New System.Drawing.Point(310, 308)
        Me.STATUSTextBox.Name = "STATUSTextBox"
        Me.STATUSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.STATUSTextBox.TabIndex = 14
        '
        'COMLAB1DataGridView
        '
        Me.COMLAB1DataGridView.AutoGenerateColumns = False
        Me.COMLAB1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.COMLAB1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.COMLAB1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.COMLAB1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.COMLAB1DataGridView.DataSource = Me.COMLAB1BindingSource
        Me.COMLAB1DataGridView.Location = New System.Drawing.Point(449, 92)
        Me.COMLAB1DataGridView.Name = "COMLAB1DataGridView"
        Me.COMLAB1DataGridView.Size = New System.Drawing.Size(741, 311)
        Me.COMLAB1DataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PRODUCT_CODE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PRODUCT_CODE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MANUFACTURER"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MANUFACTURER"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRODUCT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRODUCT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn5.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DATE ADDED"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DATE ADDED"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 501)
        Me.Panel1.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LOG_IN_USER
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 71)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Red
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(12, 302)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(144, 35)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = "LOGOUT"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Red
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(12, 80)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 35)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "COMPUTER LAB 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(12, 149)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(144, 35)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "REPORTS"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Red
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(12, 223)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(144, 35)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "MENU"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(12, 385)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 35)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(176, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 40)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "COMPUTER LAB 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(190, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "MANUFACTURER:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(834, 413)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 45)
        Me.Button4.TabIndex = 77
        Me.Button4.Text = "SAVE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(647, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 45)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "CONFIGURE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(463, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 45)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "ADD " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.White
        Me.RadioButton4.Location = New System.Drawing.Point(1023, 43)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton4.TabIndex = 85
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "STATUS"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(930, 43)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton3.TabIndex = 84
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "PRODUCT"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(798, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton2.TabIndex = 83
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "MANUFACTURER"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(669, 43)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(111, 17)
        Me.RadioButton1.TabIndex = 82
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "PRODUCT CODE"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(891, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 20)
        Me.TextBox1.TabIndex = 81
        Me.TextBox1.Text = "SEARCH HERE"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.clear_black_192x192
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Location = New System.Drawing.Point(850, 63)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(33, 27)
        Me.Button12.TabIndex = 80
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(575, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "SEARCH FOR:"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.search1600
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Location = New System.Drawing.Point(1143, 63)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(34, 26)
        Me.Button11.TabIndex = 78
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BCKGROUND_BLUE
        Me.ClientSize = New System.Drawing.Size(1202, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(PRODUCTLabel)
        Me.Controls.Add(PRICELabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.COMLAB1DataGridView)
        Me.Controls.Add(Me.PRODUCT_CODETextBox)
        Me.Controls.Add(Me.MANUFACTURERTextBox)
        Me.Controls.Add(Me.PRODUCTTextBox)
        Me.Controls.Add(Me.PRICETextBox)
        Me.Controls.Add(Me.QUANTITYTextBox)
        Me.Controls.Add(Me.DATE_ADDEDTextBox)
        Me.Controls.Add(Me.STATUSTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPUTER LAB 1"
        CType(Me.FUCKTHISSHIT1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMLAB1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMLAB1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FUCKTHISSHIT1DataSet1 As WindowsApplication1.FUCKTHISSHIT1DataSet1
    Friend WithEvents COMLAB1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMLAB1TableAdapter As WindowsApplication1.FUCKTHISSHIT1DataSet1TableAdapters.COMLAB1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.FUCKTHISSHIT1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PRODUCT_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MANUFACTURERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRODUCTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUANTITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_ADDEDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STATUSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COMLAB1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
End Class
