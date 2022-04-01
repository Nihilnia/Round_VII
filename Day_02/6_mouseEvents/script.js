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

document.body.addEventListener("dragenter", function (x) {
  console.clear();
  abc = 0;
});

// console.log(document.all);
