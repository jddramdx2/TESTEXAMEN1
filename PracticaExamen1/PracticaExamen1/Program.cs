using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ClaseMenu1.Desplegar();


            ClaseProfesor1 Carlos = new ClaseProfesor1("1", " Carlos", 150); //instanciando      
            ClaseProfesor1 Sofia = new ClaseProfesor1("2", " Sofia", 300);
            ClaseProfesor1 Diana = new ClaseProfesor1("3", " Diana", 500);
            ClaseProfesor1 Luis = new ClaseProfesor1("4");
            ClaseProfesor1 Mateo = new ClaseProfesor1();

            Console.WriteLine(Carlos.nombre, ClaseProfesor1.precio );
            Console.WriteLine(Sofia.nombre, ClaseProfesor1.precio);
            Console.Read();
        }
    }
}
