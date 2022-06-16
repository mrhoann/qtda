const inputElement = document.getElementsByClassName('address-item-input');


for (let i = 0; i < inputElement.length; i++) {
    inputElement[i].onclick = function () {
        inputElement[i].style.border = '2px solid #80BDFF';
        for (let j = 0; j < inputElement.length; j++) {
            if (j != i) {
                inputElement[j].style.border = '1px solid rgba(128, 128, 128, 0.315)';
            }
        }
        // inputElement[i].style.boxShadow = '1px 1px #80BDFF'; 
    }
}

const radioCheck = document.getElementsByClassName('radio-type-check');
//const radioMain = document.getElementsByClassName('radio-main'); 
for (let i = 0; i < radioCheck.length; i++) {
    radioCheck[i].onclick = function () {
        radioCheck[i].style.border = '2px solid orangered';
        document.getElementsByClassName('radio-main')[i].style.display = 'block';
        for (let j = 0; j < radioCheck.length; j++) {
            if (j != i) {
                radioCheck[j].style.border = '2px solid gray';
                document.getElementsByClassName('radio-main')[j].style.display = 'none';
            }
        }
    }
}

const dropDown = document.getElementsByClassName('header-user-name')[0];
dropDown.onclick = function () {
    document.getElementsByClassName('drop-down-options-account')[0].classList.toggle('activatedDropDown')
}
