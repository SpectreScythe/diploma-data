const indexString = (ogStr,s1,s2,s3) => {
    let str1 = ogStr.indexOf(s1);
    let str2 = ogStr.indexOf(s2);
    let str3 = ogStr.indexOf(s3);

    process.stdout.write("Original String : \t\t" + ogStr + "\n");
    process.stdout.write("String A = 'ONE' : \t\t" + str1 + "\n");
    process.stdout.write("String B = 'who' : \t\t" + str2 + "\n");
    process.stdout.write("String C = 'knocks' :\t\t" + str3 + "\n");
};

let myString = "I am the ONE who knocks";
let str1 = "ONE";
let str2 = "who";
let str3 = "knocks";

indexString(myString, str1, str2, str3);
