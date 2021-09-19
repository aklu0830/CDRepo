function reverse(arr) {
    var temp;
    var count = 0;
    var something = 1;

    while(count < arr.length/2) {
        temp = arr[count];
        arr[count] = arr[arr.length-something];
        arr[arr.length-something] = temp;

        count++;
        something++;

    }
    return arr;


}

reverse(["a", "b", "c", "d", "e"];)
