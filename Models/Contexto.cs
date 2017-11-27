using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure; 

namespace MVC.Model
{
    public class Contexto:DbContext
    {
        public Contexto(): base("MVC2017") { }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

    }
}
