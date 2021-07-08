@ModelType Proyecto1.productos
@Code
    ViewData("Title") = "Create"
End Code


<div class="row container_center title-basic">
    <h1>Cracion Productos</h1>
</div>
<div class="row container_center">
    <div class="col-md-8">


        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="form-horizontal">
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-row">
        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.nombre, htmlAttributes:=New With {.class = "control-label "})
            @Html.EditorFor(Function(model) model.nombre, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.nombre, "", New With {.class = "text-danger"})
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.descripcion, htmlAttributes:=New With {.class = "control-label"})
            @Html.EditorFor(Function(model) model.descripcion, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.descripcion, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-row">
        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.tipo, htmlAttributes:=New With {.class = "control-label"})
            @Html.EditorFor(Function(model) model.tipo, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.tipo, "", New With {.class = "text-danger"})
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.stock, htmlAttributes:=New With {.class = "control-label"})
            @Html.EditorFor(Function(model) model.stock, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.stock, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.valor, htmlAttributes:=New With {.class = "control-label"})
            @Html.EditorFor(Function(model) model.valor, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.valor, "", New With {.class = "text-danger"})
        </div>

        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.id_Empresa, "id_Empresa", htmlAttributes:=New With {.class = "control-label"})
            @Html.DropDownList("id_Empresa", Nothing, htmlAttributes:=New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.id_Empresa, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-6">
            @Html.LabelFor(Function(model) model.estado, htmlAttributes:=New With {.class = "control-label"})
            <div class="checkbox">
                @Html.EditorFor(Function(model) model.estado)
                @Html.ValidationMessageFor(Function(model) model.estado, "", New With {.class = "text-danger"})
            </div>
        </div>
    </div>
    <div class="form-row">
        <div class="form-group col-md-12">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
     </div>
    </div>
    End Using
</div>
</div>


<div>
    @Html.ActionLink("Volver a Listado", "Index", Function(model) model.nombre, htmlAttributes:=New With {.class = "btn btn-primary"})
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
