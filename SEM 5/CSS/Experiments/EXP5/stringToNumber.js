let myString = "54";

const stringToNum = (str) => Number(str);
const stringToInt = (str) => parseInt(str);
const stringToFloat = (str) => parseFloat(str);

let myNum = stringToNum(myString);
let myFloat = stringToFloat(myString);
let myInt = stringToInt(myString);

process.stdout.write("Original String : " + myString + "\n\n");
process.stdout.write("String to Integer : " + '"' + myInt + '"' + "\n");
process.stdout.write("String to Number : " + '"' + myNum + '"' + "\n");
process.stdout.write("String to Float : " + '"' + myFloat + '"' + "\n");
