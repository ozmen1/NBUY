const display = document.querySelector('.calculator-input');
const keys = document.querySelector('.calculator-keys');

let displayValue = '0';

updateDisplay();

function updateDisplay(){
    display.value=displayValue;
}

keys.addEventListener('click', function(event){
    const element = event.target;
    if (!element.matches('button')) return;
    // if (event.target.type != 'button') {
    // console.log('functiondan çıkılıyor');
    // return;
    // }
    if (element.classList.contains('operator')) {
        
        console.log('bir operatöre tıklandı');
    }
    else if(element.classList.contains('decimal')){
        console.log('ondalık sayı yazmak üzere . işaretine tıklandı');
    }else if(element.classList.contains('clear')){
        console.log('temizleme butonuna tıklandı');
    }else{
        console.log('bir rakama tıklandı');
    }

});