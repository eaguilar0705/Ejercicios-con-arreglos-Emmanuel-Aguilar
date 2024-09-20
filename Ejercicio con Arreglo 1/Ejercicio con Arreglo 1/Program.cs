using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_con_Arreglo_1
{
    /*Escriba un programa en C# que simule el tirar dos dados. El programa deberá utilizar rand para tirar el primer dado,
    y después volverá a utilizar rand para tirar el segundo. suma de los valores deberá entonces ser calculada. 
    Nota: en vista de que cada dado puede mostrar un valor entero de 1 a 6, entonces la suma de los dos valores variara desde 2 
    hasta 12, siendo 7 la suma mas frecuente y 2 y 12 las menos frecuentes. En la figura 6.23 se muestran las 36 combinaciones 
    posibles de los dos dados. Su programa deberá tirar 36,000 veces los dos dados. Utilice un arreglo de un subíndice para llevar 
    cuenta del numero de veces que aparece cada suma posible. Imprima los resultados en un formato tabular. 
    También determine si los totales son razonables, es decir existen seis formas de llegar a un 7, por lo que aproximadamente una 
    sexta parte de todas las tiradas deberán ser 7.*/
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] suma = new int[13];
            int totaltiros = 36000;

            for (int i = 0; i < totaltiros; i++)
            {
                int dado1 = rand.Next(1, 7);
                int dado2 = rand.Next(1, 7);
                int sum = dado1 + dado2;
                suma[sum]++;
            }

            Console.WriteLine("Suma\tFrecuencia\tPorcentaje");
            for (int i = 2; i < suma.Length; i++)
            {
                double percentage = (double)suma[i] / totaltiros * 100;
                Console.WriteLine($"{i}\t{suma[i]}\t\t{percentage:F2}%");
            }

            Console.WriteLine($"\nLa suma de 7 aparecio {suma[7]} veces, lo que es aproximadamente {(double)suma[7] / totaltiros * 100:F2}% del total de tiradas.");
          
            Console.ReadKey();
        }
    }
}