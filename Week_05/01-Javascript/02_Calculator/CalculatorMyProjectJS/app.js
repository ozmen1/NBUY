const btnNumber = document.getElementsByName('calculator-keys').value;
btnNumber.addEventListener('click', getNumber());
function getNumber(value){
    console.log(btnNumber);
}