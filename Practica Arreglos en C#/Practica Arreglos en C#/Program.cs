using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Arreglos_en_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tam = 0, CP=0, CI=0;
            Console.WriteLine("Ingrese el tamaño del arreglo: ");
            tam = int.Parse(Console.ReadLine());
            int[] numeros = new int[tam];
            Console.WriteLine("Digite los datos del arrelgo");
            Console.WriteLine();
            for (int i = 0; i < tam; i++)
            { //Lectura
                Console.WriteLine("Ingresa numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Datos del arreglo:");
            Console.WriteLine();
            for (int i = 0; i < tam; i++)   
            {
                Console.Write(numeros[i] + ", ");
                if (numeros[i] % 2 == 0) 
                {
                    CP++;
                }
                else CI++;
            }
            Console.WriteLine("Numeros Pares: " + CP);
            Console.WriteLine("Numeros Impares: " + CI);
            Console.ReadKey();
        }
    }
}
