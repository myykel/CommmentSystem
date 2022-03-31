namespace CommentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Frist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        CommentText = c.String(),
                        Username = c.String(),
                        CommentDate = c.DateTime(nullable: false),
                        ParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comments");
        }
    }
}
