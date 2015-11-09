Imports System.Security.Principal

Public Class PrincipalPersonalizada
    Implements IPrincipal

    Private identidadPersonalizadaValue As IdentityPersonalizada

    Sub New(identidad As IdentityPersonalizada)
        Me.identidadPersonalizada = identidad
    End Sub

    Public Property identidadPersonalizada As IdentityPersonalizada
        Get
            Return identidadPersonalizadaValue ''CType(Identity, IdentityPersonalizada)
        End Get
        Private Set(value As IdentityPersonalizada)
            identidadPersonalizadaValue = value
        End Set
    End Property



    Public Function IsInRole(role As String) As Boolean Implements IPrincipal.IsInRole
        Dim comparador As Integer = String.Compare(role, CType(Identity, IdentityPersonalizada).rol_nombre, False)

        If comparador = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public ReadOnly Property Identity As IIdentity Implements IPrincipal.Identity
        Get
            Return Me.identidadPersonalizadaValue
        End Get
    End Property
End Class
