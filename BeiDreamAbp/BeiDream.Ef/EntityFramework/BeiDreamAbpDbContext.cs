using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using BeiDream.Core.Admin.SysManage.Authorization.Roles;
using BeiDream.Core.Admin.SysManage.Authorization.Users;
using BeiDream.Core.Admin.SysManage.MultiTenancy;

namespace BeiDream.Ef.EntityFramework
{
    public class BeiDreamAbpDbContext: AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        //public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        /* Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         * But it may cause problems when working Migrate.exe of EF. ABP works either way.         * 
         */
        public BeiDreamAbpDbContext()
            : base("Default")
        {
            
        }

        /* This constructor is used by ABP to pass connection string defined in AbpZeroTemplateDataModule.PreInitialize.
         * Notice that, actually you will not directly create an instance of AbpZeroTemplateDbContext since ABP automatically handles it.
         */
        public BeiDreamAbpDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection.
         */
        public BeiDreamAbpDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }
    }
}