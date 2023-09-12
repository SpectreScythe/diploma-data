const isArm = (num) => {
  let n = num;
  let rem = 0;
  let arm = 0;
  while (n > 0) {
    rem = n % 10;
    arm = arm + rem * rem * rem;
    n = parseInt(n / 10);
  }

  if (arm == num) {
    console.log("The number " + num + " is an armstrong number");
  } else {
	  console.log("The number " + num + " is not an armstrong number");
  }
};

isArm(153);
