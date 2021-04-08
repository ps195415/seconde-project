function openNav() {
  document.getElementById('MysidenarBar').style.width = "100%";
  document.getElementById('header').style.display = "none";
  document.getElementById('footer').style.display = "none";
  document.getElementById('topNav').style.display = "none";
  document.getElementById('main').style.display = "none";
}

function ColseBtn() {
  document.getElementById('MysidenarBar').style.width = "0%";
  document.getElementById('header').style.display = "block";
  document.getElementById('topNav').style.display = "block";
  document.getElementById('footer').style.display = "block";
  document.getElementById('main').style.display = "block";
}


// dit is voor het foto galarij in de home page.
var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  if (n > slides.length) { slideIndex = 1 }
  if (n < 1) { slideIndex = slides.length }
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex - 1].style.display = "block";
  dots[slideIndex - 1].className += " active";
}

//hier komt het openings tijd van het home page 
var d = new Date();


function Open_dicht() {

}

function Validation(){
  var mail = document.getElementById('e-mail').value;
  var regx = /^([a-zA-Z0-9/._])+@([a-zA-Z0-9])+.([a-z]+)(.[a-z]+)?$/

  if (!regx.text(mail)){
    alert("Je hebt niet een geldig e-mail.")
  }
  else{
    return;
  }
}


function ImgGroter() {

  document.getElementById('card2').style.display = 'none';
  document.getElementById('card3').style.display = 'none';
  document.getElementById('card4').style.display = 'none';
  document.getElementById('card1').style.height = '470px';
  document.getElementById('cardimg1').style.height = '40%';
  document.getElementById('infoCard1').style.height = '50%';
  document.getElementById('btnImg1').style.height = '10%';
  document.getElementById('btnImg1').innerHTML = "Close"

}

function kleiner(){
  document.getElementById('card2').style.display = 'block';
  document.getElementById('card3').style.display = 'block';
  document.getElementById('card4').style.display = 'block';
  document.getElementById('card1').style.height = '300px';
  document.getElementById('cardimg1').style.height = '70%';
  document.getElementById('infoCard1').style.height = '15%';
  document.getElementById('btnImg1').style.height = '10%';
  document.getElementById('btnImg1').innerHTML = "Add to Cart"
}


function ImgGroter2() {

  document.getElementById('card1').style.display = 'none';
  document.getElementById('card3').style.display = 'none';
  document.getElementById('card4').style.display = 'none';
  document.getElementById('card2').style.height = '470px'
  document.getElementById('cardimg2').style.height = '40%';
  document.getElementById('infoCard2').style.height = '50%';
  document.getElementById('btnImg2').style.height = '10%';
  document.getElementById('btnImg2').innerHTML = "Close"
}

function kleiner2() {
  document.getElementById('card1').style.display = 'block';
  document.getElementById('card3').style.display = 'block';
  document.getElementById('card4').style.display = 'block';
  document.getElementById('card2').style.height = '300px'
  document.getElementById('cardimg2').style.height = '70%';
  document.getElementById('infoCard2').style.height = '15%';
  document.getElementById('btnImg2').style.height = '10%';
  document.getElementById('btnImg2').innerHTML = "Add to Cart"
}

function ImgGroter3() {

  document.getElementById('card1').style.display = 'none';
  document.getElementById('card2').style.display = 'none';
  document.getElementById('card4').style.display = 'none';
  document.getElementById('card3').style.height = '500px'
  document.getElementById('cardimg3').style.height = '40%';
  document.getElementById('infoCard3').style.height = '50%';
  document.getElementById('btnImg3').style.height = '10%';
  document.getElementById('btnImg3').innerHTML = "Close"
}

function kleiner3() {
  document.getElementById('card1').style.display = 'block';
  document.getElementById('card2').style.display = 'block';
  document.getElementById('card4').style.display = 'block';
  document.getElementById('card3').style.height = '300px'
  document.getElementById('cardimg3').style.height = '70%';
  document.getElementById('infoCard3').style.height = '15%';
  document.getElementById('btnImg3').style.height = '10%';
  document.getElementById('btnImg3').innerHTML = "Add to Cart"
}

function ImgGroter4() {

  document.getElementById('card1').style.display = 'none';
  document.getElementById('card3').style.display = 'none';
  document.getElementById('card2').style.display = 'none';
  document.getElementById('card4').style.height = '450px'
  document.getElementById('cardimg4').style.height = '40%';
  document.getElementById('infoCard4').style.height = '50%';
  document.getElementById('btnImg4').style.height = '10%';
  document.getElementById('btnImg4').innerHTML = "Close"
}

function kleiner4() {
  document.getElementById('card1').style.display = 'block';
  document.getElementById('card3').style.display = 'block';
  document.getElementById('card2').style.display = 'block';
  document.getElementById('card4').style.height = '300px'
  document.getElementById('cardimg4').style.height = '70%';
  document.getElementById('infoCard4').style.height = '15%';
  document.getElementById('btnImg4').style.height = '10%';
  document.getElementById('btnImg4').innerHTML = "Add to Cart"
}