@ModelType Proyecto1.empresas
@Code
    ViewData("Title") = "Create"
End Code



    <div class="row container_center title-basic">
        <h1>Cracion Empresa</h1>
    </div>
    <div class="row container_center">
        <div class="col-md-8" style=" margin-left: 45px;">

            @Using (Html.BeginForm())
                @Html.AntiForgeryToken()

                @<div class="form-horizontal">
                   
                    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

                    
                        <div class="form-group col-md-6">
                            @Html.LabelFor(Function(model) model.identificacion, htmlAttributes:=New With {.class = "control-label"})
                            @Html.EditorFor(Function(model) model.identificacion, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.identificacion, "", New With {.class = "text-danger"})
                        </div>

                        <div class="form-group col-md-6">
                            @Html.LabelFor(Function(model) model.nombre, htmlAttributes:=New With {.class = "control-label"})
                            @Html.EditorFor(Function(model) model.nombre, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.nombre, "", New With {.class = "text-danger"})
                        </div>
                 

                    <div class="form-row">
                        <div class="form-group col-md-6">
                            @Html.LabelFor(Function(model) model.razonSocial, htmlAttributes:=New With {.class = "control-label"})
                            @Html.EditorFor(Function(model) model.razonSocial, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.razonSocial, "", New With {.class = "text-danger"})
                        </div>
                        <div class="form-group col-md-6">
                            @Html.LabelFor(Function(model) model.tipo, htmlAttributes:=New With {.class = "control-label"})
                            @Html.EditorFor(Function(model) model.tipo, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.tipo, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="form-row">
                        <div class="form-group col-md-6">
                            @Html.LabelFor(Function(model) model.direccion, htmlAttributes:=New With {.class = "control-label"})
                            @Html.EditorFor(Function(model) model.direccion, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.direccion, "", New With {.class = "text-danger"})
                        </div>
                        <div class="form-group col-md-6">
                            @Html.LabelFor(Function(model) model.telefono, htmlAttributes:=New With {.class = "control-label"})
                            @Html.EditorFor(Function(model) model.telefono, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.telefono, "", New With {.class = "text-danger"})
                        </div>
                    </div>


                    <div class="form-row">
                        <div class="form-group col-md-6">
                            @Html.LabelFor(Function(model) model.logo, htmlAttributes:=New With {.class = "control-label"})
                            @Html.EditorFor(Function(model) model.logo, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.logo, "", New With {.class = "text-danger"})
                        </div>
                        <div class="form-group col-md-6">
                            @Html.LabelFor(Function(model) model.correoElectronico, htmlAttributes:=New With {.class = "control-label"})
                            @Html.EditorFor(Function(model) model.correoElectronico, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.correoElectronico, "", New With {.class = "text-danger"})
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
                            <input type="submit" value="Create" class="btn btn-default" />
                        </div>
                    </div>

                </div>
            End Using
         </div>
       </div>


    <div>
        @Html.ActionLink("Volver a Lista", "Index", Function(model) model.nombre, htmlAttributes:=New With {.class = "btn btn-primary"})
    </div>

    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section
