using Aula02_08_POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_08_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            car.Modelo = "Ferrari";
            car.Acelerar();
            ExecutarTesteMotor(car);
            
        

            Moto moto = new Moto();
            moto.Modelo = "Kawasaki";

            ExecutarTesteMotor(moto);
            


        }

        static void ExecutarTesteMotor(IMotorizado vec)
        {
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            for (int i = 0; i < 3; i++)
            {
                vec.Acelerar();
            }
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            for (int i = 0; i < 2; i++)
            {
                vec.Frenar();
            }
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            Console.ReadKey();
        }


    }
}
