@Code
    ViewData("Title") = "Home Page"
End Code
<div class="">
    <div class="row container_center" id="login">
        <div class="col col-md-4" style="background-color:#808080; padding:2.5rem; border-radius:10px; text-align:center;">
            <img src="~/img/LogoCitapp.png" width="150" />
            <form action="" class="dataLogin" method="post">

                <div class="form-group col-md-12">
                    <input type="text" class="form-control" id="dataUser" aria-describedby="" placeholder="Usuario">
                </div>
                <div class="form-group col-md-12">
                    <input type="password" class="form-control" id="dataPass" aria-describedby="" placeholder="Clave">
                </div>
                <input type="submit" class="btn btn-primary" value="Iniciar sesion" />
            </form>
        </div>
    </div>
</div>