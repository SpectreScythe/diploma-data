const myArray = [500, -70, 21, 30, -8];
console.log("Array: " + myArray);
const n = myArray.length
for (let i = 0; i < n - 1; i++) {
    for (let j = 0; j < n - i - 1; j++) {
        if (myArray[j] > myArray[j + 1]) {
            let temp = myArray[j];
            myArray[j]=myArray[j+1];
            myArray[j+1]=temp;
        }
    }
}
console.log("Sorted Array: " + myArray);
