using BeiDream.Ef.EntityFramework;

namespace BeiDream.Ef.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly BeiDreamAbpDbContext _context;

        public InitialHostDbBuilder(BeiDreamAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            //new DefaultEditionCreator(_context).Create();
            //new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            //new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
