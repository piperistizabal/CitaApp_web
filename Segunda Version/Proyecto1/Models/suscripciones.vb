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

Partial Public Class suscripciones
    Public Property id As Integer
    Public Property id_Empresa As Integer
    Public Property fechaInicio As Date
    Public Property fechaFin As Nullable(Of Date)
    Public Property id_Plan As Integer
    Public Property estado As Nullable(Of Boolean)

    Public Overridable Property empresas As empresas
    Public Overridable Property planes As planes

End Class
