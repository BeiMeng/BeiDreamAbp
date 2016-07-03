using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using BeiDream.Ef.Migrations.Seed.Host;
using BeiDream.Ef.Migrations.Seed.Tenants;
using EntityFramework.DynamicFilters;

namespace BeiDream.Ef.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<EntityFramework.BeiDreamAbpDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BeiDreamAbp";
        }

        protected override void Seed(EntityFramework.BeiDreamAbpDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantBuilder(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases...
            }

            context.SaveChanges();
        }
    }
}