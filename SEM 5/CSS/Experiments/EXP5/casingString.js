const stringChanges = (ogStr, need, replacer) => {
  let newStr = ogStr.replace(need, replacer);
  let toUpper = ogStr.toUpperCase();
  let toLower = ogStr.toLowerCase();

  process.stdout.write("Original : \t\t" + ogStr + "\n");
  process.stdout.write("After Replacement : \t" + newStr + "\n");
  process.stdout.write("UpperCased : \t\t" + toUpper + "\n");
  process.stdout.write("LowerCased : \t\t" + toLower + "\n");
};

let myString = "Jesse, we need to cook";
let nameStr = "Jesse";
let changeName = "Yo Mr. White";

stringChanges(myString, nameStr, changeName);
