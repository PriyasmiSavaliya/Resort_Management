<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Addroom
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Addroom))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRoomid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRoomno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRoomtype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtBed = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtBooked = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnAddroom = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(841, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add New Room"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(85, 226)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(802, 623)
        Me.DataGridView1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(22, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Room Id"
        '
        'txtRoomid
        '
        Me.txtRoomid.BorderColor = System.Drawing.Color.Gray
        Me.txtRoomid.BorderThickness = 3
        Me.txtRoomid.CustomizableEdges = CustomizableEdges7
        Me.txtRoomid.DefaultText = ""
        Me.txtRoomid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRoomid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRoomid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomid.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtRoomid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRoomid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRoomid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomid.Location = New System.Drawing.Point(22, 61)
        Me.txtRoomid.Name = "txtRoomid"
        Me.txtRoomid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomid.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtRoomid.PlaceholderText = "Room id"
        Me.txtRoomid.SelectedText = ""
        Me.txtRoomid.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Me.txtRoomid.Size = New System.Drawing.Size(476, 41)
        Me.txtRoomid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtRoomid.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(22, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Room Number"
        '
        'txtRoomno
        '
        Me.txtRoomno.BorderColor = System.Drawing.Color.Gray
        Me.txtRoomno.BorderThickness = 3
        Me.txtRoomno.CustomizableEdges = CustomizableEdges9
        Me.txtRoomno.DefaultText = ""
        Me.txtRoomno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRoomno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRoomno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomno.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtRoomno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomno.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRoomno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRoomno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomno.Location = New System.Drawing.Point(23, 170)
        Me.txtRoomno.Name = "txtRoomno"
        Me.txtRoomno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomno.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtRoomno.PlaceholderText = "Room Number"
        Me.txtRoomno.SelectedText = ""
        Me.txtRoomno.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Me.txtRoomno.Size = New System.Drawing.Size(476, 41)
        Me.txtRoomno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtRoomno.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(23, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Bed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(23, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Room Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(23, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(26, 555)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Booked"
        '
        'txtRoomtype
        '
        Me.txtRoomtype.BackColor = System.Drawing.Color.Transparent
        Me.txtRoomtype.BorderColor = System.Drawing.Color.Gray
        Me.txtRoomtype.BorderThickness = 3
        Me.txtRoomtype.CustomizableEdges = CustomizableEdges11
        Me.txtRoomtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtRoomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRoomtype.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtRoomtype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomtype.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRoomtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtRoomtype.ItemHeight = 30
        Me.txtRoomtype.Items.AddRange(New Object() {"Ac", "Non-Ac"})
        Me.txtRoomtype.Location = New System.Drawing.Point(22, 278)
        Me.txtRoomtype.Name = "txtRoomtype"
        Me.txtRoomtype.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Me.txtRoomtype.Size = New System.Drawing.Size(476, 36)
        Me.txtRoomtype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtRoomtype.TabIndex = 19
        '
        'txtBed
        '
        Me.txtBed.BackColor = System.Drawing.Color.Transparent
        Me.txtBed.BorderColor = System.Drawing.Color.Gray
        Me.txtBed.BorderThickness = 3
        Me.txtBed.CustomizableEdges = CustomizableEdges5
        Me.txtBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBed.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBed.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtBed.ItemHeight = 30
        Me.txtBed.Items.AddRange(New Object() {"Single", "Double", "Triple"})
        Me.txtBed.Location = New System.Drawing.Point(23, 378)
        Me.txtBed.Name = "txtBed"
        Me.txtBed.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Me.txtBed.Size = New System.Drawing.Size(476, 36)
        Me.txtBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBed.TabIndex = 20
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtPrice.BorderColor = System.Drawing.Color.Gray
        Me.txtPrice.BorderThickness = 3
        Me.txtPrice.CustomizableEdges = CustomizableEdges3
        Me.txtPrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPrice.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrice.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtPrice.ItemHeight = 30
        Me.txtPrice.Items.AddRange(New Object() {"1000", "2000", "3000", "4000", "5000", "6000", "7000", "8000"})
        Me.txtPrice.Location = New System.Drawing.Point(23, 483)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Me.txtPrice.Size = New System.Drawing.Size(476, 36)
        Me.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPrice.TabIndex = 21
        '
        'txtBooked
        '
        Me.txtBooked.BackColor = System.Drawing.Color.Transparent
        Me.txtBooked.BorderColor = System.Drawing.Color.Gray
        Me.txtBooked.BorderThickness = 3
        Me.txtBooked.CustomizableEdges = CustomizableEdges1
        Me.txtBooked.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtBooked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBooked.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBooked.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBooked.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBooked.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBooked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtBooked.ItemHeight = 30
        Me.txtBooked.Items.AddRange(New Object() {"Yes", "No"})
        Me.txtBooked.Location = New System.Drawing.Point(23, 583)
        Me.txtBooked.Name = "txtBooked"
        Me.txtBooked.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Me.txtBooked.Size = New System.Drawing.Size(476, 36)
        Me.txtBooked.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBooked.TabIndex = 22
        '
        'btnAddroom
        '
        Me.btnAddroom.BackColor = System.Drawing.Color.DarkGray
        Me.btnAddroom.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddroom.Location = New System.Drawing.Point(1570, 284)
        Me.btnAddroom.Name = "btnAddroom"
        Me.btnAddroom.Size = New System.Drawing.Size(192, 41)
        Me.btnAddroom.TabIndex = 23
        Me.btnAddroom.Text = "Add Room"
        Me.btnAddroom.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.DarkGray
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupdate.Location = New System.Drawing.Point(1570, 346)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(192, 41)
        Me.btnupdate.TabIndex = 24
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.DarkGray
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btndelete.Location = New System.Drawing.Point(1570, 404)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(192, 41)
        Me.btndelete.TabIndex = 25
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.DarkGray
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsearch.Location = New System.Drawing.Point(1570, 458)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(192, 41)
        Me.btnsearch.TabIndex = 26
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.DarkGray
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnclear.Location = New System.Drawing.Point(1570, 522)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(192, 41)
        Me.btnclear.TabIndex = 27
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtBooked)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtBed)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtRoomid)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtRoomno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtRoomtype)
        Me.Panel1.Location = New System.Drawing.Point(945, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 634)
        Me.Panel1.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(-19, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1858, 1101)
        Me.Panel2.TabIndex = 30
        '
        'UC_Addroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnAddroom)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "UC_Addroom"
        Me.Size = New System.Drawing.Size(1839, 1000)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtRoomid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRoomno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddroom As Button
    Friend WithEvents txtBooked As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtBed As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtRoomtype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
