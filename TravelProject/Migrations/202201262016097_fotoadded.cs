namespace TravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fotoadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Otels", "FotoUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Otels", "FotoUrl");
        }
    }
}
