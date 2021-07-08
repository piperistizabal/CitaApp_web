@ModelType Proyecto1.productos
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>productos</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.descripcion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.stock)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.stock)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.valor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.valor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.estado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.estado)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.empresas.identificacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.empresas.identificacion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
