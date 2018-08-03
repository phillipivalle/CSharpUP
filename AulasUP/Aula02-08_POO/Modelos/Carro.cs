using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_08_POO.Modelos
{
    class Carro : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Diminuindo a velocidade...");
            Velocidade -= 3;
        }
    }
}
