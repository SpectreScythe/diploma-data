const isPalindrome = (str) => {
  let strBool;
  let strNum = str.toString();
  let strLen = strNum.length;

  for (let i = 0; i < Math.floor(strLen / 2); i++) {
    strBool = strNum[i] === strNum[strLen - i - 1];
  }

  if (strBool) {
    process.stdout.write("The number " + str + " is a palindrome.");
  } else {
    process.stdout.write("The number " + str + " is not a palindrome.");
  }
};

isPalindrome(12321);
