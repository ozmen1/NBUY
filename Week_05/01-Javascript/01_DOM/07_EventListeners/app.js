'use strict';
let gorevListesi = [
    { 'id': 1, 'gorevAdi': 'Görev 1' },
    { 'id': 2, 'gorevAdi': 'Görev 2' },
    { 'id': 3, 'gorevAdi': 'Görev 3' },
    { 'id': 4, 'gorevAdi': 'Görev 4' },
    { 'id': 5, 'gorevAdi': 'Görev 5' }

];

let ul = document.getElementById('task-list');
// let ul = document.querySelector('#task-list');

for (const gorev of gorevListesi) {
    let li = `
    <li class="task list-group-item">
        <div class="form-check">
            <input type="checkbox" id="${gorev.id}" class="form-check-input">
            <label for="${gorev.id}" class="form-check-label">${gorev.gorevAdi}</label>
        </div>
    </li>
    `;
    ul.insertAdjacentHTML('beforeend',li);

}

// let btnEkle = document.querySelector('#btnAddNewTask');
// btnEkle.addEventListener('click', function(event){
//     // buraya gelen event paramentresi, ilgili elementin gerçekleşen click olayı ile ilgili bilgileri barındırıyor.
//     // btnEkle adlı elemente tıklandığı zaman çalışacak kodlar burada.
//     event.preventDefault(); //sayfayı refresh etmesini engelliyoruz.
//     console.log('btnEkle tıklandı!');
// });



// let btnTemizle = document.querySelector('#btnClear');
// btnTemizle.addEventListener('click', clearAll) //burada function çağırılırken aç kapa parantez yapılmaz!!! click event'ine referansını söylemek yeterli!

// function clearAll(event){
//     event.preventDefault();
//     console.log('tıklandı');
// }

let btnAdd = document.querySelector('#btnAddNewTask');
btnAdd.addEventListener('click', newTask);
function newTask(event){
    event.preventDefault();
    event.target.classList.add('btn-warning');
    event.target.style.display='none';
    console.log(event.target);
}