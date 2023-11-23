using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebTeste007.Models;

namespace WebTeste007.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WebTeste007.Models.Cadclientes> Cadclientes { get; set; } = default!;

        public DbSet<WebTeste007.Models.CadMaquinas> CadMaquinas { get; set; } = default!;

        public DbSet<WebTeste007.Models.Inventario> Inventario { get; set; } = default!;
    }
}
