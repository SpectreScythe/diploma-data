const factorial = (n) => {
    if (n == 1) {
        return 1;
    } else {
        return n * factorial(n - 1);
    }
};

function person(i) {
    this.i = i;
    this.fact = () => {
        const r = factorial(this.i);
        console.log(r);
    };
}

let p = new person(5);
p.fact();
