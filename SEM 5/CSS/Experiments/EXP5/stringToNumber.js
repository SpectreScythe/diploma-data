let myString = "54";

function stringToNum(str) {
  return Number(str);
}

function stringToInt(str) {
  return parseInt(str);
}

function stringToFloat(str) {
  return parseFloat(str);
}

let myNum = stringToNum(myString);
let myFloat = stringToFloat(myString);
let myInt = stringToInt(myString);

process.stdout.write("Original String : " + myString + "\n\n");
process.stdout.write("String to Integer : " + '"' + myInt + '"' + "\n");
process.stdout.write("String to Number : " + '"' + myNum + '"' + "\n");
process.stdout.write("String to Float : " + '"' + myFloat + '"' + "\n");
