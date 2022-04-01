//Switch- Case

var a = 1;

switch (a) {
  case "1":
    console.log("1", typeof a);
    break;

  case 1:
    console.log(1, typeof a);
    break;
}

var _daObject = {
  type: "abc",
  idk: "now",
};

switch (_daObject.idk) {
  case "abc":
    console.log("first");
    break;

  case "now":
    console.log("second");
    break;
}

console.log("\n");

switch (new Date().getDay()) {
  case 0:
    console.log("Today is the sunday.");
    break;
  case 1:
    console.log("Today is the monday.");
    break;
  case 2:
    console.log("Today is the tuesday.");
    break;
  case 3:
    console.log("Today is the wednesday.");
    break;
  case 4:
    console.log("Today is the thursday.");
    break;
  case 5:
    console.log("Today is the friday.");
    break;
  default:
    console.log("Today is the saturday.");
}
