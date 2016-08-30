using System;
using BeiDream.MetronicMpa.Models.UI.DataTables;

namespace BeiDream.MetronicMpa.Areas.SysManage.Models
{
    public class UserQueryVm : DataTablesParameters
    {
        public string UserName { get; set; }
        public DateTime StartCreateTime { get; set; }
        public DateTime EndCreateTime { get; set; }
    }
}