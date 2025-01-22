namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstUp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HealthGoals",
                c => new
                    {
                        GoalId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        MatricType = c.String(),
                        TargetValue = c.Single(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Progress = c.Single(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GoalId);
            
            CreateTable(
                "dbo.Matrics",
                c => new
                    {
                        MatricsId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        Name = c.String(),
                        Weight = c.Single(nullable: false),
                        BloodPressure = c.Int(nullable: false),
                        BloodTemperature = c.Int(nullable: false),
                        BloodSugarLevel = c.Single(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MatricsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matrics");
            DropTable("dbo.HealthGoals");
        }
    }
}
