//You can bind multiple events in an "on method"

var inp01 = $("#inp01");

inp01.on("click mouseover", function () {
    console.log("It' s works with even two events.");
});


//And also you can bind multiple events with multiple purposes

var inp02 = $("#inp02");

inp02.on({
    "click": function () {
        console.log("You clicked to input02");
    },
    "mouseover": function () {
        console.log("You just hover the input02, dat english.");
    }
}
);

//You can turn off any event

inp02.off("click");



//ONE METHOD- Runs the methods only once


var inp03 = $("#inp03");

inp03.one({
    "click": function () {
        console.log("You clicked to input02");
    },
    "mouseover": function () {
        console.log("You just hover the input02, dat english.");
    }
}
);