using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables globales y locales 
            num1 = 25.3f;
            num2 = 14.3f;
            suma();
            resta();
            Console.Read();

        }
        static void suma( float v1, float v2)
        { 
        
        float resultado; //variable local
        resultado = 0;
            num1 = 3; num2 = 9;
            Console.Writeline($"Suma: {num1 +num2}");
        }


        static void resta() {
            num1 = 1; num2 = 2;
            Console.WriteLine($"Resta: {(num1 - num2)})
        }

    }

}
