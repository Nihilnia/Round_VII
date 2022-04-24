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
});