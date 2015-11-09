Imports System.Security.Principal

Public Class IdentityPersonalizada
    Implements IIdentity

    Public id As Integer
    Public nombres As String
    Public apellidos As String
    Public correo As String
    Public rol_id As Integer
    Public rol_nombre As String

    Public Identidad As IIdentity

    Sub New(identidad As IIdentity)
        Me.Identidad = identidad
        Dim MembershipUserPersonalizada = CType(Membership.GetUser(identidad.Name), MembershipUserPersonalizada)
        If MembershipUserPersonalizada IsNot Nothing Then
            Me.id = MembershipUserPersonalizada.id
            Me.nombres = MembershipUserPersonalizada.nombres
            Me.apellidos = MembershipUserPersonalizada.apellidos
            Me.correo = MembershipUserPersonalizada.correo
            Me.rol_id = MembershipUserPersonalizada.rol_id
            Me.rol_nombre = MembershipUserPersonalizada.rol_nombre

        End If
    End Sub

    Public ReadOnly Property AuthenticationType As String Implements IIdentity.AuthenticationType
        Get
            Return Me.Identidad.AuthenticationType
        End Get
    End Property

    Public ReadOnly Property IsAuthenticated As Boolean Implements IIdentity.IsAuthenticated
        Get
            Return Me.Identidad.IsAuthenticated
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IIdentity.Name
        Get
            Return Me.Identidad.Name
        End Get
    End Property
End Class
