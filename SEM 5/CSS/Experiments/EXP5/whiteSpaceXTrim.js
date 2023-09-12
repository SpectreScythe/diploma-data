let myString =
  "           Next to nothing is known about the presumed wet-works Specialist, Spectre.               ";

let myIndex = 66;

let charCodestr = myString.charCodeAt(myIndex);
let charAtstr = myString.charAt(myIndex);

let whiteLess = myString.trim();

console.log("Original String : " + myString);
console.log("White Space Less : " + whiteLess);
console.log("charCodeAt : " + charCodestr);
console.log("charAt : " + charAtstr);
