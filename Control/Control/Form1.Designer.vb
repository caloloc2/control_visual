<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Zona1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Z1_B = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Z1_H = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Z1_T = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarAlDispositivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConexiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zona2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Z2_B = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Z2_H = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Z2_T = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Seteo = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.S_H = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.S_T = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Actuadores = New System.Windows.Forms.GroupBox()
        Me.A_V = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.A_M = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Barra_Estado = New System.Windows.Forms.StatusStrip()
        Me.Estado_Conexion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Puerto_Serie = New System.IO.Ports.SerialPort(Me.components)
        Me.Z1_F = New System.Windows.Forms.TextBox()
        Me.Z2_F = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Z3_F = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Z3_B = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Z3_H = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Z3_T = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Zona1.SuspendLayout()
        Me.MenuPrincipal.SuspendLayout()
        Me.Zona2.SuspendLayout()
        Me.Seteo.SuspendLayout()
        Me.Actuadores.SuspendLayout()
        CType(Me.A_V, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A_M, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Barra_Estado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Zona1
        '
        Me.Zona1.Controls.Add(Me.Z1_F)
        Me.Zona1.Controls.Add(Me.Label8)
        Me.Zona1.Controls.Add(Me.Z1_B)
        Me.Zona1.Controls.Add(Me.Label7)
        Me.Zona1.Controls.Add(Me.Label6)
        Me.Zona1.Controls.Add(Me.Label4)
        Me.Zona1.Controls.Add(Me.Z1_H)
        Me.Zona1.Controls.Add(Me.Label5)
        Me.Zona1.Controls.Add(Me.Label3)
        Me.Zona1.Controls.Add(Me.Z1_T)
        Me.Zona1.Controls.Add(Me.Label2)
        Me.Zona1.Controls.Add(Me.Label1)
        Me.Zona1.Location = New System.Drawing.Point(12, 27)
        Me.Zona1.Name = "Zona1"
        Me.Zona1.Size = New System.Drawing.Size(207, 186)
        Me.Zona1.TabIndex = 0
        Me.Zona1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(167, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "%"
        '
        'Z1_B
        '
        Me.Z1_B.Location = New System.Drawing.Point(111, 135)
        Me.Z1_B.Name = "Z1_B"
        Me.Z1_B.ReadOnly = True
        Me.Z1_B.Size = New System.Drawing.Size(50, 23)
        Me.Z1_B.TabIndex = 10
        Me.Z1_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Bateria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Humo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "%"
        '
        'Z1_H
        '
        Me.Z1_H.Location = New System.Drawing.Point(111, 77)
        Me.Z1_H.Name = "Z1_H"
        Me.Z1_H.ReadOnly = True
        Me.Z1_H.Size = New System.Drawing.Size(50, 23)
        Me.Z1_H.TabIndex = 5
        Me.Z1_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Humedad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "° C"
        '
        'Z1_T
        '
        Me.Z1_T.Location = New System.Drawing.Point(111, 48)
        Me.Z1_T.Name = "Z1_T"
        Me.Z1_T.ReadOnly = True
        Me.Z1_T.Size = New System.Drawing.Size(50, 23)
        Me.Z1_T.TabIndex = 2
        Me.Z1_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temperatura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ZONA 1"
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(660, 24)
        Me.MenuPrincipal.TabIndex = 1
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConectarAlDispositivoToolStripMenuItem, Me.ConexiónToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ConectarAlDispositivoToolStripMenuItem
        '
        Me.ConectarAlDispositivoToolStripMenuItem.Name = "ConectarAlDispositivoToolStripMenuItem"
        Me.ConectarAlDispositivoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ConectarAlDispositivoToolStripMenuItem.Text = "Conectar al dispositivo"
        '
        'ConexiónToolStripMenuItem
        '
        Me.ConexiónToolStripMenuItem.Name = "ConexiónToolStripMenuItem"
        Me.ConexiónToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ConexiónToolStripMenuItem.Text = "Configuración"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(191, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Zona2
        '
        Me.Zona2.Controls.Add(Me.Z2_F)
        Me.Zona2.Controls.Add(Me.Label9)
        Me.Zona2.Controls.Add(Me.Z2_B)
        Me.Zona2.Controls.Add(Me.Label10)
        Me.Zona2.Controls.Add(Me.Label11)
        Me.Zona2.Controls.Add(Me.Label12)
        Me.Zona2.Controls.Add(Me.Z2_H)
        Me.Zona2.Controls.Add(Me.Label13)
        Me.Zona2.Controls.Add(Me.Label14)
        Me.Zona2.Controls.Add(Me.Z2_T)
        Me.Zona2.Controls.Add(Me.Label15)
        Me.Zona2.Controls.Add(Me.Label16)
        Me.Zona2.Location = New System.Drawing.Point(225, 27)
        Me.Zona2.Name = "Zona2"
        Me.Zona2.Size = New System.Drawing.Size(207, 186)
        Me.Zona2.TabIndex = 13
        Me.Zona2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(167, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "%"
        '
        'Z2_B
        '
        Me.Z2_B.Location = New System.Drawing.Point(111, 135)
        Me.Z2_B.Name = "Z2_B"
        Me.Z2_B.ReadOnly = True
        Me.Z2_B.Size = New System.Drawing.Size(50, 23)
        Me.Z2_B.TabIndex = 10
        Me.Z2_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Bateria"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Humo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(167, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 15)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "%"
        '
        'Z2_H
        '
        Me.Z2_H.Location = New System.Drawing.Point(111, 77)
        Me.Z2_H.Name = "Z2_H"
        Me.Z2_H.ReadOnly = True
        Me.Z2_H.Size = New System.Drawing.Size(50, 23)
        Me.Z2_H.TabIndex = 5
        Me.Z2_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Humedad"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(167, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 15)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "° C"
        '
        'Z2_T
        '
        Me.Z2_T.Location = New System.Drawing.Point(111, 48)
        Me.Z2_T.Name = "Z2_T"
        Me.Z2_T.ReadOnly = True
        Me.Z2_T.Size = New System.Drawing.Size(50, 23)
        Me.Z2_T.TabIndex = 2
        Me.Z2_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Temperatura"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "ZONA 2"
        '
        'Seteo
        '
        Me.Seteo.Controls.Add(Me.Label20)
        Me.Seteo.Controls.Add(Me.S_H)
        Me.Seteo.Controls.Add(Me.Label21)
        Me.Seteo.Controls.Add(Me.Label22)
        Me.Seteo.Controls.Add(Me.S_T)
        Me.Seteo.Controls.Add(Me.Label23)
        Me.Seteo.Controls.Add(Me.Label24)
        Me.Seteo.Location = New System.Drawing.Point(123, 219)
        Me.Seteo.Name = "Seteo"
        Me.Seteo.Size = New System.Drawing.Size(207, 120)
        Me.Seteo.TabIndex = 13
        Me.Seteo.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(167, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(16, 15)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "%"
        '
        'S_H
        '
        Me.S_H.Location = New System.Drawing.Point(111, 77)
        Me.S_H.Name = "S_H"
        Me.S_H.Size = New System.Drawing.Size(50, 23)
        Me.S_H.TabIndex = 5
        Me.S_H.Text = "80"
        Me.S_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 15)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Humedad"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(167, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 15)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "° C"
        '
        'S_T
        '
        Me.S_T.Location = New System.Drawing.Point(111, 48)
        Me.S_T.Name = "S_T"
        Me.S_T.Size = New System.Drawing.Size(50, 23)
        Me.S_T.TabIndex = 2
        Me.S_T.Text = "35"
        Me.S_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(18, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 15)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Temperatura"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 15)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "SETEO"
        '
        'Actuadores
        '
        Me.Actuadores.Controls.Add(Me.A_V)
        Me.Actuadores.Controls.Add(Me.Label18)
        Me.Actuadores.Controls.Add(Me.A_M)
        Me.Actuadores.Controls.Add(Me.Label17)
        Me.Actuadores.Controls.Add(Me.Label26)
        Me.Actuadores.Location = New System.Drawing.Point(336, 219)
        Me.Actuadores.Name = "Actuadores"
        Me.Actuadores.Size = New System.Drawing.Size(207, 120)
        Me.Actuadores.TabIndex = 14
        Me.Actuadores.TabStop = False
        '
        'A_V
        '
        Me.A_V.BackColor = System.Drawing.Color.Gray
        Me.A_V.Location = New System.Drawing.Point(111, 80)
        Me.A_V.Name = "A_V"
        Me.A_V.Size = New System.Drawing.Size(50, 20)
        Me.A_V.TabIndex = 16
        Me.A_V.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(18, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 15)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Ventilador"
        '
        'A_M
        '
        Me.A_M.BackColor = System.Drawing.Color.Gray
        Me.A_M.Location = New System.Drawing.Point(111, 51)
        Me.A_M.Name = "A_M"
        Me.A_M.Size = New System.Drawing.Size(50, 20)
        Me.A_M.TabIndex = 14
        Me.A_M.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 15)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Motor"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 15)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "ACTUADORES"
        '
        'Barra_Estado
        '
        Me.Barra_Estado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Estado_Conexion})
        Me.Barra_Estado.Location = New System.Drawing.Point(0, 353)
        Me.Barra_Estado.Name = "Barra_Estado"
        Me.Barra_Estado.Size = New System.Drawing.Size(660, 22)
        Me.Barra_Estado.TabIndex = 15
        Me.Barra_Estado.Text = "StatusStrip1"
        '
        'Estado_Conexion
        '
        Me.Estado_Conexion.BackColor = System.Drawing.Color.White
        Me.Estado_Conexion.ForeColor = System.Drawing.Color.Black
        Me.Estado_Conexion.Name = "Estado_Conexion"
        Me.Estado_Conexion.Size = New System.Drawing.Size(82, 17)
        Me.Estado_Conexion.Text = "Desconectado"
        '
        'Timer
        '
        Me.Timer.Interval = 500
        '
        'Z1_F
        '
        Me.Z1_F.Location = New System.Drawing.Point(111, 106)
        Me.Z1_F.Name = "Z1_F"
        Me.Z1_F.ReadOnly = True
        Me.Z1_F.Size = New System.Drawing.Size(50, 23)
        Me.Z1_F.TabIndex = 13
        Me.Z1_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Z2_F
        '
        Me.Z2_F.Location = New System.Drawing.Point(111, 106)
        Me.Z2_F.Name = "Z2_F"
        Me.Z2_F.ReadOnly = True
        Me.Z2_F.Size = New System.Drawing.Size(50, 23)
        Me.Z2_F.TabIndex = 14
        Me.Z2_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Z3_F)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Z3_B)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Z3_H)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Z3_T)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Location = New System.Drawing.Point(441, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 186)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Z3_F
        '
        Me.Z3_F.Location = New System.Drawing.Point(111, 106)
        Me.Z3_F.Name = "Z3_F"
        Me.Z3_F.ReadOnly = True
        Me.Z3_F.Size = New System.Drawing.Size(50, 23)
        Me.Z3_F.TabIndex = 14
        Me.Z3_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(167, 138)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 15)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "%"
        '
        'Z3_B
        '
        Me.Z3_B.Location = New System.Drawing.Point(111, 135)
        Me.Z3_B.Name = "Z3_B"
        Me.Z3_B.ReadOnly = True
        Me.Z3_B.Size = New System.Drawing.Size(50, 23)
        Me.Z3_B.TabIndex = 10
        Me.Z3_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(18, 138)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 15)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Bateria"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(18, 109)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(39, 15)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Humo"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(167, 80)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(16, 15)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "%"
        '
        'Z3_H
        '
        Me.Z3_H.Location = New System.Drawing.Point(111, 77)
        Me.Z3_H.Name = "Z3_H"
        Me.Z3_H.ReadOnly = True
        Me.Z3_H.Size = New System.Drawing.Size(50, 23)
        Me.Z3_H.TabIndex = 5
        Me.Z3_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(18, 80)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 15)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Humedad"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(167, 51)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(21, 15)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "° C"
        '
        'Z3_T
        '
        Me.Z3_T.Location = New System.Drawing.Point(111, 48)
        Me.Z3_T.Name = "Z3_T"
        Me.Z3_T.ReadOnly = True
        Me.Z3_T.Size = New System.Drawing.Size(50, 23)
        Me.Z3_T.TabIndex = 2
        Me.Z3_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(18, 51)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(76, 15)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Temperatura"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(12, 19)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 15)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "ZONA 3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(660, 375)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Barra_Estado)
        Me.Controls.Add(Me.Actuadores)
        Me.Controls.Add(Me.Seteo)
        Me.Controls.Add(Me.Zona2)
        Me.Controls.Add(Me.Zona1)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Control"
        Me.Zona1.ResumeLayout(False)
        Me.Zona1.PerformLayout()
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.Zona2.ResumeLayout(False)
        Me.Zona2.PerformLayout()
        Me.Seteo.ResumeLayout(False)
        Me.Seteo.PerformLayout()
        Me.Actuadores.ResumeLayout(False)
        Me.Actuadores.PerformLayout()
        CType(Me.A_V, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A_M, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Barra_Estado.ResumeLayout(False)
        Me.Barra_Estado.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Zona1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Z1_B As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Z1_H As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Z1_T As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConexiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Zona2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Z2_B As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Z2_H As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Z2_T As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Seteo As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents S_H As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents S_T As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Actuadores As GroupBox
    Friend WithEvents A_V As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents A_M As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Barra_Estado As StatusStrip
    Friend WithEvents Estado_Conexion As ToolStripStatusLabel
    Friend WithEvents Timer As Timer
    Friend WithEvents Puerto_Serie As IO.Ports.SerialPort
    Friend WithEvents ConectarAlDispositivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Z1_F As TextBox
    Friend WithEvents Z2_F As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Z3_F As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Z3_B As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Z3_H As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Z3_T As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
End Class
