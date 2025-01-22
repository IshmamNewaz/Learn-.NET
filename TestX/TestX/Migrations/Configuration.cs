namespace TestX.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestX.EF.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestX.EF.Context context)
        {
            Random rand = new Random();
            for (int i = 1; i <= 100; i++)
            {
                context.Courses.Add(new EF.Course()
                {

                    Name = "Sub" + i,
                    Description = "Lorem Ipsum" + i,
                    Author = "XT" + i
                });
            }
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
