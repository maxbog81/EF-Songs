namespace EF_Songs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateArtist : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Artists", "SecondName", "Surname");
            //AddColumn("dbo.Artists", "SurName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Artists", "Patronimyc", c => c.String(maxLength: 255));
            AlterColumn("dbo.Artists", "Surname", c => c.String(maxLength: 255));
            //DropColumn("dbo.Artists", "SecondName");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Artists", "SecondName", c => c.String(maxLength: 80));
            RenameColumn("dbo.Artists", "Surname", "SecondName");
            AlterColumn("dbo.Artists", "Patronimyc", c => c.String(maxLength: 100));
            AlterColumn("dbo.Artists", "SecondName", c => c.String(maxLength: 80));
            //DropColumn("dbo.Artists", "SurName");
        }
    }
}
