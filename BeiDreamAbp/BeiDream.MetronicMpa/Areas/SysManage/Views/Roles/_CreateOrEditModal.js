(function ($) {
    app.modals.CreateOrEditRoleModal = function () {

        var _userService = abp.services.app.role;

        var _modalManager;
        var _$userInformationForm = null;


        this.init = function (modalManager) {

        };

        this.save = function () {
            alert("保存");
        };
    };
})(jQuery);