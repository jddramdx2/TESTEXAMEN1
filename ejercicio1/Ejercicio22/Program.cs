using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //acumuladores y contadores 
            int contador = 57;
            float total = 0; int salario = 0;
            string nombre = "Tamara";

            Console.WriteLine("Mi edad es de" + contador); //concatenacion
            Console.WriteLine("Mi edad es de {0} y mi nombre es {1}", contador, nombre); //referencia
            Console.WriteLine($"Mi edad es {contador} y mi nombre es {nombre}");  //interpolacion

            //contadores
            contador = contador + 1;
            contador++;
            ++contador;
            //contador a la inversa
            contador--;
            --contador;
            // Acumuladores 
            //sal1 100
            //sal2 200
            //sal3 300

            total = total + salario;

            //   0      100
            //   100  +  200
            //    300  + 300;= 600
            // Acumuladores 2
            total = total + salario;
            total += salario;
            total += 5;
            total *= 2;
            total /= 6; // total = total / 6

            //sistema para calcular el promedio de n estudiantes 
            //calcular cuentos estudiantes tienen una nota superiores al promedio 

            String[] Estudiantes = new string[4];
            float[] notas = new float[4];
            float promedio = 0;
            total = 0;
            for (int i = 0; i < Estudiantes.Length; i++) 
            
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                Estudiantes[i] = Console.ReadLine();
                Console.Write("Ingrese el la nota: ");

                //convertir de string a flotante
                notas[i] = float.Parse(Console.ReadLine());
                //acumulador
               total = total + notas[i];//sumas las notas
                Console.Clear();
            }
            total/=Estudiantes.Length;// dividir las notas entre la cantidad de estudiantes 
            Console.WriteLine($"Sumatoria de notas es: {total}");

            //calcula la cantidad de estudiantes con mayor nota del promedio
            contador = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i]>total)  // i = 0
                {
                    Console.WriteLine("Estudiante:" + Estudiantes[i] + "Nota" + notas[i]);
                    contador++;//contador = contador + 1
                }
            }
            Console.WriteLine($"La cantidad de estudiante con nota mayor al promedio es {contador}");



            Console.ReadLine();  
        }
    }
}
