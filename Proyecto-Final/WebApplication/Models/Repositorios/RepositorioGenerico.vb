Imports System.Data.Entity

Public Class RepositorioGenerico(Of TEntity As Class)
    Implements IRepositorioGenerico(Of TEntity)


    Private _libreriaEntities As libreriaEntities
    Private _entidad As DbSet(Of TEntity)

    Sub New()
        Me._libreriaEntities = New libreriaEntities
        Me._entidad = _libreriaEntities.Set(Of TEntity)()
    End Sub

    Public Function actualizar(entidad As TEntity) As Boolean Implements IRepositorioGenerico(Of TEntity).actualizar
        Try
            Me._libreriaEntities.Entry(entidad).State = EntityState.Modified
            Me._libreriaEntities.SaveChanges()

            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Public Function agregar(entidad As TEntity) As Boolean Implements IRepositorioGenerico(Of TEntity).agregar
        Try
            Me._entidad.Add(entidad)
            Me._libreriaEntities.SaveChanges()

            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Public Function buscarPorID(id As Integer) As TEntity Implements IRepositorioGenerico(Of TEntity).buscarPorID
        Try

            Return Me._entidad.Find(id)
        Catch ex As Exception

            Return Nothing
        End Try
    End Function

    Public Function eliminar(entidad As TEntity) As Boolean Implements IRepositorioGenerico(Of TEntity).eliminar
        Try
            Me._libreriaEntities.Entry(entidad).State = EntityState.Deleted
            Me._libreriaEntities.SaveChanges()

            'En el caso de recibir el ID
            'Dim entidad = Me._entidad.Find(id)
            'Me._entidad.Remove(entidad)
            'Me._libreriaEntities.SaveChanges()

            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Public Function seleccionarTodas() As IEnumerable(Of TEntity) Implements IRepositorioGenerico(Of TEntity).seleccionarTodas
        Try

            Return Me._entidad.ToList
        Catch ex As Exception

            Return Nothing
        End Try
    End Function
End Class
