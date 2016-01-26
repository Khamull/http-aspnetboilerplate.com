using System.Data.Entity.Migrations;
using sample.Migrations.SeedData;

namespace sample.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<sample.EntityFramework.sampleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "sample";
        }

        protected override void Seed(sample.EntityFramework.sampleDbContext context)
        {
            new InitialDataBuilder(context).Build();
        }
    }
}
