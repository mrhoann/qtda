
const incCart = document.getElementsByClassName('product-cart-main-select-quantity-increment'); 


const decCart = document.getElementsByClassName('product-cart-main-select-quantity-decrement'); 


const quantityCart = document.getElementsByClassName('product-cart-main-select-quantity-item'); 


for(let i = 0; i<incCart.length; i++){
    incCart[i].onclick = ()=>{
       let quantity = parseInt(quantityCart[i].innerHTML); 
       quantity += 1; 
       quantityCart[i].innerHTML = quantity; 
    }
}

for(let i = 0; i<decCart.length; i++){
    decCart[i].onclick = ()=>{
       let quantity = parseInt(quantityCart[i].innerHTML); 
       if(quantity > 1){
           quantity -= 1; 
           quantityCart[i].innerHTML = quantity; 
       }
    }
}
const infoShop= document.getElementsByClassName
('product-detail-description-shop')[0];
const infoDescription= document.getElementsByClassName('product-detail-description-item')[0];



window.addEventListener('scroll',function(e) {
    const fixed = document.getElementsByClassName('header-main')[0];      
    const scrollY =  this.scrollY; 
 // console.log(scrollY); 
    if(scrollY == 0){
       fixed.style.top = '30px'; 
    }else{
       fixed.style.top = '0px'; 
    }
});



window.addEventListener('scroll',function(e) { 

const mWidth = document.getElementsByClassName('my-product-detail')[0].clientHeight; 

const mWidthD = document.getElementsByClassName('product-detail-description-shop')[0].clientHeight; 

const oWidth = mWidth-(mWidthD+40); 
 var offsets = document.getElementsByClassName(' product-your-love')[0].getBoundingClientRect();
 var top = offsets.top; 
   
   const scrollY =  this.scrollY; 
   if(scrollY >= 800){
     infoShop.style.position ='fixed'; 
     infoShop.style.top ='130px'; 
     infoDescription.style.left = '540px'
  }
  if(top < 384){
       infoShop.style.position='relative'; 
       infoShop.style.top =oWidth+'px';  
       infoDescription.style.left = '0px'
  }     
  if(scrollY < 800){
   infoShop.style.position ='relative'; 
   infoShop.style.top ='0px'; 
   infoDescription.style.left = '0px'
}  
});
const myColor = document.getElementsByClassName('product-detail-main-select-color-item'); 

for(let i=0 ; i<myColor.length; i++){
    myColor[i].onclick = ()=>{
        myColor[i].style.border = '1px solid orangered'; 
        myColor[i].style.borderRadius = '5px'; 
        for(let j = 0; i< myColor.length; j++){
            if(j != i){
                myColor[j].style.border = '1px solid #EEEEEE'; 
                myColor[i].style.borderRadius = '5px'; 
            }
        }
    }
}

const mySize = document.getElementsByClassName('product-detail-main-select-size-item'); 

for(let i=0 ; i<mySize.length; i++){
    mySize[i].onclick = ()=>{
        mySize[i].style.border = '1px solid orangered'; 
        mySize[i].style.borderRadius = '5px'; 
        for(let j = 0; i< mySize.length; j++){
            if(j != i){
                mySize[j].style.border = '1px solid #EEEEEE'; 
                mySize[i].style.borderRadius = '5px'; 
            }
        }
    }
}


const inc = document.getElementsByClassName('product-detail-main-select-quantity-increment')[0]; 

const dec = document.getElementsByClassName('product-detail-main-select-quantity-decrement')[0]; 



inc.onclick = ()=>{
    let quantityProduct = document.getElementsByClassName('product-detail-main-select-quantity-item')[0].innerHTML; 
    let quantity  = parseInt(quantityProduct) + 1; 
    document.getElementsByClassName('product-detail-main-select-quantity-item')[0].innerHTML = quantity;
}
dec.onclick = ()=>{
    let quantityProduct = document.getElementsByClassName('product-detail-main-select-quantity-item')[0].innerHTML; 
    if(quantityProduct > 1 ){
        let quantity  = parseInt(quantityProduct) - 1; 
        document.getElementsByClassName('product-detail-main-select-quantity-item')[0].innerHTML = quantity;
    }
}

const listImageDetails = document.getElementsByClassName('product-detail-img'); 
const mainImage = document.getElementById('main-img-details'); 

for(let i =0; i<listImageDetails.length; i++){
    listImageDetails[i].onclick = function(){
        listImageDetails[i].style.border = '2px solid orangered';
        const srcImageDetails = listImageDetails[i].getAttribute('src'); 
        mainImage.setAttribute('src',srcImageDetails); 
        for(let j =0; j< listImageDetails.length; j++){
            if(j != i){
                listImageDetails[j].style.border = 'none'; 
            }
        }
    }
}

