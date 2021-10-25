
//Bubble Sort Start
function bubblesort(arr){
    var temp = 0
    for (var i = 0; i < arr.length; i++) {
        console.log(arr)
        for (var r = 0; r<(arr.length-i-1); r++) {
            if (arr[r] > arr[r+1]) {
                temp = arr[r]
                arr[r] = arr[r+1]
                arr[r+1] = temp
            }
        }
    }
}
bubblesort([6,4,5,2,9,3,8]) //output: [2,3,4,5,6,8,9]
// Bubble Sort End


