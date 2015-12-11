var numFlag = true;
var txtFlag = true;
var drpFlag = true;
var dateFlag = true;
var chkFlag = true;
var chkDeleteFlag = true;
var chkActiveFlag = true;
var drpInsrtUpdt = true;

function callMethod() {

   
    //----------------------- validation for input number -----------------------//
    $('.numValidator').each(function () {
        if (isNaN($(this).val()) || $(this).val().length > 25 || $(this).val() === "" || $(this).val() === undefined) {
            if (!$(this).next().hasClass('error'))
                $(this).after('<span class="error">Please enter a valid Number </span>');
            numFlag = false;
            return false;

        } else {
            if ($(this).next().hasClass('error'))
                $(this).next().remove();
            numFlag = true;
        }

    });
    //----------------------- validation for input text -----------------------//
    $('.txtValidator').each(function () {

        if ($(this).val() === "" || $(this).val() === undefined || !/^[A-z ]+$/.test($(this).val())) {
            if (!$(this).next().hasClass('error'))
            { $(this).after('<span class="error">Please enter a valid data</span>'); }
            txtFlag = false;
            return false;

        } else {
            if ($(this).next().hasClass('error'))
                $(this).next().remove();

            txtFlag = true;
        }


    });

    //----------------------- validation for dropdown -----------------------//
    $('.drpValidation').each(function () {
        if ($(this).val() === "NA") {

            if (!$(this).next().hasClass('error'))
            { $(this).after('<span class="error">Please select an option</span>'); }
            drpFlag = false;


        } else {
            if ($(this).next().hasClass('error'))
                $(this).next().remove();

            drpFlag = true;

        }

    });

    //----------------------- validation for date picker -----------------------//
    $('.dateValidator').each(function () {
        if ($(this).val() === "" || $(this).val() === undefined) {
            if (!$(this).next().hasClass('error'))
            { $(this).after('<span class="error">Please select a date</span>'); }
            dateFlag = false;

        } else {
            if ($(this).next().hasClass('error'))
                $(this).next().remove();

            dateFlag = true;
        }


    });

    //--------------- ckeckbox selection ------------------------------//
    $('.chkValidator').each(function () {

        if ($(this).hasClass('chkActive')) {
            if ($(this).find('input').is(':checked')) {
                chkActiveFlag = true;
            } else {

                chkActiveFlag = false;
            }
        }
        if ($(this).hasClass('chkDelete')) {
            if ($(this).find('input').is(':checked')) {
                chkDeleteFlag = true;

            } else {

                chkDeleteFlag = false;
            }

        }

    });

    //------------- checking validation for checkbox  -----------------------------//
    if (chkActiveFlag && chkDeleteFlag) {
        chkFlag = false;
        $('.chkValidator').each(function () {

            if ($(this).hasClass('chkActive')) {
                if (!$(this).find('input').next().hasClass('error'))
                    $(this).find('input').after('<span class="error">Please select any one check box</span>');
            }
            if ($(this).hasClass('chkDelete')) {
                if (!$(this).find('input').next().hasClass('error'))
                    $(this).find('input').after('<span class="error">Please select any one check box</span>');
            }

        });

    } else {
        if (chkActiveFlag || chkDeleteFlag) {
            chkFlag = true;
            $('.chkValidator').each(function () {

                $(this).find('.error').remove();

            });
        } else {
            chkFlag = false;


            $('.chkValidator').each(function () {

                if ($(this).hasClass('chkActive')) {
                    if (!$(this).find('input').next().hasClass('error'))
                        $(this).find('input').after('<span class="error">Please select any one check box</span>');
                }
                if ($(this).hasClass('chkDelete')) {
                    if (!$(this).find('input').next().hasClass('error'))
                        $(this).find('input').after('<span class="error">Please select any one check box</span>');
                }

            });
        }

    }
   

    

}
function onSubmit() {
    callMethod();


    //------------ Validation check for insert and update dropdown--------------------//

    if ( $('.drpUpdate')[0]) {
        if ( $('.drpUpdate').val() === "NA") {
            drpInsrtUpdt = false;
           
            if (!$('.drpUpdate').next().hasClass('error')) {
                $('.drpUpdate').after('<span class="error">Please select any one option</span>');
            }

        } else {
            if ( $('.drpUpdate').val() !== "NA") {
                drpInsrtUpdt = false;
               
                if (!$('.drpUpdate').next().hasClass('error')) {
                    $('.drpUpdate').after('<span class="error">Please select any one option</span>');
                }

            } else {
                drpInsrtUpdt = true;
                if ($('.drpUpdate').next().hasClass('error'))
                    $('.drpUpdate').next().remove();
              

            }

        }

    }



    // ------------- return form validation value--------------------------//
    if (numFlag && txtFlag && drpFlag && dateFlag && chkFlag && drpInsrtUpdt) {
        console.log();
        return true;
    } else {
        console.log();
        return false;
    }

}

function onAdd() {
    callMethod();


    //------------ Validation check for insert and update dropdown--------------------//

    if ($('.drpInsert')[0]) {
        if ($('.drpInsert').val() === "NA") {
            drpInsrtUpdt = false;
            if (!$('.drpInsert').next().hasClass('error')) {
                $('.drpInsert').after('<span class="error">Please select any one option</span>');
            }
          

        } else {
            if ($('.drpInsert').val() !== "NA" ) {
                drpInsrtUpdt = false;
                if (!$('.drpInsert').next().hasClass('error')) {
                    $('.drpInsert').after('<span class="error">Please select any one option</span>');
                }
               

            } else {
                drpInsrtUpdt = true;
               
                if ($('.drpInsert').next().hasClass('error'))
                    $('.drpInsert').next().remove();

            }

        }

    }




    // ------------- return form validation value--------------------------//
    if (numFlag && txtFlag && drpFlag && dateFlag && chkFlag && drpInsrtUpdt) {
        console.log();
        return true;
    } else {
        console.log();
        return false;
    }

}

function orderForm() {
  
        $('.orderList').addClass('hide');

        $('.orderForm').removeClass('hide');


    return true;
}