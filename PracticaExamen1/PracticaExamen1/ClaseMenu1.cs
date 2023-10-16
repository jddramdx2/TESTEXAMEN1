using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClaseMenu1
    {
        //attibuto
        static int opcion = 0;  //global a la clase

        //metodo
        static public void Desplegar()  //global a la clase
        {
            do
            {
                Console.WriteLine("1- Inicializar Vectores");
                Console.WriteLine("2- Incluir Estudiantes");
                Console.WriteLine("3- Consultar");
                Console.WriteLine("4- Salir");
                //opcion = int.Parse(Console.ReadLine()); //20
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:ClaseEstudiante1.Inicializar(); break;
                    case 2:ClaseEstudiante1.Agregar break;
                    case 3: ClaseEstudiante1.Agregar break;
                    case 4: ClaseEstudiante1.Agregar break;
                    default:
                        break;
                }
            } while (opcion!=3);


        }

    }
}
