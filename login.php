<?php
// Initialize the session
session_start();
 
// Check if the user is already logged in, if yes then redirect him to welcome page
if(isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] === true){
    header("location: welcome.php");
    exit;
}
 
// Include config file
require_once "config.php";
 
// Define variables and initialize with empty values
$username = $password = "";
$username_err = $password_err = "";
 
// Processing form data when form is submitted
if($_SERVER["REQUEST_METHOD"] == "POST"){
 
    // Check if username is empty
    if(empty(trim($_POST["username"]))){
        $username_err = "Please enter username.";
    } else{
        $username = trim($_POST["username"]);
    }
    
    // Check if password is empty
    if(empty(trim($_POST["password"]))){
        $password_err = "Please enter your password.";
    } else{
        $password = trim($_POST["password"]);
    }
    
    // Validate credentials
    if(empty($username_err) && empty($password_err)){
        // Prepare a select statement
        $sql = "SELECT id, username, password FROM users WHERE username = ?";
        
        if($stmt = mysqli_prepare($link, $sql)){
            // Bind variables to the prepared statement as parameters
            mysqli_stmt_bind_param($stmt, "s", $param_username);
            
            // Set parameters
            $param_username = $username;
            
            // Attempt to execute the prepared statement
            if(mysqli_stmt_execute($stmt)){
                // Store result
                mysqli_stmt_store_result($stmt);
                
                // Check if username exists, if yes then verify password
                if(mysqli_stmt_num_rows($stmt) == 1){                    
                    // Bind result variables
                    mysqli_stmt_bind_result($stmt, $id, $username, $hashed_password);
                    if(mysqli_stmt_fetch($stmt)){
                        if(password_verify($password, $hashed_password)){
                            // Password is correct, so start a new session
                            session_start();
                            
                            // Store data in session variables
                            $_SESSION["loggedin"] = true;
                            $_SESSION["id"] = $id;
                            $_SESSION["username"] = $username;                            
                            
                            // Redirect user to welcome page
                            header("location: welcome.php");
                        } else{
                            // Display an error message if password is not valid
                            $password_err = "The password you entered was not valid.";
                        }
                    }
                } else{
                    // Display an error message if username doesn't exist
                    $username_err = "No account found with that username.";
                }
            } else{
                echo "Oops! Something went wrong. Please try again later.";
            }
        }

		
        // Close statement
        mysqli_stmt_close($stmt);
    }
    
    // Close connection
    mysqli_close($link);
}
?>
 
<!DOCTYPE html>
<html lang="en">
<!-- Mirrored from maaemo.no/about-maaemo by HTTrack Website Copier/3.x [XR&CO'2014], Tue, 29 Aug 2017 12:31:29 GMT -->
<!-- Added by HTTrack --><meta http-equiv="content-type" content="text/html;charset=utf-8" /><!-- /Added by HTTrack -->
<head>
  <meta charset="utf-8">
    <title>Login</title>
      
<meta name="description" content="Maaemo is Oslo’s ground-breaking two Michelin starred restaurant. It first opened its doors in December 2010 and is run and co-owned by Head Chef Esben Holmboe Bang and Sommelier Pontus Dahlström." />

<meta property="og:title" content="About Maaemo"/>
<meta property="og:description" content="Maaemo is Oslo’s ground-breaking two Michelin starred restaurant. It first opened its doors in December 2010 and is run and co-owned by Head Chef Esben Holmboe Bang and Sommelier Pontus Dahlström."/>
<meta property="og:site_name" content="Maaemo"/>
<meta property="og:locale" content="en_US"/>
<meta property="og:url" content="about-maaemo.html"/>


  <meta property="og:image" content="../d27shkkua6xyjc.cloudfront.net/images/02.About/_600xAUTO_crop_center-center/About_01_2500px2c55.jpg?mtime=20141112134851"/>
  <meta property="og:image" content="../d27shkkua6xyjc.cloudfront.net/images/02.About/_600xAUTO_crop_center-center/About_02_2500pxdbd9.jpg?mtime=20141112134904"/>
  <meta property="og:image" content="../d27shkkua6xyjc.cloudfront.net/images/02.About/_600xAUTO_crop_center-center/About_03_2500px85c3.jpg?mtime=20141112134919"/>

<meta name="twitter:card" content="summary" />
<meta name="twitter:site" content="@maaemo" />
<meta name="twitter:title" content="About Maaemo" />
<meta name="twitter:description" content="Maaemo is Oslo’s ground-breaking two Michelin starred restaurant. It first opened its doors in December 2010 and is run and co-owned by Head Chef Esben Holmboe Bang and Sommelier Pontus Dahlström." />
	<meta name="twitter:image" content="../d27shkkua6xyjc.cloudfront.net/images/02.About/_360x240_crop_center-center/About_01_2500px2c55.jpg?mtime=20141112134851" />
<meta name="twitter:url" content="about-maaemo.html" />

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

<body class="is-page">

  <header id="top" class="page-header clearfix" role="banner">
  <h1 class="visuallyhidden" aria-live="polite">Maaemo<span class="subtitle"> – About Maaemo</span></h1>
  
  <nav class="main-menu" role="navigation" id="main-menu">
    <h2 class="visuallyhidden">Main navigation</h2>
    
    <div class="top-bar no-flicker">
      <a class="home-button history-enabled" href="index.html">
				<span class="home-title">Home</span>
			</a>
      
      <a class="booking-toggle show-booking" href="https://retrobit.games" onclick="location.replace('https://retrobit.games')">Home</a>
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
  
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.css">
    <style type="text/css">
        body{ font: 14px sans-serif; }
        .wrapper{ width: 350px; padding: 20px; }
    </style>
	
</head>
<center>
<body>
    <div class="wrapper">
	<br>
        <h2>Login</h2>
        <p>Please fill in your credentials to login.</p>
        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
            <div class="form-group <?php echo (!empty($username_err)) ? 'has-error' : ''; ?>">
                <label>Username</label>
                <input type="text" name="username" class="form-control" value="<?php echo $username; ?>">
                <span class="help-block"><?php echo $username_err; ?></span>
            </div>    
            <div class="form-group <?php echo (!empty($password_err)) ? 'has-error' : ''; ?>">
                <label>Password</label>
                <input type="password" name="password" class="form-control">
                <span class="help-block"><?php echo $password_err; ?></span>
            </div>
            <div class="form-group">
                <input type="submit" class="btn btn-primary" value="Login">
            </div>
            <p>Don't have an account? <a href="register.php">Sign up now</a>.</p>
        </form>
    </div>    
</body>
</center>
</html>