<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servidor
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMD5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesencriptado = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSalMD5 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSalDesencriptado = New System.Windows.Forms.TextBox()
        Me.txtSalEncriptado = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBoton = New System.Windows.Forms.Button()
        Me.Lista = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBitacora = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(865, 431)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(855, 405)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtMD5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtDesencriptado)
        Me.TabPage1.Controls.Add(Me.txtMensaje)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(847, 379)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Entradas de Datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(683, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Encriptación MD5"
        '
        'txtMD5
        '
        Me.txtMD5.Enabled = False
        Me.txtMD5.Location = New System.Drawing.Point(638, 40)
        Me.txtMD5.Multiline = True
        Me.txtMD5.Name = "txtMD5"
        Me.txtMD5.Size = New System.Drawing.Size(189, 319)
        Me.txtMD5.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(427, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desencriptado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Encriptado"
        '
        'txtDesencriptado
        '
        Me.txtDesencriptado.Enabled = False
        Me.txtDesencriptado.Location = New System.Drawing.Point(320, 40)
        Me.txtDesencriptado.Multiline = True
        Me.txtDesencriptado.Name = "txtDesencriptado"
        Me.txtDesencriptado.Size = New System.Drawing.Size(290, 319)
        Me.txtDesencriptado.TabIndex = 1
        '
        'txtMensaje
        '
        Me.txtMensaje.Enabled = False
        Me.txtMensaje.Location = New System.Drawing.Point(18, 40)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(290, 319)
        Me.txtMensaje.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtSalMD5)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtSalDesencriptado)
        Me.TabPage2.Controls.Add(Me.txtSalEncriptado)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(847, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salidas de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(684, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Encriptación MD5"
        '
        'txtSalMD5
        '
        Me.txtSalMD5.Enabled = False
        Me.txtSalMD5.Location = New System.Drawing.Point(637, 42)
        Me.txtSalMD5.Multiline = True
        Me.txtSalMD5.Name = "txtSalMD5"
        Me.txtSalMD5.Size = New System.Drawing.Size(189, 319)
        Me.txtSalMD5.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Desencriptado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Encriptado"
        '
        'txtSalDesencriptado
        '
        Me.txtSalDesencriptado.Enabled = False
        Me.txtSalDesencriptado.Location = New System.Drawing.Point(320, 42)
        Me.txtSalDesencriptado.Multiline = True
        Me.txtSalDesencriptado.Name = "txtSalDesencriptado"
        Me.txtSalDesencriptado.Size = New System.Drawing.Size(290, 319)
        Me.txtSalDesencriptado.TabIndex = 5
        '
        'txtSalEncriptado
        '
        Me.txtSalEncriptado.Enabled = False
        Me.txtSalEncriptado.Location = New System.Drawing.Point(18, 42)
        Me.txtSalEncriptado.Multiline = True
        Me.txtSalEncriptado.Name = "txtSalEncriptado"
        Me.txtSalEncriptado.Size = New System.Drawing.Size(290, 319)
        Me.txtSalEncriptado.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoServer.My.Resources.Resources.TSE
        Me.PictureBox1.Location = New System.Drawing.Point(857, 443)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnBoton
        '
        Me.btnBoton.Image = Global.ProyectoServer.My.Resources.Resources._ON
        Me.btnBoton.Location = New System.Drawing.Point(36, 463)
        Me.btnBoton.Name = "btnBoton"
        Me.btnBoton.Size = New System.Drawing.Size(63, 62)
        Me.btnBoton.TabIndex = 7
        Me.btnBoton.UseVisualStyleBackColor = True
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(19, 41)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(199, 381)
        Me.Lista.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lista)
        Me.GroupBox1.Location = New System.Drawing.Point(881, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 431)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'btnBitacora
        '
        Me.btnBitacora.Image = Global.ProyectoServer.My.Resources.Resources.log
        Me.btnBitacora.Location = New System.Drawing.Point(429, 469)
        Me.btnBitacora.Name = "btnBitacora"
        Me.btnBitacora.Size = New System.Drawing.Size(50, 50)
        Me.btnBitacora.TabIndex = 11
        Me.btnBitacora.UseVisualStyleBackColor = True
        '
        'Servidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 552)
        Me.Controls.Add(Me.btnBitacora)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBoton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Servidor"
        Me.Text = "Servidor"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBoton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesencriptado As System.Windows.Forms.TextBox
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSalDesencriptado As System.Windows.Forms.TextBox
    Friend WithEvents txtSalEncriptado As System.Windows.Forms.TextBox
    Friend WithEvents Lista As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSalMD5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMD5 As System.Windows.Forms.TextBox
    Friend WithEvents btnBitacora As System.Windows.Forms.Button
End Class
