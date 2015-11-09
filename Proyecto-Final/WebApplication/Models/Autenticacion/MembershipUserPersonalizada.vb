Imports System.Web.Security
Public Class MembershipUserPersonalizada
    Inherits MembershipUser

    Public id As Integer
    Public nombres As String
    Public apellidos As String
    Public correo As String
    Public rol_id As Integer
    Public rol_nombre As String

    Sub New(usuario As usuarios)
        Me.id = usuario.id
        Me.nombres = usuario.nombres
        Me.apellidos = usuario.apellidos
        Me.correo = usuario.correo
        Me.rol_id = usuario.rol_id
        Me.rol_nombre = usuario.roles.nombre
    End Sub

End Class
