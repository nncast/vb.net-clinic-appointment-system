<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientForm
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
        Me.patientview = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dob = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.phonenum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.street = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.barangay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.city = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.province = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.pnlinput = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtprovince = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtbarangay = New System.Windows.Forms.TextBox()
        Me.txtstreet = New System.Windows.Forms.TextBox()
        Me.txtphonenum = New System.Windows.Forms.MaskedTextBox()
        Me.cmbsex = New System.Windows.Forms.ComboBox()
        Me.txtdob = New System.Windows.Forms.MaskedTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shapepassword = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapeemail = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapeprovince = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapecity = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapebarangay = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapestreet = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapephonenum = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapesex = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapedob = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapelname = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapefname = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.ShapeContainer8 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.ShapeContainer7 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.piclogout = New System.Windows.Forms.PictureBox()
        Me.lockupdate = New System.Windows.Forms.PictureBox()
        Me.lockdelete = New System.Windows.Forms.PictureBox()
        Me.locksave = New System.Windows.Forms.PictureBox()
        Me.locknew = New System.Windows.Forms.PictureBox()
        Me.pnlinput.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.piclogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lockupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lockdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locksave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locknew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patientview
        '
        Me.patientview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.fname, Me.lname, Me.dob, Me.sex, Me.phonenum, Me.street, Me.barangay, Me.city, Me.province, Me.email, Me.password})
        Me.patientview.FullRowSelect = True
        Me.patientview.GridLines = True
        Me.patientview.Location = New System.Drawing.Point(21, 385)
        Me.patientview.Name = "patientview"
        Me.patientview.Size = New System.Drawing.Size(875, 150)
        Me.patientview.TabIndex = 1
        Me.patientview.UseCompatibleStateImageBehavior = False
        Me.patientview.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 40
        '
        'fname
        '
        Me.fname.Text = "First Name"
        Me.fname.Width = 113
        '
        'lname
        '
        Me.lname.Text = "Last Name"
        Me.lname.Width = 109
        '
        'dob
        '
        Me.dob.Text = "Date of Birth"
        Me.dob.Width = 134
        '
        'sex
        '
        Me.sex.Text = "Sex"
        Me.sex.Width = 100
        '
        'phonenum
        '
        Me.phonenum.Text = "Phone Number"
        Me.phonenum.Width = 157
        '
        'street
        '
        Me.street.Text = "Street"
        Me.street.Width = 127
        '
        'barangay
        '
        Me.barangay.Text = "Barangay"
        Me.barangay.Width = 100
        '
        'city
        '
        Me.city.Text = "City"
        Me.city.Width = 100
        '
        'province
        '
        Me.province.Text = "Province"
        Me.province.Width = 100
        '
        'email
        '
        Me.email.Text = "Email"
        Me.email.Width = 100
        '
        'password
        '
        Me.password.Text = "Password"
        Me.password.Width = 100
        '
        'txtfname
        '
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfname.Location = New System.Drawing.Point(50, 48)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(125, 25)
        Me.txtfname.TabIndex = 2
        '
        'txtlname
        '
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlname.Location = New System.Drawing.Point(202, 48)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(125, 25)
        Me.txtlname.TabIndex = 3
        '
        'pnlinput
        '
        Me.pnlinput.BackColor = System.Drawing.SystemColors.Control
        Me.pnlinput.Controls.Add(Me.Label12)
        Me.pnlinput.Controls.Add(Me.Label11)
        Me.pnlinput.Controls.Add(Me.Label10)
        Me.pnlinput.Controls.Add(Me.Label9)
        Me.pnlinput.Controls.Add(Me.Label8)
        Me.pnlinput.Controls.Add(Me.Label7)
        Me.pnlinput.Controls.Add(Me.Label6)
        Me.pnlinput.Controls.Add(Me.Label5)
        Me.pnlinput.Controls.Add(Me.Label4)
        Me.pnlinput.Controls.Add(Me.Label3)
        Me.pnlinput.Controls.Add(Me.Label2)
        Me.pnlinput.Controls.Add(Me.Label1)
        Me.pnlinput.Controls.Add(Me.txtpassword)
        Me.pnlinput.Controls.Add(Me.txtemail)
        Me.pnlinput.Controls.Add(Me.txtprovince)
        Me.pnlinput.Controls.Add(Me.txtcity)
        Me.pnlinput.Controls.Add(Me.txtbarangay)
        Me.pnlinput.Controls.Add(Me.txtstreet)
        Me.pnlinput.Controls.Add(Me.txtphonenum)
        Me.pnlinput.Controls.Add(Me.cmbsex)
        Me.pnlinput.Controls.Add(Me.txtdob)
        Me.pnlinput.Controls.Add(Me.txtfname)
        Me.pnlinput.Controls.Add(Me.txtlname)
        Me.pnlinput.Controls.Add(Me.ShapeContainer2)
        Me.pnlinput.Location = New System.Drawing.Point(21, 60)
        Me.pnlinput.Name = "pnlinput"
        Me.pnlinput.Size = New System.Drawing.Size(872, 251)
        Me.pnlinput.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(45, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 18)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "YYYY-MM-DD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(619, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 24)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Password :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(425, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Email :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(630, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 24)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Province :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(425, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 24)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "City :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(626, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Barangay :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(425, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Street :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(33, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Phone Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(189, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Sex :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(33, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Date of Birth :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(189, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Last Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "First Name :"
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Location = New System.Drawing.Point(646, 204)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(167, 25)
        Me.txtpassword.TabIndex = 12
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Location = New System.Drawing.Point(444, 204)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(165, 25)
        Me.txtemail.TabIndex = 11
        '
        'txtprovince
        '
        Me.txtprovince.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtprovince.Location = New System.Drawing.Point(648, 108)
        Me.txtprovince.Name = "txtprovince"
        Me.txtprovince.Size = New System.Drawing.Size(165, 25)
        Me.txtprovince.TabIndex = 10
        '
        'txtcity
        '
        Me.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcity.Location = New System.Drawing.Point(444, 108)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(165, 25)
        Me.txtcity.TabIndex = 9
        '
        'txtbarangay
        '
        Me.txtbarangay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbarangay.Location = New System.Drawing.Point(648, 45)
        Me.txtbarangay.Name = "txtbarangay"
        Me.txtbarangay.Size = New System.Drawing.Size(165, 25)
        Me.txtbarangay.TabIndex = 8
        '
        'txtstreet
        '
        Me.txtstreet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtstreet.Location = New System.Drawing.Point(444, 45)
        Me.txtstreet.Name = "txtstreet"
        Me.txtstreet.Size = New System.Drawing.Size(165, 25)
        Me.txtstreet.TabIndex = 7
        '
        'txtphonenum
        '
        Me.txtphonenum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtphonenum.Location = New System.Drawing.Point(50, 201)
        Me.txtphonenum.Mask = "0000-000-0000"
        Me.txtphonenum.Name = "txtphonenum"
        Me.txtphonenum.Size = New System.Drawing.Size(125, 25)
        Me.txtphonenum.TabIndex = 6
        '
        'cmbsex
        '
        Me.cmbsex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbsex.FormattingEnabled = True
        Me.cmbsex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbsex.Location = New System.Drawing.Point(202, 119)
        Me.cmbsex.Name = "cmbsex"
        Me.cmbsex.Size = New System.Drawing.Size(125, 32)
        Me.cmbsex.TabIndex = 5
        '
        'txtdob
        '
        Me.txtdob.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdob.Location = New System.Drawing.Point(50, 122)
        Me.txtdob.Mask = "0000-00-00"
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(125, 25)
        Me.txtdob.TabIndex = 4
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shapepassword, Me.shapeemail, Me.shapeprovince, Me.shapecity, Me.shapebarangay, Me.shapestreet, Me.shapephonenum, Me.shapesex, Me.shapedob, Me.shapelname, Me.shapefname, Me.RectangleShape4, Me.RectangleShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(872, 251)
        Me.ShapeContainer2.TabIndex = 24
        Me.ShapeContainer2.TabStop = False
        '
        'shapepassword
        '
        Me.shapepassword.BorderColor = System.Drawing.Color.Black
        Me.shapepassword.CornerRadius = 10
        Me.shapepassword.FillColor = System.Drawing.Color.White
        Me.shapepassword.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapepassword.Location = New System.Drawing.Point(632, 196)
        Me.shapepassword.Name = "shapepassword"
        Me.shapepassword.Size = New System.Drawing.Size(186, 37)
        '
        'shapeemail
        '
        Me.shapeemail.BorderColor = System.Drawing.Color.Black
        Me.shapeemail.CornerRadius = 10
        Me.shapeemail.FillColor = System.Drawing.Color.White
        Me.shapeemail.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapeemail.Location = New System.Drawing.Point(431, 196)
        Me.shapeemail.Name = "shapeemail"
        Me.shapeemail.Size = New System.Drawing.Size(186, 37)
        '
        'shapeprovince
        '
        Me.shapeprovince.BorderColor = System.Drawing.Color.Black
        Me.shapeprovince.CornerRadius = 10
        Me.shapeprovince.FillColor = System.Drawing.Color.White
        Me.shapeprovince.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapeprovince.Location = New System.Drawing.Point(633, 100)
        Me.shapeprovince.Name = "shapeprovince"
        Me.shapeprovince.Size = New System.Drawing.Size(186, 37)
        '
        'shapecity
        '
        Me.shapecity.BorderColor = System.Drawing.Color.Black
        Me.shapecity.CornerRadius = 10
        Me.shapecity.FillColor = System.Drawing.Color.White
        Me.shapecity.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapecity.Location = New System.Drawing.Point(431, 99)
        Me.shapecity.Name = "shapecity"
        Me.shapecity.Size = New System.Drawing.Size(186, 37)
        '
        'shapebarangay
        '
        Me.shapebarangay.BorderColor = System.Drawing.Color.Black
        Me.shapebarangay.CornerRadius = 10
        Me.shapebarangay.FillColor = System.Drawing.Color.White
        Me.shapebarangay.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapebarangay.Location = New System.Drawing.Point(632, 38)
        Me.shapebarangay.Name = "shapebarangay"
        Me.shapebarangay.Size = New System.Drawing.Size(186, 37)
        '
        'shapestreet
        '
        Me.shapestreet.BorderColor = System.Drawing.Color.Black
        Me.shapestreet.CornerRadius = 10
        Me.shapestreet.FillColor = System.Drawing.Color.White
        Me.shapestreet.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapestreet.Location = New System.Drawing.Point(429, 37)
        Me.shapestreet.Name = "shapestreet"
        Me.shapestreet.Size = New System.Drawing.Size(186, 37)
        '
        'shapephonenum
        '
        Me.shapephonenum.BorderColor = System.Drawing.Color.Black
        Me.shapephonenum.CornerRadius = 10
        Me.shapephonenum.FillColor = System.Drawing.Color.White
        Me.shapephonenum.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapephonenum.Location = New System.Drawing.Point(36, 190)
        Me.shapephonenum.Name = "shapephonenum"
        Me.shapephonenum.Size = New System.Drawing.Size(144, 37)
        '
        'shapesex
        '
        Me.shapesex.BorderColor = System.Drawing.Color.Black
        Me.shapesex.CornerRadius = 10
        Me.shapesex.FillColor = System.Drawing.Color.White
        Me.shapesex.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapesex.Location = New System.Drawing.Point(192, 115)
        Me.shapesex.Name = "shapesex"
        Me.shapesex.Size = New System.Drawing.Size(144, 37)
        '
        'shapedob
        '
        Me.shapedob.BorderColor = System.Drawing.Color.Black
        Me.shapedob.CornerRadius = 10
        Me.shapedob.FillColor = System.Drawing.Color.White
        Me.shapedob.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapedob.Location = New System.Drawing.Point(36, 114)
        Me.shapedob.Name = "shapedob"
        Me.shapedob.Size = New System.Drawing.Size(144, 37)
        '
        'shapelname
        '
        Me.shapelname.BorderColor = System.Drawing.Color.Black
        Me.shapelname.CornerRadius = 10
        Me.shapelname.FillColor = System.Drawing.Color.White
        Me.shapelname.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapelname.Location = New System.Drawing.Point(190, 39)
        Me.shapelname.Name = "shapelname"
        Me.shapelname.Size = New System.Drawing.Size(144, 37)
        '
        'shapefname
        '
        Me.shapefname.BorderColor = System.Drawing.Color.Black
        Me.shapefname.CornerRadius = 10
        Me.shapefname.FillColor = System.Drawing.Color.White
        Me.shapefname.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapefname.Location = New System.Drawing.Point(37, 39)
        Me.shapefname.Name = "shapefname"
        Me.shapefname.Size = New System.Drawing.Size(144, 37)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.CornerRadius = 25
        Me.RectangleShape4.FillColor = System.Drawing.Color.White
        Me.RectangleShape4.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape4.Location = New System.Drawing.Point(383, 2)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(484, 246)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.CornerRadius = 25
        Me.RectangleShape2.FillColor = System.Drawing.Color.White
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(3, 2)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(367, 245)
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lockupdate)
        Me.Panel7.Controls.Add(Me.btnupdate)
        Me.Panel7.Controls.Add(Me.ShapeContainer8)
        Me.Panel7.Location = New System.Drawing.Point(166, 321)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(141, 63)
        Me.Panel7.TabIndex = 27
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Black
        Me.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(10, 10)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(118, 37)
        Me.btnupdate.TabIndex = 8
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'ShapeContainer8
        '
        Me.ShapeContainer8.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer8.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer8.Name = "ShapeContainer8"
        Me.ShapeContainer8.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape8})
        Me.ShapeContainer8.Size = New System.Drawing.Size(141, 63)
        Me.ShapeContainer8.TabIndex = 1
        Me.ShapeContainer8.TabStop = False
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BackColor = System.Drawing.Color.Black
        Me.RectangleShape8.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape8.CornerRadius = 10
        Me.RectangleShape8.FillColor = System.Drawing.Color.Black
        Me.RectangleShape8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape8.Location = New System.Drawing.Point(3, 4)
        Me.RectangleShape8.Name = "RectangleShape3"
        Me.RectangleShape8.Size = New System.Drawing.Size(130, 46)
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lockdelete)
        Me.Panel6.Controls.Add(Me.btndelete)
        Me.Panel6.Controls.Add(Me.ShapeContainer7)
        Me.Panel6.Location = New System.Drawing.Point(311, 321)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(141, 63)
        Me.Panel6.TabIndex = 28
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Black
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(10, 10)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(118, 37)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'ShapeContainer7
        '
        Me.ShapeContainer7.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer7.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer7.Name = "ShapeContainer7"
        Me.ShapeContainer7.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape7})
        Me.ShapeContainer7.Size = New System.Drawing.Size(141, 63)
        Me.ShapeContainer7.TabIndex = 1
        Me.ShapeContainer7.TabStop = False
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BackColor = System.Drawing.Color.Black
        Me.RectangleShape7.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape7.CornerRadius = 10
        Me.RectangleShape7.FillColor = System.Drawing.Color.Black
        Me.RectangleShape7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape7.Location = New System.Drawing.Point(3, 4)
        Me.RectangleShape7.Name = "RectangleShape3"
        Me.RectangleShape7.Size = New System.Drawing.Size(130, 46)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btncancel)
        Me.Panel5.Controls.Add(Me.ShapeContainer6)
        Me.Panel5.Location = New System.Drawing.Point(608, 321)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(141, 63)
        Me.Panel5.TabIndex = 29
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Black
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(10, 10)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(118, 37)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape6})
        Me.ShapeContainer6.Size = New System.Drawing.Size(141, 63)
        Me.ShapeContainer6.TabIndex = 1
        Me.ShapeContainer6.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BackColor = System.Drawing.Color.Black
        Me.RectangleShape6.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape6.CornerRadius = 10
        Me.RectangleShape6.FillColor = System.Drawing.Color.Black
        Me.RectangleShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape6.Location = New System.Drawing.Point(3, 4)
        Me.RectangleShape6.Name = "RectangleShape3"
        Me.RectangleShape6.Size = New System.Drawing.Size(130, 46)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.locksave)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.ShapeContainer4)
        Me.Panel3.Location = New System.Drawing.Point(752, 321)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(141, 63)
        Me.Panel3.TabIndex = 30
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Black
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(10, 10)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(118, 37)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5})
        Me.ShapeContainer4.Size = New System.Drawing.Size(141, 63)
        Me.ShapeContainer4.TabIndex = 1
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackColor = System.Drawing.Color.Black
        Me.RectangleShape5.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape5.CornerRadius = 10
        Me.RectangleShape5.FillColor = System.Drawing.Color.Black
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(3, 4)
        Me.RectangleShape5.Name = "RectangleShape3"
        Me.RectangleShape5.Size = New System.Drawing.Size(130, 46)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.locknew)
        Me.Panel1.Controls.Add(Me.btnnew)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(21, 321)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 63)
        Me.Panel1.TabIndex = 26
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.Black
        Me.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(10, 10)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(118, 37)
        Me.btnnew.TabIndex = 7
        Me.btnnew.Text = "Add"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(141, 63)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Black
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.FillColor = System.Drawing.Color.Black
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(3, 4)
        Me.RectangleShape1.Name = "RectangleShape3"
        Me.RectangleShape1.Size = New System.Drawing.Size(130, 46)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblheader)
        Me.Panel2.Location = New System.Drawing.Point(21, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(309, 61)
        Me.Panel2.TabIndex = 31
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lblheader.Location = New System.Drawing.Point(3, 8)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(293, 49)
        Me.lblheader.TabIndex = 6
        Me.lblheader.Text = "Patient Records"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.Black
        Me.txtid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtid.Location = New System.Drawing.Point(506, 336)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(47, 32)
        Me.txtid.TabIndex = 32
        Me.txtid.Text = "ID"
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtid.Visible = False
        '
        'piclogout
        '
        Me.piclogout.BackColor = System.Drawing.SystemColors.Control
        Me.piclogout.ErrorImage = Global.ClinicSystem.My.Resources.Resources.logout
        Me.piclogout.Image = Global.ClinicSystem.My.Resources.Resources.logout
        Me.piclogout.Location = New System.Drawing.Point(856, 12)
        Me.piclogout.Name = "piclogout"
        Me.piclogout.Size = New System.Drawing.Size(37, 33)
        Me.piclogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.piclogout.TabIndex = 33
        Me.piclogout.TabStop = False
        '
        'lockupdate
        '
        Me.lockupdate.BackColor = System.Drawing.Color.Black
        Me.lockupdate.Image = Global.ClinicSystem.My.Resources.Resources.lock
        Me.lockupdate.InitialImage = Global.ClinicSystem.My.Resources.Resources.lock
        Me.lockupdate.Location = New System.Drawing.Point(52, 12)
        Me.lockupdate.Name = "lockupdate"
        Me.lockupdate.Size = New System.Drawing.Size(31, 27)
        Me.lockupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.lockupdate.TabIndex = 26
        Me.lockupdate.TabStop = False
        Me.lockupdate.Visible = False
        '
        'lockdelete
        '
        Me.lockdelete.BackColor = System.Drawing.Color.Black
        Me.lockdelete.Image = Global.ClinicSystem.My.Resources.Resources.lock
        Me.lockdelete.InitialImage = Global.ClinicSystem.My.Resources.Resources.lock
        Me.lockdelete.Location = New System.Drawing.Point(52, 12)
        Me.lockdelete.Name = "lockdelete"
        Me.lockdelete.Size = New System.Drawing.Size(31, 27)
        Me.lockdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.lockdelete.TabIndex = 27
        Me.lockdelete.TabStop = False
        Me.lockdelete.Visible = False
        '
        'locksave
        '
        Me.locksave.BackColor = System.Drawing.Color.Black
        Me.locksave.Image = Global.ClinicSystem.My.Resources.Resources.lock
        Me.locksave.InitialImage = Global.ClinicSystem.My.Resources.Resources.lock
        Me.locksave.Location = New System.Drawing.Point(52, 12)
        Me.locksave.Name = "locksave"
        Me.locksave.Size = New System.Drawing.Size(31, 27)
        Me.locksave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.locksave.TabIndex = 28
        Me.locksave.TabStop = False
        '
        'locknew
        '
        Me.locknew.BackColor = System.Drawing.Color.Black
        Me.locknew.Image = Global.ClinicSystem.My.Resources.Resources.lock
        Me.locknew.InitialImage = Global.ClinicSystem.My.Resources.Resources.lock
        Me.locknew.Location = New System.Drawing.Point(52, 12)
        Me.locknew.Name = "locknew"
        Me.locknew.Size = New System.Drawing.Size(31, 27)
        Me.locknew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.locknew.TabIndex = 25
        Me.locknew.TabStop = False
        Me.locknew.Visible = False
        '
        'PatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(912, 548)
        Me.Controls.Add(Me.piclogout)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlinput)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.patientview)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PatientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EverGreen/PatientForm"
        Me.pnlinput.ResumeLayout(False)
        Me.pnlinput.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.piclogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lockupdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lockdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locksave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locknew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents patientview As System.Windows.Forms.ListView
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents pnlinput As System.Windows.Forms.Panel
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtprovince As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtbarangay As System.Windows.Forms.TextBox
    Friend WithEvents txtstreet As System.Windows.Forms.TextBox
    Friend WithEvents txtphonenum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbsex As System.Windows.Forms.ComboBox
    Friend WithEvents txtdob As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents fname As System.Windows.Forms.ColumnHeader
    Friend WithEvents lname As System.Windows.Forms.ColumnHeader
    Friend WithEvents dob As System.Windows.Forms.ColumnHeader
    Friend WithEvents sex As System.Windows.Forms.ColumnHeader
    Friend WithEvents phonenum As System.Windows.Forms.ColumnHeader
    Friend WithEvents street As System.Windows.Forms.ColumnHeader
    Friend WithEvents barangay As System.Windows.Forms.ColumnHeader
    Friend WithEvents city As System.Windows.Forms.ColumnHeader
    Friend WithEvents province As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents password As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lockupdate As System.Windows.Forms.PictureBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer8 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lockdelete As System.Windows.Forms.PictureBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer7 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer6 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents locksave As System.Windows.Forms.PictureBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents locknew As System.Windows.Forms.PictureBox
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblheader As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapelname As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapefname As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapephonenum As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapesex As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapedob As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapestreet As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapeprovince As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapecity As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapebarangay As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapepassword As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapeemail As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents piclogout As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
