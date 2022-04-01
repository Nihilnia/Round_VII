//Set
localStorage.setItem("ERA", "Ameno");

//Get
var geet = localStorage.getItem("ERA");
console.log(geet);

//Remove
localStorage.removeItem(geet);

//Setting as Array
var exArray = ["a", "b", "c", 1, 2, 3];
localStorage.setItem("AAAAAAA", JSON.stringify(exArray));

//Getting as Array
var getArray = JSON.parse(localStorage.getItem("AAAAAAA"));
console.log(getArray);
