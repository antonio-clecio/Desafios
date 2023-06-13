using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////
            ////                        DESAFIO 02: Contador de palavras                               /////
            ////   Crie um programa que conte o número de palavras em um texto informado pelo usuário. /////
            ////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("///////// Bem Vindo ao Contador de Palavras/ Texto /////////");
            Console.WriteLine("Iremos fazer a contagem dos caracteres inseridos");
            Console.WriteLine("Aperte ENTER para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Digite uma palavra ou texto:");
            string cont1 = Console.ReadLine();
            string cont2 = cont1.Replace(" ", "");
            Console.WriteLine("Caracteres com espaço: " + cont1.Length);
            Console.WriteLine("Caracteres sem espaço: " + cont2.Length);

            Console.WriteLine("Digite uma frase ou texto:");
            string palavraTexto = Console.ReadLine();
            string[] count = palavraTexto.Split(' ');

            Console.WriteLine("Foram detectados " + count.Length + " palavras");

        }
    }
}
