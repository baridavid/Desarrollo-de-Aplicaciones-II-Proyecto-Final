Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace WebApplication1
    Public Class NoticiaController
        Inherits System.Web.Mvc.Controller

        Private db As New PortalNoticiasBDEntities

        ' GET: /Noticia/
        Function Index() As ActionResult
            Dim noticia = db.Noticia.Include(Function(n) n.Categoria).Include(Function(n) n.Puntuacion)
            Return View(noticia.ToList())
        End Function

        ' GET: /Noticia/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim noticia As Noticia = db.Noticia.Find(id)
            If IsNothing(noticia) Then
                Return HttpNotFound()
            End If
            Return View(noticia)
        End Function

        ' GET: /Noticia/Create
        Function Create() As ActionResult
            ViewBag.fkCategoria = New SelectList(db.Categoria, "Id", "nombre")
            ViewBag.fkPuntuacion = New SelectList(db.Puntuacion, "Id", "puntuacion1")
            Return View()
        End Function

        ' POST: /Noticia/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "Id,titulo,resumen,detalle,fechaCreacion,fuente,imagen,fkPuntuacion,fkCategoria")> ByVal noticia As Noticia) As ActionResult
            If ModelState.IsValid Then
                db.Noticia.Add(noticia)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.fkCategoria = New SelectList(db.Categoria, "Id", "nombre", noticia.fkCategoria)
            ViewBag.fkPuntuacion = New SelectList(db.Puntuacion, "Id", "puntuacion1", noticia.fkPuntuacion)
            Return View(noticia)
        End Function

        ' GET: /Noticia/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim noticia As Noticia = db.Noticia.Find(id)
            If IsNothing(noticia) Then
                Return HttpNotFound()
            End If
            ViewBag.fkCategoria = New SelectList(db.Categoria, "Id", "nombre", noticia.fkCategoria)
            ViewBag.fkPuntuacion = New SelectList(db.Puntuacion, "Id", "puntuacion1", noticia.fkPuntuacion)
            Return View(noticia)
        End Function

        ' POST: /Noticia/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "Id,titulo,resumen,detalle,fechaCreacion,fuente,imagen,fkPuntuacion,fkCategoria")> ByVal noticia As Noticia) As ActionResult
            If ModelState.IsValid Then
                db.Entry(noticia).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.fkCategoria = New SelectList(db.Categoria, "Id", "nombre", noticia.fkCategoria)
            ViewBag.fkPuntuacion = New SelectList(db.Puntuacion, "Id", "puntuacion1", noticia.fkPuntuacion)
            Return View(noticia)
        End Function

        ' GET: /Noticia/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim noticia As Noticia = db.Noticia.Find(id)
            If IsNothing(noticia) Then
                Return HttpNotFound()
            End If
            Return View(noticia)
        End Function

        ' POST: /Noticia/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim noticia As Noticia = db.Noticia.Find(id)
            db.Noticia.Remove(noticia)
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
