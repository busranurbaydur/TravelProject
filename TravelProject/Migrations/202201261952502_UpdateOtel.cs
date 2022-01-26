namespace TravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOtel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Otels", "Adi", c => c.String());
            DropColumn("dbo.Otels", "Adı");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Otels", "Adı", c => c.String());
            DropColumn("dbo.Otels", "Adi");
        }
    }
}
