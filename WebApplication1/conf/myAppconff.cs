using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.conf
{
    public class myAppconff : DbContext
    {
        public myAppconff(DbContextOptions options) : base(options)

        {

        }
        public DbSet<Datas> Datas { get; set; }

    }
}
