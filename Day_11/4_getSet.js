$(function () {
    var daInput = $("#Gloria");
    var daButton1 = $("#btn1");

    daButton1.click(function () {
        console.log("asd");
        daInput.attr("value", daButton1.text());
    });

    var daButton2 = $("#btn2");
    daButton2.click(function () {
        daInput.val(function (index, oldText) {
            return `oldText was ${oldText}, new text is: ${daButton2.text()}
            and the index is: ${index}`;
        })
    });

    var p1 = $("#p1");
    var p2 = $("#p2");
    var btnIDK = $("#btnIDK");
    btnIDK.click(function () {
        $("p").text(function (af, y) {
            return "Old text was: " + y + " and new text is: " + btnIDK.text() + " and the index is: " + af;
        });

    });

});