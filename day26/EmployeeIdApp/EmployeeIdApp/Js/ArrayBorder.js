let inputArray = ["test1", "test2", "test3"];

// Transform each element by wrapping it with asterisks
let transformedArray = inputArray.map(element => `*${element}*`);

// Concatenate the transformed array with the additional elements
let outputArray = ["****", ...transformedArray, "****"];

console.log(outputArray);

/*

let inputArray = ["test1", "test2", "test3"];
let outputArray = new Array(inputArray.length + 2);

// Add the first **** at the beginning
outputArray[0] = "****";

// Transform each element and add it to the output array
for (let i = 0; i < inputArray.length; i++) {
    outputArray[i + 1] = `*${inputArray[i]}*`;
}

// Add the last **** at the end
outputArray[outputArray.length - 1] = "****";

console.log(outputArray);
*/