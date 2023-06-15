using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////                        DESAFIO 04: Verificador de números primos                               /////
            ////        Escreva um programa que verifique se um número informado pelo usuário é primo.         /////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////



            int numero, valor = 1, divisores = 0;

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0) {

                while (valor <= numero) {
                    
                    if (numero % valor == 0) {
                        divisores++;
                    }
                    valor++;
                }

                if (divisores == 2) {
                    Console.WriteLine($"{numero} é primo");
                } else {
                    Console.WriteLine($"{numero} não é primo");
                }

            } else {
                Console.WriteLine("Valor negativo ou igual a zero!");
            }













             ////////////////////////////////////////////
            ///////  Outra forma de verificação  ///////
           ////////////////////////////////////////////


            //Console.WriteLine("Digite um número: ");
            //int numero = int.Parse(Console.ReadLine());

            //if (EhPrimo(numero))
            //{
            //    Console.WriteLine($"{numero} é primo.");
            //}
            //else 
            //{
            //    Console.WriteLine($"{numero} não é primo.");
            //}
        }

        //static bool EhPrimo(int numero)
        //{
        //    if (numero < 2)
        //    {
        //        return false;
        //    }

        //    for (int i = 2; i < Math.Sqrt(numero); i++)
        //    {
        //        if (numero % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
    }
}
