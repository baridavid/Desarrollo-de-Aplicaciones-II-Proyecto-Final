'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Noticia
    Public Property Id As Integer
    Public Property titulo As String
    Public Property resumen As String
    Public Property detalle As String
    Public Property fechaCreacion As Nullable(Of Date)
    Public Property fuente As String
    Public Property imagen As Byte()
    Public Property fkPuntuacion As Integer
    Public Property fkCategoria As Integer

    Public Overridable Property Categoria As Categoria
    Public Overridable Property Comentario As ICollection(Of Comentario) = New HashSet(Of Comentario)
    Public Overridable Property Preferencia As ICollection(Of Preferencia) = New HashSet(Of Preferencia)
    Public Overridable Property Puntuacion As Puntuacion

End Class
