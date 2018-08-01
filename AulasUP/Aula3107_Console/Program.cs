using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_Console
{
    class Program
    {
        public static int Id { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Meu mouse é uma bosta");
            Console.ReadKey();


            Console.WriteLine("Informe um número:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("você digitou" + Id);
            Console.ReadKey();
        }
    }
}
