let myString = "racecar";
let strLen = myString.length;
let strBool;

for (let i = 0; i < Math.floor(strLen / 2); i++) {
  strBool = myString[i] === myString[strLen - i - 1];
}

if (strBool){
    console.log("palindrome it is")
} else{
    console.log("palindrome it aint")
}