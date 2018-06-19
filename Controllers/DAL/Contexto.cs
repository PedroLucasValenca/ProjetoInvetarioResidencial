using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Local> Locais { get; set; }

        public DbSet<TipoUso> TiposUsos { get; set; }
    }
}
