using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608_EFDatabaseFirst.Controllers
{
    class PersonController
    {

        void inserir(Person p)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

            contexto.Person.Add(p);
            contexto.SaveChanges();
        }
        List<Person> ListarTodosPerson()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.ToList();
        }

        Person BuscarPorID(int ID)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

            return contexto.Person.Find(ID);
        }

        void Excluir (int ID)
        {

            Person pExcluir = BuscarPorID(ID);

            if(pExcluir != null)
            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Person.Remove(pExcluir);
                contexto.SaveChanges();
            }

        }
    }
}
