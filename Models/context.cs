using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.SqlServer.Server;

namespace mvcP.Models
{
    public class context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-USCVCC5\\SQLEXPRESS; database=BirimDB; TrustServerCertificate=True; integrated security=true;");
        }

        public DbSet<Birim> Birims{ get; set; }
        public  DbSet<personel>personels{ get; set; }    
        public DbSet<Admin> Admins { get; set; }
    }
}
