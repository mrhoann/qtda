

var miDec = document.getElementsByClassName('product-cart-main-select-quantity-decrement')
var miInc = document.getElementsByClassName('product-cart-main-select-quantity-increment')
var quantityProduct = document.getElementsByClassName('product-cart-main-select-quantity-item');
var ID = document.getElementsByClassName('IDCartProc');
for (let i = 0; i < miInc.length; i++) {
    let myI = i;
    miInc[i].onclick = function () {
        var quantity = parseInt(quantityProduct[myI].innerText);
        quantityProduct[myI].innerText = (quantity + 1).toString();
        quantityProduct[myI].style.fontSize = "30px";
        let myID = parseInt(ID[myI].innerText);
        let myQuantity = parseInt(quantityProduct[myI].innerText);
        let d = 1;
        window.location = "https://localhost:44309/Sendo/updateMyCart/" + myID + '/' + myQuantity + '/' + d;
    }
}

for (let i = 0; i < miDec.length; i++) {
    let myI = i;
    miDec[i].onclick = function () {
        var quantity = parseInt(quantityProduct[myI].innerText);
        quantityProduct[myI].innerText = (quantity - 1).toString();
        quantityProduct[myI].style.fontSize = "30px";
        let myID = parseInt(ID[myI].innerText);
        let myQuantity = parseInt(quantityProduct[myI].innerText);
        let d = 1;
        window.location = "https://localhost:44309/Sendo/updateMyCart/" + myID + '/' + myQuantity + '/' + d;
    }
}