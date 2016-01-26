using sample.EntityFramework;
using EntityFramework.DynamicFilters;

namespace sample.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly sampleDbContext _context;

        public InitialDataBuilder(sampleDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
