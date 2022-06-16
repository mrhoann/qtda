



let mHour = 1;
let mMin = 47;
let mSec = 22;

let hour = document.getElementById('hour');
let min = document.getElementById('min');
let sec = document.getElementById('sec');

hour.innerHTML = mHour;
min.innerHTML = mMin;
sec.innerHTML = mSec;
setInterval(() => {
    mSec--;
    sec.innerHTML = mSec;
    if (mSec == 0) {
        mSec = 59
        sec.innerHTML = mSec;
        mMin--;
        min.innerHTML = mMin;
    }
    if (mMin == 0) {
        mMin == 59;
        mHour--;
        hour.innerHTML = mHour;
    }

}, 1000)

let scrollLeft = document.getElementsByClassName('flash-scroll-left')[0];
let scrollRight = document.getElementsByClassName('flash-scroll-right')[0];

let widthWrap = document.getElementsByClassName('main-flash-sale-wrap')[0].clientWidth;
let wrapInfinitive = document.getElementsByClassName('main-flash-sale-wrap-infinitive')[0];
let widthWrapInfinitive = document.getElementsByClassName('main-flash-sale-wrap-infinitive')[0].clientWidth;
console.log(widthWrapInfinitive);
let scrollDefault = 1246;
let initScroll = 0;
let sumScroll = 0;
scrollRight.onclick = function () {
    if (widthWrapInfinitive > 1282) {
        initScroll += scrollDefault;
        wrapInfinitive.style.right = initScroll + 'px';
        wrapInfinitive.style.animation = "scroll 1s"
        widthWrapInfinitive -= 1246;
        sumScroll += 1246;
        scrollLeft.style.display = 'block';
    }
}

scrollLeft.onclick = function () {
    if (sumScroll > 0) {
        wrapInfinitive.style.right = '0px';
        wrapInfinitive.style.animation = "scroll 1s";
        widthWrapInfinitive += 1246;
        initScroll -= 1246
        scrollLeft.style.display = 'none';
    }
}


const listCategory = document.getElementsByClassName('header-category-item');

for (let i = 0; i < listCategory.length; i++) {
   
    listCategory[i].onclick = function () {
        const id = listCategory[i].getAttribute('id');
        const myElement = document.getElementById(id);
        console.log(myElement); 
        //myElement.style.borderBottom = "4px solid #EEEEEE";
      
    }
}


