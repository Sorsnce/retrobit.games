<?php
$referer = $_POST["id"]; 
$path1 = "storage/UserID/";
$path2 = "/SAVES/";
$uploads_dir = ($path1.$referer.$path2); //Directory to save the file that comes from client application.
m('File upload '.(@copy($_FILES['uploadfile']['tmp_name'],getcwd().'\\'.$uploads_dir.$_FILES['uploadfile']['name']) ? 'success' : 'failed'));
function m($msg) {
} 

?>