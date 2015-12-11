<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResourceAllocation.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.ResourceAllocation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="iso-8859-1">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	
	 <link href="/Admin/css/main.css" rel="stylesheet">
     <link href="/Admin/css/layout.css" rel="stylesheet">


	<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
		<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
		<!--[if lt IE 9]>
			<script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
			<script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
		<![endif]-->
</head>
<body>
    <form id="form1" runat="server">
   <!-- content -->
<div class="layout__main-content-container">
			<nav class="topbar topbar--board">
				<div class="topbar__left">
					<div class="topbar__logo-wrapper">
						<a href="/" class="topbar__logo">Resource Booking</a>
					</div>
				</div>
				
				
			</nav>
		</div>
<div class="wrapper mainBody">
     

  <div id="container">
   
	<!-- ################################################################################################ -->
    <div class="full_width col2 clear">
      
	
		<div class="three_quarter1 col ">
			<div class="block clear blogBlock">
			
				 <div class="filters">
	
							
							<div class="action_button">
								<!--<Button class="btn save" type="Button" >Save</Button>-->
								<Button class="btn btn-success" type="Button"  >Submit</Button>
								<Button id="its" class="btn btn-default"  type="Button"  >Add Row</Button>
							</div>
					
					</div>
				
				<div class="tableBorder">
					<div class="table-responsive">
					  <table id="itsTable" class="table table-bordered table-striped display">
						<thead>
						  <tr>
							<th>S.No</th>
							<th>Name</th>
							<th>Skill</th>
							<th>Global Grade</th>
							<th>India Grade</th>
							<th>FTE</th>
							<th>Max Hrs / Week</th>
							<th>Duration (Hrs)</th>
							<th>FTE Hrs / Week</th>
							<th>Total</th>
							<th>Week 1</th>
							<th>Week 2</th>
							<th>Week 3</th>
							<th>Week 4</th>
							<th>Week 5</th>
							<th>Week 6</th>
							<th>Week 7</th>
							<th>Week 8</th>
							<th>Week 9</th>
							<th>Week 10</th>
							<th>Week 11</th>
							<th>Week 12</th>
							<th>Week 13</th>
							<th>Week 14</th>
							<th>Week 15</th>
						  </tr>
						</thead>
						<tbody>
						 <tr>
							<td class="sno" scope="row">1</td>
							
							<td>
								<select class="project" name="name">
											  <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
						 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>
						 <!-- ROW 1 -->
						  <tr>
							<td class="sno" scope="row">2</td>
							
							<td>
								<select class="project" name="name">
											 <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
							
							 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>
						<tr>
							<td class="sno" scope="row">3</td>
							
							<td>
								<select class="project" name="name">
											 <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
						 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>

<tr>
							<td class="sno" scope="row">4</td>
							
							<td>
								<select class="project" name="name">
											 <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
							
						 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>
						<tr>
							<td class="sno" scope="row">5</td>
							
							<td>
								<select class="project" name="name">
											 <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
					 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>
						<tr>
							<td class="sno" scope="row">6</td>
							
							<td>
								<select class="project" name="name">
											 <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
						 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>

					<tr>
							<td class="sno" scope="row">7</td>
							
							<td>
								<select class="project" name="name">
											 <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
					 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>
						<tr>
							<td class="sno" scope="row">8</td>
							
							<td>
								<select class="project" name="name">
											 <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
							
					 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>
				<tr>
							<td class="sno" scope="row">9</td>
							
							<td>
								<select class="project" name="name">
											 <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
							
						 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>

					<tr>
							<td class="sno" scope="row">10</td>
							
							<td>
								<select class="project" name="name">
											 <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project" name="project" >
											  <option value="">Select Skill</option>
											  <option value="Episerver">Episerver</option>
											  <option value=".Net">.Net</option>
											  <option value="MVC/.Net">MVC/.Net</option>
											  <option value="Tester">Tester</option>
											  <option value="Architect">Architect</option>
											  <option value="UI/UX">UI/UX</option>
									</select>
							</td>
							<td>
							    <select class="globalGrade" name="globalgradeselect">
										  <option value="A">A</option>
										  <option value="B">B</option>
										  <option value="C">C</option>
										  <option value="D">D</option>
										  <option value="E">E</option>
								</select>
							</td>
							<td>
							    <select class="indiaGrade" name="indiagradeselect">
										  <option value="P0">P0</option>
										  <option value="P1">P1</option>
										  <option value="P2">P2</option>
										  <option value="P3">P3</option>
										  <option value="P4">P4</option>
										  <option value="P5">P5</option>
										  <option value="M1">M1</option>
										  <option value="M2">M2</option>
										  <option value="M3">M3</option>
								</select>
							</td>
						 <td><input class="actualHours" type="text" name="fte"/></td>
							 <td><input class="actualHours" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
							<td><input class="actualHours" type="text" name="week4"/></td>
							<td><input class="actualHours" type="text" name="week5"/></td>
							<td><input class="actualHours" type="text" name="week6"/></td>
							<td><input class="actualHours" type="text" name="week7"/></td>
							<td><input class="actualHours" type="text" name="week8"/></td>
							<td><input class="actualHours" type="text" name="week9"/></td>
							<td><input class="actualHours" type="text" name="week10"/></td>
							<td><input class="actualHours" type="text" name="week11"/></td>
							<td><input class="actualHours" type="text" name="week12"/></td>
							<td><input class="actualHours" type="text" name="week13"/></td>
							<td><input class="actualHours" type="text" name="week14"/></td>
							<td><input class="actualHours" type="text" name="week15"/></td>
						 </tr>
						 
						 
						 
						</tbody>
					  </table>
					 

					</div>
				</div>

			</div>
		</div>
		  

		  
		 
		  
		  
		  
		  
		  
	  </div>
	 
     </div>
    <!-- ################################################################################################ -->
    
    
  </div>


	
	
	
	
	<!--<script src="js/jquery-1.11.0.min.js"></script>-->
	<script src="../Scripts/jquery.js"></script>
	<script src="../Scripts/jquery.dataTables.js"></script>
   <script src="../Scripts/resourceBooking.js"></script>
    </form>
</body>
</html>
