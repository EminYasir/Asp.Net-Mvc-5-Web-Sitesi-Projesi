namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Muzes", "ZiyaretSayisi", c => c.Int(nullable: false));
            DropColumn("dbo.Muzes", "BegeniOrani");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Muzes", "BegeniOrani", c => c.Int(nullable: false));
            DropColumn("dbo.Muzes", "ZiyaretSayisi");
        }
    }
}
