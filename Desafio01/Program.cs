using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //// DESAFIO 01: Escreva um programa que receba como entrada uma lista de números e calcule a média deles. /////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int N;
            double media, soma = 0;

            Console.WriteLine("Digite o tamanho da lista de números:");
            N = int.Parse(Console.ReadLine());
            int[] vet;

            vet = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um número:");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                soma += vet[i];
            }

            media = soma / N;

            Console.WriteLine("A média dos números é " + media);

            ///////////// REFATORANDO O CÓDIGO /////////////

            //string msg = null;
            //double media = 0;

            //List<double> vet = new List<double>();

            //do
            //{
            //    Console.WriteLine("Digite um número:");
            //    msg = Console.ReadLine();

            //    if (msg != "")
            //    {
            //        vet.Add(double.Parse(msg));
            //    }
            //} while (msg != "");

            //media = vet.Sum() / vet.Count();
            //Console.WriteLine("A média dos números é " + media);
        }
    }
}
