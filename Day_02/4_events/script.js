//Creating an event

var newBtn = document.createElement("button");
newBtn.setAttribute("value", "click");
newBtn.innerText = "Click here ya";
newBtn.addEventListener("click", function (x) {
  console.log("Clicked");
  console.log(x.offsetX);
  console.log(x.offsetY);
});

var getThirdList = document.querySelector("#yes_3");
getThirdList.appendChild(newBtn);
newBtn.addEventListener("mouseover", function () {
  console.log("Over");
});

//to Body
document.body.addEventListener("click", function (Gloria) {
  var getX = Gloria.offsetX;
  var getY = Gloria.offsetY;

  if (getX == 6 || getY == 6) {
    console.log("Found the six");

    console.log("Mouse offsetY:", getY);
    console.log("Mouse offsetX:", getX, "\n\n");
  } else {
    console.log("Mouse offsetY:", getY);
    console.log("Mouse offsetX:", getX, "\n\n");
  }
});

var getNihil = document.querySelector("img");

getNihil.addEventListener("mouseover", function (x, y) {
  console.log("Mouse is over the picture:", x);
});
