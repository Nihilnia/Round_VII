//Declaration

function Gloria(a, b) {
  var total = a + b;
  console.log("Total:", total);
}

//Using

Gloria(1, 2);

console.log("\n");

//Expression
var Gloria_2 = function (a, b) {
  var total = a + b;
  console.log("Total:", total);
};

//Using
Gloria_2(2, 3);

console.log("\n");

//Default parameters /w ES6

function Gloria_3(a = 1960, b = 1994) {
  var total = a + b;
  console.log("Total:", total);
}

Gloria_3();
Gloria_3((a = 1));

console.log("\n");

//With bit control
var Gloria_4 = function (a, b) {
  if (typeof a == "undefined") {
    console.log("Where is a ha?");
  }
  if (typeof b == "undefined") {
    console.log("Where is b eh?");
  } else {
    var total = a + b;
    console.log("Total:", total);
  }
};

Gloria_4((a = 1));
Gloria_4((a = 1), (b = 2));

var Gloria_5 = function (a, b) {
  if (typeof a == "number") {
    if (typeof b == "number") {
      var total = a + b;
      console.log(total);
    } else {
      console.log("b must be a number");
    }
  } else {
    console.log("a must be a number.");
  }
};

Gloria_5((a = "2"), (b = 2));
Gloria_5((a = 2), (b = 2));

console.log("\n");

//ARGS

var Gloria_6 = function (args) {
  var total = 0;
  args.forEach(function (x) {
    total += x;
  });

  console.log(total);
};

Gloria_6([1, 2, 3]);
