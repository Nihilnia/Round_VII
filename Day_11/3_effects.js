/*
show, hide
show(500), hide(1500)

slideUp, slideDown

fadeIn, fadeOut

toggle



*/


$(function () {
    console.log("Document is ready to go.");

    var h3Element = $("h3");

    h3Element.hide("slow");
    h3Element.toggle("slow");
    //or, the same
    h3Element.toggle("slow");
    h3Element.toggle("slow");

    var h3Nihil = $("#h3Nihil");
    h3Nihil.toggle("slow");
    h3Nihil.fadeIn("slow").addClass("borderBlue");

    //You can add class after the animation complete- with callback functions

    var h1Element = $("h1");
    h1Element.fadeOut("slow");
    h1Element.fadeIn("slow", function () {
        $(this).addClass("bgBlue");
    });


    //You can stop the animations whenever you want
    var btnStopEm = $("#stopEm");
    btnStopEm.on("click", function () {
        console.log("aa");
        h1Element.stop();
    });

    //You can even delay effects, lol
    var lastOne = $("#lastOne");
    lastOne.toggle(3400).delay(4000).toggle(2000);
});