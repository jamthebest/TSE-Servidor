Public Class Registro
    Public tabla As String
    Public parametros As ArrayList

    Public Sub New()
        Me.tabla = ""
        Me.parametros = New ArrayList()
    End Sub

    Public Sub New(ByVal tabla As String)
        Me.tabla = tabla
        Me.parametros = New ArrayList()
    End Sub

    Public Sub New(ByVal tabla As String, ByVal parametros As ArrayList)
        Me.tabla = tabla
        Me.parametros = parametros
    End Sub

End Class
