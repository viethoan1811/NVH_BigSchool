namespace NVH_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Crourses", newName: "Courses");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Courses", newName: "Crourses");
        }
    }
}
