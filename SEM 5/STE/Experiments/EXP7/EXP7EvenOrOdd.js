const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question('Enter a value: ', (userInput) => {
    if (userInput === "") {
        console.log(`${userInput} is a string`);
    } else {
        const number = parseFloat(userInput);
        if (!isNaN(number) && userInput.includes('.')) {
            console.log(`${userInput} is a floating point number`);
        } else if (parseInt(userInput) % 2 === 0) {
            console.log(`${userInput} is an even number`);
        } else if (parseInt(userInput) % 2 !== 0) {
            console.log(`${userInput} is an odd number`);
        }
    }
    rl.close();
});
