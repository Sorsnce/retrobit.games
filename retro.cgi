$dateinfo=`date +%Y%M%d%H%M%S%N`;
chop $dateinfo;
$myfile="/uploads/$dateinfo."."csv";
#The next 13 lines parse the report and pipe it to the file
use CGI;
use CGI::Carp qw (fatalsToBrowser);
use File::Basename;
my $query = new CGI;
my $filename = $query->param("reportContent");
my $upload_filehandle = $query->upload("reportContent");
open ( UPLOADFILE, ">$myfile" ) or die "$!";
binmode UPLOADFILE;
while ( <$upload_filehandle> )
{
print UPLOADFILE;
}
close UPLOADFILE;
#This just generates a blank page after form submission, so Apache
#doesn’t throw an error message in the log file
print $query->header ( );
print <<END_HTML;
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Thanks!</title>
<style type="text/css">
img {border: none;}
</style>
</head>
<body>
<p>Thanks</p>
</body>
</html>
END_HTML