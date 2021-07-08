@ModelType IEnumerable(Of Proyecto1.empresas)
@Code
    ViewData("Title") = "Index"
End Code

    <div class="row col-md-12 container_center title-basic">
        <h1>Listado de Empresas</h1>
    </div>


    <p>
        @Html.ActionLink("Crear Nuevo", "Create", Function(model) model.nombre, htmlAttributes:=New With {.class = "btn btn-primary"})
    </p>
    <div class="row container_center">
        <table class="table">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.identificacion)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.nombre)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.razonSocial)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.tipo)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.direccion)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.telefono)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.logo)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.correoElectronico)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.estado)
                </th>
                <th></th>
            </tr>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.identificacion)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.nombre)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.razonSocial)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.tipo)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.direccion)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.telefono)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.logo)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.correoElectronico)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.estado)
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


