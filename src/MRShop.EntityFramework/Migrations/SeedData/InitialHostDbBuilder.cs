using MRShop.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MRShop.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MRShopDbContext _context;

        public InitialHostDbBuilder(MRShopDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
