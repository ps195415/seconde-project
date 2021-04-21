<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/stlye.css">
    <link rel="stylesheet" href="css/menu.css">
    <link rel="stylesheet" href="css/footer.css">
    <script src="javascript/main.js"></script>
    <script src="https://kit.fontawesome.com/350eedb788.js" crossorigin="anonymous"></script>
</head>
<body>
    

    <header id="header">
        <div class="container">
            <div class="row">
                <div class="logo-and-img">
                    <img src="img/logo20x20.png" alt=" het logo van de website">
                    <h2>De Fluitend Fietser</h2>
                </div>
                <div class="zoekmachine">
                    <input type="text" placeholder="Search..">
                    <button type="submit"><i class="fa fa-search"></i></button>
                </div>
            </div>
        </div>
    </header>

    <nav id="nav">
        <div class="container">
            <div class="topNav" id="topNav">
                <div class="mobiel-icon">
                    <span style="font-size: 30px;" id="btnMenu" onclick="openNav()">&#9776;</span>
                </div>
                <ul>
                    <li><a href="index.php">Home</a></li>
                    <li><a href="fietsen.html">Fietsen</a></li>
                    <li><a href="fietsHuren.html">FietsHuren</a></li>
                    <li><a href="Contact.html">Contact</a></li>
                    <li><a href="Openingstijden.html">Openingstijden</a></li>
                    <li><a href="Overons.html">Over ons</a></li>
                </ul>
            </div>

            <div id="MysidenarBar" class="SidenavBar">
                <a class="closeBtn" style="font-size: 60px;" onclick="ColseBtn()">&times;</a>
                <a href="index.php">Home</a>
                <a href="fietsen.html">Fietsen</a>
                <a href="fietsHuren.html">FietsHuren</a>
                <a href="Contact.html">Contact</a>
                <a href="Openingstijden.html">Openingstijden</a>
                <a href="Overons.html">Over ons</a>
            </div>
        </div>
    </nav>
    <main id="main">
        <div class="container-Gegevens">
            <div class="container-Contact-h">
                <div class="form">

                    <label for="fname">Naam</label>
                    <input type="text" id="fname" name="firstname" placeholder="Jouw Naam.." required>

                    <label for="country">E-mail</label>
                    <input type="text" id="e-mail" name="e-mail" placeholder="Jouw E-mail.." required>

                    <label for="lname">Adres</label>
                    <input type="text" id="adress" name="Lastname" placeholder="Adres .." required>

                    <label for="lname">Stad</label>
                    <input type="text" id="stad" name="Lastname" placeholder="Stad .." required>

                    <label for="subject">Postcode</label>
                    <input type="text" id="postcode" name="postcode" placeholder="Postcode.." required>

                    <input onclick="Validation(document.getElementById('e-mail'), 'Dit is geen geldige E-mail.')" type="submit" value="Gegevens versturen">

                </div>
                
            </div>

            <article>
                <?php
                    echo '<div class="my_items">';
                    echo '<h2> Dit zijn uw keuze: </h2>';
                    if(isset($_POST['checkList'])){
                    foreach($_POST['checkList'] as $check){
                    echo '<br>';
                    echo '.'.$check;
                    }
                    
                    }
                    echo '</div>';
                ?>
            </article>
        </div>
        
    </main>

    


    <footer id="footer">
        <div class="container-Footer">
            <h2 class="footerTitel">Informatie footer</h2>
            <div class="row-F">
                <div class="col-1">
                    <h3>Informatie over winkel</h3>
                    <p><a href="Overons.html">Over ons</a></p>
                    <p><a href="Contact.html">Contact</a></p>
                    <p><a>E-mail: info@fluitendefietser.nl</a></p>
                </div>
                <div class="col-1">
                    <h3>Social-Media</h3>
                    <p><a class="fab fa-facebook" href="https://www.facebook.com/fietsmagazine">Facebook</a></p>
                </div>
                <div class="col-1">
                    <h3>Algemeene voorwarden</h3>
                    <p><a href="https://www.bovag.nl/BovagWebsite/media/BovagMediaFiles/Downloads/Garantie%20en%20voorwaarden/Algemene-voorwaarden-BOVAG-tweewielerbedrijven-april-2018.pdf">AGV</a></p>
                </div>
                <div class="btnummer">
                    <div class="jaarduiding">
                        © 2021 Fluitende Fietser
                    </div>
                    <div class="kbnumber">KVK: 88599665 | BTW NL999888492Z09</div>
                </div>
            </div>
        </div>
    </footer>

</body>
</html>