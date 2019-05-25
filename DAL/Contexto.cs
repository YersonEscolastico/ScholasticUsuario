using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Registro.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Entidades.Usuario> usuarios { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
