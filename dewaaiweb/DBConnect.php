<?php
$table = "Users";
DBConnectionSetup($table);
function DBConnectionSetup($table)
{
	
	$servername = "localhost";
	$username = "pieter";
	$password = "5CgwNv!?WGPU";
	$dbname = "pieter_DeWaai";
	
	// Create connection
	$conn = new mysqli($servername, $username, $password, $dbname);
	// Check connection
	if ($conn->connect_error) {
		 die("Connection failed: " . $conn->connect_error);
	} 
	
	$sql = "SELECT * 
FROM  $table
LIMIT 0 , 30";
	$result = $conn->query($sql);
	
	if ($result->num_rows > 0) {
		 // output data of each row
		 while($row = $result->fetch_assoc()) {
			 echo "<br> id: ". $row["id"]. " - Email: ". $row["Email"]. " - FirstName" . $row["FirstName"] . "<br>";
		 }
	} else {
		 echo "0 results";
	}
	
	$conn->close();
 
}
function getTable($tablename)
{
	
}


?>