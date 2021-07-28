<?php

$filename = $_POST["name"];
$text1 = $_POST["dataToSave"];

if ($filename != "")
{
	$file = fopen($filename, "a");
	fwrite($file, $text1);
	fclose($file);
}
else {
	echo("Data was empty");
}

?>