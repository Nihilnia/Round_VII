//Getting elements through DOM
var _Gloria = window.document;

//You can reach any time via window object
console.log(_Gloria.head);
console.log(_Gloria.body);

//Getting complete document
console.log(_Gloria);

//One by one
for (let f = 0; f <= _Gloria.all.length; f++) {
  console.log("Segment number:", f + 1, _Gloria.all[f]);
}

//Basically you can reach everything
console.log(_Gloria.URL);
console.log(_Gloria.images);
console.log(_Gloria.images[0].currentSrc);
console.log(_Gloria.scripts);

//Getting multiple elements
var inside = document.querySelector("#yes").querySelectorAll("li");
console.log(inside);

var copy = [];

inside.forEach(function (x, y) {
  console.log("Numb:", y, "Element:", x.style);
  //you can always use the inner attributes

  copy.push(x.style);
});

console.log(copy);

//Ex
var viaClass = document.querySelectorAll(".exClass li");

viaClass.forEach(function (x, Y) {
  console.log(Y, x.innerText);
});

//Ex- 2

var abc = document.querySelectorAll(".exClass a");
console.log(abc);

abc.forEach(function (z) {
  console.log(z.href);
});

var newElement = document.createElement("h3");
newElement.setAttribute("class", "aaabbb");
newElement.setAttribute("innerText", "aaabbb");

var getThirdList = document.querySelector("#yes_3").appendChild(newElement);

var allDOC = window.document;
console.log(allDOC.body);

var abc_1 = document.getElementById("yes_3");
console.log(abc_1);

var abc_2 = document.querySelector("#yes_3");
console.log(abc_2);

/*

- firstChild - lastChild
- childElementCount
- parentElement - parentNode
- nextElementSibling - previousElementSbling
- nextSibling - previousSibling

*/
