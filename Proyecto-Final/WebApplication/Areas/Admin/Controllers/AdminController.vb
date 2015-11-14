Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace WebApplication1
    Public Class AdminController
        Inherits System.Web.Mvc.Controller

        Private db As New PortalNoticiasBDEntities

        ' GET: /Admin/Admin/
        Function Index() As ActionResult
            Return View(db.Usuario.ToList())
        End Function

        ' GET: /Admin/Admin/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usuario As Usuario = db.Usuario.Find(id)
            If IsNothing(usuario) Then
                Return HttpNotFound()
            End If
            Return View(usuario)
        End Function

        ' GET: /Admin/Admin/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Admin/Admin/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,nom1,nom2,apePat,apeMat,user,password,correo,administrador")> ByVal usuario As Usuario) As ActionResult
            If ModelState.IsValid Then
                db.Usuario.Add(usuario)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(usuario)
        End Function

        ' GET: /Admin/Admin/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usuario As Usuario = db.Usuario.Find(id)
            If IsNothing(usuario) Then
                Return HttpNotFound()
            End If
            Return View(usuario)
        End Function

        ' POST: /Admin/Admin/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,nom1,nom2,apePat,apeMat,user,password,correo,administrador")> ByVal usuario As Usuario) As ActionResult
            If ModelState.IsValid Then
                db.Entry(usuario).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(usuario)
        End Function

        ' GET: /Admin/Admin/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usuario As Usuario = db.Usuario.Find(id)
            If IsNothing(usuario) Then
                Return HttpNotFound()
            End If
            Return View(usuario)
        End Function

        ' POST: /Admin/Admin/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim usuario As Usuario = db.Usuario.Find(id)
            db.Usuario.Remove(usuario)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
