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

Partial Public Class planes
    Public Property id As Integer
    Public Property nombre As String
    Public Property descripcion As String
    Public Property valor As Decimal
    Public Property duracion As Integer
    Public Property estado As Nullable(Of Boolean)

    Public Overridable Property suscripciones As ICollection(Of suscripciones) = New HashSet(Of suscripciones)

End Class
