<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Home Page</title>
    <link rel="stylesheet" href="css/stlye.css">
    <link rel="stylesheet" href="css/menu.css">
    <link rel="stylesheet" href="css/footer.css">
    <link rel="icon" type="image/png" href="img/logo20x20.png" />
    <script src="https://kit.fontawesome.com/350eedb788.js" crossorigin="anonymous"></script>
    <script src="javascript/main.js"></script>
</head>

<body onload="TijdCheck()">

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
        <div class="container-main">
            <?php
                include 'OpenClose.php';
            ?>
            
            <div class="mainRow">
                
                <div class="gallarySlider">
                    <div class="slideshow-container">
                        <div class="mySlides fade">
                            <img src="img/sfeer4.jpg" style="width:100%">
                        </div>
                        <div class="mySlides fade" style="display: none;">
                            <img src="img/sfeer2.jpg" style="width:100%">
                        </div>

                        <div class="mySlides fade" style="display: none;">
                            <img src="img/sfeer3.jpg" style="width:100%">
                        </div>


                        <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
                        <a class="next" onclick="plusSlides(1)">&#10095;</a>
                    </div>
                    
                </div>
            </div>

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
                        ?? 2021 Fluitende Fietser
                    </div>
                    <div class="kbnumber">KVK: 88599665 | BTW NL999888492Z09</div>
                </div>
            </div>
        </div>
    </footer>


</body>

</html>