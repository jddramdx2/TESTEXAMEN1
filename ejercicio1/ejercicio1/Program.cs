using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        
        public struct Empleado
        {
            public int codigo;
            public string nombre;
            public float salario;
            
        }
        static void Main(string[] args)
        {

            // tipos de datos

            int num1, num2;    //enteras negativos, positivos, no decimales
            short corto = 5660;
float flotante = 3.14f;    // decimal    32bits
            double doble = 15.2d;   //decimales mayores 64bits
            decimal deci = 15.15m; // decimal mas grandes 128 bits
            byte b = 25;
            long larga = 123456789132456;
            ulong ulargo = 56;

            Boolean boleano = false;
            char letra = 'a';
            string cadena = "Hoy es lunes 18 de setiembre";

            // var // dynamic

            var variable = 15.25f;
            dynamic dinamica = 25.3f;
            dinamica = "Nombre empleado";
            dinamica = "true";
            dinamica = "c";

            // arreglos
            int n = 4;
            string[] musico = new string[n];
            musico[0] = "Carlos";
            musico[1] = "Maria";
            musico[2] = "Sofia";
            musico[3] = "Eva";
            
            
            float[] salario = new float[4];

            for (int i = 0; i < salario.Length; i++)

                if (true)
                {

                }

            while (true) { }

            do
            {

            } while (true);

            Console.WriteLine("Digite el salario");
            salario[0] = float.Parse(Console.ReadLine());


            Console.WriteLine("listado de musicos");

            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);

            n = 20;
            musico = new string[n];
            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);

            Console.ReadLine();

            string[] nombres = new string[] { "Ringo", "George", "Paul", "John" };

            
        }
       
    }
}
