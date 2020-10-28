namespace er_jobboard.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JobboardDBContext>
    {
        public Configuration()
        {

 ///////////////////Developer purpose only//////////////////////////////////////////////////
            //Automatic Migration Enabled
            AutomaticMigrationsEnabled = true;
            //Data loss Enabled
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "JobboardDBContext";
        }

        protected override void Seed(JobboardDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
