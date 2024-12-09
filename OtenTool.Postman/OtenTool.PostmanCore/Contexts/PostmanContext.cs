using Microsoft.EntityFrameworkCore;
using OtenTool.PostmanCore.Helpers;
using OtenTool.PostmanCore.Models;

namespace OtenTool.PostmanCore.Contexts
{
    public class PostmanContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(SettingsHelper.GetSettings().ConnectionStrings.DefaultConStr);
                //optionsBuilder.UseNpgsql("User ID=postgres;Password=1234qqqQQ;Host=localhost;Port=5432;Database=dbPostman;Pooling=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tUser>().HasData(
                new tUser { Id = 1, UserName = "admin", CreatedId = 1, IsDeleted = false, Mail = "oten@gmail.com", Password = "admin" }
            );
        }

        public DbSet<tProject> tProjects { get; set; }
        public DbSet<tTreeItem> tTreeItems { get; set; }
        public DbSet<tRequestItem> tRequestItems { get; set; }
        public DbSet<tUser> tUsers { get; set; }
        public DbSet<tProjectUserMap> tProjectUserMaps { get; set; }

    }
}
