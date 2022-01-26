namespace TravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Otels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adı = c.String(),
                        Adresi = c.String(),
                        Ozellikleri = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Otels");
        }
    }
}
