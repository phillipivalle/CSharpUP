using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_08_POO.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando a moto...");
            Velocidade += 30;
        }

        public void Frenar()
        {
            Console.WriteLine("ABS em uso...");
            Velocidade += 10;
        }
    }
}
