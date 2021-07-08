@ModelType Proyecto1.productos
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
