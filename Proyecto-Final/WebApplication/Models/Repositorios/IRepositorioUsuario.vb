Public Interface IRepositorioUsuario
    Inherits IRepositorioGenerico(Of usuarios)

    Function login(usuario As usuarios) As Boolean

    Function obtenerDatos(correo As String) As usuarios

    Function obtenerRoles(correo As String) As String()

End Interface
