<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentForm
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.pnlinput = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtreason = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbtime = New System.Windows.Forms.ComboBox()
        Me.txtdate = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbprocedurereq = New System.Windows.Forms.ComboBox()
        Me.cmbdoctor = New System.Windows.Forms.ComboBox()
        Me.cmbapttype = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shapereason = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapeprocedurereq = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapetime = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapedate = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapedoctor = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapeappointmenttype = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.locknew = New System.Windows.Forms.PictureBox()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.locksave = New System.Windows.Forms.PictureBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lockdelete = New System.Windows.Forms.PictureBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.ShapeContainer7 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lockupdate = New System.Windows.Forms.PictureBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.ShapeContainer8 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.appointmentlist = New System.Windows.Forms.ListView()
        Me.number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apttype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.doc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.proreq = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.adate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.atime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.notes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lblgreet = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.piclogout = New System.Windows.Forms.PictureBox()
        Me.pnlinput.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.locknew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.locksave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.lockdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.lockupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.piclogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape9})
        Me.ShapeContainer1.Size = New System.Drawing.Size(922, 548)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape9
        '
        Me.RectangleShape9.CornerRadius = 25
        Me.RectangleShape9.FillColor = System.Drawing.Color.White
        Me.RectangleShape9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape9.Location = New System.Drawing.Point(30, 75)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(864, 225)
        '
        'pnlinput
        '
        Me.pnlinput.BackColor = System.Drawing.Color.White
        Me.pnlinput.Controls.Add(Me.Label3)
        Me.pnlinput.Controls.Add(Me.txtreason)
        Me.pnlinput.Controls.Add(Me.Label2)
        Me.pnlinput.Controls.Add(Me.cmbtime)
        Me.pnlinput.Controls.Add(Me.txtdate)
        Me.pnlinput.Controls.Add(Me.Label1)
        Me.pnlinput.Controls.Add(Me.cmbprocedurereq)
        Me.pnlinput.Controls.Add(Me.cmbdoctor)
        Me.pnlinput.Controls.Add(Me.cmbapttype)
        Me.pnlinput.Controls.Add(Me.Label10)
        Me.pnlinput.Controls.Add(Me.Label9)
        Me.pnlinput.Controls.Add(Me.Label8)
        Me.pnlinput.Controls.Add(Me.Label7)
        Me.pnlinput.Controls.Add(Me.ShapeContainer2)
        Me.pnlinput.Location = New System.Drawing.Point(40, 96)
        Me.pnlinput.Name = "pnlinput"
        Me.pnlinput.Size = New System.Drawing.Size(837, 195)
        Me.pnlinput.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(100, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "YYYY-MM-DD"
        '
        'txtreason
        '
        Me.txtreason.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtreason.Location = New System.Drawing.Point(570, 110)
        Me.txtreason.Multiline = True
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(213, 62)
        Me.txtreason.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(548, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Reason for visit:"
        '
        'cmbtime
        '
        Me.cmbtime.DropDownHeight = 50
        Me.cmbtime.DropDownWidth = 50
        Me.cmbtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbtime.FormattingEnabled = True
        Me.cmbtime.IntegralHeight = False
        Me.cmbtime.Items.AddRange(New Object() {"09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "1:00 PM", "1:30 PM", "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM", "05:00 PM", "05:30 PM"})
        Me.cmbtime.Location = New System.Drawing.Point(304, 111)
        Me.cmbtime.Name = "cmbtime"
        Me.cmbtime.Size = New System.Drawing.Size(155, 32)
        Me.cmbtime.TabIndex = 5
        '
        'txtdate
        '
        Me.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdate.Location = New System.Drawing.Point(51, 117)
        Me.txtdate.Mask = "0000-00-00"
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 25)
        Me.txtdate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(546, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Procedure Request :"
        '
        'cmbprocedurereq
        '
        Me.cmbprocedurereq.DropDownHeight = 70
        Me.cmbprocedurereq.DropDownWidth = 20
        Me.cmbprocedurereq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbprocedurereq.FormattingEnabled = True
        Me.cmbprocedurereq.IntegralHeight = False
        Me.cmbprocedurereq.Items.AddRange(New Object() {"None", "Vaccination", "Blood Test", "Ultrasound", "X-Ray"})
        Me.cmbprocedurereq.Location = New System.Drawing.Point(570, 29)
        Me.cmbprocedurereq.Name = "cmbprocedurereq"
        Me.cmbprocedurereq.Size = New System.Drawing.Size(155, 32)
        Me.cmbprocedurereq.TabIndex = 3
        '
        'cmbdoctor
        '
        Me.cmbdoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbdoctor.FormattingEnabled = True
        Me.cmbdoctor.Location = New System.Drawing.Point(304, 29)
        Me.cmbdoctor.Name = "cmbdoctor"
        Me.cmbdoctor.Size = New System.Drawing.Size(155, 32)
        Me.cmbdoctor.TabIndex = 2
        '
        'cmbapttype
        '
        Me.cmbapttype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbapttype.FormattingEnabled = True
        Me.cmbapttype.Items.AddRange(New Object() {"Check-Up", "Follow-Up"})
        Me.cmbapttype.Location = New System.Drawing.Point(53, 29)
        Me.cmbapttype.Name = "cmbapttype"
        Me.cmbapttype.Size = New System.Drawing.Size(155, 32)
        Me.cmbapttype.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(282, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 24)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Time :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 24)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Date :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(282, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Doctor :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Appointment Type :"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shapereason, Me.shapeprocedurereq, Me.shapetime, Me.shapedate, Me.shapedoctor, Me.shapeappointmenttype})
        Me.ShapeContainer2.Size = New System.Drawing.Size(837, 195)
        Me.ShapeContainer2.TabIndex = 9
        Me.ShapeContainer2.TabStop = False
        '
        'shapereason
        '
        Me.shapereason.BorderColor = System.Drawing.Color.Black
        Me.shapereason.CornerRadius = 10
        Me.shapereason.FillColor = System.Drawing.Color.White
        Me.shapereason.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapereason.Location = New System.Drawing.Point(552, 106)
        Me.shapereason.Name = "shapereason"
        Me.shapereason.Size = New System.Drawing.Size(246, 71)
        '
        'shapeprocedurereq
        '
        Me.shapeprocedurereq.BorderColor = System.Drawing.Color.Black
        Me.shapeprocedurereq.CornerRadius = 10
        Me.shapeprocedurereq.FillColor = System.Drawing.Color.White
        Me.shapeprocedurereq.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapeprocedurereq.Location = New System.Drawing.Point(549, 25)
        Me.shapeprocedurereq.Name = "shapeprocedurereq"
        Me.shapeprocedurereq.Size = New System.Drawing.Size(179, 37)
        '
        'shapetime
        '
        Me.shapetime.BorderColor = System.Drawing.Color.Black
        Me.shapetime.CornerRadius = 10
        Me.shapetime.FillColor = System.Drawing.Color.White
        Me.shapetime.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapetime.Location = New System.Drawing.Point(283, 107)
        Me.shapetime.Name = "shapetime"
        Me.shapetime.Size = New System.Drawing.Size(179, 37)
        '
        'shapedate
        '
        Me.shapedate.BorderColor = System.Drawing.Color.Black
        Me.shapedate.CornerRadius = 10
        Me.shapedate.FillColor = System.Drawing.Color.White
        Me.shapedate.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapedate.Location = New System.Drawing.Point(40, 107)
        Me.shapedate.Name = "shapedate"
        Me.shapedate.Size = New System.Drawing.Size(116, 37)
        '
        'shapedoctor
        '
        Me.shapedoctor.BorderColor = System.Drawing.Color.Black
        Me.shapedoctor.CornerRadius = 10
        Me.shapedoctor.FillColor = System.Drawing.Color.White
        Me.shapedoctor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapedoctor.Location = New System.Drawing.Point(283, 25)
        Me.shapedoctor.Name = "shapedoctor"
        Me.shapedoctor.Size = New System.Drawing.Size(179, 37)
        '
        'shapeappointmenttype
        '
        Me.shapeappointmenttype.BorderColor = System.Drawing.Color.Black
        Me.shapeappointmenttype.CornerRadius = 10
        Me.shapeappointmenttype.FillColor = System.Drawing.Color.White
        Me.shapeappointmenttype.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shapeappointmenttype.Location = New System.Drawing.Point(40, 25)
        Me.shapeappointmenttype.Name = "shapeappointmenttype"
        Me.shapeappointmenttype.Size = New System.Drawing.Size(172, 37)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.locknew)
        Me.Panel2.Controls.Add(Me.btnnew)
        Me.Panel2.Controls.Add(Me.ShapeContainer3)
        Me.Panel2.Location = New System.Drawing.Point(30, 324)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(141, 63)
        Me.Panel2.TabIndex = 20
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
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4})
        Me.ShapeContainer3.Size = New System.Drawing.Size(141, 63)
        Me.ShapeContainer3.TabIndex = 1
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.Black
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape4.CornerRadius = 10
        Me.RectangleShape4.FillColor = System.Drawing.Color.Black
        Me.RectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape4.Location = New System.Drawing.Point(3, 4)
        Me.RectangleShape4.Name = "RectangleShape3"
        Me.RectangleShape4.Size = New System.Drawing.Size(130, 46)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.locksave)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.ShapeContainer4)
        Me.Panel3.Location = New System.Drawing.Point(755, 324)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(141, 63)
        Me.Panel3.TabIndex = 21
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btncancel)
        Me.Panel5.Controls.Add(Me.ShapeContainer6)
        Me.Panel5.Location = New System.Drawing.Point(611, 324)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(141, 63)
        Me.Panel5.TabIndex = 21
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
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lockdelete)
        Me.Panel6.Controls.Add(Me.btndelete)
        Me.Panel6.Controls.Add(Me.ShapeContainer7)
        Me.Panel6.Location = New System.Drawing.Point(320, 324)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(141, 63)
        Me.Panel6.TabIndex = 21
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
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lockupdate)
        Me.Panel7.Controls.Add(Me.btnupdate)
        Me.Panel7.Controls.Add(Me.ShapeContainer8)
        Me.Panel7.Location = New System.Drawing.Point(175, 324)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(141, 63)
        Me.Panel7.TabIndex = 21
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
        'appointmentlist
        '
        Me.appointmentlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.number, Me.apttype, Me.doc, Me.proreq, Me.adate, Me.atime, Me.notes, Me.id})
        Me.appointmentlist.FullRowSelect = True
        Me.appointmentlist.GridLines = True
        Me.appointmentlist.Location = New System.Drawing.Point(30, 385)
        Me.appointmentlist.Name = "appointmentlist"
        Me.appointmentlist.Size = New System.Drawing.Size(866, 150)
        Me.appointmentlist.TabIndex = 0
        Me.appointmentlist.UseCompatibleStateImageBehavior = False
        Me.appointmentlist.View = System.Windows.Forms.View.Details
        '
        'number
        '
        Me.number.Text = "#"
        Me.number.Width = 40
        '
        'apttype
        '
        Me.apttype.Text = "Appointment Type"
        Me.apttype.Width = 170
        '
        'doc
        '
        Me.doc.Text = "Doctor"
        Me.doc.Width = 136
        '
        'proreq
        '
        Me.proreq.Text = "Procedure Request"
        Me.proreq.Width = 200
        '
        'adate
        '
        Me.adate.Text = "Date"
        Me.adate.Width = 116
        '
        'atime
        '
        Me.atime.Text = "Time"
        Me.atime.Width = 123
        '
        'notes
        '
        Me.notes.Text = "Reason for visit"
        Me.notes.Width = 200
        '
        'id
        '
        Me.id.Width = 0
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.Black
        Me.txtid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtid.Location = New System.Drawing.Point(512, 334)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(47, 32)
        Me.txtid.TabIndex = 0
        Me.txtid.Text = "ID"
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtid.Visible = False
        '
        'lblgreet
        '
        Me.lblgreet.AutoSize = True
        Me.lblgreet.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgreet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lblgreet.Location = New System.Drawing.Point(8, -4)
        Me.lblgreet.Name = "lblgreet"
        Me.lblgreet.Size = New System.Drawing.Size(347, 49)
        Me.lblgreet.TabIndex = 0
        Me.lblgreet.Text = "Book Appointment"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblgreet)
        Me.Panel1.Location = New System.Drawing.Point(31, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 45)
        Me.Panel1.TabIndex = 26
        '
        'piclogout
        '
        Me.piclogout.BackColor = System.Drawing.SystemColors.Control
        Me.piclogout.ErrorImage = Global.ClinicSystem.My.Resources.Resources.logout
        Me.piclogout.Image = Global.ClinicSystem.My.Resources.Resources.logout
        Me.piclogout.Location = New System.Drawing.Point(859, 24)
        Me.piclogout.Name = "piclogout"
        Me.piclogout.Size = New System.Drawing.Size(37, 33)
        Me.piclogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.piclogout.TabIndex = 23
        Me.piclogout.TabStop = False
        '
        'AppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(922, 548)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.piclogout)
        Me.Controls.Add(Me.appointmentlist)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlinput)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AppointmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EverGreen/AppointmentForm"
        Me.pnlinput.ResumeLayout(False)
        Me.pnlinput.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.locknew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.locksave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.lockdelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.lockupdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.piclogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shapetime As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapedate As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapedoctor As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shapeappointmenttype As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cmbprocedurereq As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdoctor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbapttype As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer6 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer7 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer8 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents appointmentlist As System.Windows.Forms.ListView
    Friend WithEvents number As System.Windows.Forms.ColumnHeader
    Friend WithEvents apttype As System.Windows.Forms.ColumnHeader
    Friend WithEvents doc As System.Windows.Forms.ColumnHeader
    Friend WithEvents proreq As System.Windows.Forms.ColumnHeader
    Friend WithEvents adate As System.Windows.Forms.ColumnHeader
    Friend WithEvents shapeprocedurereq As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents atime As System.Windows.Forms.ColumnHeader
    Friend WithEvents RectangleShape9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cmbtime As System.Windows.Forms.ComboBox
    Friend WithEvents txtdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents piclogout As System.Windows.Forms.PictureBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents locknew As System.Windows.Forms.PictureBox
    Friend WithEvents locksave As System.Windows.Forms.PictureBox
    Friend WithEvents lockdelete As System.Windows.Forms.PictureBox
    Friend WithEvents lockupdate As System.Windows.Forms.PictureBox
    Friend WithEvents lblgreet As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents shapereason As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents notes As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtreason As System.Windows.Forms.TextBox
    Friend WithEvents pnlinput As System.Windows.Forms.Panel
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
