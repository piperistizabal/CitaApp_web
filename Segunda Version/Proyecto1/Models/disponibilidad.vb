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

Partial Public Class disponibilidad
    Public Property id As Integer
    Public Property fechaInicio As Date
    Public Property fechaFin As Date
    Public Property horaInicio As System.TimeSpan
    Public Property horaFin As System.TimeSpan
    Public Property id_Espacio As Nullable(Of Integer)
    Public Property id_Profesional As Nullable(Of Integer)
    Public Property id_Producto As Nullable(Of Integer)
    Public Property estado As Nullable(Of Boolean)

    Public Overridable Property espacios As espacios
    Public Overridable Property profesionales As profesionales
    Public Overridable Property productos As productos

End Class
