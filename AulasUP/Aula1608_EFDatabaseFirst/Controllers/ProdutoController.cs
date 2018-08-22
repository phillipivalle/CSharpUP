using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608_EFDatabaseFirst.Controllers
{
    class ProdutoController
    {
        void cadastrar(Product p)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Product.Add(p);
            contexto.SaveChanges();
        }

        List<Product> EstoqueDeProdutos() 
        {
          AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
          return  contexto.Product.ToList();
        }

        Product Buscar(int id)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.Find(id);
        }

        void Excluir(int id)
        {
            Product pExcluir = Buscar(id);
            if(pExcluir != null)
            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Product.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }

        void Editar(int id, Product Alteracao)
        {
            Product antigo = Buscar(id);
            if(antigo != null)
            {
                antigo.Name = Alteracao.Name;
                antigo.Class = Alteracao.Class;
                antigo.Class = Alteracao.Class;

                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Entry(antigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        List<Product> PesquisaPorCor(String cor)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            var lista = from p in contexto.Product
                        where p.Color == cor
                        select p;

             return lista.ToList();
        }

    }
}
