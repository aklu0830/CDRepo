function changeFunc() {
    let Box = document.getElementById("selectBox");
    let selectedValue = Box.options[Box.selectedIndex].value;
    alert('You are looking for a: '+selectedValue);
}

var pettings_pepper_ct = 3;
var pettings_bruce_ct = 5;
var pettings_oscar_ct = 8;


function pettings_pepper() {
    pettings_pepper_ct++;
    let pet_prepper_button = document.getElementById("pet-pepper-counter").innerText = pettings_pepper_ct + " petting(s)";

}

function pettings_bruce() {
    pettings_bruce_ct++;
    let pet_bruce_button = document.getElementById("pet-bruce-counter").innerText = pettings_bruce_ct + " petting(s)";

}

function pettings_oscar() {
    pettings_oscar_ct++;
    let pet_oscar_button = document.getElementById("pet-oscar-counter").innerText = pettings_oscar_ct + " petting(s)";


}