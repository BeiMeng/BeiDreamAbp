var Login = function() {

    var handleLogin = function() {

        $('.form-horizontal').validate({
            //errorElement: 'span', //default input error message container
            //errorClass: 'help-block', // default input error message class
            focusInvalid: false, // do not focus the last invalid input
            rules: {
                usernameOrEmailAddress: {
                    required: true
                },
                password: {
                    required: true
                },
                vCode: {
                    required: true
                },
                remember: {
                    required: false
                }
            },

            messages: {
                usernameOrEmailAddress: {
                    required: "用户名必填"
                },
                password: {
                    required: "密码必填"
                },
                vCode: {
                    required: "验证码必填"
                }
            },

            invalidHandler: function (event, validator) { //display error alert on form submit 
                var errorMsg="";
                $.each(validator.errorList, function (i, error) {
                    if (errorMsg === "") {
                        errorMsg = error.message;
                    } else {
                        errorMsg += "," + error.message;
                    }
                });
                $('.alert-danger span', $('.form-horizontal')).html(errorMsg);
                $('.alert-danger', $('.form-horizontal')).show();
            },

            highlight: function (element) { // hightlight error inputs
                $(element)
                    .closest('.form-group').addClass('has-error'); // set error class to the control group
            },

            success: function(label) {
                label.closest('.form-group').removeClass('has-error');
                label.remove();
            },

            errorPlacement: function(error, element) {
                //error.insertAfter(element.closest('.input-icon'));
            },

            submitHandler: function(form) {
                $('.alert-danger', $('.form-horizontal')).hide(); // form validation success, call ajax form submit
            }
        });

        $('.form-horizontal input').keypress(function (e) {
            if (e.which === 13) {
                if ($('.form-horizontal').validate().form()) {
                    $('.form-horizontal').submit(); //form validation success, call ajax form submit
                }
                return false;
            }
        });

        $('.form-horizontal').submit(function (e) {
            e.preventDefault();

            if (!$('.form-horizontal').valid()) {
                return;
            }

            abp.ui.setBusy(
                null,
                abp.ajax({
                    contentType: app.consts.contentTypes.formUrlencoded,
                    url: $('.form-horizontal').attr('action'),
                    data: $('.form-horizontal').serialize()
                })
            );
        });



        $('input[type=text]').first().focus();
    }

    var handleForgetPassword = function() {
        $('.forget-form').validate({
            //errorElement: 'span', //default input error message container
            //errorClass: 'help-block', // default input error message class
            focusInvalid: false, // do not focus the last invalid input
            ignore: "",
            rules: {
                email: {
                    required: true,
                    email: true
                }
            },

            messages: {
                email: {
                    required: "请输入邮箱地址."
                }
            },

            invalidHandler: function(event, validator) { //display error alert on form submit   

            },

            highlight: function(element) { // hightlight error inputs
                $(element)
                    .closest('.form-group').addClass('has-error'); // set error class to the control group
            },

            success: function(label) {
                label.closest('.form-group').removeClass('has-error');
                label.remove();
            },

            errorPlacement: function(error, element) {
                error.insertAfter(element.closest('.input-icon'));
            },

            submitHandler: function(form) {
                //form.submit();
            }
        });

        $('.forget-form input').keypress(function(e) {
            if (e.which === 13) {
                if ($('.forget-form').validate().form()) {
                    $('.forget-form').submit();
                }
                return false;
            }
        });

        jQuery('#forget-password').click(function() {
            jQuery('.form-horizontal').hide();
            jQuery('.forget-form').show();
        });

        jQuery('#back-btn').click(function() {
            jQuery('.form-horizontal').show();
            jQuery('.forget-form').hide();
        });

    }
    return {
        //main function to initiate the module
        init: function() {

            handleLogin();
            handleForgetPassword();
            // init background images(实现登录背景的定时变化)
            $('.login').backstretch([
                    "/metronic/assets/admin/img/login/bg2.jpg",
                    "/metronic/assets/admin/img/login/bg1.jpg",
                    "/metronic/assets/admin/img/login/bg3.jpg"
            ], {
                fade: 1000,
                duration: 8000
            }
            );
        }

    };

}();

jQuery(document).ready(function() {
    Login.init();
});