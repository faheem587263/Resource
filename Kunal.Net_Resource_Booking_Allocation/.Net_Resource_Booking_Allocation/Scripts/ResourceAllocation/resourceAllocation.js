var datanew = new Array();
var rownumber = 1;

$(document).ready(function () {
//    $("#fromweek option[value='24']").attr("selected", "selected");
    var intro = 'a';

    $('#btnsubmit').on('click', function () {
        rownumber = 1;
        var fromweek = $('#fromweek option:selected').val();
        var toweek = $('#toweek option:selected').val();
        var resourcedetailsarray = [];

        $('#Table2 > tbody  > tr').each(function () {
            debugger;
            var obj = {};
            obj.resource = $(this).closest('tr').find('select.resource option:selected').val();
            obj.skill = $(this).closest('tr').find('select.skill option:selected').val();
            obj.glbgrd = $(this).closest('tr').find('select.glbgrd option:selected').val();
            obj.indgrd = $(this).closest('tr').find('select.indgrd option:selected').val();
            obj.fte = $(this).closest('tr').find('input.fte').val();
            obj.maxWeekHours = $(this).closest('tr').find('input[name=maxWeekHours]').val();
            obj.durationHours = $(this).closest('tr').find('input[name=durationHours]').val();
            obj.fteHours = $(this).closest('tr').find('input[name=fteHours]').val();
            obj.totalHours = $(this).closest('tr').find('input[name=totalHours]').val();

            for (var a = fromweek; a <= toweek; a++) {
                obj['' + a + ''] = $(this).closest('tr').find('input[name=Week' + a + ']').val();
            }
            resourcedetailsarray.push(obj);
        });

        $.ajax({
            url: 'ResourceAllocation.aspx/insertresourcedata',
            type: "GET",
            dataType: "json",
            data: { a: JSON.stringify(resourcedetailsarray), projectId: '1', startweek: fromweek, endweek: toweek },
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.d == true)
                    alert('success');
                else
                    alert('fail');
            }
        });
    });


    $('#its').on('click', function () {


        var fromweek = $('#fromweek option:selected').val();
        var toweek = $('#toweek option:selected').val();
        var strmaintable = "";
        for (var a = fromweek; a <= toweek; a++) {
            strmaintable = strmaintable + "<td><input class='actualHours weeks' type='text' name='Week" + a + "'/></td>";
        }
        var a = "";
        a = a + "<tr><td class='sno' scope='row'>" + rownumber + "</td><td><select class='project resource' name='name'></select></td><td><select class='project skill' name='project'>";
        a = a + "<option value='0'>Select Skill</option><option value='1'>.Net</option><option value='2'>EpiServer</option><option value='3'>Testing</option>";
        a = a + "<option value='4'>Tester</option><option value='5'>Architect</option><option value='6'>UI/UX</option></select></td><td>";
        a = a + "<select class='globalGrade glbgrd' name='globalgradeselect'><option value='1'>A</option><option value='2'>B</option><option value='3'>C</option>";
        a = a + "<option value='4'>D</option><option value='5'>E</option></select></td><td>";
        a = a + "<select class='indiaGrade indgrd' name='indiagradeselect'><option value='0'>P0</option><option value='1'>P1</option>";
        a = a + "<option value='2'>P2</option><option value='3'>P3</option><option value='4'>P4</option><option value='5'>P5</option><option value='11'>M1</option><option value='12'>M2</option><option value='13'>M3</option>";
        a = a + "</select></td><td><input class='actualHours fte' id='ida' type='text' name='fte'/></td><td><input class='actualHours' value='5' type='text' name='maxWeekHours'/></td>";
        a = a + "<td><input class='actualHours a' type='text' name='durationHours'/></td><td><input class='actualHours' type='text' name='fteHours'/></td><td><input class='actualHours' disabled='disabled' type='text' name='totalHours'/></td>";
        a = a + strmaintable;
        $('#Table2 tbody').append(a);

        $("#Table2 > tbody  > tr .a, .skill, .glbgrd, .indgrd").focusout(function () {
            var skillVal = $(this).closest('tr').find('select.skill option:selected').val();
            var glbgrdVal = $(this).closest('tr').find('select.glbgrd option:selected').val();
            var indgrdVal = $(this).closest('tr').find('select.indgrd option:selected').val();

            var fteFieldVal = $(this).closest('tr').find('input.fte').val();
            var arraynumber = $(this).closest('tr').find('td.sno').text();
            GetResourceData($(this).closest('tr'), arraynumber, skillVal, glbgrdVal, indgrdVal, fteFieldVal);

            var weeksForRow = $(this).closest('tr').find('.weeks');
            weeksForRow.change(function () {

                debugger;
                var weeks = $(this).closest('tr').find('.weeks');

                var sum = 0;
                weeks.each(function () {
                    sum = sum + parseInt($(this).val());
                });
                $(this).closest('tr').find('input[name=totalHours]').val('');
                $(this).closest('tr').find('input[name=totalHours]').val(sum);

                var weekhrsvalidate = $(this).val();

                var columnNumber, headerText;
                columnNumber = $(this).closest("td").index() + 1;
                headerText = $('th:nth-child(' + columnNumber + ')').text();
                var weeknumber = headerText.slice(4);
                debugger;
                if (datanew[0][parseInt($(this).closest('tr').find('td.sno').text()) - 1]["" + parseInt(weeknumber) + ""].trim()) {
                    if (parseInt(weekhrsvalidate) > datanew[0][parseInt($(this).closest('tr').find('td.sno').text()) - 1]["" + parseInt(weeknumber) + ""]) {
                        alert('Booking Hrs Should be less than or equals to ' + datanew[0][parseInt($(this).closest('tr').find('td.sno').text()) - 1]["" + parseInt(weeknumber) + ""] + ' Hrs');
                        $(this).focus();
                        return false;
                    }
                }
                else {
                    if (parseInt(weekhrsvalidate) > 45) {
                        alert('Booking Hrs Should be less than or equals to 45 Hrs');
                        $(this).focus();
                        return false;
                    }
                }

            });


        });

        rownumber = rownumber + 1;
    });





    $('#toweek').change(function () {
        rownumber = 1;
        $('#subdiv').html('');
        var fromweek = $('#fromweek option:selected').val();
        var toweek = $('#toweek option:selected').val();

        var strmaintable = "<table id='Table2' class='table table-bordered table-striped display'><thead><tr><th>S.No</th><th>Name</th><th>Skill</th><th>Global Grade</th><th>India Grade</th><th>FTE</th><th>Max Hrs / Week</th><th>Duration (Hrs)</th><th>FTE Hrs / Week</th><th>Total</th>";
        for (var a = fromweek; a <= toweek; a++) {
            strmaintable = strmaintable + "<th>Week" + a + "</th>";
        }
        strmaintable = strmaintable + "</tr></thead><tbody></tbody></table>";
        $('#subdiv').append(strmaintable);
        $('#its').trigger("click");
    });
});

function GetResourceData(currentrow, arraynumber, skillVal, glbgrdVal, indgrdVal, fteFieldVal) {

    var a = {};
    var b = $('#fromweek option:selected').val();
    $.ajax({
        url: 'ResourceAllocation.aspx/getresourcedata',
        type: "GET",
        dataType: "json",
        data: { "fromweek": $('#fromweek option:selected').val(), "toweek": $('#toweek option:selected').val(), "skillVal": "" + parseInt(skillVal) + "", "glbgrdVal": "" + glbgrdVal + "", "indgrdVal": "" + indgrdVal + "", "fteFieldVal": "" + fteFieldVal + "" },

        contentType: "application/json; charset=utf-8",
        success: function (data) {
            if (data.d) {
                var objdata = $.parseJSON(data.d);
                a = objdata;
                datanew[arraynumber - 1] = a;
                var a = currentrow.find('select.skill option:selected').val();
                var drptobind = currentrow.find('select.resource');
                drptobind.html('');
                drptobind.append($("<option></option>").val('select').html('..SELECT'));
                $.each(datanew[arraynumber - 1], function (k, v) {
                    drptobind.append($("<option></option>").val(v.Res_Id).html(v.Res_Name));
                });

                drptobind.change(function () {
                    var sourcedata = datanew[arraynumber - 1];
                    var returnedData = $.grep(sourcedata, function (element, index) {
                        return element.Res_Id == drptobind.find('option:selected').val();
                    });
                    var fromweek = $('#fromweek option:selected').val();
                    var toweek = $('#toweek option:selected').val();
                    debugger;
                    for (var a = fromweek; a <= toweek; a++) {
                        drptobind.closest('tr').find('input[name=Week' + a + ']').val('');
                        if (returnedData[0]['' + a + ''].trim()) {
                            drptobind.closest('tr').find('input[name=Week' + a + ']').val(returnedData[0]['' + a + '']);
                        }
                        else {
                            drptobind.closest('tr').find('input[name=Week' + a + ']').val('45');
                        }
                    }

                    var weekforrow = $(this).closest('tr').find('.weeks');

                    weekforrow.trigger('change');

                });
            }

        }
    });

}

