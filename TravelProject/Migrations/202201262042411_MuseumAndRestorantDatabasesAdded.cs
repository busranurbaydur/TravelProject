namespace TravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MuseumAndRestorantDatabasesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Muzes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Adresi = c.String(),
                        FotoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Restorans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Adresi = c.String(),
                        YemekCesidi = c.String(),
                        FotoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restorans");
            DropTable("dbo.Muzes");
        }
    }
}
