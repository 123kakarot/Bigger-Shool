namespace BTTuan4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        FollowerID = c.Int(nullable: false),
                        FolloweeID = c.String(nullable: false, maxLength: 128),
                        Follower_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FollowerID, t.FolloweeID })
                .ForeignKey("dbo.AspNetUsers", t => t.Follower_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.FolloweeID)
                .Index(t => t.FolloweeID)
                .Index(t => t.Follower_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Followings", "FolloweeID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "Follower_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Followings", new[] { "Follower_Id" });
            DropIndex("dbo.Followings", new[] { "FolloweeID" });
            DropTable("dbo.Followings");
        }
    }
}
