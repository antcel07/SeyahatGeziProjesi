using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
//manage nuget packgesde entityframework paketini indirip sisteme ekleriz.


namespace TravelTripProject.Models.Siniflar
{
    public class Context:DbContext
        //miras kalıtım alıyoruz
    {

        public DbSet<Admin>Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
       
    }
}