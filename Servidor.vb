Imports System.Threading

Public Class Servidor
    Dim WithEvents WinSockServer1 As New WinSockServer()
    Private demo As Threading.Thread = Nothing
    Private demo1 As Threading.Thread = Nothing
    Private demo2 As Threading.Thread = Nothing
    Private demo3 As Threading.Thread = Nothing
    Private thread As Thread
    Dim IP1 As String
    Dim port1 As String
    Dim texto As String
    Dim texto2 As String
    Dim texto3 As String
    Dim tipo As Boolean
    Private encendido As Boolean = False
    Private tool As ToolTip = New ToolTip()
    Dim funciones As Funciones = New Funciones()
    Delegate Sub SetTextCallback(ByVal [text1] As String)

    Private Sub ThreadProcSafe()
        Me.SetText(IP1)
    End Sub

    Private Sub SetText(ByVal [text1] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.Lista.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text1]})
        Else
            If tipo Then
                Lista.Items.Add(text1)
            Else
                Lista.Items.Remove(text1)
            End If
        End If
    End Sub

    Private Sub ThreadProcSafe1()
        Me.SetText1(texto)
    End Sub

    Private Sub SetText1(ByVal [text1] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.txtMensaje.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText1)
            Me.Invoke(d, New Object() {[text1]})
        Else
            Me.txtMensaje.Text = text1
        End If
    End Sub

    Private Sub ThreadProcSafe2()
        Me.SetText2(texto2)
    End Sub

    Private Sub SetText2(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.txtDesencriptado.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText2)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.txtDesencriptado.Text = text
        End If
    End Sub

    Private Sub ThreadProcSafe3()
        Me.SetText3(texto3)
    End Sub

    Private Sub SetText3(ByVal [text1] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.Lista.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText3)
            Me.Invoke(d, New Object() {[text1]})
        Else
            txtMD5.Text = text1
        End If
    End Sub
    Private Sub Servidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.Bitacora("La aplicación Servidor fue abierta")
        'Me.txtPuerto.Text = "8050"
        tool.SetToolTip(Me.btnBoton, "Encender")
        tool.SetToolTip(Me.btnBitacora, "Bitácora")
    End Sub

    Private Sub Server_Exit(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Try
            funciones.Bitacora("La aplicación Servidor fue cerrada")
            Me.WinSockServer1 = Nothing
            End
        Catch ex As Exception
            MsgBox("Error al Salir" & ex.Message)
        End Try
    End Sub

    Private Sub WinSockServer_ConexionTerminada(ByVal IDTerminal As System.Net.IPEndPoint) Handles WinSockServer1.ConexionTerminada
        'Muestro con quien se termino la conexion 
        'MsgBox("Se ha desconectado el cliente desde la IP= " & IDTerminal.Address.ToString & _
        '                                                    ",Puerto = " & IDTerminal.Port)
        funciones.Bitacora("El usuario " & WinSockServer1.getUser(IDTerminal) & " se desconectó")
        IP1 = WinSockServer1.Cerrar(IDTerminal)
        tipo = False
        funciones.cambioEstado(New User(IP1), 0)
        WinSockServer1.ActualizarListado()
        Me.SetText(IP1)
        'Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
        'Me.demo.Start()
    End Sub

    Private Sub WinSockServer_DatosRecibidos(ByVal IDTerminal As System.Net.IPEndPoint, ByVal Datos As String) Handles WinSockServer1.DatosRecibidos
        'Muestro quien envio el mensaje 
        'TxtMensaje.Text = TxtMensaje.Text & vbCrLf & "IP(" & IDTerminal.Address.ToString & ":" & IDTerminal.Port & ")" & WinSockServer1.ObtenerDatos(IDTerminal)
        Dim y As String = Datos.Last
        Do While y.Equals("?")
            Datos = Datos.Substring(0, Datos.Length - 1)
            y = Datos.Last
        Loop
        Dim x As String = funciones.decryptString(Datos)
        Debug.WriteLine("Datos: " + Datos + "Decript, " + x)
        Debug.WriteLine("Decript: " + x)
        texto3 = x.Substring(x.IndexOf("?XXXJAMXXX?") + 11)
        Debug.WriteLine("texto3: " + texto3)
        x = x.Substring(0, x.IndexOf("?XXXJAMXXX?"))
        Debug.WriteLine("Nuevo x: " + x)
        Dim sol As Solicitud = funciones.DesSerializar(x, 1)
        texto = Datos
        texto2 = x
        If Not funciones.MD5Encrypt(texto2).Equals(texto3) Then
            MsgBox("Trama Incorrecta!" + vbCrLf + "Error al recibir la trama. La trama ha sido modificada", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim solicitud As Solicitud = New Solicitud(sol.TipoSolicitud)
        Select Case sol.TipoSolicitud
            Case 1
                funciones.Bitacora("Intento de logueo con el usuario " & sol.ArgumentosSolicitud.Item(0))
                Dim dat As Datos = New Datos(sol.ArgumentosSolicitud.Item(0), sol.ArgumentosSolicitud.Item(1))
                Dim res As ArrayList = funciones.Validar(dat)
                If res.Count > 0 Then
                    System.Threading.Thread.Sleep(1000)
                    funciones.Bitacora("Éxito al loguear al usuario " & sol.ArgumentosSolicitud.Item(0))
                    solicitud.MensajeSolicitud = "Exito al hacer login"
                    solicitud.ArgumentosSolicitud = res
                    IP1 = sol.ArgumentosSolicitud.Item(0).ToString
                    WinSockServer1.SetUser(IDTerminal, IP1)
                    tipo = True
                    funciones.cambioEstado(New User(IP1), 1)
                    Me.demo = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe))
                    Me.demo.Start()
                Else
                    funciones.Bitacora("Error al hacer login con el usuario " & sol.ArgumentosSolicitud.Item(0))
                    solicitud.MensajeSolicitud = "Error al hacer login"
                End If

            Case 2
                Dim parametros As String = funciones.decryptString(sol.MensajeSolicitud)
                texto = sol.MensajeSolicitud
                texto3 = parametros.Substring(parametros.IndexOf("?XXXJAMXXX?") + 11)
                parametros = parametros.Substring(0, parametros.IndexOf("?XXXJAMXXX?"))
                texto2 = parametros
                Dim registro As Registro = funciones.DesSerializarRegistro(parametros)
                Dim creado As Boolean = funciones.nuevoRegistro(registro)
                If (registro.tabla <> "" And registro.parametros.Count And creado) Then
                    solicitud.MensajeSolicitud = "Registro Creado!"
                Else
                    solicitud.MensajeSolicitud = "Error al crear Registro!"
                End If

            Case 3
                funciones.Bitacora("El usuario " & sol.ArgumentosSolicitud.Item(0).ToString & "(" & sol.ArgumentosSolicitud.Item(1).ToString & ")" & " solicitó el listado de usuarios")
                WinSockServer1.SetUser(IDTerminal, sol.ArgumentosSolicitud.Item(0).ToString, 0)
                solicitud.ArgumentosSolicitud = funciones.obtenerClientes(New User(sol.ArgumentosSolicitud.Item(0).ToString))
                solicitud.MensajeSolicitud = "Usuarios Enviados"
                funciones.Bitacora("Se envió el listado de usuarios a " & sol.ArgumentosSolicitud.Item(0).ToString)

            Case 4
                funciones.Bitacora("El usuario " & sol.ArgumentosSolicitud.Item(0).ToString & "(" & sol.ArgumentosSolicitud.Item(1).ToString & ")" & " solicitó los datos de la tabla " & sol.MensajeSolicitud)
                WinSockServer1.SetUser(IDTerminal, sol.ArgumentosSolicitud.Item(0).ToString, sol.ArgumentosSolicitud.Item(1))
                Dim arg As ArrayList = New ArrayList
                arg = funciones.obtenerRegistros(sol.MensajeSolicitud, sol.ArgumentosSolicitud)

                solicitud.ArgumentosSolicitud = arg
                solicitud.MensajeSolicitud = "Registros Enviados"
                funciones.Bitacora("Se enviaron los registros de la tabla " & sol.MensajeSolicitud & " a " & sol.ArgumentosSolicitud.Item(0).ToString & "(" & sol.ArgumentosSolicitud.Item(1).ToString & ")")

            Case Else

        End Select

        Dim xml As String = funciones.Serializar(solicitud, "Solicitud")
        Dim salMd As String = funciones.MD5Encrypt(xml)
        Dim tDes As String = funciones.encryptString(xml & "?XXXJAMXXX?" & salMd)
        Me.txtSalDesencriptado.Text = xml
        Me.txtSalEncriptado.Text = tDes
        Me.txtSalMD5.Text = salMd
        Me.WinSockServer1.EnviarDatos(IDTerminal, tDes)

        'Me.SetText2(texto2)
        'Me.SetText3(texto3)
        'Me.SetText1(texto)

        Me.demo1 = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe1))
        Me.demo1.Start()
        Me.demo2 = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe2))
        Me.demo2.Start()
        Me.demo3 = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ThreadProcSafe3))
        Me.demo3.Start()

        System.Threading.Thread.Sleep(600)
        'If solicitud.TipoSolicitud = 1 Then
        'WinSockServer1.ActualizarListado()
        'End If

        'Muestro el mensaje recibido 
        ' Call MsgBox(WinSockServer1.ObtenerDatos(IDTerminal))
    End Sub

    Private Sub btnBoton_Click(sender As Object, e As EventArgs) Handles btnBoton.Click
        If Not encendido Then
            funciones.Bitacora("Se encendió el servidor")
            With WinSockServer1
                'Establezco el puerto donde escuchar 
                .PuertoDeEscucha = "8050"
                '.PuertoDeEscucha = Me.txtPuerto.Text
                'Comienzo la escucha 
                If .Escuchar() Then
                    encendido = True
                    tool.SetToolTip(Me.btnBoton, "Apagar")
                    btnBoton.Image = ProyectoServer.My.Resources.OFF
                End If
            End With
        Else
            funciones.Bitacora("Se apagó el servidor")
            With WinSockServer1
                .Cerrar()
            End With
            encendido = False
            tool.SetToolTip(Me.btnBoton, "Encender")
            btnBoton.Image = ProyectoServer.My.Resources._ON
        End If
    End Sub

    Private Sub btnBitacora_Click(sender As Object, e As EventArgs) Handles btnBitacora.Click
        Dim bitacora As New Bitacora()
        bitacora.Show()
    End Sub
End Class