let students = ["Amit", "Sumit", "Abhishek"];
let marks = [70, 78, 71];

console.log("Before Sorting:");

console.log(students);
console.log(marks);

for (let i = 0; i < students.length; i++) {
  if (marks[i] > marks[i + 1]) {
    let temp = marks[i];
    marks[i] = marks[i + 1];
    marks[i + 1] = temp;
  }
}

console.log("After Sorting:");

console.log(students);
console.log(marks);

let avg = 0;

for (let i = 0; i < students.length; i++) {
  avg = avg + marks[i];
}

console.log("Averge:");
console.log(avg / marks.length);
