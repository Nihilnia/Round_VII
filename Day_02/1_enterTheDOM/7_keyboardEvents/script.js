var abc = 0;

document.body.addEventListener("click", function (x, y) {
  console.log("OffsetX:", x.offsetX);
  console.log("OffsetY:", x.offsetY, "\n");

  if (document.all[abc]) {
    console.log(document.all[abc]);
  }
  console.log("currentABC:", abc);
  abc += 1;
});

// console.log(document.all);

//K E Y B O A R D
var y = 1;

document.body.addEventListener("keypress", function (x) {
  console.log(y, "Pressed key:", x.key);
  abc = 0;
  y++;
});
