@ModelType Proyecto1.empresas
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>empresas</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.identificacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.identificacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.razonSocial)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.razonSocial)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.direccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.telefono)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.telefono)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.logo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.logo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.correoElectronico)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.correoElectronico)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.estado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.estado)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
