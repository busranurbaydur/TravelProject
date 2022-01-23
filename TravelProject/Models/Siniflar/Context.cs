﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace TravelProject.Models.Siniflar
{
    public class Context:DbContext
    {

        public Context()
        {
            Database.Connection.ConnectionString = @"Data Source=DESKTOP-UAJDS2G;Initial Catalog=TravelProjectDb;Integrated Security=true;";
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; } 
    }
}