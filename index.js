"use strict";
// 1. Write a program to check if a String is a Number
function isStringNumber(string) {
    // cast the string to a number using '+'. If unable to cast, will return NaN.
    return !isNaN(+string);
}
// 2. Write a program to count the number of occurrences of a character in an input string
function numCharacterOccurrences(string, char) {
    if (char.length !== 1) {
        throw new Error("second parameter must be a single character");
    }
    return string.split(char).length - 1;
}
// 3. How to remove duplicates from an array
function removeDuplicatesFromArray(array) {
    // in order to not mutate the original array
    const copy = [...array].sort();
    return copy.reduce((a, c, i, arr) => {
        a[i] = arr.indexOf(c) === i ? c : 0;
        return a;
    }, []);
}
// 4. Find the missing number in a given non-sorted integer array of 1 to 10
function findMissingNumbers(array) {
    const result = [];
    for (let i = 1; i <= 10; i++) {
        if (!array.includes(i))
            result.push(i);
    }
    return result;
}
// 5. Find all pairs in an array of integers whose sum is equal to a given number
function findSumPairs(array, sum) {
    const result = [];
    array.forEach((i, index) => {
        for (let j = index; j < array.length; j++) {
            if (i + j === sum)
                result.push([i, j]);
        }
    });
    return result;
}
// Tests for 1
console.log(isStringNumber("123")); // true
console.log(isStringNumber("0.242")); // true
console.log(isStringNumber("Code Test")); // false
console.log(isStringNumber("10E30")); // true (exponential)
console.log(isStringNumber("0x23F5")); // true (hexadecimal)
console.log("\n\n");
// Tests for 2
console.log(numCharacterOccurrences("One Fish, Two Fish, Red Fish, Blue Fish", "F")); // 4
console.log(numCharacterOccurrences("abbcccddddeeeee", "f")); // 0
console.log(numCharacterOccurrences("abbcccddddeeeee", "b")); // 2
console.log(numCharacterOccurrences("abbcccddddeeeee", "c")); // 3
// console.log(numCharacterOccurrences("This results in an error", "this"));
console.log("\n\n");
// Tests for 3
console.log(removeDuplicatesFromArray([1, 1, 2, 2, 3, 4, 5])); // [1, 0, 2, 0, 3, 4, 5]
console.log(removeDuplicatesFromArray([1, 1, 1, 1, 1, 1, 1])); // [1, 0, 0, 0, 0, 0, 0]
console.log(removeDuplicatesFromArray([1, 2, 3, 4, 5, 6, 7])); // [1, 2, 3, 4, 5, 6, 7]
console.log(removeDuplicatesFromArray([1, 2, 1, 1, 1, 1, 1])); // [1, 0, 0, 0, 0, 0, 2]
console.log("\n\n");
// Tests for 4
console.log(findMissingNumbers([1, 2, 3, 4, 6])); // [1, 0, 2, 0, 3, 4, 5]
console.log(findMissingNumbers([1, 2, 3, 4, 6, 7, 9, 8, 10])); // [1, 0, 0, ]
console.log(findMissingNumbers([1, 2, 3, 4, 6, 9, 8])); // [1, 0, 2, 0, 3, 4, 5]
console.log(findMissingNumbers([1, 2, 3, 4, 9, 8])); // [1, 0, 2, 0, 3, 4, 5]
console.log("\n\n");
// Test for 5
console.log(findSumPairs([2, 4, 3, 5, 6, -2, 4, 7, 8, 9], 7)); // [[2, 5], [4, 3], [3, 4], [-2, 9]]
