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

Partial Public Class Usuario
    Public Property Id As Integer
    Public Property nom1 As String
    Public Property nom2 As String
    Public Property apePat As String
    Public Property apeMat As String
    Public Property user As String
    Public Property password As String
    Public Property correo As String
    Public Property administrador As Boolean

    Public Overridable Property Comentario As ICollection(Of Comentario) = New HashSet(Of Comentario)
    Public Overridable Property Preferencia As ICollection(Of Preferencia) = New HashSet(Of Preferencia)
    Public Overridable Property Sugerencia As ICollection(Of Sugerencia) = New HashSet(Of Sugerencia)

End Class
