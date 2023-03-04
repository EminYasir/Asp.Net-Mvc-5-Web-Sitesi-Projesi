namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otelResimlerEklentinew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OtelResimlers", "FileName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OtelResimlers", "FileName");
        }
    }
}
