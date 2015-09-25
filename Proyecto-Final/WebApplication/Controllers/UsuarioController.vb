Imports System.Web.Mvc

Public Class UsuarioController
    Inherits Controller

    ' GET: /Usuario
    Function Index() As ActionResult
        Return View()
    End Function

    Function Lista() As ActionResult
        Dim modelUsuario As New PortalNoticiasBDEntities
        Dim usuarioListado As List(Of Usuario) = modelUsuario.Usuario.ToList
        Return View(usuarioListado)
    End Function

    ' GET: /Usuario/Details/5
    Function Details(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    ' GET: /Usuario/Create
    Function Create() As ActionResult
        Return View()
    End Function

    ' POST: /Usuario/Create
    <HttpPost()>
    Function Create(ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Add insert logic here

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    ' GET: /Usuario/Edit/5
    Function Edit(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    ' POST: /Usuario/Edit/5
    <HttpPost()>
    Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Add update logic here

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    ' GET: /Usuario/Delete/5
    Function Delete(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    ' POST: /Usuario/Delete/5
    <HttpPost()>
    Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Add delete logic here

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class