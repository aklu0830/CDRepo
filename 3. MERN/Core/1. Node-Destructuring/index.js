const cars = ['Tesla', 'Mercedes', 'Honda']
const [ randomCar ] = cars
const [ ,otherRandomCar ] = cars
//Predict the output == Tesla, \n Mercedes
console.log(randomCar)
console.log(otherRandomCar)
// End 1

const employee = {
    name: 'Elon',
    age: 47,
    company: 'Tesla'
}
const { name: otherName } = employee;
//Predict the output
//console.log(name);
console.log(otherName);
//End 2



const person = {
    name: 'Phil Smith',
    age: 47,
    height: '6 feet'
}
const password = '12345';
const { password: hashedPassword } = person;
//Predict the output == 12345 and undefined because password doesn't exist in the person object
console.log(password);
console.log(hashedPassword);
//End 3


const numbers = [8, 2, 3, 5, 6, 1, 67, 12, 2];
const [,first] = numbers;
const [,,,second] = numbers;
const [,,,,,,,,third] = numbers;
//Predict the output === false for the 1st log and true for the 2nd line
console.log(first == second);
console.log(first == third);
//End 4


const lastTest = {
    key: 'value',
    secondKey: [1, 5, 1, 8, 3, 3]
}
const { key } = lastTest;
const { secondKey } = lastTest;
const [ ,willThisWork] = secondKey;
//Predict the output == Prints the string 'value', the array secondKey, and the prints the 1st and the 2nd value on separate lines from array secondKey
console.log(key);
console.log(secondKey);
console.log(secondKey[0]);
console.log(willThisWork);
//End 5