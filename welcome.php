<?php
// Initialize the session
session_start();
 $test = ($_SESSION["id"]);
 $path = "storage/UserID/";
 $slash = "/";
 $savep = "SAVES";
 $romp = "ROM";
 
 if (!file_exists($path.$test)) {
mkdir($path.$test, 0777, true);
 }
 else {
 }
  if (!file_exists($path.$test.$savep)) {
mkdir($path.$test.$slash.$savep, 0777, true);
 }
 else {
 }
 if (!file_exists($path.$test.$romp)) {
mkdir($path.$test.$slash.$romp, 0777, true);
 }
 else {
 }
 $Path0001 = "storage/UserID/";
 $ROM0001 = "/ROM/00001.n64";
 if (file_exists($Path0001.$test.$ROM0001)) {
	 $pic00001 = "/storage/ROMDB/00001/Image/0e544972-3ac4-47d4-8c7a-eadc1bd1020f.jpg";
 }
 else
	{

	}
 $Path0002 = "storage/UserID/";
 $ROM0002 = "/ROM/00002.n64";
 if (file_exists($Path0002.$test.$ROM0002)) {
	 $pic00002 = "/storage/ROMDB/00002/Image/52b8fb58-017b-4273-adaa-f3cb823529b0.jpg";
 }
 else
	{

	}
 $Path0003 = "storage/UserID/";
 $ROM0003 = "/ROM/00003.n64";
 if (file_exists($Path0003.$test.$ROM0003)) {
	 $pic00003 = "/storage/ROMDB/00003/Image/e234e09b-62b9-4c0b-8cd8-7a2a12134dc2.jpg";
 }
 else
	{

	}
 $Path0004 = "storage/UserID/";
 $ROM0004 = "/ROM/00004.n64";
 if (file_exists($Path0004.$test.$ROM0004)) {
	 $pic00004 = "/storage/ROMDB/00004/Image/5e7af8c2-be30-4a7a-850b-c48461490cf4.jpg";
 }
 else
	{

	}
$Path0005 = "storage/UserID/";
 $ROM0005 = "/ROM/00005.n64";
 if (file_exists($Path0005.$test.$ROM0005)) {
	 $pic00005 = "/storage/ROMDB/00005/Image/1188716a-e5db-40ac-a8c1-e8505cc4f8e5.jpg";
 }
 else
	{

	}
 $Path0006 = "storage/UserID/";
 $ROM0006 = "/ROM/00006.n64";
 if (file_exists($Path0006.$test.$ROM0006)) {
	 $pic00006 = "/storage/ROMDB/00006/Image/57cd5c59-69fe-4541-ab4e-d604bf5aeb32.jpg";
 }
 else
	{

	}
 $Path0007 = "storage/UserID/";
 $ROM0007 = "/ROM/00007.n64";
 if (file_exists($Path0007.$test.$ROM0007)) {
	 $pic00007 = "/storage/ROMDB/00007/Image/437ad260-785b-479e-ba1b-0b7b079e4094.jpg";
 }
 else
	{

	}
 $Path0008 = "storage/UserID/";
 $ROM0008 = "/ROM/00008.n64";
 if (file_exists($Path0008.$test.$ROM0008)) {
	 $pic00008 = "/storage/ROMDB/00008/Image/0f633ee3-5665-4128-a28b-9dfad23db4ff.jpg";
 }
 else
	{

	}
 $Path0009 = "storage/UserID/";
 $ROM0009 = "/ROM/00009.n64";
 if (file_exists($Path0009.$test.$ROM0009)) {
	 $pic00009 = "/storage/ROMDB/00009/Image/8ce6bc0a-553c-4af5-8d3d-126c5ae1dc22.jpg";
 }
 else
	{

	}
 $Path0010 = "storage/UserID/";
 $ROM0010 = "/ROM/00010.n64";
 if (file_exists($Path0010.$test.$ROM0010)) {
	 $pic00010 = "/storage/ROMDB/00010/Image/24d7a36c-3b0b-4eb4-a201-3075cf91ad9c.jpg";
 }
 else
	{

	}
 $Path0021 = "storage/UserID/";
 $ROM0021 = "/ROM/00021.n64";
 if (file_exists($Path0021.$test.$ROM0021)) {
	 $pic00021 = "/storage/ROMDB/00021/Image/2ea26142-61e5-44fa-883b-e55c22043544.jpg";
 }
 else
	{

	}
 $Path0022 = "storage/UserID/";
 $ROM0022 = "/ROM/00022.n64";
 if (file_exists($Path0022.$test.$ROM0022)) {
	 $pic00022 = "/storage/ROMDB/00022/Image/2bacd72d-98b0-4ae5-a7a1-a05036c97904.png";
 }
 else
	{

	}
 $Path0023 = "storage/UserID/";
 $ROM0023 = "/ROM/00023.n64";
 if (file_exists($Path0023.$test.$ROM0023)) {
	 $pic00023 = "/storage/ROMDB/00023/Image/726d8929-5015-4a94-ace2-da43e9d935c5.jpg";
 }
 else
	{

	}
 $Path0024 = "storage/UserID/";
 $ROM0024 = "/ROM/00024.n64";
 if (file_exists($Path0024.$test.$ROM0024)) {
	 $pic00024 = "/storage/ROMDB/00024/Image/502e9319-c887-453f-a291-6852a334d657.jpg";
 }
 else
	{

	}
 $Path0025 = "storage/UserID/";
 $ROM0025 = "/ROM/00025.n64";
 if (file_exists($Path0025.$test.$ROM0025)) {
	 $pic00025 = "/storage/ROMDB/00025/Image/3d581f4c-0c1b-42d1-bfac-9542b3b4ae98.jpg";
 }
 else
	{

	}
 $Path0026 = "storage/UserID/";
 $ROM0026 = "/ROM/00026.n64";
 if (file_exists($Path0026.$test.$ROM0026)) {
	 $pic00026 = "/storage/ROMDB/00026/Image/0827b971-c2c8-4ba7-9313-0e51e75eb496.jpg";
 }
 else
	{

	}
$Path0030 = "storage/UserID/";
$ROM0030 = "/ROM/00030.smc";
 if (file_exists($Path0030.$test.$ROM0030)) {
	 $pic00030 = "/storage/ROMDB/00030/Image/cbc53d45-745b-41a5-a08b-73dd2ad93d1c.jpg";
 }
 else
	{

	}
$Path0031 = "storage/UserID/";
$ROM0031 = "/ROM/00031.smc";
 if (file_exists($Path0031.$test.$ROM0031)) {
	 $pic00031 = "/storage/ROMDB/00031/Image/0af318b0-1ffc-401e-a2e0-8384b6231c8b.jpg";
 }
 else
	{

	}	
$Path0032 = "storage/UserID/";
$ROM0032 = "/ROM/00032.smc";
 if (file_exists($Path0032.$test.$ROM0032)) {
	 $pic00032 = "/storage/ROMDB/00032/Image/b4c002be-d127-4c93-afd5-3f656183ea9b.png";
 }
 else
	{

	}
$Path0033 = "storage/UserID/";
$ROM0033 = "/ROM/00033.smc";
 if (file_exists($Path0033.$test.$ROM0033)) {
	 $pic00033 = "/storage/ROMDB/00033/Image/1a175c33-1c72-4524-bc46-9f88b566cb16.jpg";
 }
 else
	{

	}	
$Path0034 = "storage/UserID/";
$ROM0034 = "/ROM/00034.smc";
 if (file_exists($Path0034.$test.$ROM0034)) {
	 $pic00034 = "/storage/ROMDB/00034/Image/019cbea1-242c-40b7-b4bd-3e58495ecfaf.jpg";
 }
 else
	{

	}	
$Path0035 = "storage/UserID/";
$ROM0035 = "/ROM/00035.smc";
 if (file_exists($Path0035.$test.$ROM0035)) {
	 $pic00035 = "/storage/ROMDB/00035/Image/081547e0-8308-45ab-9462-a28933cc7e7a.jpg";
 }
 else
	{

	}		
$Path0036 = "storage/UserID/";
$ROM0036 = "/ROM/00036.smc";
 if (file_exists($Path0036.$test.$ROM0036)) {
	 $pic00036 = "/storage/ROMDB/00036/Image/8c1a9e22-0d0d-4e44-a32e-b50199df8a55.jpg";
 }
 else
	{

	}	
$Path0037 = "storage/UserID/";
$ROM0037 = "/ROM/00037.smc";
 if (file_exists($Path0037.$test.$ROM0037)) {
	 $pic00037 = "/storage/ROMDB/00037/Image/1dd78885-5737-4671-9fda-91196de36818.png";
 }
 else
	{

	}	
$Path0038 = "storage/UserID/";
$ROM0038 = "/ROM/00038.smc";
 if (file_exists($Path0038.$test.$ROM0038)) {
	 $pic00038 = "/storage/ROMDB/00038/Image/81c03bcd-6311-4116-9b38-ed762744e933.jpg";
 }
 else
	{

	}		
$Path0039 = "storage/UserID/";
$ROM0039 = "/ROM/00039.smc";
 if (file_exists($Path0039.$test.$ROM0039)) {
	 $pic00039 = "/storage/ROMDB/00039/Image/07501be2-2019-40df-9043-2c393317d7e0.jpg";
 }
 else
	{

	}	
$Path0040 = "storage/UserID/";
$ROM0040 = "/ROM/00040.smc";
 if (file_exists($Path0040.$test.$ROM0040)) {
	 $pic00040 = "/storage/ROMDB/00040/Image/384da923-15ea-44f2-9d07-16c996b63aaa.png";
 }
 else
	{

	}	
$Path0041 = "storage/UserID/";
$ROM0041 = "/ROM/00041.smc";
 if (file_exists($Path0041.$test.$ROM0041)) {
	 $pic00041 = "/storage/ROMDB/00041/Image/47d92511-6554-49ca-ab1c-c5986d05db16.jpg";
 }
 else
	{

	}	
$Path0042 = "storage/UserID/";
$ROM0042 = "/ROM/00042.smc";
 if (file_exists($Path0042.$test.$ROM0042)) {
	 $pic00042 = "/storage/ROMDB/00042/Image/2358dcbf-dac9-4651-b396-f55cee9790b0.jpg";
 }
 else
	{

	}	
$Path0043 = "storage/UserID/";
$ROM0043 = "/ROM/00043.smc";
 if (file_exists($Path0043.$test.$ROM0043)) {
	 $pic00043 = "/storage/ROMDB/00043/Image/18e0af45-5df8-4867-b37a-13cda3e3a057.png";
 }
 else
	{

	}	
$Path0044 = "storage/UserID/";
$ROM0044 = "/ROM/00044.smc";
 if (file_exists($Path0044.$test.$ROM0044)) {
	 $pic00044 = "/storage/ROMDB/00044/Image/8aa352d1-899d-4e1a-8236-d1caf2e50ed2.jpg";
 }
 else
	{

	}	
$Path0045 = "storage/UserID/";
$ROM0045 = "/ROM/00045.smc";
 if (file_exists($Path0045.$test.$ROM0045)) {
	 $pic00045 = "/storage/ROMDB/00045/Image/fb6412ac-5bcc-43ce-9fd2-82b6f7ed3ff3.jpg";
 }
 else
	{

	}
$Path0050 = "storage/UserID/";
$ROM0050 = "/ROM/00050.nes";
 if (file_exists($Path0050.$test.$ROM0050)) {
	 $pic00050 = "/storage/ROMDB/00050/Image/f50ff361-ed6d-4877-ab98-f85c2037efc3.jpg";
 }
 else
	{

	}	
$Path0051 = "storage/UserID/";
$ROM0051 = "/ROM/00051.nes";
 if (file_exists($Path0051.$test.$ROM0051)) {
	 $pic00051 = "/storage/ROMDB/00051/Image/b68a54a4-ece1-4f62-a93f-be07b7a61379.jpg";
 }
 else
	{

	}	
$Path0052 = "storage/UserID/";
$ROM0052 = "/ROM/00052.nes";
 if (file_exists($Path0052.$test.$ROM0052)) {
	 $pic00052 = "/storage/ROMDB/00052/Image/0f1ff472-a800-471e-b99b-7ce9d672cbbb.jpg.png";
 }
 else
	{

	}	
$Path0053 = "storage/UserID/";
$ROM0053 = "/ROM/00053.nes";
 if (file_exists($Path0053.$test.$ROM0053)) {
	 $pic00053 = "/storage/ROMDB/00053/Image/d54ea3d5-440e-4659-96d5-3f3dd6a123f2.jpg";
 }
 else
	{

	}	
$Path0054 = "storage/UserID/";
$ROM0054 = "/ROM/00054.nes";
 if (file_exists($Path0054.$test.$ROM0054)) {
	 $pic00054 = "/storage/ROMDB/00054/Image/96d86e0c-e80f-43f3-82f9-3fbadf389ab0.jpg";
 }
 else
	{

	}		
$Path0055 = "storage/UserID/";
$ROM0055 = "/ROM/00055.nes";
 if (file_exists($Path0055.$test.$ROM0055)) {
	 $pic00055 = "/storage/ROMDB/00055/Image/67080b03-6fee-4761-adc4-abd87842a4d2.jpg";
 }
 else
	{

	}		
$Path0056 = "storage/UserID/";
$ROM0056 = "/ROM/00056.nes";
 if (file_exists($Path0056.$test.$ROM0056)) {
	 $pic00056 = "/storage/ROMDB/00056/Image/df436972-2e5c-4525-8c0c-82c4b77be5b3.jpg";
 }
 else
	{

	}	
$Path0057 = "storage/UserID/";
$ROM0057 = "/ROM/00057.nes";
 if (file_exists($Path0057.$test.$ROM0057)) {
	 $pic00057 = "/storage/ROMDB/00057/Image/335880f8-1db7-4b9c-b918-0d168d01fec5.jpg";
 }
 else
	{

	}
$Path0058 = "storage/UserID/";
$ROM0058 = "/ROM/00058.nes";
 if (file_exists($Path0058.$test.$ROM0058)) {
	 $pic00058 = "/storage/ROMDB/00058/Image/3fdfea06-890f-49b7-9a3e-248fea26def2.jpg";
 }
 else
	{

	}
$Path0059 = "storage/UserID/";
$ROM0059 = "/ROM/00059.nes";
 if (file_exists($Path0059.$test.$ROM0059)) {
	 $pic00059 = "/storage/ROMDB/00059/Image/33aaa5f8-d8bb-4cf8-b7fd-b39a5759b53f.png.jpg";
 }
 else
	{

	}
$Path0060 = "storage/UserID/";
$ROM0060 = "/ROM/00060.nes";
 if (file_exists($Path0060.$test.$ROM0060)) {
	 $pic00060 = "/storage/ROMDB/00060/Image/c5a08c70-9bcd-4cd7-96d7-df2c4f82bc2b.jpg";
 }
 else
	{

	}
$Path0061 = "storage/UserID/";
$ROM0061 = "/ROM/00061.nes";
 if (file_exists($Path0061.$test.$ROM0061)) {
	 $pic00061 = "/storage/ROMDB/00061/Image/40a6e33a-a1d8-4226-9e9b-5398226156e2.jpg";
 }
 else
	{

	}	
$Path0062 = "storage/UserID/";
$ROM0062 = "/ROM/00062.nes";
 if (file_exists($Path0062.$test.$ROM0062)) {
	 $pic00062 = "/storage/ROMDB/00062/Image/1f9e7bad-5692-49b8-a438-232abe866541.jpg";
 }
 else
	{

	}	
$Path0063 = "storage/UserID/";
$ROM0063 = "/ROM/00063.nes";
 if (file_exists($Path0063.$test.$ROM0063)) {
	 $pic00063 = "/storage/ROMDB/00063/Image/6f4cb84e-43ce-4b42-88dc-593c994377f1.png";
 }
 else
	{

	}		
$Path0064 = "storage/UserID/";
$ROM0064 = "/ROM/00064.nes";
 if (file_exists($Path0064.$test.$ROM0064)) {
	 $pic00064 = "/storage/ROMDB/00064/Image/cf86a691-49bc-448d-b8d2-335f328449f0.jpg";
 }
 else
	{

	}	
$Path0065 = "storage/UserID/";
$ROM0065 = "/ROM/00065.nes";
 if (file_exists($Path0065.$test.$ROM0065)) {
	 $pic00065 = "/storage/ROMDB/00065/Image/c712dd7d-db08-4b1e-a057-927fe054cee4.jpg";
 }
 else
	{

	}	
$Path0066 = "storage/UserID/";
$ROM0066 = "/ROM/00066.nes";
 if (file_exists($Path0066.$test.$ROM0066)) {
	 $pic00066 = "/storage/ROMDB/00066/Image/1c8096c5-7af6-4dbd-a7e4-4df98c9c44fb.jpg";
 }
 else
	{

	}	
$Path0067 = "storage/UserID/";
$ROM0067 = "/ROM/00067.nes";
 if (file_exists($Path0067.$test.$ROM0067)) {
	 $pic00067 = "/storage/ROMDB/00067/Image/0bdcf9f7-572e-4311-b600-6a7cabdf9a0a.jpg";
 }
 else
	{

	}	
$Path0068 = "storage/UserID/";
$ROM0068 = "/ROM/00068.nes";
 if (file_exists($Path0068.$test.$ROM0068)) {
	 $pic00068 = "/storage/ROMDB/00068/Image/98cebfcf-1a08-435f-bdcc-27e47073f205.jpg";
 }
 else
	{

	}	
$Path0070 = "storage/UserID/";
$ROM0070 = "/ROM/00070.gbc";
 if (file_exists($Path0070.$test.$ROM0070)) {
	 $pic00070 = "/storage/ROMDB/00070/Image/7f1cd22b-5f8e-47bd-b5ad-eb3ec0bf2a13.jpg";
 }
 else
	{

	}	
$Path0071 = "storage/UserID/";
$ROM0071 = "/ROM/00071.gbc";
 if (file_exists($Path0071.$test.$ROM0071)) {
	 $pic00071 = "/storage/ROMDB/00071/Image/f0760be3-acfe-49d0-8084-f6ff2508af2c.jpg";
 }
 else
	{

	}
$Path0072 = "storage/UserID/";
$ROM0072 = "/ROM/00072.gbc";
 if (file_exists($Path0072.$test.$ROM0072)) {
	 $pic00072 = "/storage/ROMDB/00072/Image/eff8a63e-272b-47fc-8a2a-d6905df2b330.jpg";
 }
 else
	{

	}	
$Path0073 = "storage/UserID/";
$ROM0073 = "/ROM/00073.gbc";
 if (file_exists($Path0073.$test.$ROM0073)) {
	 $pic00073 = "/storage/ROMDB/00073/Image/90cf2517-1ef8-49bd-866c-a2d2b7b5d1a4.png";
 }
 else
	{

	}	
$Path0074 = "storage/UserID/";
$ROM0074 = "/ROM/00074.gbc";
 if (file_exists($Path0074.$test.$ROM0074)) {
	 $pic00074 = "/storage/ROMDB/00074/Image/e96de88c-338a-490b-a664-dea3a636cf1c.png";
 }
 else
	{

	}		
$Path0075 = "storage/UserID/";
$ROM0075 = "/ROM/00075.gbc";
 if (file_exists($Path0075.$test.$ROM0075)) {
	 $pic00075 = "/storage/ROMDB/00075/Image/a530156e-0ecc-48d5-8920-22f6c4b7db8e.png";
 }
 else
	{

	}		
$Path0076 = "storage/UserID/";
$ROM0076 = "/ROM/00076.gbc";
 if (file_exists($Path0076.$test.$ROM0076)) {
	 $pic00076 = "/storage/ROMDB/00076/Image/6d4eee5b-4a18-426a-8c90-55203923c246.jpg";
 }
 else
	{

	}	
$Path0077 = "storage/UserID/";
$ROM0077 = "/ROM/00077.gbc";
 if (file_exists($Path0077.$test.$ROM0077)) {
	 $pic00077 = "/storage/ROMDB/00077/Image/055b1d16-43ab-48be-8565-8ccedc8802d5.jpg";
 }
 else
	{

	}	
$Path0078 = "storage/UserID/";
$ROM0078 = "/ROM/00078.gba";
 if (file_exists($Path0078.$test.$ROM0078)) {
	 $pic00078 = "/storage/ROMDB/00078/Image/c0cfa5ca-0b5a-40e8-a94c-42ff9741e312.png";
 }
 else
	{

	}		
$Path0079 = "storage/UserID/";
$ROM0079 = "/ROM/00079.gba";
 if (file_exists($Path0079.$test.$ROM0079)) {
	 $pic00079 = "/storage/ROMDB/00079/Image/4a036083-b5c7-4d0e-8d33-d45a567f34b7.png";
 }
 else
	{

	}		
$Path0080 = "storage/UserID/";
$ROM0080 = "/ROM/00080.gba";
 if (file_exists($Path0080.$test.$ROM0080)) {
	 $pic00080 = "/storage/ROMDB/00080/Image/76544f7b-a881-4a4a-83ec-721b9bdef3c1.jpg";
 }
 else
	{

	}	
$Path0081 = "storage/UserID/";
$ROM0081 = "/ROM/00081.gba";
 if (file_exists($Path0081.$test.$ROM0081)) {
	 $pic00081 = "/storage/ROMDB/00081/Image/35a3d0f0-461d-4ee0-8afa-df5d1b753a99.jpg";
 }
 else
	{

	}	
$Path0082 = "storage/UserID/";
$ROM0082 = "/ROM/00082.gba";
 if (file_exists($Path0082.$test.$ROM0082)) {
	 $pic00082 = "/storage/ROMDB/00082/Image/4503d0f6-3dad-4dfd-8ab5-54be64130f4d.jpg";
 }
 else
	{

	}		
$Path0083 = "storage/UserID/";
$ROM0083 = "/ROM/00083.gba";
 if (file_exists($Path0083.$test.$ROM0083)) {
	 $pic00083 = "/storage/ROMDB/00083/Image/bc942bdf-d6a2-4292-8edd-4eb44efee8fd.jpg.png";
 }
 else
	{

	}		
$Path0084 = "storage/UserID/";
$ROM0084 = "/ROM/00084.gba";
 if (file_exists($Path0084.$test.$ROM0084)) {
	 $pic00084 = "/storage/ROMDB/00084/Image/9d530b2c-f042-4dbd-b8be-ff1a9914bc71.png";
 }
 else
	{

	}		
$Path0085 = "storage/UserID/";
$ROM0085 = "/ROM/00085.gba";
 if (file_exists($Path0085.$test.$ROM0085)) {
	 $pic00085 = "/storage/ROMDB/00085/Image/6cb6058b-0215-47cf-9691-af3e78ce23a6.jpg";
 }
 else
	{

	}		
// Check if the user is logged in, if not then redirect him to login page
if(!isset($_SESSION["loggedin"]) || $_SESSION["loggedin"] !== true){
	$smsg = "ROM uploading, Please wait...";
    header("location: login.php");
    exit;
}
ini_set('upload_max_filesize', '30M');
ini_set('post_max_size', '30M');
ini_set('max_input_time', 3000);
ini_set('max_execution_time', 3000);
$name = $_FILES['file']['name'];
$size = $_FILES['file']['size'];
$type = $_FILES['file']['type'];
$path1 = "storage/UserID/";
$test = ($_SESSION["id"]);
$path2 = "/ROM/";
$tmp_name = $_FILES['file']['tmp_name'];

if(isset($_POST['formSubmit']) )
	{
	  $varMovie = $_POST['ROM'];
	  $errorMessage = "";
	}

$extension = substr($name, strpos($name, '.') + 1);
 
$max_size = 100000000;
if(isset($name) && !empty($name)){
		if($extension == "n64"){
		$location = ($path1.$test.$path2);
		$name1 = $_POST['N64'];
		$ex = ".n64";
		$name = ($name1.$ex);
		if(move_uploaded_file($tmp_name, $location.$name)){
			
			header("Refresh:0");
		}else{
			$fmsg = "Failed to Upload File";
		}
	}if($extension == "z64"){
			$location = ($path1.$test.$path2);
			$name1 = $_POST['N64'];
			$ex = ".n64";
			$name = ($name1.$ex);
			if(move_uploaded_file($tmp_name, $location.$name)){
			
			header("Refresh:0");	
		}else{
			$fmsg = "Failed to Upload File";
		}
	}
	if($extension == "smc"){
			$location = ($path1.$test.$path2);
			$name1 = $_POST['SNES'];
			$ex = ".smc";
			$name = ($name1.$ex);
			if(move_uploaded_file($tmp_name, $location.$name)){
			
			header("Refresh:0");	
		}
	}
	if($extension == "nes"){
			$location = ($path1.$test.$path2);
			$name1 = $_POST['NES'];
			$ex = ".nes";
			$name = ($name1.$ex);
			if(move_uploaded_file($tmp_name, $location.$name)){
			
			header("Refresh:0");	
		}
	}
	if($extension == "gbc"){
			$location = ($path1.$test.$path2);
			$name1 = $_POST['GB'];
			$ex = ".gbc";
			$name = ($name1.$ex);
			if(move_uploaded_file($tmp_name, $location.$name)){
			
			header("Refresh:0");	
		}
	}
	if($extension == "gba"){
			$location = ($path1.$test.$path2);
			$name1 = $_POST['GB'];
			$ex = ".gba";
			$name = ($name1.$ex);
			if(move_uploaded_file($tmp_name, $location.$name)){
			
			header("Refresh:0");	
		}
	}
	if($extension == "sfc"){
			$location = ($path1.$test.$path2);
			$name1 = $_POST['SNES'];
			$ex = ".smc";
			$name = ($name1.$ex);
			if(move_uploaded_file($tmp_name, $location.$name)){
			
			header("Refresh:0");	
		}
	}if($extension != "n64" && $extension != "z64" && $extension != "smc" && $extension != "nes" && $extension != "gbc" && $extension != "sfc" && $extension != "gba"){
	$fmsg = "File must be in a valid ROM Format (make sure you only have one '.' in the name of your ROM file)";
	}

}


?>
 
<!DOCTYPE html>
<html lang="en">
<link rel="icon" type="image/png" href="assets/build/img/retro-games-colored-06-512.png" sizes="512x512" />
<head>
    <meta charset="UTF-8">
    <title>Welcome</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.css">
    <style type="text/css">
        body{ font: 14px sans-serif; text-align: center; }
    </style>
</head>
<body>
    <div class="page-header">
        <h1>Hi, <b><?php echo htmlspecialchars($_SESSION["username"]); ?></b>. Welcome to our site.</h1>
    </div>
    <p>
        <a href="reset-password.php" class="btn btn-warning">Reset Your Password</a>
        <a href="logout.php" class="btn btn-danger">Sign Out of Your Account</a>
		
    </p>
		<h3><a href="https://retrobit.games" onclick="location.replace('https://retrobit.games')">Home</a></h3>
		<!-- <h3><a href="https://retrobit.games/setup.exe" onclick="location.replace('https://retrobit.games/setup.exe')">Download the Client</a></h3> -->
		
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" >
 
<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" >
 
<link rel="stylesheet" href="styles.css" >
 
<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <meta http-equiv="content-type" content="text/html; charset=UTF-8">
  <title></title>
  <meta http-equiv="content-type" content="text/html; charset=UTF-8">
  <meta name="robots" content="noindex, nofollow">
  <meta name="googlebot" content="noindex, nofollow">
  <meta name="viewport" content="width=device-width, initial-scale=1">


  <script
    type="text/javascript"
    src="//code.jquery.com/jquery-1.6.2.js"
    
  ></script>


  <script type="text/javascript">


    $(window).load(function(){
      
$("#Rank").change(function(){
   correspondingID = $(this).find(":selected").val()
   $(".style-sub-1").hide();
   $("#" + correspondingID).show();

})

    });

</script>

</head>
<body>
 
<div class="container">
<?php //echo $name; ?>
<?php //echo $size; ?>
<?php //echo $type; ?>
<?php //echo $tmp_name; ?>
<center>
<form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top">
<input type="hidden" name="cmd" value="_s-xclick">
<input type="hidden" name="hosted_button_id" value="K8FV9PKPGZQU2">
<table>
<tr><td><input type="hidden" name="on0" value="Payment options"><center>Payment options</center></td></tr><tr><td><select name="os0">
	<option value="Retro Pass (M)">Retro Pass (M) : $5.00 USD - monthly</option>
	<option value="Retro Pass (Y)">Retro Pass (Y) : $30.00 USD - yearly</option>
</select> </td></tr>
</table><br>
<input type="hidden" name="currency_code" value="USD">
<input type="image" src="https://www.paypalobjects.com/en_US/i/btn/btn_subscribeCC_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
<img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif" width="1" height="1">
</form>



</center>
      <form class="form-signin" method="POST" enctype="multipart/form-data">
      <?php if(isset($smsg)){ ?><div class="alert alert-success" role="alert"> <?php echo $smsg; ?> </div><?php } ?>
      <?php if(isset($fmsg)){ ?><div class="alert alert-danger" role="alert"> <?php echo $fmsg; ?> </div><?php } ?>      
        <h2 class="form-signin-heading">Upload File</h2>
	  <div class="form-group">
	    <label for="exampleInputFile">File input</label>
		<p>

	
  <div class="ccms_form_element cfdiv_custom" id="style_container_div">
Please select supported consoles
<select size="1" id="Rank" class=" validate['required']" title="" type="select" name="Rank" value="-Select Your Rank-">
    <optgroup>
	    <option value="">Select...</option>
    <option value="N64">N64</option>
    <option value="SNES">SNES</option>
	<option value="NES">NES</option>
	<option value="GB">GBA/GBC</option>
    </optgroup>
</select><div class="clear"></div><div id="error-message-style"></div></div>

<div id="N64"  class="style-sub-1"  style="display: none;" name="stylesub1" onchange="ChangeDropdowns(this.value)">
Please select correct N64 ROM
    <select id="N64" name="N64">
<option value="00001">Banjo-Kazooie</option>
<option value="00002">Diddy Kong Racing</option>
<option value="00003">Donkey Kong 64</option>
<option value="00004">The Legends of Zelda: Majora's Mask</option>
<option value="00005">The Legends of Zelda: Ocarina of Time</option>
<option value="00006">Mario Kart 64</option>
<option value="00007">Star Fox 64</option>
<option value="00008">Super Mario 64</option>
<option value="00009">Super Smash Bros.</option>
<option value="00010">Yoshi Story</option>
<option value="00021">GoldenEye 007</option>
<option value="00022">Mario Party</option>
<option value="00023">Paper Mario</option>
<option value="00024">Banjo-Tooie</option>
<option value="00025">Conker's Bad Fur Day</option>
<option value="00026">Perfect Dark</option>
    </select>
</div>
<div id="SNES"  class="style-sub-1"  style="display: none;" name="stylesub1" onchange="ChangeDropdowns(this.value)">
	Please select correct SNES ROM
    <select id="SNES" name="SNES">
      <option value="00030">The Legends of Zelda: A Link to the Past</option>
	  <option value="00031">Chrono Trigger</option>
	  <option value="00032">Super Metroid</option>
	  <option value="00033">Super Mario World</option>
	  <option value="00034">Yoshi's Island</option>
	  <option value="00035">Super Mario Kart</option>
	  <option value="00036">Star Fox</option>
	  <option value="00037">Star Fox 2</option>
	  <option value="00038">Super Mario RPG</option>
	  <option value="00039">Mega Man X</option>
	  <option value="00040">Donkey Kong Country</option>
	  <option value="00041">Donkey Kong Country 2</option>
	  <option value="00042">Harvest Moon</option>
	  <option value="00043">Secret of Mana</option>
	  <option value="00044">Super Punch-Out</option>
	  <option value="00045">F-Zero</option>
    </select>
</div>
<div id="NES"  class="style-sub-1"  style="display: none;" name="stylesub1" onchange="ChangeDropdowns(this.value)">
	Please select correct NES ROM
    <select id="NES" name="NES">
      <option value="00050">Super Mario Bros. 3</option>
	  <option value="00051">The Legend of Zelda</option>
	  <option value="00052">Super Mario Bros.</option>
	  <option value="00053">Metroid</option>
	  <option value="00054">Mike Tyson's Punch-Out</option>
	  <option value="00055">ExciteBike</option>
	  <option value="00056">Super Mario Bros. 2</option>
	  <option value="00057">Ice Climber</option>
	  <option value="00058">Yoshi</option>
	  <option value="00059">Super Dodge Ball</option>
	  <option value="00060">Donkey Kong</option>
	  <option value="00061">Dr. Mario</option>
	  <option value="00062">Ninja Gaiden</option>
	  <option value="00063">Castlevania</option>
	  <option value="00064">Gradius</option>
	  <option value="00065">Ghosts'n Goblins</option>
	  <option value="00066">The Adventure of Link</option>
	  <option value="00067">Kirby's Adventure</option>
	  <option value="00068">Kid Icarus</option>
    </select>
</div>
<div id="GB"  class="style-sub-1"  style="display: none;" name="stylesub1" onchange="ChangeDropdowns(this.value)">
	Please select correct GBA/GBC ROM
    <select id="GB" name="GB">
      <option value="00070">The Legend of Zelda: Oracle of Ages</option>
	  <option value="00071">Survival Kids</option>
	  <option value="00072">Tetris DX</option>
	  <option value="00073">Pokemon Yellow</option>
	  <option value="00074">Pokemon Crystal</option>
	  <option value="00075">The Legends of Zelda: Link's Awakening DX</option>
	  <option value="00076">Wario Land 3</option>
	  <option value="00077">Shantae</option>
	  <option value="00078">Metroid Fusion</option>
	  <option value="00079">Mario & Luigi: Superstar Saga</option>
	  <option value="00080">Pokemon Emerald</option>
	  <option value="00081">The Legend of Zelda: Minish Cap</option>
	  <option value="00082">Mario Kart: Super Circuit</option>
	  <option value="00083">WarioWare, Inc.: Mega Microgames!</option>
	  <option value="00084">Metroid: Zero Mission</option>
	  <option value="00085">Pokemon Fire Red</option>
    </select>
</div>
        <div class="clear"></div><div id="error-message-style-sub-1"></div></div>
  
  <script>
    // tell the embed parent frame the height of the content
    if (window.parent && window.parent.parent){
      window.parent.parent.postMessage(["resultsFrame", {
        height: document.body.getBoundingClientRect().height,
        slug: "dKMzk"
      }], "*")
    }
  </script>

	
	
	
	
	
	
	
	</p>
	    <input type="file" name="file" id="exampleInputFile">
	    <p class="help-block">Upload a valid ROM File <br>(GBA, GBC, N64, Z64, NES or SMC)</p>
	  </div>
        <button <?php echo $smsg = "ROM uploading, Please wait..."; ?> style="width:300px;height:50px;" class="btn btn-lg btn-primary btn-block;form-signin-heading" type="submit" >Upload</button>
      </form>
</div>
		
  </form>
	          <h2 class="form-signin-heading">Games you own</h2><br>
<br>
<button onclick="n64()">N64 Games</button>  <button onclick="snes()">SNES Games</button>  <button onclick="nes()">NES Games</button>  <button onclick="gb()">GBA/GBC Games</button>


<div id="n64games" style="display: none;">
<br>
<br>
 <img src="<?php echo $pic00001; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00002; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00003; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00004; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00005; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00006; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00007; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00008; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00009; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00010; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00021; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00022; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00023; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00024; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00025; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00026; ?>" alt="" style="width:425px;height:309px;"> 
</div> 
<script>	
	function n64() {
    var snes = document.getElementById("snesgames");
	var nes = document.getElementById("nesgames");
	var n64 = document.getElementById("n64games");
	var gb = document.getElementById("gbgames");
    if (n64.style.display === "none") {
        n64.style.display = "block";
		snes.style.display = "none";
		nes.style.display = "none";
		gb.style.display = "none";
    } else {
        n64.style.display = "none";
    }
} 
</script>	

<div id="snesgames" style="display: none;">
<br>
<br>
 <img src="<?php echo $pic00030; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00031; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00032; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00033; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00034; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00035; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00036; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00037; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00038; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00039; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00040; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00041; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00042; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00043; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00044; ?>" alt="" style="width:425px;height:309px;"> 
 <img src="<?php echo $pic00045; ?>" alt="" style="width:425px;height:309px;"> 
</div> 
<script>	
	function snes() {
    var snes = document.getElementById("snesgames");
	var nes = document.getElementById("nesgames");
	var n64 = document.getElementById("n64games");
	var gb = document.getElementById("gbgames");
    if (snes.style.display === "none") {
        snes.style.display = "block";
		n64.style.display = "none";
		nes.style.display = "none";
		gb.style.display = "none";
    } else {
        snes.style.display = "none";
    }
} 
</script>	
<div id="nesgames" style="display: none;">
<br>
<br>
 <img src="<?php echo $pic00050; ?>" alt="" style="width:310px;height:425px;"> 
 <img src="<?php echo $pic00051; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00052; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00053; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00054; ?>" alt="" style="width:310px;height:425px;"> 
 <img src="<?php echo $pic00055; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00056; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00057; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00058; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00059; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00060; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00061; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00062; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00063; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00064; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00065; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00066; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00067; ?>" alt="" style="width:310px;height:425px;">
 <img src="<?php echo $pic00068; ?>" alt="" style="width:310px;height:425px;">
</div> 
<script>	
	function nes() {
    var nes = document.getElementById("nesgames");
	var snes = document.getElementById("snesgames");
	var n64 = document.getElementById("n64games");
	var gb = document.getElementById("gbgames");
    if (nes.style.display === "none") {
        nes.style.display = "block";
		n64.style.display = "none";
		snes.style.display = "none";
		gb.style.display = "none";
    } else {
        nes.style.display = "none";
    }
} 
</script>
<div id="gbgames" style="display: none;">
<br>
<br>
 <img src="<?php echo $pic00070; ?>" alt="" style="width:300px;height:269px;"> 
 <img src="<?php echo $pic00071; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00072; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00073; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00074; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00075; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00076; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00077; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00078; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00079; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00080; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00081; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00082; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00083; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00084; ?>" alt="" style="width:300px;height:269px;">
 <img src="<?php echo $pic00085; ?>" alt="" style="width:300px;height:269px;">
</div> 
<script>	
	function gb() {
    var nes = document.getElementById("nesgames");
	var snes = document.getElementById("snesgames");
	var n64 = document.getElementById("n64games");
	var gb = document.getElementById("gbgames");
    if (gb.style.display === "none") {
        gb.style.display = "block";
		n64.style.display = "none";
		snes.style.display = "none";
		nes.style.display = "none";
    } else {
        gb.style.display = "none";
    }
} 
</script>	

</body>

</html>
