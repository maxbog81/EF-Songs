namespace EF_Songs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 120),
                        SecondName = c.String(maxLength: 80),
                        Patronimyc = c.String(maxLength: 100),
                        BirthDay = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 120),
                        Length = c.Double(nullable: false),
                        Description = c.String(),
                        Artist_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artists", t => t.Artist_Id)
                .Index(t => t.Artist_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "Artist_Id", "dbo.Artists");
            DropIndex("dbo.Songs", new[] { "Artist_Id" });
            DropTable("dbo.Songs");
            DropTable("dbo.Artists");
        }
    }
}
