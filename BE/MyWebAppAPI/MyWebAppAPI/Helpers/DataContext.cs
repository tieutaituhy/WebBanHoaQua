using Microsoft.EntityFrameworkCore;
using MyWebAppAPI.Entities;

namespace MyWebAppAPI.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Catalog> catalogs { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Users> users { get; set; }
        //protected override void OnModelCreating(ModelBuilder m)
        //{
        //    m.Entity<GioHoaQua>(e =>
        //    {
        //        e.ToTable("AppGioHoaQua");
        //    });
        //    m.Entity<HoaQuaNhapKhau>(e =>
        //    {
        //        e.ToTable("AppHoaQuaNhapKhau");
        //    });
        //    m.Entity<HoaQuaTuoi>(e =>
        //    {
        //        e.ToTable("AppHoaQuaTuoi");
        //    });
        //    m.Entity<TraiCaySay>(e =>
        //    {
        //        e.ToTable("AppTraiCaySay");
        //    });
        //}
    }
}
