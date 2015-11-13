Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace WebApplication1
    Public Class CategoriasController
        Inherits System.Web.Mvc.Controller

        Private db As New PortalNoticiasBDEntities

        ' GET: /Categorias/
        Function Index() As ActionResult
            Return View(db.Categoria.ToList())
        End Function

        ' GET: /Categorias/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim categoria As Categoria = db.Categoria.Find(id)
            If IsNothing(categoria) Then
                Return HttpNotFound()
            End If
            Return View(categoria)
        End Function

        ' GET: /Categorias/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Categorias/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,nombre,descripcion,imagen")> ByVal categoria As Categoria) As ActionResult
            If ModelState.IsValid Then
                db.Categoria.Add(categoria)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            Return View(categoria)
        End Function

        ' GET: /Categorias/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim categoria As Categoria = db.Categoria.Find(id)
            If IsNothing(categoria) Then
                Return HttpNotFound()
            End If
            Return View(categoria)
        End Function

        ' POST: /Categorias/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,nombre,descripcion,imagen")> ByVal categoria As Categoria) As ActionResult
            If ModelState.IsValid Then
                db.Entry(categoria).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(categoria)
        End Function

        ' GET: /Categorias/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim categoria As Categoria = db.Categoria.Find(id)
            If IsNothing(categoria) Then
                Return HttpNotFound()
            End If
            Return View(categoria)
        End Function

        ' POST: /Categorias/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim categoria As Categoria = db.Categoria.Find(id)
            db.Categoria.Remove(categoria)
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
