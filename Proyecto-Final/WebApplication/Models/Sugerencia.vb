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

Partial Public Class Sugerencia
    Public Property Id As Integer
    Public Property contenido As String
    Public Property fechaCreacion As Nullable(Of Date)
    Public Property fkUsuario As Integer

    Public Overridable Property Usuario As Usuario

End Class