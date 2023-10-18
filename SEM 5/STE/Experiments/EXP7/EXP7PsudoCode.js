const readline = require('readline');

let count;
let length;

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question('Enter a value for count: ', (userInputCount) => {
    count = parseInt(userInputCount);

    rl.question('Enter a value for length: ', (userInputLength) => {
        length = parseInt(userInputLength);

        rl.close();

        while (count <= 6) {
            if (length >= 100) {
                length = length - 2;
            } else {
                length = count * length;
            }
            count++;
        }

        console.log(`Final length: ${length}`);
    });
});
