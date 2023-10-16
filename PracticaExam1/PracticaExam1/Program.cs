using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExam1
{

   // static string[] NumeroPlaca = new string[15];
    //static string[] TipoVehiculo = new string[15];
    //static double[] tollAmounts = new double[15];
    //static int currentIndex = 0;
    internal class Program
    {
        static void Main(string[] args)
        {
            String respuesta;
            Console.WriteLine("Cuando es 5 x 5? ");
            respuesta = Console.ReadLine();
            
            if (respuesta.Equals("ESTUDIAR"))
            {
                Console.WriteLine("Eso es correcto!");

            }
            else
            {
                Console.WriteLine("Eso es incorrecto!");
                Console.ReadKey();
            }

        }
    }
}
