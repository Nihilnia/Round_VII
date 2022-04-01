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
