$(function () {
    console.log("Ready to go!");

    var container = $("#container");

    var btnAppend = $("#btnAppend");
    var btnPrepend = $("#btnPrepend");

    container.append(btnAppend).prepend(btnPrepend);

    btnAppend.click(function () {
        container.append("<input type = 'text' value='GloriaAppend' />");
    });

    btnPrepend.click(function () {
        container.prepend("<input type = 'text' value='GloriaPrepend' />");
        console.log(btnAppend.attr("class"));
    });
});