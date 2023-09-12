const sumOfN = (num) => {
  myNum = num;
  let rem = 0;
  let sum = 0;

  while (myNum > 0) {
    rem = myNum % 10;
    myNum = Number.parseInt(myNum / 10);
    sum = sum + rem;
  }

  console.log("Sum of " + num + " is : " + sum);
};

sumOfN(12345);
