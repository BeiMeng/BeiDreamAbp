; (function ($) {
    $(function () {
        RolesTable.tableInit();
        abp.event.on('app.rolesTableReLoad', function () {
            RolesTable.tableRefresh();
        });
        RolesButtons.buttonsInit();
    });
})(jQuery);

var RolesTable = function () {
    var roleTable;
    return {
        tableInit: function () {

            roleTable = $('#grid').DataTable({
                "ajax": {
                    "url": "Roles/GetRoleDatas",
                    "data": function (data) {
                        data.RoleName = $("#txtRoleName").val();//此处是添加额外的请求参数
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
                        "targets": 2,
                        render: function (data, type, row, meta) {
                            var show = "";
                            show += row.Name + " &nbsp; ";
                            if (row.IsStatic)
                                show += '<span class="label label-info" style="cursor:pointer" data-toggle="tooltip" title="不能删除系统角色" data-placement="top">系统</span>&nbsp;';
                            if (row.IsDefault) {
                                show += '<span class="label label-default" style="cursor:pointer" data-toggle="tooltip" title="新用户将默认拥有此角色" data-placement="top">默认</span>&nbsp;';
                            }
                            return show;
                        }
                    },
                    {
                        "targets": 4,
                        render: function (data, type, full, meta) {
                            return moment(full.CreationTime).format('L');
                        }
                    },
                    {
                        "targets": -1,
                        "width": "100px",
                        render: function (data, type, row, meta) {
                            var html = '<span>' +
                                '<button class="btn btn-success btn-xs" title="权限设置" onclick="RolesButtons.setPermissions(' + row.Id + ')"><i class="fa fa-edit"></i>权限设置</button>' +
                                 '<button class="btn btn-info btn-xs" title="用户设置" onclick="RolesButtons.setUsers(' + row.Id + ')"><i class="fa fa-edit"></i>用户设置</button>' +
                                '</span>';
                            return html;
                        }
                    }]
            });
            roleTable.on('init.dt', function () {
                $(".pagination li").removeClass("paginate_button");
            });
            roleTable.on('draw.dt', function () {
                $(".pagination li").removeClass("paginate_button");
            });
        },
        tableRefresh: function () {
            roleTable.ajax.reload();
        }
    };
}();

var RolesButtons = function () {
    var createOrEditModal = new app.ModalManager({
        viewUrl: abp.appPath + 'SysManage/Roles/CreateOrEditModal',
        scriptUrl: abp.appPath + 'Areas/SysManage/Views/Roles/_CreateOrEditModal.js',
        modalClass: 'CreateOrEditRoleModal'
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
                abp.event.trigger('app.rolesTableReLoad');
            });
            $("#btnRefresh").click(function () {
                abp.event.trigger('app.rolesTableReLoad');
            });
        },
        //设置角色权限
        setPermissions: function (id) {
            var selectId = $(".checkchild:checked").val();
            alert(selectId);
        },
        //设置角色用户
        setUsers: function (id) {
            var selectId = $(".checkchild:checked").val();
            alert(selectId);
        }
    };
}();