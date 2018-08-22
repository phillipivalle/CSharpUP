using Aula2108_CodeFirst.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Controllers.DAL
{
    //herdar da dbContext
    class Contexto : DbContext
    {

        public Contexto() : base("NomeStringConexao")
        {
              
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Proutos { get; set; }


    }
}
