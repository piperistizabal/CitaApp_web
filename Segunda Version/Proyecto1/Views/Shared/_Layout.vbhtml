<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="vertical-menu">
        <a href="#" class="boton-cerrar" onclick="ocultar()">×</a>
        <div class="container-logo">
            <img src="~/img/LogoCitapp.png" width="90">
        </div>

        <ul>
            <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
            <li>@Html.ActionLink("Empresas", "Index", "empresas")</li>
            <li>@Html.ActionLink("Prodcutos", "Index", "productos")</li>

        </ul>

        <div class="footer-options">
            <ul>
                <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                <li></li>
            </ul>
            <a class="btn btn-primary close-session">salir</a>
        </div>




        </div>

        <div class="navbar navbar-inverse navbar-fixed-top">
            <a class="icon-menu" href="#"> <img src="~/img/select object.png" width="30"> </a>
            <div class="container" style="display:none;">
                @*<div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    @Html.ActionLink("Nombre de la aplicación", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                        <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                        <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                    </ul>
                </div>*@
            </div>
        </div>
        <div class="container body-content">
            @RenderBody()
            <hr />
            <footer>
                <p>&copy; @DateTime.Now.Year - Mi aplicación ASP.NET</p>
            </footer>
        </div>

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
</body>
</html>
