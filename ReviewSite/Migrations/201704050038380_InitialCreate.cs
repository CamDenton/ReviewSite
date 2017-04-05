namespace ReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CatID = c.Int(nullable: false, identity: true),
                        CatName = c.String(),
                        ReviewID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CatID)
                .ForeignKey("dbo.Reviews", t => t.ReviewID, cascadeDelete: true)
                .Index(t => t.ReviewID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        ReviewTitle = c.String(),
                        ReviewContent = c.String(),
                        PublishedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "ReviewID", "dbo.Reviews");
            DropIndex("dbo.Categories", new[] { "ReviewID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Categories");
        }
    }
}
