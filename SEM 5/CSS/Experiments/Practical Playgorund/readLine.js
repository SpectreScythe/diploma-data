const readline = require('readline');

// Create an interface to read input from the standard input stream
const rl = readline.createInterface({
    input: process.stdin, // Read from standard input
    output: process.stdout // Write to standard output
});

// Ask a question and wait for user input
rl.question('What is your name? ', (name) => {
    console.log(`Hello, ${name}!`);
    rl.close(); // Close the interface when done
});
