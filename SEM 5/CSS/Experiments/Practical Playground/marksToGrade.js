function studentData(name, marks) {
  this.name = name;
  this.marks = marks;

  this.assignGrade = function () {
    if (this.marks >= 60 && this.marks <= 70) {
      console.log(this.name + " \t Grade: E");
    } else if (this.marks >= 60 && this.marks <= 70) {
      console.log(this.name + " \t Grade: D");
    } else if (this.marks >= 70 && this.marks <= 80) {
      console.log(this.name + " \t Grade: C");
    } else if (this.marks >= 80 && this.marks <= 90) {
      console.log(this.name + " \t Grade: B");
    } else if (this.marks >= 90 && this.marks <= 100) {
      console.log(this.name + " \t Grade: A");
    }
  };
}

const sName = ["Sumit", "Kalpesh", "Amit", "Tejas", "Abhishek"];
const sMarks = [80, 77, 88, 93, 65];

for (let i = 0; i < sName.length; i++) {
  let S = new studentData(sName[i], sMarks[i]);
  S.assignGrade();
}
