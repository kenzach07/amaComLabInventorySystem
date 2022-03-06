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
        Dim IDLabel As System.Windows.Forms.Label
        Dim PRODUCTLabel As System.Windows.Forms.Label
        Dim PRICELabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PRODUCT_CODETextBox = New System.Windows.Forms.TextBox()
        Me.COMLAB1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FUCKTHISSHIT1DataSet = New WindowsApplication1.FUCKTHISSHIT1DataSet()
        Me.MANUFACTURERTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCTTextBox = New System.Windows.Forms.TextBox()
        Me.PRICETextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_ADDEDTextBox = New System.Windows.Forms.TextBox()
        Me.COMLAB1DataGridView = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.COMLAB1TableAdapter = New WindowsApplication1.FUCKTHISSHIT1DataSetTableAdapters.COMLAB1TableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.FUCKTHISSHIT1DataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        PRODUCTLabel = New System.Windows.Forms.Label()
        PRICELabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMLAB1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUCKTHISSHIT1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMLAB1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        IDLabel.TabIndex = 47
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
        PRODUCTLabel.TabIndex = 48
        PRODUCTLabel.Text = "PRODUCT:"
        '
        'PRICELabel
        '
        PRICELabel.AutoSize = True
        PRICELabel.BackColor = System.Drawing.Color.Transparent
        PRICELabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PRICELabel.ForeColor = System.Drawing.Color.White
        PRICELabel.Location = New System.Drawing.Point(251, 256)
        PRICELabel.Name = "PRICELabel"
        PRICELabel.Size = New System.Drawing.Size(51, 16)
        PRICELabel.TabIndex = 49
        PRICELabel.Text = "PRICE:"
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.BackColor = System.Drawing.Color.Transparent
        QUANTITYLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QUANTITYLabel.ForeColor = System.Drawing.Color.White
        QUANTITYLabel.Location = New System.Drawing.Point(225, 312)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(76, 16)
        QUANTITYLabel.TabIndex = 50
        QUANTITYLabel.Text = "QUANTITY:"
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
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "COMPUTER LAB 1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 500)
        Me.Panel1.TabIndex = 29
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(12, 374)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 35)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LOG_IN_ADMIN
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
        'PRODUCT_CODETextBox
        '
        Me.PRODUCT_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "PRODUCT_CODE", True))
        Me.PRODUCT_CODETextBox.Location = New System.Drawing.Point(310, 103)
        Me.PRODUCT_CODETextBox.Name = "PRODUCT_CODETextBox"
        Me.PRODUCT_CODETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCT_CODETextBox.TabIndex = 32
        '
        'COMLAB1BindingSource
        '
        Me.COMLAB1BindingSource.DataMember = "COMLAB1"
        Me.COMLAB1BindingSource.DataSource = Me.FUCKTHISSHIT1DataSet
        '
        'FUCKTHISSHIT1DataSet
        '
        Me.FUCKTHISSHIT1DataSet.DataSetName = "FUCKTHISSHIT1DataSet"
        Me.FUCKTHISSHIT1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MANUFACTURERTextBox
        '
        Me.MANUFACTURERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "MANUFACTURER", True))
        Me.MANUFACTURERTextBox.Location = New System.Drawing.Point(310, 153)
        Me.MANUFACTURERTextBox.Name = "MANUFACTURERTextBox"
        Me.MANUFACTURERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MANUFACTURERTextBox.TabIndex = 34
        '
        'PRODUCTTextBox
        '
        Me.PRODUCTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "PRODUCT", True))
        Me.PRODUCTTextBox.Location = New System.Drawing.Point(310, 204)
        Me.PRODUCTTextBox.Name = "PRODUCTTextBox"
        Me.PRODUCTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCTTextBox.TabIndex = 36
        '
        'PRICETextBox
        '
        Me.PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "PRICE", True))
        Me.PRICETextBox.Location = New System.Drawing.Point(310, 255)
        Me.PRICETextBox.Name = "PRICETextBox"
        Me.PRICETextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRICETextBox.TabIndex = 38
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(310, 308)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUANTITYTextBox.TabIndex = 40
        '
        'DATE_ADDEDTextBox
        '
        Me.DATE_ADDEDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMLAB1BindingSource, "DATE ADDED", True))
        Me.DATE_ADDEDTextBox.Location = New System.Drawing.Point(666, 464)
        Me.DATE_ADDEDTextBox.Name = "DATE_ADDEDTextBox"
        Me.DATE_ADDEDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DATE_ADDEDTextBox.TabIndex = 42
        '
        'COMLAB1DataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.COMLAB1DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.COMLAB1DataGridView.AutoGenerateColumns = False
        Me.COMLAB1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.COMLAB1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.COMLAB1DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.COMLAB1DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.COMLAB1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.COMLAB1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.COMLAB1DataGridView.DataSource = Me.COMLAB1BindingSource
        Me.COMLAB1DataGridView.Location = New System.Drawing.Point(444, 96)
        Me.COMLAB1DataGridView.Name = "COMLAB1DataGridView"
        Me.COMLAB1DataGridView.Size = New System.Drawing.Size(656, 311)
        Me.COMLAB1DataGridView.TabIndex = 42
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(956, 413)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 45)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "SAVE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(793, 413)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 45)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "DELETE "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(622, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 45)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "UPDATE "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(460, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 45)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "ADD " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(567, 468)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "DATE ADDED:"
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
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "MANUFACTURER:"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.search1600
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Location = New System.Drawing.Point(1023, 61)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(34, 26)
        Me.Button11.TabIndex = 54
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(445, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "SEARCH FOR:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(514, 31)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(133, 20)
        Me.CheckBox1.TabIndex = 56
        Me.CheckBox1.Text = "PRODUCT_CODE"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(792, 31)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(89, 20)
        Me.CheckBox2.TabIndex = 57
        Me.CheckBox2.Text = "PRODUCT"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(653, 31)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(133, 20)
        Me.CheckBox3.TabIndex = 58
        Me.CheckBox3.Text = "MANUFACTURER"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.clear_black_192x192
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Location = New System.Drawing.Point(733, 61)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(33, 27)
        Me.Button12.TabIndex = 60
        Me.Button12.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.Color.White
        Me.CheckBox4.Location = New System.Drawing.Point(887, 31)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(90, 20)
        Me.CheckBox4.TabIndex = 59
        Me.CheckBox4.Text = "QUANTITY"
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(771, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 20)
        Me.TextBox1.TabIndex = 61
        Me.TextBox1.Text = "SEARCH HERE"
        '
        'COMLAB1TableAdapter
        '
        Me.COMLAB1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.COMLAB1TableAdapter = Me.COMLAB1TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.FUCKTHISSHIT1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DATE ADDED"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DATE ADDED"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BCKGROUND_BLUE
        Me.ClientSize = New System.Drawing.Size(1112, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(PRODUCTLabel)
        Me.Controls.Add(PRICELabel)
        Me.Controls.Add(QUANTITYLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.COMLAB1DataGridView)
        Me.Controls.Add(Me.PRODUCT_CODETextBox)
        Me.Controls.Add(Me.MANUFACTURERTextBox)
        Me.Controls.Add(Me.PRODUCTTextBox)
        Me.Controls.Add(Me.PRICETextBox)
        Me.Controls.Add(Me.QUANTITYTextBox)
        Me.Controls.Add(Me.DATE_ADDEDTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " COMPUTER LAB 1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMLAB1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUCKTHISSHIT1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMLAB1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents FUCKTHISSHIT1DataSet As WindowsApplication1.FUCKTHISSHIT1DataSet
    Friend WithEvents COMLAB1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMLAB1TableAdapter As WindowsApplication1.FUCKTHISSHIT1DataSetTableAdapters.COMLAB1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.FUCKTHISSHIT1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRODUCT_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MANUFACTURERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRODUCTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUANTITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATE_ADDEDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COMLAB1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
