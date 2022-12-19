    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

namespace Database.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Database.Services.Data.AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Database.Services.Data.AppDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
