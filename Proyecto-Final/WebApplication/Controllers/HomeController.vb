Imports System.Web.Mvc
Imports System.Web.Security

Public Class HomeController
    Inherits Controller

    Private db As New PortalNoticiasBDEntities

    ' GET: /Home
    Function Index() As ActionResult
        Dim categorias = db.Categoria.ToList
        ViewData("categorias") = categorias
        Return View()
    End Function
    <HttpGet()>
    Function Login() As ActionResult

        Return View()
    End Function

    <HttpPost()>
    Function Login(objUsuario As Usuario) As ActionResult
        If ModelState.IsValid Then
            If IsValid(objUsuario.user, objUsuario.password) Then

                FormsAuthentication.SetAuthCookie(objUsuario.user, False)
                Return Redirect("~/Usuario/Lista")
            Else
                ModelState.AddModelError("", "Error ,volver a ingresar los datos")
            End If

        End If

        Return View(objUsuario)
    End Function
    Function IsValid(usr As String, pass As String) As Boolean
        Dim IsVl As Boolean
        Dim modelUsuarios As New PortalNoticiasBDEntities
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