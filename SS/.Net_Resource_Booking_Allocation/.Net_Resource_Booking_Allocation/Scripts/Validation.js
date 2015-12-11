function callMethod() {

    var numFlag =true;
    var txtFlag = true;
    var drpFlag = true;
    var dateFlag = true;
    var chkFlag = true;
    var chkDeleteFlag = true;
    var chkActiveFlag = true;
       //----------------------- validation for input number -----------------------//
        $('.numValidator').each(function () {
            if (isNaN($(this).val()) || $(this).val().length > 25 || $(this).val() === "" || $(this).val() === undefined) {
                if (!$(this).next().hasClass('error'))
                    $(this).after('<span class="error">Please enter a valid Number </span>');
                numFlag = false;

            } else {
                if ($(this).next().hasClass('error'))
                $(this).next().remove();
                numFlag = true;
            }

        });
        //----------------------- validation for input text -----------------------//
        $('.txtValidator').each(function () {
            /* if (/^[A-z ]+$/.test($(this).val()))
            { alert(/^[A-z ]+$/.test($(this).val())); }
            else
            { alert(!/^[A-z ]+$/.test($(this).val())); }*/
            if ($(this).val() === "" || $(this).val() === undefined || !/^[A-z ]+$/.test($(this).val())) {
                if (!$(this).next().hasClass('error'))
                { $(this).after('<span class="error">Please enter a valid data</span>'); }
                txtFlag = false;

            } else {
                if ($(this).next().hasClass('error'))
                    $(this).next().remove();
               
                 txtFlag = true; 
            }


         });

         //----------------------- validation for dropdown -----------------------//
         $('.drpValidation').each(function () {
             if ($(this +"option:selected").index() > 0) {
                // console.log($(this).is(':selected'));
                 if (!$(this).next().hasClass('error'))
                 {
                     $(this).after('<span class="error">Please select an option</span>'); 
                 }
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
                   if(!$(this).find('input').next().hasClass('error'))
                       $(this).find('input').after('<span class="error">Please select any one check box</span>');
                   }

               });
           }
       
       }

      

      // ------------- return form validation value--------------------------//
       if (numFlag && txtFlag && drpFlag && dateFlag && chkFlag) {
            return true;
        } else {
            return false;
        }

    }
