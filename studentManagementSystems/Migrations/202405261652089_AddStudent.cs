namespace studentManagementSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        StudentEmail = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
