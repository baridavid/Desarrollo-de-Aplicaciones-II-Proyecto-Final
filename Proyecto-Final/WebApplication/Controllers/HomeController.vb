Imports System.Web.Mvc

Public Class HomeController
    Inherits Controller

    ' GET: /Home
    Function Index() As ActionResult
        Return View()
    End Function
    <HttpGet()>
    Function Login() As ActionResult

        Return View()
    End Function

    <HttpPost()>
    Function Login(objUsuario As Usuario) As ActionResult
        If IsValid(objUsuario.user, objUsuario.password) Then

            FormsAuthentication.SetAuthCookie(objUsuario.user, False)
            Return Redirect("Index")
        End If
        ModelState.AddModelError("", "Error ,volver a ingresar los datos")
        Return View(objUsuario)
    End Function
    Function IsValid(usr As String, pass As String) As Boolean
        Dim IsVl As Boolean
        Dim modelUsuarios As New PortalNoticias_BDEntities
        IsVl = False
        Using (modelUsuarios)
            Dim user = modelUsuarios.Usuario.FirstOrDefault(Function(Model) Model.user = usr)
            If user IsNot Nothing Then
                If user.password = pass Then
                    IsVl = True
                End If
            End If
        End Using
        Return IsVl
    End Function

    Function LogOut() As ActionResult
        FormsAuthentication.SignOut()
        Return RedirectToAction("Index")
    End Function
End Class