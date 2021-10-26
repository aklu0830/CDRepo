// console.log(hello);
// var hello = 'world';



// var needle = 'haystack';
// test();
// function test(){
//     var needle = 'magnet';
//     console.log(needle);
// }


console.log(makeDojo("Chicago", 65));
console.log(makeDojo("Berkeley", 70));
function makeDojo(name, students){
    const dojo = {};
    dojo.name = name;
    dojo.students = students;
    if(dojo.students > 50){
        dojo.hiring = true;
    }
    else if(dojo.students <= 0){
        const dojo = "closed for now";
    }
    return dojo;
}



