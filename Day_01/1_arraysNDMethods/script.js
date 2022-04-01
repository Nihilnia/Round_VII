//Creatin'

var strArray = ["a", "b", "c"];
console.log(typeof strArray);

var intArray = [1, 2, 3, 4];
console.log(typeof intArray);

console.log("\n");

//Gettin'
console.log("strArray's first item:", strArray[0]);
console.log("intArray's last item:", intArray[intArray.length - 1]);

console.log("\n");

//Addin'
strArray[60] = "x";
intArray[99] = 66;

strArray.forEach(function (x, y) {
  console.log(`Index of ${x}:`, strArray.indexOf(x));
});

intArray.forEach(function (x, y) {
  console.log(`Index of ${x}:`, intArray.indexOf(x));
});

console.log("\n");

//Some methods of 'em-

//Push "add an item to end of the array"
for (let f = 0; f <= 10; f++) {
  strArray.push(f + 99);
}

strArray.forEach(function (x) {
  console.log(`Index of ${x}:`, strArray.indexOf(x));
});

console.log(strArray.length);

//Unshift "add an item to beginning of the array"

intArray.unshift(-77);
intArray.forEach(function (x) {
  console.log(`Index of ${x}:`, intArray.indexOf(x));
});

//pop "deleting the last item of the array"
//shift "deleting the first item of the array"

intArray.shift();
intArray.forEach(function (x) {
  console.log(`Index of ${x}:`, intArray.indexOf(x));
});

//reverse
//sort

console.log("\n");

//Concat "collect 'em together"
var concattedArray = strArray.concat(intArray);
concattedArray.forEach(function (x, y) {
  console.log(`Item '${x}'s index: ${y}'`);
});
