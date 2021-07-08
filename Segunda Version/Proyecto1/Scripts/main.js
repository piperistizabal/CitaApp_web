$(document).ready(function () {

    $('.icon-menu').on('click', function (e) {
        e.preventDefault();
        var toggleWidth = $(".vertical-menu").width() == 300 ? "200px" : "300px";
        $('.vertical-menu').animate({ width: toggleWidth });
    });

    $('.boton-cerrar').on('click', function (e) {
        e.preventDefault();
        var toggleWidth = $(".vertical-menu").width() == 0 ? "0px" : "0px";
        $('.vertical-menu').animate({ width: toggleWidth });
    });

    


});