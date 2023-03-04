namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otelResimlerEkle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Otels", "imageDetails1", c => c.String());
            AddColumn("dbo.Otels", "imageDetails2", c => c.String());
            AddColumn("dbo.Otels", "imageDetails3", c => c.String());
            AddColumn("dbo.Otels", "imageDetails4", c => c.String());
            AddColumn("dbo.Otels", "imageDetails5", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Otels", "imageDetails5");
            DropColumn("dbo.Otels", "imageDetails4");
            DropColumn("dbo.Otels", "imageDetails3");
            DropColumn("dbo.Otels", "imageDetails2");
            DropColumn("dbo.Otels", "imageDetails1");
        }
    }
}
