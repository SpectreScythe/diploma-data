const factN = (num) => {
  return num === 1 ? 1 : num * factN(num - 1);
};

function Factorial() {
  this.factN = (myN) => {
    console.log(`The factorial series of ${myN} is as follows:`);
    for (let i = 1; i <= myN; i++) {
      process.stdout.write(`${factN(i)} `);
    }
  };
}

const f = new Factorial();
f.factN(10);
