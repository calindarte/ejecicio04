using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        { /*pedir dos numeros por teclado y decir cual es el mayor*/
            Console.SetCursorPosition(20, 4); Console.Write("Digite el primer numero:");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(20, 6); Console.Write("Digite el segundo numero:");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 == Num2)
            {
                Console.SetCursorPosition(20, 11); Console.WriteLine("Los numeros son iguales");
            }
            else
            {
                if (Num1 > Num2)
                {
                    Console.SetCursorPosition(20, 9); Console.WriteLine("El numero mayor es el " + Num1);
                }
                else
                {
                    Console.SetCursorPosition(20, 10); Console.WriteLine("El numero mayor es el " + Num2);
                }
            }
            


            Console.ReadLine();
        }
    }
}