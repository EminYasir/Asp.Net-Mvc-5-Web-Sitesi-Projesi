namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otelResimlerEklenti : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OtelResimlers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FilePath = c.String(),
                        Otelid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otelid, cascadeDelete: true)
                .Index(t => t.Otelid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OtelResimlers", "Otelid", "dbo.Otels");
            DropIndex("dbo.OtelResimlers", new[] { "Otelid" });
            DropTable("dbo.OtelResimlers");
        }
    }
}
