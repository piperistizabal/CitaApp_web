@ModelType IEnumerable(Of Proyecto1.productos)
@Code
    ViewData("Title") = "Index"
End Code

<div class="row col-md-12 container_center title-basic">
    <h1>Listado de Productos</h1>
</div>

<p>
    @Html.ActionLink("Crear Nuevo", "Create", Function(model) model.nombre, htmlAttributes:=New With {.class = "btn btn-primary"})
</p>
<div class="row container_center">
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.nombre)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.descripcion)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.tipo)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.stock)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.valor)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.estado)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.empresas.identificacion)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.nombre)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.descripcion)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.tipo)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.stock)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.valor)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.estado)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.empresas.identificacion)
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.id}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.id}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.id})
                </td>
            </tr>
        Next
      </table>
    </div>
