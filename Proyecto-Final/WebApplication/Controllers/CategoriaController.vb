Imports System.Web.Mvc

Public Class CategoriaController
    Inherits Controller

    ' GET: /Categoria
    Function Index() As ActionResult
        Return View()
    End Function

    Function Lista() As ActionResult
        Dim modelCategorias As New PortalNoticias_BDEntities
        Dim categoriasListado As List(Of Categoria) = modelCategorias.Categoria.ToList
        Return View(categoriasListado)
    End Function

    <HttpGet()>
    Function Create() As ActionResult
        Return View()
    End Function

    <HttpPost()>
    Function Create(objCategoria As Categoria) As ActionResult
        Dim modelCategorias As New PortalNoticias_BDEntities
        modelCategorias.Categoria.Add(objCategoria)
        modelCategorias.SaveChanges()
        Return RedirectToAction("Lista")
    End Function

    <HttpGet()>
    Function Edit(id As Integer) As ActionResult
        Dim modelCategorias As New PortalNoticias_BDEntities
        Dim categoria As Categoria = modelCategorias.Categoria.Find(id)
        Return View(categoria)
    End Function

    <HttpPost()>
    Function Edit(objCategoria As Categoria) As ActionResult
        Dim modelCategorias As New PortalNoticias_BDEntities
        modelCategorias.Entry(objCategoria).State = Entity.EntityState.Modified
        modelCategorias.SaveChanges()
        Return RedirectToAction("Lista")
    End Function

    Function Details(id As Integer) As ActionResult
        Dim modelCategorias As New PortalNoticias_BDEntities
        Dim categoria As Categoria = modelCategorias.Categoria.Find(id)
        Return View(categoria)
    End Function

    Function Delete(id As Integer) As ActionResult
        Dim modelCategorias As New PortalNoticias_BDEntities
        Dim categoria As Categoria = modelCategorias.Categoria.Find(id)
        modelCategorias.Categoria.Remove(categoria)
        modelCategorias.SaveChanges()
        Return RedirectToAction("Lista")
    End Function

End Class