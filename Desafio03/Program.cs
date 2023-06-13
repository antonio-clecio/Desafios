using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///                        DESAFIO 03: Jogo da Adivinhação                                 /////
            ///   Desenvolva um jogo em que o computador escolha um número aleatório e o jogador       /////
            ///                          deve adivinhar qual é o número.                               /////
            ////////////////////////////////////////////////////////////////////////////////////////////////


            Random numAleatorio = new Random();
            int tentativas = 1;
            int numeroPensado = numAleatorio.Next(0, 20);

            Console.WriteLine(">>>> BEM VINDO AO JOGO DA ADIVINHAÇÃO <<<<\r\n");
            Console.WriteLine("> O jogo consiste em você adivinhar o número pensado pela máquina.\r\n");
            Console.WriteLine("> Vamos começar? Aperte ENTER para iniciar o jogo");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("O número pensado pela máquina está entre 0 e 20.\r\n");

            while (tentativas <= 3)
            {
                Console.WriteLine("Digite seu chute:");
                int chute = int.Parse(Console.ReadLine());

                if (chute == numeroPensado)
                {
                    Console.WriteLine("ACERTOU MIZERAVí!!! O NÚMERO ERA " + numeroPensado);
                    break;
                }
                else
                {
                    Console.WriteLine("ERROU, TENTE NOVAMENTE!\r\n");
                }
                tentativas++;
            }
            Console.WriteLine("\r\nFIM DO JOGO!");

        }
    }
}
