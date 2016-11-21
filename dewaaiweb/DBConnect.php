<?php
//Setup data conneciton
function DBConnectionSetup($page)
{
	//create variable for db conneciton
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
	//check page
	if ($page == "Courses")
	{
	Getcourses($conn);
	}
	if ($page == "Instructors")
	{
		GetInstructors($conn);
	}
		if ($page == "about")
	{
		GetAbout($conn);
	}
}
//set data for Courses
function Getcourses($conn)
{
		$sql = "SELECT * 
FROM  `Courses` 
LIMIT 0 , 30";
	$result = $conn->query($sql);
	
	if ($result->num_rows > 0) {
		 // output data of each row
		 while($row = $result->fetch_assoc()) {
			 echo $row["Title"] . $row["Description"] . $row["Price"]. "<br/><img src='" . $row["IMG"] . " '/><br>";
		 }
	} else {
		 echo "0 results";
	}
	//close db connection
	$conn->close();
 
}
//set data for Instructors
function GetInstructors($conn)
{

		$sql = "SELECT * 
FROM  `Instructors` 
LIMIT 0 , 30";
	$result = $conn->query($sql);
	if ($result->num_rows > 0) {
		 // output data of each row
		 while($row = $result->fetch_assoc()) {
			 echo $row["Name"] . "<br>" .$row["Description"].  "<br>";
		 }
	} else {
		 echo "0 results";
	}
	//close connection
	$conn->close();
 
}
//set data for Instructors
function GetAbout($conn)
{

		$sql = "SELECT * 
FROM  `noinfo` 
LIMIT 0 , 30";
	$result = $conn->query($sql);
	if ($result->num_rows > 0) {
		 // output data of each row
		 while($row = $result->fetch_assoc()) {
			 echo $row["Name"] . "<br>" .$row["Description"].  "<br>";
		 }
	} else {
		 echo "0 results";
	}
	//close connection
	$conn->close();
 
}

?>