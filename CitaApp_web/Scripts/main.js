$(document).ready(function () {

    $(".dataLogin").on("submit", function (e) {
        e.preventDefault();

        var user = $("#dataUser").val();
        var pass = $("#dataPass").val();

        $.ajax({
            data: {user:user,pass:pass},
            url: "ajax/",
            type: "POST",
            success: function (data) {

            }
        });

    });



});
