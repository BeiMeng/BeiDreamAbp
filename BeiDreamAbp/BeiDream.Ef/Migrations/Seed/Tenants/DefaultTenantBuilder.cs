using System.Linq;
using BeiDream.Core.Admin.SysManage.MultiTenancy;
using BeiDream.Ef.EntityFramework;

namespace BeiDream.Ef.Migrations.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly BeiDreamAbpDbContext _context;

        public DefaultTenantBuilder(BeiDreamAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new Tenant(Tenant.DefaultTenantName,Tenant.DefaultTenantName);

                //var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                //if (defaultEdition != null)
                //{
                //    defaultTenant.EditionId = defaultEdition.Id;
                //}

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}
