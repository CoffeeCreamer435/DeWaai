<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>De Waai - Homepagina</title>
	<link type="text/css" rel="stylesheet" href="http://www.dewaai.ga/css/main.css" />
    <link type="text/css" rel="stylesheet" href="http://www.dewaai.ga/css/font-awesome.min.css" />
    <script src="https://use.fontawesome.com/e7598f83ce.js"></script>
	<link href="https://fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">
</head>
<body>
<div id="Container">
	<?php include 'header.php';?>
    
    <div id="Content">
        <div class="bannertext">
        	<h1 class="bannertitle">Zeilplezier voor <strong style="color:white;">jong en oud</strong> bij De Waai</h1>
        </div>
        
        <img class="img-responsive img visual" src="/images/banner_home.jpg" alt="banner homepagina" />
        
        <div id="Content_Text">
            <!-- CONTENT !-->
<form action="" method="post">
            	<table>
                	<tr>
                    	<td>
                        Voor naam
                        </td>
                        <td>
                        <input type="text" name="FirstName"/>
                        </td>
                    </tr>
                    <tr>
                    	<td>
                        Achternaam
                        </td>
                        <td>
                        <input type="text" name="LastName"/>
                        </td>
                    </tr>
                                    	<tr>
                    	<td>
                        wachtwoord
                        </td>
                        <td>
                        <input type="password" name="Password"/>
                        </td>
                    </tr>
                 	<tr>
                    	<td>
                        Straat
                        </td>
                        <td>
                        <input type="text" name="Street"/>
                        </td>
                    </tr>
                    <tr>
                    	<td>
                        huisnummer
                        </td>
                        <td>
                        <input type="text" name="HouseNumber"/>
                        </td>
                    </tr>
                    
                                    	<tr>
                    	<td>
                        Postcode
                        </td>
                        <td>
                        <input type="text" name="Zip"/>
                        </td>
                    </tr>
                    <tr>
                    	<td>
                        woonplaats
                        </td>
                        <td>
                        <input type="text" name="City"/>
                        </td>
                    </tr>
					<tr>
                    	<td>
                        Telefoon
                        </td>
                        <td>
                        <input type="tel" name="phone"/>
                        </td>
                    </tr>
					<tr>
                    	<td>
                        </td>
                        <td>
                        <input type="submit" value="registreer"/>
                        </td>
                    </tr>
                </table>
            </form>
    	</div>
    
    </div>
    
    <?php include 'footer.php';?>
</div>
</body>