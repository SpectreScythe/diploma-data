function printEquilateralTriangle(height) {
  for (let i = 1; i <= height; i++) {
    let row = "";
    // Add spaces for indentation
    for (let j = 1; j <= height-i; j++) {
      row += " ";
    }
    // Add asterisks for this row
    for (let k = 1; k <= 2 * i - 1; k++) {
      row += "*";
    }
    // Print the row
    console.log(row);
  }
}
// Call the function to print an equilateral triangle with a height of 5
printEquilateralTriangle(5);

//Right angled Triangle
// for (let i = 0; i < 10; i++) {
//   for (let j = 0; j < i; j++) {
//     process.stdout.write("*" + " ");
//   }
//   console.log("");
// }
