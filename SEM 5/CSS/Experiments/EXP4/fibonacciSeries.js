const fiboN = (num) => {
  if (num === 1) {
    return 1;
  } else {
    return num * fiboN(num - 1);
  }
};

function FibonacciSeries() {
  this.fiboN = (myN) => {
    let n1 = 0;
    let n2 = 1;
    console.log("The fibonacci series of 10 is as follows:");
    process.stdout.write(n1 + " " + n2 + " ");
    for (let i = 1; i <= myN - 2; i++) {
      let n3 = n1 + n2;
      process.stdout.write(n3 + " ");
      n1 = n2;
      n2 = n3;
    }
  };
}

let f = new FibonacciSeries();
f.fiboN(10);
