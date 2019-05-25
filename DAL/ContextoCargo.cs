using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Registro.DAL
{
    class ContextoCargo : DbContext
    {
        public DbSet<Entidades.Cargo> cargos { get; set; }

        public ContextoCargo() : base("ConStr")
        { }
    }
}

