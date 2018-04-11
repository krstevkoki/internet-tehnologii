namespace Aud3MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        MemberCard = c.String(nullable: false),
                        Telephone = c.String(nullable: false),
                        IsSubscribed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DownloadURL = c.String(nullable: false),
                        ImageURL = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieClients",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Client_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieClients", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.MovieClients", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MovieClients", new[] { "Client_Id" });
            DropIndex("dbo.MovieClients", new[] { "Movie_Id" });
            DropTable("dbo.MovieClients");
            DropTable("dbo.Movies");
            DropTable("dbo.Clients");
        }
    }
}
