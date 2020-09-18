using System;

namespace Algoritmo_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {

        int numero;

        Console.WriteLine("Escribe un numero");

        numero = Convert.ToInt32(Console.ReadLine());

        System.Console.Write(numero);

        for (int i = 1; i <= numero; i++)
        {

            System.Console.Write("," + i);

        }


        }
    }
}
