Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Proyecto1

Namespace Controllers
    Public Class productosController
        Inherits System.Web.Mvc.Controller

        Private db As New CitAppEntities

        ' GET: productos
        Function Index() As ActionResult
            Dim productos = db.productos.Include(Function(p) p.empresas)
            Return View(productos.ToList())
        End Function

        ' GET: productos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim productos As productos = db.productos.Find(id)
            If IsNothing(productos) Then
                Return HttpNotFound()
            End If
            Return View(productos)
        End Function

        ' GET: productos/Create
        Function Create() As ActionResult
            ViewBag.id_Empresa = New SelectList(db.empresas, "id", "identificacion")
            Return View()
        End Function

        ' POST: productos/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,nombre,descripcion,tipo,stock,valor,id_Empresa,estado")> ByVal productos As productos) As ActionResult
            If ModelState.IsValid Then
                db.productos.Add(productos)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.id_Empresa = New SelectList(db.empresas, "id", "identificacion", productos.id_Empresa)
            Return View(productos)
        End Function

        ' GET: productos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim productos As productos = db.productos.Find(id)
            If IsNothing(productos) Then
                Return HttpNotFound()
            End If
            ViewBag.id_Empresa = New SelectList(db.empresas, "id", "identificacion", productos.id_Empresa)
            Return View(productos)
        End Function

        ' POST: productos/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,nombre,descripcion,tipo,stock,valor,id_Empresa,estado")> ByVal productos As productos) As ActionResult
            If ModelState.IsValid Then
                db.Entry(productos).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.id_Empresa = New SelectList(db.empresas, "id", "identificacion", productos.id_Empresa)
            Return View(productos)
        End Function

        ' GET: productos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim productos As productos = db.productos.Find(id)
            If IsNothing(productos) Then
                Return HttpNotFound()
            End If
            Return View(productos)
        End Function

        ' POST: productos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim productos As productos = db.productos.Find(id)
            db.productos.Remove(productos)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
