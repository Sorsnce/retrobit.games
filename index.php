<?php
// Initialize the session
session_start();
 
// Check if the user is logged in, if not then redirect him to login page

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
        
							
	<div class="head-image" data-video-mp4="https://d27shkkua6xyjc.cloudfront.net/videos/maaemo-film-2.mp4?mtime=20141113185431" data-video-ogv="https://d27shkkua6xyjc.cloudfront.net/videos/maaemo-film-2.ogv?mtime=20141113185421">
		<div class="frontpage-head-block head-block">
						
							
				<figure class="image-block">
									
																									        
          <img class="head-image" 
              sizes="120vw"
              srcset="assets/wallup-36850.jpg" 
              alt="" 
              data-original-width="1920" 
              data-original-height="1080" />
						
									</figure>
			<div class="esben" ><h1><b>RetroBit.Games</b></h1></div>
		</div>
	</div>

  <div class="frontpage-blocks">
    <div class="block-wrapper clearfix">
	  <center>
	<font size="8">Stream smarter.</font> <br> <br>
	Your favorite retro games, streamed to your favorite screens.


	</center>
	<br>
	<br>
	<br>
      <div class="row clearfix">
        <div class="frontpage-ingress scroll-block">
          <font size="8">Why RetroBit.Games?</font> <br> <br><font size="5">RetroBit.Games brings your favorite retro games together in one place, making them beautiful and easy to enjoy. RetroBit.Games organizes your personal retro ROM collections and streams them to all of your devices. With RetroBit.Games Pass you can experience a growing catalog of great online content, including ROM hacks, HD textures, and online game play. We’re making it easier to find and enjoy all the retro games you love on all of your devices, no matter where you happen to be.

</font>
        </div>
        
                  
                    				
																									
				
                                    				
										          
          <article class="frontpage-list-article num-1">
            <a class="block-link scroll-block history-enabled">
              <div class="block-image-slideshow image-wrapper" data-images="">
				<img		
					sizes="(min-width: 100em) calc(38vw - 168px - 16px), (min-width: 75em) calc(34vw - 138px - 16px), (min-width: 62em) calc(42vw - 68px - 16px), (min-width: 45em) calc(75vw - 32px - 68px), calc(100vw - 70px)"
					srcset="assets/Zelda_smol.png" 
					alt="Woman holding dish with smoke">
              </div>
              
            </a>
          </article>
                  
                    				
                      				
										          
          <article class="frontpage-list-article num-2">
                  <h2 class="heading-small"><font size="5">RetroBit.Games is the world’s first plex-like retro game streaming service, available soon on the Android and Windows platforms.</font>
	            </a>
          </article>

                                      </div>
									  <div>
            				
										    <center>
	<font size="8">Get started</font> <br> <br>
<style type="text/css">
/*! CSS Used from: https://zhf1943ap1t4f26r11i05c7l-wpengine.netdna-ssl.com/wp-content/themes/plex/dist/css/app.min.css?ver=4.0.0-1547036964 ; media=all */
@media all{
a{background-color:transparent;-webkit-text-decoration-skip:objects;}
img{border-style:none;}
.grid-x{display:-ms-flexbox;}
.grid-x{display:flex;-ms-flex-flow:row wrap;flex-flow:row wrap;}
.cell{-ms-flex:0 0 auto;flex:0 0 auto;min-height:0;min-width:0;width:100%;}
@media print,screen and (min-width:64.063em){
.grid-x>.large-12{-ms-flex-preferred-size:auto;flex-basis:auto;}
}
@media print,screen and (min-width:64.063em){
.grid-x>.large-12{width:100%;}
}
.grid-padding-x>.cell{padding-right:.9375rem;padding-left:.9375rem;}
.small-up-1>.cell{width:100%;}
@media print,screen and (min-width:40.063em){
.medium-up-2>.cell{width:50%;}
}
@media print,screen and (min-width:64.063em){
.large-up-3>.cell{width:33.33333%;}
}
::-webkit-input-placeholder{color:#b3bac1;line-height:1.2em;}
::-moz-placeholder{color:#b3bac1;}
:-ms-input-placeholder{color:#b3bac1;}
:-moz-placeholder{color:#b3bac1;}
*,:after,:before{-moz-box-sizing:border-box;box-sizing:border-box;-moz-osx-font-smoothing:grayscale;}
h4{font-family:plexeina-bold,Helvetica,sans-serif;font-weight:400;font-style:normal;-webkit-font-smoothing:antialiased;text-rendering:optimizeLegibility;}
img{max-width:100%;vertical-align:bottom;}
h4,p{margin:0;padding:0;}
h4{color:#282a2d;font-smoothing:antialiased;line-height:1.4em;}
h4{font-size:1.2em;letter-spacing:-.25px;}
p{line-height:1.5em;padding-bottom:25px;}
p:last-child{padding-bottom:0;}
a{text-decoration:none;color:#e5a00d;-webkit-transition:all .3s ease;-moz-transition:all .3s ease;-ms-transition:all .3s ease;-o-transition:all .3s ease;transition:all .3s ease;outline:0;word-wrap:break-word;}
@media screen and (max-width:40em){
p{font-size:.9em;}
}
.dynamic-block p{padding-bottom:0;}
.dynamic-block p{padding-top:25px;}
.grid-block .grid-content p{padding-top:15px;font-size:.9em;}
.grid-elements .cell{padding-bottom:30px;}
@media screen and (max-width:40em){
.grid-elements .cell{padding-bottom:15px;}
}
.grid-elements .grid-illustration .grid-img-illustration img{max-width:150px;padding-bottom:5px;}
.grid-elements .grid-illustration .grid-inner{padding:0;}
@media screen and (max-width:40em){
.grid-elements .grid-illustration .grid-img-illustration img{max-width:120px;}
}
}
/*! CSS Used fontfaces */
@font-face{font-family:plexeina-bold;src:url(https://zhf1943ap1t4f26r11i05c7l-wpengine.netdna-ssl.com/wp-content/themes/plex/assets/fonts/plexeina-bold-webfont.woff2) format('woff2'),url(https://zhf1943ap1t4f26r11i05c7l-wpengine.netdna-ssl.com/wp-content/themes/plex/assets/fonts/plexeina-bold-webfont.woff) format('woff');font-weight:400;font-style:normal;}
</style>
 
<section id="section1" data-magellan-target="section1" class="grid-x dynamic-block grid-block gray">

					<div class="large-12 cell grid-text ">


				
				
			</div>
		
		<div class="large-12 cell grid-elements">
			<div style="max-width: 1100px; margin: 0 auto;" class="grid-x grid-padding-x grid-illustration small-up-1 medium-up-2 large-up-3">

				
					
						<div class="cell">
							<div class="grid-inner">

								
									<div class="grid-img-illustration">
										<img src="assets/sign-up-1.png" srcset="assets/sign-up-1.png 300w, assets/sign-up-1-150x150.png 150w" sizes="(max-width: 300px) 100vw, 300px">									</div>

								
								<div class="grid-content">
																			<h4>Sign up</h4>
									
																			<p>Get a <a class="go-signup" href="https://retrobit.games/register.php">FREE RetroBit.Games account</a>.</p>
																	</div>

							</div>
						</div>

					
						<div class="cell">
							<div class="grid-inner">

								
									<div class="grid-img-illustration">
										<img src="assets/download-1.png" srcset="assets/download-1.png 300w, assets/download-1-150x150.png 150w" sizes="(max-width: 300px) 100vw, 300px">									</div>

								
								<div class="grid-content">
																			<h4>Get RetroBit.Games</h4>
									
																			<p><a href="https://retrobit.games/downloads.php">Get the RetroBit.Games app</a> on your device.</p>
																	</div>

							</div>
						</div>

					
						<div class="cell">
							<div class="grid-inner">

								
									<div class="grid-img-illustration">
										<img src="assets/add-media-1.png" srcset="assets/add-media-1.png 300w, assets/add-media-1-150x150.png 150w" sizes="(max-width: 300px) 100vw, 300px">									</div>

								
								<div class="grid-content">
																			<h4>Play Now</h4>
									
																			<p>Get access to the platform with a <a href='https://retrobit.games/welcome.php'>Retro Pass</a>.</p>
																	</div>

							</div>
						</div>

					
				
			</div>
		</div>
	</section>

	</center>      
<br>
<br>
                  
                    				
																									
				
                                      </div><div class="row clearfix">
            				
			<article class="frontpage-list-article num-1">
            <a class="block-link scroll-block history-enabled">
              <div class="block-image-slideshow image-wrapper" data-images="">
				<img		
					sizes="(min-width: 100em) calc(38vw - 168px - 16px), (min-width: 75em) calc(34vw - 138px - 16px), (min-width: 62em) calc(42vw - 68px - 16px), (min-width: 45em) calc(75vw - 32px - 68px), calc(100vw - 70px)"
					srcset="assets/tumblr_oaqxved6721r7liu0o1_500.gif" 
					alt="Woman holding dish with smoke">
              </div>
            </a>
			</article> 
            <article class="frontpage-list-article num-2">
                  <h2 class="heading-small"><font size="5">Retrogaming, also known as classic gaming or old school gaming, is the playing or collecting of older personal computer, console, and arcade video games in contemporary times. Usually retrogaming is based upon systems that are obsolete or discontinued.
				  	<br>
					<br>
					<br>
					<br>
					<br>
				  Retrogaming has three main activities: vintage retrogaming, retrogaming emulation, and ported retrogaming.</h2></font>
	          
				
			</article>    
                    				
																									

                
        
      </div>
    </div>
    
  </div>
    
    </div>
    
    <footer class="page-footer clearfix" role="contentinfo">
  <h2 class="visuallyhidden">Contact information</h2>
  
  <address class="footer-address vcard">
    <span class="visuallyhidden fn">Sorsnce</span>
    <p class="adr">
      <span class="street-address">RetroBit.Games</span>
      <span class="postal-code">1337</span> <span class="locality">Internet</span> 
      <span class="country-name">USA</span>
    </p>
    <span class="tel"><a href="tel:+4722179969"></a></span>
    <span class="email"><a href="mailto:help@retrobit.games">help@retrobit.games</a></span>
  </address>
  
	<div class="links-wrapper">
		<nav class="social-links">
			<h3 class="visuallyhidden">Sorsnce in social media</h3>
			<ul>
								<li><a href="https://github.com/RetroBitGames/" target="_blank">GitHub</a></li>
								<li><a href="https://www.linkedin.com/in/trae-horton-2311763b/" target="_blank">LinkedIn</a></li>
								<li><a href="https://twitter.com/sorsnce" target="_blank">Twitter</a></li>
							</ul>
		</nav>
		
		<nav class="additional-links">
			<h3 class="visuallyhidden">Additional links about Sorsnce</h3>
			<ul>
								<li><a href="https://sorsnce.com" target="_blank">Sorsnce Enterprise Security</a></li>
								<li><a href="https://runescape.sorsnce.com" target="_blank">Private Runescape Sever</a></li>
							</ul>
		</nav>
  </div>
	
  <a class="to-top-button no-flicker" href="#top"><svg xmlns="http://www.w3.org/2000/svg" width="33" height="27" viewBox="0 0 33 27"><path d="M10 15.6l6.5-5.2 6.5 5.2v1l-6.5-5.1-6.5 5.1v-1z"/></svg><span class="visuallyhidden">Scroll to top</span></a>
</footer>

<div id="show-map" class="map-area" data-latitude="35.964668" data-longitude="-83.926453"><div class="map-area-inner"><div id="map"></div></div></div>  </main>
  
	<div class="parallax-bottom"><div class="inner"></div></div>
	
  <div class="booking-wrapper">
		<div class="inner"></div>
	</div>
  
	<div class="loader no-flicker">
		<div>
			<span class="a1"><svg xmlns="http://www.w3.org/2000/svg" width="65.5" height="59" viewBox="0 0 65.5 59"><path fill="#231F20" d="M65.3 56.8l-5-8.9-18.6-33.4L34 .8c-.3-.5-.8-.8-1.3-.8s-1 .3-1.3.8L.2 56.8c-.4.7-.1 1.6.6 2 .7.4 1.6.1 2-.6l5.8-10.4h48.3l5.8 10.4c.3.5.8.8 1.3.8.2 0 .5-.1.7-.2.7-.4 1-1.3.6-2zm-37.1-12h-18L32.7 4.5l9 16.1 13.5 24.2h-27z"/></svg></span>
			<span class="a2"><svg xmlns="http://www.w3.org/2000/svg" width="65.5" height="59" viewBox="0 0 65.5 59"><path fill="#231F20" d="M65.3 56.8l-5-8.9-18.6-33.4L34 .8c-.3-.5-.8-.8-1.3-.8s-1 .3-1.3.8L.2 56.8c-.4.7-.1 1.6.6 2 .7.4 1.6.1 2-.6l5.8-10.4h48.3l5.8 10.4c.3.5.8.8 1.3.8.2 0 .5-.1.7-.2.7-.4 1-1.3.6-2zm-37.1-12h-18L32.7 4.5l9 16.1 13.5 24.2h-27z"/></svg></span>
		</div>
	</div>
  
  <div class="lightbox-container" style="display: none;" tabindex="0">
    <div class="lightbox-inner">
      <button class="visuallyhidden control-button prev"><span class="visuallyhidden">Next slide</span><span class="icon"><svg xmlns="http://www.w3.org/2000/svg" width="6.2" height="12.9" viewBox="0 0 6.2 12.9"><path fill="#FFF" d="M5.2 12.9L0 6.5 5.2 0h1L1.1 6.5 6.2 13h-1z"/></svg></span></button>  
      <button class="visuallyhidden control-button next"><span class="visuallyhidden">Previous slide</span><span class="icon"><svg xmlns="http://www.w3.org/2000/svg" width="6.2" height="12.9" viewBox="0 0 6.2 12.9"><path fill="#FFF" d="M5.2 12.9L0 6.5 5.2 0h1L1.1 6.5 6.2 13h-1z"/></svg></span></button>
    </div>
    
    <div class="counter no-flicker">
      <span class="current">1</span> — <span class="total">1</span>
    </div>
    <button class="close-button"><span class="visuallyhidden">Close</span><span class="icon"><svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24"><path d="M18.717 4.575l.708.707L5.283 19.424l-.708-.707z"/><path d="M5.283 4.575l14.142 14.142-.708.707L4.575 5.282z"/></svg></span></button>
  </div>
  
    <script>
  var PATHS = {};
  PATHS.AJAX_BOOKING = 'booking.html';
  PATHS.AJAX_LOAD_VIDEO_EMBED = 'ajax/load_video_embed.html';
	
	var IS_LIVE_PREVIEW = false;
</script>

<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDvKmqhif2K41U0PRnBXxL3EGFLYfiGF4Y"></script>

  
  <script src="../ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
  <script>window.jQuery || document.write('<script src="assets/src/js/libs/jquery-1.11.0.min.js"><\/script>')</script>
  <script src="assets/build/js/main.1499775528.js"></script>
  
</body>
</html>