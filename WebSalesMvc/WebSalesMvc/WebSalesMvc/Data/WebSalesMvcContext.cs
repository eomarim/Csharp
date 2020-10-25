using Microsoft.EntityFrameworkCore;
using WebSalesMvc.Models;

namespace WebSalesMvc.Data
{
    public class WebSalesMvcContext : DbContext
    {
        public WebSalesMvcContext (DbContextOptions<WebSalesMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }

        public DbSet<Vendedor> Vendedor { get; set; }

        public DbSet<Venda> Venda { get; set; }
    }
}
