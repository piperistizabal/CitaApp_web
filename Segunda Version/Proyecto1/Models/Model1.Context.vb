'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class CitAppEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=CitAppEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property agendamientos() As DbSet(Of agendamientos)
    Public Overridable Property agendamientos_detalles() As DbSet(Of agendamientos_detalles)
    Public Overridable Property disponibilidad() As DbSet(Of disponibilidad)
    Public Overridable Property empresas() As DbSet(Of empresas)
    Public Overridable Property espacios() As DbSet(Of espacios)
    Public Overridable Property pagos() As DbSet(Of pagos)
    Public Overridable Property parametros() As DbSet(Of parametros)
    Public Overridable Property planes() As DbSet(Of planes)
    Public Overridable Property productos() As DbSet(Of productos)
    Public Overridable Property profesionales() As DbSet(Of profesionales)
    Public Overridable Property suscripciones() As DbSet(Of suscripciones)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Overridable Property usuarios() As DbSet(Of usuarios)

End Class
