(function ($) {
    app.modals.CreateOrEditUserModal = function() {

        var _userService = abp.services.app.user;

        var _modalManager;
        var _$userInformationForm = null;
        

        this.init = function (modalManager) {

        };

        this.save = function() {
            alert("保存");
        };
    };
})(jQuery);