Imports System.Web.Security

Public Class RolesPersonalizada
    Inherits RoleProvider

    Public Overrides Sub AddUsersToRoles(usernames() As String, roleNames() As String)

    End Sub

    Public Overrides Property ApplicationName As String

    Public Overrides Sub CreateRole(roleName As String)

    End Sub

    Public Overrides Function DeleteRole(roleName As String, throwOnPopulatedRole As Boolean) As Boolean

    End Function

    Public Overrides Function FindUsersInRole(roleName As String, usernameToMatch As String) As String()

    End Function

    Public Overrides Function GetAllRoles() As String()

    End Function

    Public Overrides Function GetRolesForUser(username As String) As String()

        If HttpContext.Current.User.Identity.IsAuthenticated = False Then
            Return {}
        End If

        ''
        Dim nomCache As String = username & "_roles"

        If HttpRuntime.Cache(nomCache) IsNot Nothing Then
            Return CType(HttpRuntime.Cache(nomCache), String())
        Else
            Dim iUsuario As IRepositorioUsuario = New RepositorioUsuario
            Dim roles() = iUsuario.obtenerRoles(username)

            HttpRuntime.Cache.Insert(nomCache, roles, Nothing, DateTime.Now.AddMinutes(10), Cache.NoSlidingExpiration)

            Return roles.ToArray
        End If

    End Function

    Public Overrides Function GetUsersInRole(roleName As String) As String()

    End Function

    Public Overrides Function IsUserInRole(username As String, roleName As String) As Boolean
        Dim roles = Me.GetRolesForUser(username)
        Return roles.Contains(roleName)
    End Function

    Public Overrides Sub RemoveUsersFromRoles(usernames() As String, roleNames() As String)

    End Sub

    Public Overrides Function RoleExists(roleName As String) As Boolean

    End Function
End Class
