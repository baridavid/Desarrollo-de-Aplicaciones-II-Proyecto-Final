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

Partial Public Class Puntuacion
    Public Property Id As Integer
    Public Property puntuacion1 As String
    Public Property valoracion As String
    Public Property descripcion As String

    Public Overridable Property Noticia As ICollection(Of Noticia) = New HashSet(Of Noticia)

End Class
