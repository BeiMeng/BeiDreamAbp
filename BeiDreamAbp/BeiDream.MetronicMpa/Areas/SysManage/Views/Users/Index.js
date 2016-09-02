; (function ($) {
    moment.locale('zh-CN'); //设置当前语言环境为中文
    var todayAsString = moment().format('YYYY-MM-DD');
    var selectedDateRange = {
        StartCreateTime: todayAsString,
        EndCreateTime: todayAsString
    };

    $('input.date-range-picker').daterangepicker(
        $.extend(true, app.createDateRangePickerOptions(), selectedDateRange),
        function (start, end, label) {
            selectedDateRange.StartCreateTime = start.format('YYYY-MM-DD');
            selectedDateRange.EndCreateTime = end.format('YYYY-MM-DD');
        });

    var userTable = $('#grid').DataTable({
        "ajax": {
            "url": "Users/GetUserDatas",
            "data": function (data) {
                data.UserName = $("#txtUserName").val();//此处是添加额外的请求参数
                data = $.extend(data, selectedDateRange);
                return JSON.stringify(data);
            }
        },
        "columnDefs": [{
            "targets": 1,
            "width": "15px",
            render: function (data, type, full, meta) {
                return '<input type="checkbox" name="rowcheck" id="checkbox-all-' + full.Id + '" value="' + full.Id + '" class="checkchild"/>';
            }
            },
            {
                "targets": 5,
                render: function (data, type, full, meta) {
                    if (full.lastLoginTime) {
                        return moment(full.lastLoginTime).format('L');
                    }
                    return '-';
                }
            },
            {
                "targets": 6,
                render: function (data, type, full, meta) {
                    return moment(full.CreationTime).format('L');
                }
            },
            {
                "targets": -1,
                "width": "100px",
                render: function (data, type, row, meta) {
                    var html = '<span>' +
                        '<button class="btn btn-success btn-xs" title="权限设置" onclick="setPermissions(' + row.Id + ')"><i class="fa fa-edit"></i>权限设置</button>' +
                        '</span>';
                    return html;
                }
            }]
    });
    userTable.on('init.dt', function () {
        $(".pagination li").removeClass("paginate_button");
    });
    userTable.on('draw.dt', function () {
        $(".pagination li").removeClass("paginate_button");
    });
        
    $("#btnSearch").click(function () {
        userTable.ajax.reload();
    });
    $("#btnRefresh").click(function () {
        userTable.ajax.reload();
    });
})(jQuery);

//设置用户权限
function setPermissions(id) {
    var aa = $(".checkchild:checked").val();
    alert(aa);
}