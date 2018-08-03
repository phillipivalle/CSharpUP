using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_08_POO.Modelos
{
    interface IMotorizado
    {
        int Velocidade { get; set; }
        void Acelerar();
        void Frenar();
    }
}
