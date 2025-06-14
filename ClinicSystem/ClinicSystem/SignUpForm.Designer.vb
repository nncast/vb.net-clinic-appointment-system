<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Me.lblheader = New System.Windows.Forms.Label()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtphonenum = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbsex = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdob = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblpnlheader1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shapephonenum = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapesex = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapedob = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapelname = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapefname = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblpanelheader2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtprovince = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtbarangay = New System.Windows.Forms.TextBox()
        Me.txtstreet = New System.Windows.Forms.TextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shapeprovince = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapecity = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapebarangay = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapestreet = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapeemail = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapepassword = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lblheader.Location = New System.Drawing.Point(8, 5)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(154, 49)
        Me.lblheader.TabIndex = 6
        Me.lblheader.Text = "Sign Up"
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbllogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbllogin.Font = New System.Drawing.Font("Candara", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lbllogin.Location = New System.Drawing.Point(192, 4)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(65, 24)
        Me.lbllogin.TabIndex = 8
        Me.lbllogin.Text = "LOGIN"
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblquestion.Location = New System.Drawing.Point(3, 4)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(223, 24)
        Me.lblquestion.TabIndex = 7
        Me.lblquestion.Text = "Already have an account?"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtphonenum)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cmbsex)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtdob)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtlname)
        Me.Panel1.Controls.Add(Me.txtfname)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblpnlheader1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(30, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 320)
        Me.Panel1.TabIndex = 10
        '
        'txtphonenum
        '
        Me.txtphonenum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtphonenum.Location = New System.Drawing.Point(37, 271)
        Me.txtphonenum.Mask = "0000-000-0000"
        Me.txtphonenum.Name = "txtphonenum"
        Me.txtphonenum.Size = New System.Drawing.Size(129, 25)
        Me.txtphonenum.TabIndex = 11
        Me.txtphonenum.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 232)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 24)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Phone Number :"
        '
        'cmbsex
        '
        Me.cmbsex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbsex.FormattingEnabled = True
        Me.cmbsex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbsex.Location = New System.Drawing.Point(225, 181)
        Me.cmbsex.Name = "cmbsex"
        Me.cmbsex.Size = New System.Drawing.Size(128, 32)
        Me.cmbsex.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 24)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Sex :"
        '
        'txtdob
        '
        Me.txtdob.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdob.Location = New System.Drawing.Point(37, 187)
        Me.txtdob.Mask = "0000-00-00"
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(100, 25)
        Me.txtdob.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 24)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Date of Birth :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Last Name :"
        '
        'txtlname
        '
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlname.Location = New System.Drawing.Point(225, 102)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(158, 25)
        Me.txtlname.TabIndex = 3
        '
        'txtfname
        '
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfname.Location = New System.Drawing.Point(37, 102)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(155, 25)
        Me.txtfname.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "First Name :"
        '
        'lblpnlheader1
        '
        Me.lblpnlheader1.BackColor = System.Drawing.Color.Transparent
        Me.lblpnlheader1.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpnlheader1.ForeColor = System.Drawing.Color.Black
        Me.lblpnlheader1.Location = New System.Drawing.Point(-2, 1)
        Me.lblpnlheader1.Name = "lblpnlheader1"
        Me.lblpnlheader1.Size = New System.Drawing.Size(206, 44)
        Me.lblpnlheader1.TabIndex = 0
        Me.lblpnlheader1.Text = "PATIENT DETAILS"
        Me.lblpnlheader1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shapephonenum, Me.shapesex, Me.shapedob, Me.shapelname, Me.shapefname})
        Me.ShapeContainer1.Size = New System.Drawing.Size(412, 320)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'shapephonenum
        '
        Me.shapephonenum.BorderColor = System.Drawing.Color.Black
        Me.shapephonenum.CornerRadius = 10
        Me.shapephonenum.FillColor = System.Drawing.Color.White
        Me.shapephonenum.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapephonenum.Location = New System.Drawing.Point(26, 261)
        Me.shapephonenum.Name = "shapephonenum"
        Me.shapephonenum.Size = New System.Drawing.Size(143, 37)
        '
        'shapesex
        '
        Me.shapesex.BorderColor = System.Drawing.Color.Black
        Me.shapesex.CornerRadius = 10
        Me.shapesex.FillColor = System.Drawing.Color.White
        Me.shapesex.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapesex.Location = New System.Drawing.Point(211, 176)
        Me.shapesex.Name = "shapesex"
        Me.shapesex.Size = New System.Drawing.Size(146, 37)
        '
        'shapedob
        '
        Me.shapedob.BorderColor = System.Drawing.Color.Black
        Me.shapedob.CornerRadius = 10
        Me.shapedob.FillColor = System.Drawing.Color.White
        Me.shapedob.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapedob.Location = New System.Drawing.Point(26, 176)
        Me.shapedob.Name = "shapedob"
        Me.shapedob.Size = New System.Drawing.Size(116, 37)
        '
        'shapelname
        '
        Me.shapelname.BorderColor = System.Drawing.Color.Black
        Me.shapelname.CornerRadius = 10
        Me.shapelname.FillColor = System.Drawing.Color.White
        Me.shapelname.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapelname.Location = New System.Drawing.Point(211, 94)
        Me.shapelname.Name = "shapelname"
        Me.shapelname.Size = New System.Drawing.Size(179, 37)
        '
        'shapefname
        '
        Me.shapefname.BorderColor = System.Drawing.Color.Black
        Me.shapefname.CornerRadius = 10
        Me.shapefname.FillColor = System.Drawing.Color.White
        Me.shapefname.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapefname.Location = New System.Drawing.Point(26, 94)
        Me.shapefname.Name = "shapefname"
        Me.shapefname.Size = New System.Drawing.Size(172, 37)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblpanelheader2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(470, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 184)
        Me.Panel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Address"
        '
        'lblpanelheader2
        '
        Me.lblpanelheader2.BackColor = System.Drawing.Color.Transparent
        Me.lblpanelheader2.Font = New System.Drawing.Font("Candara", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpanelheader2.ForeColor = System.Drawing.Color.Black
        Me.lblpanelheader2.Location = New System.Drawing.Point(-14, -4)
        Me.lblpanelheader2.Name = "lblpanelheader2"
        Me.lblpanelheader2.Size = New System.Drawing.Size(225, 44)
        Me.lblpanelheader2.TabIndex = 1
        Me.lblpanelheader2.Text = "ADDRESS DETAILS"
        Me.lblpanelheader2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtprovince)
        Me.Panel3.Controls.Add(Me.txtcity)
        Me.Panel3.Controls.Add(Me.txtbarangay)
        Me.Panel3.Controls.Add(Me.txtstreet)
        Me.Panel3.Controls.Add(Me.ShapeContainer2)
        Me.Panel3.Location = New System.Drawing.Point(3, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(401, 114)
        Me.Panel3.TabIndex = 2
        '
        'txtprovince
        '
        Me.txtprovince.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtprovince.ForeColor = System.Drawing.Color.Silver
        Me.txtprovince.Location = New System.Drawing.Point(220, 57)
        Me.txtprovince.Name = "txtprovince"
        Me.txtprovince.Size = New System.Drawing.Size(158, 25)
        Me.txtprovince.TabIndex = 15
        Me.txtprovince.Text = "Province"
        '
        'txtcity
        '
        Me.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcity.ForeColor = System.Drawing.Color.Silver
        Me.txtcity.Location = New System.Drawing.Point(28, 58)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(158, 25)
        Me.txtcity.TabIndex = 14
        Me.txtcity.Text = "City"
        '
        'txtbarangay
        '
        Me.txtbarangay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbarangay.ForeColor = System.Drawing.Color.Silver
        Me.txtbarangay.Location = New System.Drawing.Point(220, 12)
        Me.txtbarangay.Name = "txtbarangay"
        Me.txtbarangay.Size = New System.Drawing.Size(158, 25)
        Me.txtbarangay.TabIndex = 13
        Me.txtbarangay.Text = "Barangay"
        '
        'txtstreet
        '
        Me.txtstreet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtstreet.ForeColor = System.Drawing.Color.Silver
        Me.txtstreet.Location = New System.Drawing.Point(28, 13)
        Me.txtstreet.Name = "txtstreet"
        Me.txtstreet.Size = New System.Drawing.Size(158, 25)
        Me.txtstreet.TabIndex = 12
        Me.txtstreet.Text = "Street"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shapeprovince, Me.shapecity, Me.shapebarangay, Me.shapestreet})
        Me.ShapeContainer2.Size = New System.Drawing.Size(401, 114)
        Me.ShapeContainer2.TabIndex = 11
        Me.ShapeContainer2.TabStop = False
        '
        'shapeprovince
        '
        Me.shapeprovince.BorderColor = System.Drawing.Color.Black
        Me.shapeprovince.CornerRadius = 10
        Me.shapeprovince.FillColor = System.Drawing.Color.White
        Me.shapeprovince.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapeprovince.Location = New System.Drawing.Point(205, 48)
        Me.shapeprovince.Name = "shapeprovince"
        Me.shapeprovince.Size = New System.Drawing.Size(179, 37)
        '
        'shapecity
        '
        Me.shapecity.BorderColor = System.Drawing.Color.Black
        Me.shapecity.CornerRadius = 10
        Me.shapecity.FillColor = System.Drawing.Color.White
        Me.shapecity.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapecity.Location = New System.Drawing.Point(13, 48)
        Me.shapecity.Name = "shapecity"
        Me.shapecity.Size = New System.Drawing.Size(179, 37)
        '
        'shapebarangay
        '
        Me.shapebarangay.BorderColor = System.Drawing.Color.Black
        Me.shapebarangay.CornerRadius = 10
        Me.shapebarangay.FillColor = System.Drawing.Color.White
        Me.shapebarangay.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapebarangay.Location = New System.Drawing.Point(205, 3)
        Me.shapebarangay.Name = "shapebarangay"
        Me.shapebarangay.Size = New System.Drawing.Size(179, 37)
        '
        'shapestreet
        '
        Me.shapestreet.BorderColor = System.Drawing.Color.Black
        Me.shapestreet.CornerRadius = 10
        Me.shapestreet.FillColor = System.Drawing.Color.White
        Me.shapestreet.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapestreet.Location = New System.Drawing.Point(13, 3)
        Me.shapestreet.Name = "shapestreet"
        Me.shapestreet.Size = New System.Drawing.Size(179, 37)
        '
        'shapeemail
        '
        Me.shapeemail.BorderColor = System.Drawing.Color.Black
        Me.shapeemail.CornerRadius = 10
        Me.shapeemail.FillColor = System.Drawing.Color.White
        Me.shapeemail.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapeemail.Location = New System.Drawing.Point(33, 31)
        Me.shapeemail.Name = "shapeemail"
        Me.shapeemail.Size = New System.Drawing.Size(352, 37)
        '
        'shapepassword
        '
        Me.shapepassword.BorderColor = System.Drawing.Color.Black
        Me.shapepassword.CornerRadius = 10
        Me.shapepassword.FillColor = System.Drawing.Color.White
        Me.shapepassword.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapepassword.Location = New System.Drawing.Point(35, 100)
        Me.shapepassword.Name = "shapepassword"
        Me.shapepassword.Size = New System.Drawing.Size(351, 37)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 24)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Email :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 24)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Password :"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtpassword)
        Me.Panel5.Controls.Add(Me.txtemail)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.ShapeContainer4)
        Me.Panel5.Location = New System.Drawing.Point(463, 318)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(407, 144)
        Me.Panel5.TabIndex = 16
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Location = New System.Drawing.Point(49, 109)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(329, 25)
        Me.txtpassword.TabIndex = 16
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Location = New System.Drawing.Point(49, 40)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(329, 25)
        Me.txtemail.TabIndex = 12
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shapepassword, Me.shapeemail})
        Me.ShapeContainer4.Size = New System.Drawing.Size(407, 144)
        Me.ShapeContainer4.TabIndex = 3
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.CornerRadius = 25
        Me.RectangleShape2.FillColor = System.Drawing.Color.White
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(24, 88)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(425, 373)
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RectangleShape2})
        Me.ShapeContainer3.Size = New System.Drawing.Size(922, 548)
        Me.ShapeContainer3.TabIndex = 17
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.CornerRadius = 25
        Me.RectangleShape1.FillColor = System.Drawing.Color.White
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(461, 88)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(425, 221)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnregister)
        Me.Panel4.Controls.Add(Me.ShapeContainer5)
        Me.Panel4.Location = New System.Drawing.Point(584, 473)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(175, 63)
        Me.Panel4.TabIndex = 18
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.Black
        Me.btnregister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregister.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregister.ForeColor = System.Drawing.Color.White
        Me.btnregister.Location = New System.Drawing.Point(8, 8)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(157, 38)
        Me.btnregister.TabIndex = 2
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer5.Size = New System.Drawing.Size(175, 63)
        Me.ShapeContainer5.TabIndex = 1
        Me.ShapeContainer5.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.Black
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape3.CornerRadius = 10
        Me.RectangleShape3.FillColor = System.Drawing.Color.Black
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(3, 4)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(165, 46)
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblheader)
        Me.Panel6.Location = New System.Drawing.Point(388, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(170, 61)
        Me.Panel6.TabIndex = 19
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lblquestion)
        Me.Panel7.Controls.Add(Me.lbllogin)
        Me.Panel7.Location = New System.Drawing.Point(30, 484)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(370, 38)
        Me.Panel7.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(34, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "YYYY-MM-DD"
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(922, 548)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.ShapeContainer3)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SignUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EverGreen/SignUpForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblheader As System.Windows.Forms.Label
    Friend WithEvents lbllogin As System.Windows.Forms.Label
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbsex As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdob As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblpnlheader1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shapefname As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapelname As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapesex As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapedob As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtphonenum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents shapephonenum As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblpanelheader2 As System.Windows.Forms.Label
    Friend WithEvents shapeemail As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapepassword As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer5 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shapebarangay As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapestreet As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapeprovince As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapecity As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtprovince As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtbarangay As System.Windows.Forms.TextBox
    Friend WithEvents txtstreet As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents btnregister As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
