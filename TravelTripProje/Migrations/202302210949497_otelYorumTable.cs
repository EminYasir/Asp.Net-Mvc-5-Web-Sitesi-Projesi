namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otelYorumTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OtelYorumlars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Kullaniciadi = c.String(),
                        Mail = c.String(),
                        Yorum = c.String(),
                        Otelid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Otels", t => t.Otelid, cascadeDelete: true)
                .Index(t => t.Otelid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OtelYorumlars", "Otelid", "dbo.Otels");
            DropIndex("dbo.OtelYorumlars", new[] { "Otelid" });
            DropTable("dbo.OtelYorumlars");
        }
    }
}
