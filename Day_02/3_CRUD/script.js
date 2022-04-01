//Creating' an element

var newEl = document.createElement("h3");
newEl.setAttribute("class", "exClass");
newEl.setAttribute("id", "exID");
newEl.textContent = "Kids";

var getThirdList = document.querySelector("#yes_3");
console.log(getThirdList.children);

getThirdList.appendChild(newEl);
console.log(getThirdList.children);

var getALLDoc = window.document;
console.log(getALLDoc.body);

var secondNew = document.createElement("h6");
secondNew.setAttribute("class", "LP");
secondNew.setAttribute("id", "Figure.09");
secondNew.textContent = "JJJJJJ";
var getOldOne = document.querySelector("#exID");
console.log(getOldOne);

//this one bit important
getOldOne.replaceWith(secondNew);

//Ex

var imgZ = document.querySelector("img");
console.log(imgZ.currentSrc);
console.log(document.images);

for (let f = 0; f <= document.images.length; f++) {
  if (
    document.images[f].currentSrc ==
    "http://127.0.0.1:5500/Day_02/1_enterTheDOM/A88.png"
  ) {
    console.log("Found:", document.images[f]);
    break;
  } else {
    console.log("nah");
  }
}
