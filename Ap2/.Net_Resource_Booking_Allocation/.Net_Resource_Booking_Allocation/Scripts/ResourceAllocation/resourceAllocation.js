$(document).ready(function () {
    GetResourceData();
});

function GetResourceData() {
    alert('KLKK');
    debugger;
    $.ajax({
        url: 'ResourceAllocation.aspx/getresourcedata', /// <reference path="/Admin/DL/DataHelpers.cs" />
        type: "POST",
        dataType: "json",
        //        data: "{'name': '" + name + "'}",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            //            alert(JSON.stringify(data));
            alert('success');
        }
    });
}

