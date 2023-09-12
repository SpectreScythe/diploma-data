
const extractString = (ogStr,sInd,lInd) => {
    const subString = ogStr.substring(sInd,lInd);
    const sliceString = ogStr.slice(sInd,lInd);

    process.stdout.write("Original String : " + ogStr + "\n");
    process.stdout.write("Sub-String : " + subString + "\n");
    process.stdout.write("Slice-String : " + sliceString + "\n");
}

let myString = "My name is Gustavo Fring but you can call me Gus.";
let sIndex = 10;
let lIndex = 35;

extractString(myString,sIndex,lIndex);