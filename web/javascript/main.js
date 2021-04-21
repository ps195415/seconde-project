// dit is voor het open en sluiten van het menubar in tablet/Phone formaat.
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
  if (n > slides.length) { slideIndex = 1 }
  if (n < 1) { slideIndex = slides.length }
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }

  slides[slideIndex - 1].style.display = "block";
}


// dit check of het een goede e-mail is.
function Validation(element, alertMSG) {
  var regx = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
  if (element.value.match(regx)) {
    element.value = "";
    document.getElementById('fname').value = "";
    document.getElementById('Lname').value = "";
    document.getElementById('subject').value = "";
    document.getElementById('number').value = "";
  }
  else {
    alert(alertMSG);
    element.focus();
  }
}


// hier is het bestel button die het betellen regelt.
function terms_changed(termsCheckBox){
  //If the checkbox has been checked
  if(termsCheckBox.checked){
      //Set the disabled property to FALSE and enable the button.
      document.getElementById("submit_button").disabled = false;
  } else{
      //Otherwise, disable the submit button.
      document.getElementById("submit_button").disabled = true;
  }
}




// deze functions zijn om de fietsen in fietspagina groter en kleiner te maken.
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

function kleiner() {
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