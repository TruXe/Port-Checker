<?php
error_reporting(E_ERROR | E_PARSE);
try{
   $IP = $_GET['ip'];
   $PORT = $_GET['port'];
   $fp=fsockopen($IP, $PORT, $errno, $errstr, 3);
 if($fp){
   echo "Port " . $PORT . " Open!"; 
 }else{
   echo "Port " . $PORT . " Closed!";
 }
 }catch(Exception $e) {
       echo $e->getMessage()." On line ". $e->getLine();
}
?>