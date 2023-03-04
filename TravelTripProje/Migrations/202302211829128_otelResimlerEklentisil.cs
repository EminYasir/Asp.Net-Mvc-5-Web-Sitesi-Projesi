namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otelResimlerEklentisil : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OtelResimlers", "Otelid", "dbo.Otels");
            DropIndex("dbo.OtelResimlers", new[] { "Otelid" });
            DropTable("dbo.OtelResimlers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OtelResimlers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        FilePath = c.String(),
                        Otelid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.OtelResimlers", "Otelid");
            AddForeignKey("dbo.OtelResimlers", "Otelid", "dbo.Otels", "Id", cascadeDelete: true);
        }
    }
}
