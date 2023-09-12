let str1 = "Spectre";
let str2 = "Ripper";
let str3 = str1 + str2;
let str4 = str1.concat(str2);

process.stdout.write("str1 = " + str1 + "\n");
process.stdout.write("str2 = " + str2 + "\n");
process.stdout.write("str1.concat(str2) = " + str3 + "\n");
process.stdout.write("str1 + str2 = " + str4);
