using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_08_POO.Modelos
{
    class Barco : IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando o barco...");
        }

        public void Frenar()
        {
            throw new NotImplementedException();
        }
    }
}
