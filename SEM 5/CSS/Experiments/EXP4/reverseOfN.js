const isReverse = (num) => {
  let myNum = num;
  let rem = 0;
  let rev = 0;

  while (myNum > 0) {
    rem = myNum % 10;
    myNum = Number.parseInt(myNum / 10);
    rev = rev * 10 + rem;
  }

  console.log("The reverse of " + num + " is " + rev);
};

isReverse(12345);
