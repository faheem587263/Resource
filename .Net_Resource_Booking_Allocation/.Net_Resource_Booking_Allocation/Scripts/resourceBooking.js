(function () {
    $('.mainBody').css('min-height', eval($(window).height() - $('.head').height() - $('.footer').height() - 20));





    //Add the row
    var rowCount = 11;


    var tbl = $('#itsTable').DataTable();
    $('#its').on('click', function () {



        tbl.row.add(
                [rowCount++, '<select class="project" name="name"><option value="[Ind] Vishal Dattani">[Ind] Vishal Dattani</option><option value="[Ind] Chandrakant Hadpidkar">[Ind] Chandrakant Hadpidkar</option><option value="[Ind] Amol Pawar">[Ind] Amol Pawar</option><option value="[Ind] Faheem Ahmad">[Ind] Faheem Ahmad</option><option value="[Ind] Kunal Doshi"> [Ind] Kunal Doshi</option><option value="[Ind] Shashank Shinde"> [Ind] Shashank Shinde</option></select>', '<select class="project" name="project"><option value="">Select Skill</option><option value="Episerver">Episerver</option><option value=".Net">.Net</option><option value="MVC/.Net">MVC/.Net</option><option value="Tester">Tester</option><option value="Architect">Architect</option><option value="UI/UX">UI/UX</option></select>', '<select class="globalGrade" name="globalgradeselect"><option value="A">A</option><option value="B">B</option><option value="C">C</option><option value="D">D</option><option value="E">E</option></select>', '  <select class="indiaGrade" name="indiagradeselect"><option value="P0">P0</option><option value="P1">P1</option><option value="P2">P2</option><option value="P3">P3</option><option value="P4">P4</option><option value="P5">P5</option><option value="M1">M1</option><option value="M2">M2</option><option value="M3">M3</option></select>', '<input class="actualHours" type="text" name="fte"/>', '<input class="actualHours" type="text" name="maxWeekHours"/>', '<input class="actualHours" type="text" name="durationHours"/>', '<input class="actualHours" type="text" name="fteHours"/>', '<input class="actualHours" type="text" name="totalHours"/>', '<input class="actualHours" type="text" name="week1"/>', '<input class="actualHours" type="text" name="week2"/>', '<input class="actualHours" type="text" name="week3"/>', '<input class="actualHours" type="text" name="week4"/>', '<input class="actualHours" type="text" name="week5"/>', '<td><input class="actualHours" type="text" name="week6"/></td>', '<td><input class="actualHours" type="text" name="week7"/></td>', '<td><input class="actualHours" type="text" name="week8"/></td>', '<td><input class="actualHours" type="text" name="week9"/></td>', '<td><input class="actualHours" type="text" name="week10"/></td>', '<td><input class="actualHours" type="text" name="week11"/></td>', '<td><input class="actualHours" type="text" name="week12"/></td>', '<td><input class="actualHours" type="text" name="week13"/></td>', '<td><input class="actualHours" type="text" name="week14"/></td>', '<td><input class="actualHours" type="text" name="week15"/></td>']
            ).draw();





    });



})();