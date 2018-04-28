namespace MVCAud4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnotherMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Address", c => c.String());
            AlterColumn("dbo.Clients", "MemberCard", c => c.String());
            AlterColumn("dbo.Clients", "Telephone", c => c.String());
            AlterColumn("dbo.Movies", "DownloadURL", c => c.String());
            AlterColumn("dbo.Movies", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ImageURL", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "DownloadURL", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Telephone", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "MemberCard", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Address", c => c.String(nullable: false));
        }
    }
}
