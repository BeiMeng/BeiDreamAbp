;(function ($) {
    $(function () {
        UsersTable.tableInit();
        abp.event.on('app.usersTableReLoad', function () {
            UsersTable.tableRefresh();
        });
        UsersButtons.buttonsInit();
    });
})(jQuery);

var UsersTable = function () {
    var userTable;
    return {
        tableInit: function () {
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
            userTable = $('#grid').DataTable({
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
                                '<button class="btn btn-success btn-xs" title="权限设置" onclick="UsersButtons.setPermissions(' + row.Id + ')"><i class="fa fa-edit"></i>权限设置</button>' +
                                 '<button class="btn btn-info btn-xs" title="角色设置" onclick="UsersButtons.setRoles(' + row.Id + ')"><i class="fa fa-edit"></i>角色设置</button>' +
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
        },
        tableRefresh: function () {
            userTable.ajax.reload();
        }
    };
}();

var UsersButtons = function () {
    var createOrEditModal = new app.ModalManager({
        viewUrl: abp.appPath + 'SysManage/Users/CreateOrEditModal',
        scriptUrl: abp.appPath + 'Areas/SysManage/Views/Users/_CreateOrEditModal.js',
        modalClass: 'CreateOrEditUserModal'
    });

    var addButtonInit = function () {
        $("#btnAdd").click(function () {
            createOrEditModal.open({ id: null });
        });
    };
    var editButtonInit = function () {
        $("#btnEdit").click(function () {
            var selectId = $(".checkchild:checked").val();
            if (selectId == undefined) {
                abp.notify.warn('请选择一行数据！');
                return;
            }
            createOrEditModal.open({ id: selectId });
        });
    };
    var deleteButtonInit = function () {
        $("#btnDel").click(function () {
            var selectId = $(".checkchild:checked").val();
            if (selectId == undefined) {
                abp.notify.warn('请选择一行数据！');
                return;
            }
            alert(selectId);
        });
    };
    var detailButtonInit = function () {
        $("#btnDetail").click(function () {
            var selectId = $(".checkchild:checked").val();
            if (selectId == undefined) {
                abp.notify.warn('请选择一行数据！');
                return;
            }
            alert(selectId);
        });
    };
    return {
        buttonsInit: function () {
            addButtonInit();
            editButtonInit();
            deleteButtonInit();
            detailButtonInit();
            $("#btnSearch").click(function () {
                abp.event.trigger('app.usersTableReLoad');
            });
            $("#btnRefresh").click(function () {
                abp.event.trigger('app.usersTableReLoad');
            });
        },
        //设置用户权限
        setPermissions: function (id) {
            var selectId = $(".checkchild:checked").val();
            alert(selectId);
        },
        //设置用户角色
        setRoles: function (id) {
        var selectId = $(".checkchild:checked").val();
        alert(selectId);
    }
    };
}();