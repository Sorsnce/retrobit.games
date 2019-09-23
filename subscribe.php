<?php

session_start();

require_once "config.php";
  
$user = ($_SESSION["username"]);
$bank = "'";
$sql = "UPDATE sys.users SET subscriber = 1 where username ='"; 
$string = $sql.$user.$bank;
if(mysqli_query($link, $string)){ 
    echo ""; 
} else { 
    echo ""  
                            . mysqli_error($link); 
}  
mysqli_close($link); 
?> 
<!doctype html>
<html class="no-js" lang="en">

<head>
  <meta charset="utf-8">

      
        
<title>RetroBit</title>
<meta name="description" content="RetroBit.Games is your one-stop shop for all of the retro game content you need! We designed RetroBit.Games too be a centralized repository for all retro mods, homebrew games for retro systems, and even the latest news in regards to retro game goodness! " />

<meta property="og:title" content="RetroBit.Games"/>
<meta property="og:description" content="RetroBit.Games is your one-stop shop for all of the retro game content you need! We designed RetroBit.Games too be a centralized repository for all retro mods, homebrew games for retro systems, and even the latest news in regards to retro game goodness!"/>
<meta property="og:site_name" content="RetroBit"/>
<meta property="og:locale" content="en_US"/>
<meta property="og:url" content="index.html"/>


  <meta property="og:image" content="../d27shkkua6xyjc.cloudfront.net/images/00.Frontpage/_600xAUTO_crop_center-center/Frontpage_02_1500px5237.jpg?mtime=20141112172540"/>
  <meta property="og:image" content="../d27shkkua6xyjc.cloudfront.net/images/00.Frontpage/_600xAUTO_crop_center-center/Frontpage_05_2500pxe04f.jpg?mtime=20141113150707"/>
  <meta property="og:image" content="../d27shkkua6xyjc.cloudfront.net/images/00.Frontpage/_600xAUTO_crop_center-center/Frontpage_03_1500px44ce.jpg?mtime=20141112172549"/>

<meta name="twitter:card" content="summary" />
<meta name="twitter:site" content="@sorsnce" />
<meta name="twitter:title" content="Maaemo Restaurant" />
<meta name="twitter:description" content="RetroBit.Games is your one-stop shop for all of the retro game content you need! We designed RetroBit.Games too be a centralized repository for all retro mods, homebrew games for retro systems, and even the latest news in regards to retro game goodness!" />
	<meta name="twitter:image" content="../d27shkkua6xyjc.cloudfront.net/images/00.Frontpage/_360x240_crop_center-center/Frontpage_02_1500px5237.jpg?mtime=20141112172540" />
<meta name="twitter:url" content="index.html" />

<meta property="og:type" content="website"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
<meta name="format-detection" content="telephone=no"/>

<link rel="icon" type="image/png" href="assets/build/img/retro-games-colored-06-512.png" sizes="512x512" />


<link rel="apple-touch-icon" sizes="57x57" href="assets/build/img/Maaemo_Favicon_57x57px.png"/>
<link rel="apple-touch-icon" sizes="72x72" href="assets/build/img/Maaemo_Favicon_72x72px.png"/>
<link rel="apple-touch-icon" sizes="76x76" href="assets/build/img/Maaemo_Favicon_76x76.png"/>
<link rel="apple-touch-icon" sizes="120x120" href="assets/build/img/Maaemo_Favicon_120x120.png"/>
<link rel="apple-touch-icon" sizes="144x144" href="assets/build/img/Maaemo_Favicon_144x144px.png"/>
<link rel="apple-touch-icon" sizes="152x152" href="assets/build/img/Maaemo_Favicon_152x152.png"/>

<meta name="msapplication-TileColor" content="#ffffff"/>
<meta name="msapplication-square150x150logo" content="assets/build/img/Maaemo_Favicon_150x150.png"/>

  <link rel="stylesheet" href="assets/build/css/main.1499775398.css" />
  <script src="assets/build/js/libs/modernizr-respond.1499775398.js"></script>
  
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','../www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-55916377-1', 'auto');
  ga('send', 'pageview');

</script>
</head>

<body class="is-frontpage">

  <header id="top" class="page-header clearfix" role="banner">
  <h1 class="visuallyhidden" aria-live="polite"><b>RetroBit</b><span class="subtitle"></span></h1>
  
  <nav class="main-menu" role="navigation" id="main-menu">
    <h2 class="visuallyhidden">Main navigation</h2>
    
    <div class="top-bar no-flicker">
			<span class="header-title"><span class="title-inner" ><a href="https://retrobit.games/welcome.php" onclick="location.replace('https://retrobit.games/welcome.php')"><b><?php echo htmlspecialchars($_SESSION["username"]); ?></b></a></span></span>
      <a class="home-button history-enabled" href="index.html">
				<span class="home-title" href=""https://RetroBit.Games/welcome.php" class="booking-toggle show-booking" onclick="location.replace('https://RetroBit.Games/welcome.php')">Home</span>
			</a>
      
      <a href=""https://RetroBit.Games" class="booking-toggle show-booking" onclick="location.replace('https://RetroBit.Games')">Home</a>
      <a href="#main-menu" class="menu-toggle show-menu"><span class="visuallyhidden">Show menu</span><span class="icon"><span class="l1"></span><span class="l2"></span><span class="l3"></span></span></a>
      <a href="#top" class="menu-toggle hide-menu"><span class="visuallyhidden">Close menu</span><span class="icon"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24"><path d="M18.717 4.575l.708.707L5.283 19.424l-.708-.707z"/><path d="M5.283 4.575l14.142 14.142-.708.707L4.575 5.282z"/></svg></span></a>
    </div>

		    <div class="main-menu-wrapper no-flicker">
      <div class="list-aligner">
        <ul>
					
                      <li><a href="news.html" onclick="location.replace('news.html')">News</a></li>
                      <li><a href="about.html" onclick="location.replace('about.html')">About Us</a></li>
                      <li><a href="FAQ.html" onclick="location.replace('FAQ.html')">FAQ</a></li>
                      <li><a href="https://www.reddit.com/r/RetroBit/" onclick="location.replace('https://www.reddit.com/r/RetroBit/')">Forum</a></li>
                      <li><a href="https://github.com/RetroBitGames/" onclick="location.replace('https://github.com/RetroBitGames/')">Open Source</a></li>
                      <li><a href="RetroMods.html" onclick="location.replace('RetroMods.html')">Retro Mods</a></li>
					  <li><a href="login.php" onclick="location.replace('login.php')">Login</a></li>
                  </ul>
      </div>
    </div>
		    
  </nav>
</header>
  
  <main role="main" class="main-content" aria-live="assertive" aria-atomic="true" aria-relevant="all">
    <div class="inner">


					

	  <br>
	  <style type="text/css">
	  .wrap {
    float: left;
    position: relative;
    left: 50%;
}

.content {
    float: left;
    position: relative;
    left: -50%;
}
	  </style>
	  <br>
	  <br>
	  <br>
<center>
<img class="center-center"
							sizes="10vw" 
							srcset="assets/qcBBexbc5.png" 
							alt="Employee ironing shirt">
							<br>
							<br>
<Strong><font size="18">Congratulations!</font></Strong>
<br>
<br>
<div style="display: inline-block; text-align: left;">
Order complete and payment received.
    </div>
</center>

</div>
</body>
</div>
    </div>
	</main>
    <style>
.footer {
  position: fixed;
  left: 0;
  bottom: 0;
  width: 100%;
  background-color: red;
  color: white;
  text-align: center;
}
</style>

<div class="footer">
    
</div> 

  
  <script src="../ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
  <script>window.jQuery || document.write('<script src="assets/src/js/libs/jquery-1.11.0.min.js"><\/script>')</script>
  <script src="assets/build/js/main.1499775528.js"></script>
  
</body>
</html>