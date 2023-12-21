namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        status = c.String(),
                        MId = c.Int(nullable: false),
                        SId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MId, cascadeDelete: true)
                .ForeignKey("dbo.Supervisors", t => t.SId, cascadeDelete: true)
                .Index(t => t.MId)
                .Index(t => t.SId);
            
            CreateTable(
                "dbo.Supervisors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "SId", "dbo.Supervisors");
            DropForeignKey("dbo.Projects", "MId", "dbo.Members");
            DropIndex("dbo.Projects", new[] { "SId" });
            DropIndex("dbo.Projects", new[] { "MId" });
            DropTable("dbo.Supervisors");
            DropTable("dbo.Projects");
            DropTable("dbo.Members");
        }
    }
}
