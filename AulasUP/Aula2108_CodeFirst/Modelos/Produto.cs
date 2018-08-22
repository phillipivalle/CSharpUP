using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos
{
    class Produto
    {
        public int ProdutoID { get; set; }
        public String Nome { get; set; }
        public string Descricao { get; set; }
        public decimal preco { get; set; }
        public decimal imposto { get; set; }

        //relacionamento produto <==> Categoria

        public int CategoriaID { get; set; }
        //Navigation Propeties
        public virtual Categoria _Categoria { get; set; }

        //

    }
}
