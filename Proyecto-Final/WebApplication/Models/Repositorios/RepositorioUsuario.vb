Public Class RepositorioUsuario
    Inherits RepositorioGenerico(Of usuarios)
    Implements IRepositorioUsuario



    Public Function login(usuario As usuarios) As Boolean Implements IRepositorioUsuario.login

        Try
            Dim modelo As New libreriaEntities
            modelo.usuarios.Single(Function(model) model.correo = usuario.correo And model.clave = usuario.clave)

            Return True
        Catch ex As Exception

            Return False
        End Try

    End Function

    Public Function obtenerDatos(correo As String) As usuarios Implements IRepositorioUsuario.obtenerDatos

        Try
            Dim modelo As New libreriaEntities
            Dim usuario As usuarios = modelo.usuarios.Single(Function(model) model.correo = correo)

            Return usuario
        Catch ex As Exception

            Return Nothing
        End Try

    End Function

    Public Function obtenerRoles(correo As String) As String() Implements IRepositorioUsuario.obtenerRoles

        Dim rol As String()
        Try
            Dim modelo As New libreriaEntities
            Dim usuario As usuarios = modelo.usuarios.Single(Function(model) model.correo = correo)
            rol = {usuario.roles.nombre}

            Return rol

        Catch ex As Exception
            rol = {}
            Return rol
        End Try

    End Function

End Class
