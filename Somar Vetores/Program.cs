using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somar_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosEntrada = new int[5];
            int contador = 0;

            while (contador < numerosEntrada.Length)
            {
                Console.WriteLine("Digite os números a serem somados:");
                numerosEntrada[contador] = int.Parse(Console.ReadLine());
                contador++;
                
                Console.Clear();
            }

            int contador2 = 0;
            int soma = 0;
            while (contador2 < numerosEntrada.Length) 
            {
                soma += numerosEntrada[contador2];
                contador2++;

                Console.Clear();
                Console.WriteLine("A soma é: " + soma);               
            }

            int contador3 = 0;  
            while(contador3 < numerosEntrada.Length) 
            {
                Console.WriteLine("Os números somados são: " + numerosEntrada[contador3]);
                contador3++;
            }
            Console.ReadKey();
        }
    }
}
