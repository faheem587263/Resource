<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="ResourceAllocations.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.ResourceAllocations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <title></title>
    <meta charset="iso-8859-1">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	
	<link rel="stylesheet" href="/Admin/css/layout.css" type="text/css" >


	<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
		<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
		<!--[if lt IE 9]>
			<script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
			<script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
		<![endif]-->

   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
	
							<div style="float:left"><label> Project Id :<span id="projectid"> 
                            <asp:DropDownList ID="drpprojectiD" runat="server" AutoPostBack="True" onselectedindexchanged="drpprojectiD_SelectedIndexChanged"></asp:DropDownList>
                            
                           </span></label>
                               <label>From Week</label> <select class="project" name="fromweek" id="fromweek">
                                                <option value="1">1</option>
                                                <option value="2">2</option>
                                                <option value="3">3</option>
                                               <option value="4">4</option>
                                                <option value="5">5</option>
                                                <option value="6">6</option>
                                                <option value="7">7</option>
                                                <option value="8">8</option>
                                                <option value="9">9</option>
                                                <option value="10">10</option>
											   <option value="11">11</option>
                                                <option value="12">12</option>
                                                <option value="13">13</option>
                                                <option value="14">14</option>
                                                <option value="15">15</option>
                                                <option value="16">16</option>
                                                <option value="17">17</option>
                                                <option value="18">18</option>
                                                <option value="19">19</option>
                                                <option value="20">20</option>
                                   <option value="21">21</option>
                                                <option value="22">22</option>
                                                <option value="23">23</option>
                                                <option value="24">24</option>
                                                <option value="25">25</option>
                                                <option value="26">26</option>
                                                <option value="27">27</option>
                                                <option value="28">28</option>
                                                <option value="29">29</option>
                                                <option value="30">30</option>
                                   <option value="31">31</option>
                                                <option value="32">32</option>
                                                <option value="33">33</option>
                                                <option value="34">34</option>
                                                <option value="35">35</option>
                                                <option value="36">36</option>
                                                <option value="37">37</option>
                                                <option value="38">38</option>
                                                <option value="39">39</option>
                                                <option value="40">40</option>
                                    <option value="41">41</option>
                                                <option value="42">42</option>
                                                <option value="43">43</option>
                                                <option value="44">44</option>
                                                <option value="45">45</option>
                                                <option value="46">46</option>
                                                <option value="47">47</option>
                                                <option value="48">48</option>
                                                <option value="49">49</option>
                                                <option value="50">50</option>
                                       <option value="51">51</option>
                                                <option value="52">52</option>

								</select>
                                <label>To Week</label>
                                <select class="project" name="toweek" id="toweek">
											  <option value="1">1</option>
                                                <option value="2">2</option>
                                                <option value="3">3</option>
                                                <option value="4">4</option>
                                                <option value="5">5</option>
                                                <option value="6">6</option>
                                                <option value="7">7</option>
                                                <option value="8">8</option>
                                                <option value="9">9</option>
                                                <option value="10">10</option>
											   <option value="11">11</option>
                                                <option value="12">12</option>
                                                <option value="13">13</option>
                                                <option value="14">14</option>
                                                <option value="15">15</option>
                                                <option value="16">16</option>
                                                <option value="17">17</option>
                                                <option value="18">18</option>
                                                <option value="19">19</option>
                                                <option value="20">20</option>
                                   <option value="21">21</option>
                                                <option value="22">22</option>
                                                <option value="23">23</option>
                                                <option value="24">24</option>
                                                <option value="25">25</option>
                                                <option value="26">26</option>
                                                <option value="27">27</option>
                                                <option value="28">28</option>
                                                <option value="29">29</option>
                                                <option value="30">30</option>
                                     <option value="31">31</option>
                                                <option value="32">32</option>
                                                <option value="33">33</option>
                                                <option value="34">34</option>
                                                <option value="35">35</option>
                                                <option value="36">36</option>
                                                <option value="37">37</option>
                                                <option value="38">38</option>
                                                <option value="39">39</option>
                                                <option value="40">40</option>
                                    <option value="41">41</option>
                                                <option value="42">42</option>
                                                <option value="43">43</option>
                                                <option value="44">44</option>
                                                <option value="45">45</option>
                                                <option value="46">46</option>
                                                <option value="47">47</option>
                                                <option value="48">48</option>
                                                <option value="49">49</option>
                                                <option value="50">50</option>
                                       <option value="51">51</option>
                                                <option value="52">52</option>
								</select>
							</div>
							<div class="action_button">
								<!--<Button class="btn save" type="Button" >Save</Button>-->
								<Button class="btn submit" id="btnsubmit" type="Button"  >Submit</Button>
								<%--<Button id="its" class="btn addRow"  type="Button"  >Add Row</Button>--%>
                               <input type="button" class="btn addRow" id="its" title="Text" />
							</div>
					
					</div>
				                 <div class="tableBorder" id="maindiv">
					                <div class="table-responsive" id="subdiv">

                                        </div>
                                     </div>
               
				

                 <%--Region AP--%>
                           
              <%--   <div class="tableBorder">
					<div class="table-responsive">
					  <table id="Table1" class="table table-bordered table-striped display">
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
						  </tr>
						</thead>
						<tbody>
						 <tr>
							<td class="sno" scope="row">1</td>
							
							<td>
								<select class="project resource" name="name">
										  <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project skill" name="project" >
											  <option value="0">Select Skill</option>
											  <option value="1">.Net</option>
											  <option value="2">EpiServer</option>
											  <option value="3">Testing</option>
											  <option value="4">Tester</option>
											  <option value="5">Architect</option>
											  <option value="6">UI/UX</option>
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
						 <td><input class="actualHours fte" type="text" name="fte"/></td>
							 <td><input class="actualHours" value="5" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours a" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
						
						 </tr>
					

                            	 <tr>
							<td class="sno" scope="row">2</td>
							
							<td>
								<select class="project resource" name="name">
										  <option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option>
											  <option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option>
											  <option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option>
											  <option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option>
											  <option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option>
											  <option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option>
								</select>
							</td>
							<td>
									<select class="project skill" name="project" >
											  <option value="0">Select Skill</option>
											  <option value="1">.Net</option>
											  <option value="2">EpiServer</option>
											  <option value="3">Testing</option>
											  <option value="4">Tester</option>
											  <option value="5">Architect</option>
											  <option value="6">UI/UX</option>
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
						 <td><input class="actualHours fte" type="text" name="fte" id="abc"/></td>
							 <td><input class="actualHours" value="5" type="text" name="maxWeekHours"/></td>
							<td><input class="actualHours a" type="text" name="durationHours"/></td>
							 <td><input class="actualHours" type="text" name="fteHours" id="fteid"/></td>
							<td><input class="actualHours" type="text" name="totalHours"/></td>
							<td><input class="actualHours" type="text" name="week1"/></td>
							<td><input class="actualHours" type="text" name="week2"/></td>
							<td><input class="actualHours" type="text" name="week3"/></td>
						
						 </tr>
						</tbody>
					  </table>
					   
                      

					</div>
				</div>--%>
                 <%--END Region AP--%>
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
   
    <script src="../Scripts/ResourceAllocation/resourceAllocation.js"
        type="text/javascript"></script>
</asp:Content>
