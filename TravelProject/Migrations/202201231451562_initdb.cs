namespace TravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdresBlogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Aciklama = c.String(),
                        AcikAdres = c.String(),
                        Email = c.String(),
                        Telefon = c.String(),
                        Konum = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        Aciklama = c.String(),
                        FotoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yorumlars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Email = c.String(),
                        Yorum = c.String(),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Hakkimizdas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FotoUrl = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Iletisims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Email = c.String(),
                        Konu = c.String(),
                        Mesaj = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorumlars", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Yorumlars", new[] { "BlogId" });
            DropTable("dbo.Iletisims");
            DropTable("dbo.Hakkimizdas");
            DropTable("dbo.Yorumlars");
            DropTable("dbo.Blogs");
            DropTable("dbo.AdresBlogs");
            DropTable("dbo.Admins");
        }
    }
}
