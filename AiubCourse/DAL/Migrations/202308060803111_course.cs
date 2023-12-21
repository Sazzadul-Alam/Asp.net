namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class course : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StudentCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SId = c.Int(nullable: false),
                        CId = c.Int(nullable: false),
                        status = c.String(),
                        SeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CId, cascadeDelete: true)
                .ForeignKey("dbo.Semesters", t => t.SeId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.SId, cascadeDelete: true)
                .Index(t => t.SId)
                .Index(t => t.CId)
                .Index(t => t.SeId);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        SId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.SId, cascadeDelete: true)
                .Index(t => t.SId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "SId", "dbo.Students");
            DropForeignKey("dbo.Registrations", "SId", "dbo.Students");
            DropForeignKey("dbo.Registrations", "SeId", "dbo.Semesters");
            DropForeignKey("dbo.Registrations", "CId", "dbo.Courses");
            DropIndex("dbo.Tokens", new[] { "SId" });
            DropIndex("dbo.Registrations", new[] { "SeId" });
            DropIndex("dbo.Registrations", new[] { "CId" });
            DropIndex("dbo.Registrations", new[] { "SId" });
            DropTable("dbo.Tokens");
            DropTable("dbo.Students");
            DropTable("dbo.Semesters");
            DropTable("dbo.Registrations");
            DropTable("dbo.Courses");
        }
    }
}
