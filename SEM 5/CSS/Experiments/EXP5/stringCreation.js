let str1 = "Spectre";
let str2 = "Reaper";
let str3 = String("Firebreak");
let a = ["Sparrow", "Nomad"];
let str4 = a[0] + a[1];
let str5 = String.fromCharCode(112, 114, 111, 112, 104, 101, 116);

console.log("Different ways to create Strings:\n");
console.log(
  str1 + '\t\t--- let str1 = "Spectre";\t\t\t\t\t\t\t' + "String Length : " + str1.length,
);
console.log(
  str2 + '\t\t--- let str2 = "Reaper";\t\t\t\t\t\t\t' + "String Length : " + str2.length,
);
console.log(
  str3 +
    '\t--- let str3 = String("Firebreak");\t\t\t\t\t\t' +
    "String Length : " +
    str3.length,
);
console.log(
  str4 +
    '\t--- let a = ["Sparrow", "Nomad"];+ "let str4 = a[0] + a[1];"\t\t\t' +
    "String Length : " +
    str4.length,
);
console.log(
  str5 +
    "\t\t--- let str5 = String.fromCharCode(112, 114, 111, 112, 104, 101, 116);\t\t" +
    "String Length : " +
    str5.length,
);
