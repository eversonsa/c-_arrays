using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array com 5 posição
            int[] idade = new int[5];
            idade[0] = 18;
            idade[1] = 42;
            idade[2] = 65;
            idade[3] = 29;
            idade[4] = 38;

            int acumulador = 0;
            for (int indice = 0; indice <= 4; indice++)
            {
                int id = idade[indice];
                Console.WriteLine($" idade[{indice}]");
                acumulador += id;
            }

            double media = acumulador / 5;
            Console.WriteLine("Media da idade: " + media);
            Console.ReadLine();
        }
    }
}
