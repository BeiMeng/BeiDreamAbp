;(function ($) {
    $(function () {
        $('.theme-colors > ul > li', $('.settingtheme-panel')).click(function () {
            $('ul > li', $('.settingtheme-panel')).removeClass("current");
            $(this).addClass("current");
        });

        $("#btnSave").click(function () {
            var panel = $('#themeoptions');
            var layoutOption = $('.layout-option', panel).val();
            var sidebarOption = $('.sidebar-option', panel).val();
            var headerOption = $('.page-header-option', panel).val();
            var footerOption = $('.page-footer-option', panel).val();
            var sidebarPosOption = $('.sidebar-pos-option', panel).val();
            var sidebarStyleOption = $('.sidebar-style-option', panel).val();
            var sidebarMenuOption = $('.sidebar-menu-option', panel).val();
            var headerTopDropdownStyle = $('.page-header-top-dropdown-style-option', panel).val();
            var themeStyle = $('.layout-style-option', panel).val();
            var themeColor = $('.current.tooltips', panel).attr("data-style");

            var themeSetting =
                {
                    themeColor: themeColor,
                    themeStyle: themeStyle,
                    layout: layoutOption,
                    sidebarMode: sidebarOption,
                    headerPosition: headerOption,
                    footerPosition: footerOption,
                    sidebarPosition: sidebarPosOption,
                    sidebarStyle: sidebarStyleOption,
                    sidebarMenu: sidebarMenuOption,
                    headerTopDropdownStyle: headerTopDropdownStyle
                }


            var _hostSettingsService = abp.services.app.hostSettings;
            abp.message.confirm(
                "保存UI主题设置后将重新加载页面", "确定保存吗?",
                function (isConfirmed) {
                    if (isConfirmed) {
                        _hostSettingsService.updateAllThemeSettings(themeSetting).done(function () {
                            abp.notify.info("保存成功!");
                            window.location = "/admin";
                        });
                    }
                }
            );
        });
    });
})(jQuery);