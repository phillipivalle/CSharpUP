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
        public static int numero1 { get; set; }
        public static int numero2 { get; set; }
        public static int opcao { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("CRF\n");
            Console.ReadKey();


            Console.WriteLine("\n\nInforme o primeiro número: ");
            Id = int.Parse(Console.ReadLine());
            ImprimirNumeroDigitado(Id);
            Console.ReadKey();


            // novo exercício
            //Pedindo números do usuário;
            Console.WriteLine("\nFavor, informar o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nFavor, informar o segundo número:");
            numero2 = int.Parse(Console.ReadLine());
            //Escolhendo qual operação;
            Console.WriteLine("Qual operação deseja fazer?\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n0 - Sair");
            opcao = int.Parse(Console.ReadLine());
            //Efetuando operação escolhida;

            //Laço
            while (opcao != 0)
            {
                if (opcao == 1)
                {
                    soma(numero1, numero2);
                }
                else
                {
                    if (opcao == 2)
                    {
                        sub(numero1, numero2);
                    }
                    else
                    {
                        if (opcao == 3)
                        {
                            multipicacao(numero1, numero2);
                        }
                        else
                        {
                            if (opcao == 4)
                            {
                                divisao(numero1, numero2);
                            }
                        }
                    }
                }
                Console.WriteLine("Qual operação deseja fazer?\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n0 - Sair");
                opcao = int.Parse(Console.ReadLine());
            }

            // Lista de funções( Imprimir, somar, subtrair, multiplicar, dividir);
        }
        static void ImprimirNumeroDigitado(int num)
        {
            Console.WriteLine("você digitou: " + num);
        }

        static void soma(int num1, int num2)
        {
            Console.WriteLine("A soma dos números é: " + (num1 + num2));
            Console.ReadKey();
        }
        static void sub(int num1, int num2)
        {
            Console.WriteLine("A subtração dos números é: " + (num1 - num2));
            Console.ReadKey();
        }
        static void multipicacao(int num1, int num2)
        {
            Console.WriteLine("A multiplicação dos números é: " + (num1 * num2));
            Console.ReadKey();
        }

        static void divisao(int num1, int num2)
        {
            Console.WriteLine("A divisão dos números é: " + (num1 / num2));
            Console.ReadKey();
        }
    }
}