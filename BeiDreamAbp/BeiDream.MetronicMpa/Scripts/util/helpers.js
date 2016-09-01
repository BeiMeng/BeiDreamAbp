var app = app || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('AbpZeroTemplate');
    app.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

    app.downloadTempFile = function (file) {
        location.href = abp.appPath + 'File/DownloadTempFile?fileType=' + file.fileType + '&fileToken=' + file.fileToken + '&fileName=' + file.fileName;
    };

    app.createDateRangePickerOptions = function () {
        var todayAsString = moment().format('YYYY-MM-DD');
        var options = {
            locale: {
                format: 'YYYY-MM-DD',
                applyLabel: "应用",
                cancelLabel: "取消",
                customRangeLabel: "自定义范围"
            },
            min: '2015-05-01',
            minDate: '2015-05-01',
            max: todayAsString,
            maxDate: todayAsString,
            ranges: {}
        };

        options.ranges["今天"] = [moment().startOf('day'), moment().endOf('day')];
        options.ranges["昨天"] = [moment().subtract(1, 'days').startOf('day'), moment().subtract(1, 'days').endOf('day')];
        options.ranges["最近7天"] = [moment().subtract(6, 'days').startOf('day'), moment().endOf('day')];
        options.ranges["最近30天"] = [moment().subtract(29, 'days').startOf('day'), moment().endOf('day')];
        options.ranges["这个月"] = [moment().startOf('month'), moment().endOf('month')];
        options.ranges["上个月"] = [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')];

        return options;
    };

    app.getUserProfilePicturePath = function (profilePictureId) {
        return profilePictureId ?
                            (abp.appPath + 'Profile/GetProfilePictureById?id=' + profilePictureId) :
                            (abp.appPath + 'Common/Images/default-profile-picture.png');
    }

    app.getUserProfilePicturePath = function () {
        return abp.appPath + 'Profile/GetProfilePicture?v=' + new Date().valueOf();
    }

    app.getShownLinkedUserName = function (linkedUser) {
        if (!abp.multiTenancy.isEnabled) {
            return linkedUser.userName;
        } else {
            if (linkedUser.tenancyName) {
                return linkedUser.tenancyName + '\\' + linkedUser.username;
            } else {
                return '.\\' + linkedUser.username;
            }
        }
    }

    app.notification = app.notification || {};

    app.notification.getUiIconBySeverity = function (severity) {
        switch (severity) {
            case abp.notifications.severity.SUCCESS:
                return 'fa fa-check';
            case abp.notifications.severity.WARN:
                return 'fa fa-warning';
            case abp.notifications.severity.ERROR:
                return 'fa fa-bolt';
            case abp.notifications.severity.FATAL:
                return 'fa fa-bomb';
            case abp.notifications.severity.INFO:
            default:
                return 'fa fa-info';
        }
    };

})();