
const nums = [1, 2, 3, 4, 5];

function double(num) {
    return num * 2;
}

const newNums = nums.map( double );

console.log( newNums ); // logs [2, 4, 6, 8, 10]