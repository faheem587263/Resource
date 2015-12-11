(function () {
    function callMethod() {

        var flag = true;
        $('.numValidator').each(function () {
            if (isNaN($(this).val()) || $(this).val().length > 25 || $(this).val() === "" || $(this).val() === undefined) {
                if (!$(this).next().hasClass('error'))
                    $(this).after('<span class="error">Please enter a valid Number </span>');
                    flag = false;

            } else {
                $(this).next().addClass('validateNum');
                flag = true;
            }

        });
        $('.txtValidator').each(function () {
            //  if (/^[A-z ]+$/.test($(this).val())) {
            if ($(this).val().length > 25 || $(this).val() === "" || $(this).val() === undefined) {
                if (!$(this).next().hasClass('error'))
                    $(this).after('<span class="error">Please enter a valid data</span>');
                flag = false;

            } else {
                $(this).next().addClass('validateStr');
                flag = true;
            }


        });

    }
});