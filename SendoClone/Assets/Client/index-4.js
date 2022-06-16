
function myAddToCart() {
    var id = document.getElementById("idProductDetails");
    const myID = parseInt(id.innerHTML);
    var quantity = document.getElementsByClassName("product-detail-main-select-quantity-item")[0].innerHTML;
    const myQuantity = parseInt(quantity);
    window.location = "https://localhost:44309/Sendo/myAddToCart/" + myID + '/' + myQuantity;
}

document.getElementsByClassName('myAddToCart')[0].addEventListener('click', myAddToCart)



