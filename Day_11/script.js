$(document).ready(function () {
    console.log("Everything is ready to go!");


    //Some basics
    $("#Gloria").click(function () {
        $("h2").attr("style", "color: red;");
    });

    $("h2").hover(function () {
        console.log("You' ve entered!");
    }, function () {
        console.log("You' ve out!");
    });

    var inp = $("#inp01");
    inp.focus(function () {
        console.log("You' re in input.");
    });
    inp.change(function () {
        console.log("Value is changed.");
    });

});