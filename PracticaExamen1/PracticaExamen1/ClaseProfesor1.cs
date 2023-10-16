using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    internal class ClaseProfesor1
    {
        public ClaseProfesor1(string Cedula, string Nombre, float Salario)
        {
            this.cedula = Cedula;
            this.nombre = Nombre;
            this.salario = Salario;
        }

        // atributos
        public string cedula { get; set; }
        public string nombre { get; set; }
        public float salario { get; set; }
       public  static float precio = 300f;


        //constructor sirve para definir cuales van a ser los valores de la clase
        public ClaseProfesor1(string cedula)
        {
            this.cedula = cedula;
        }
        public ClaseProfesor1()
        { }

        public void Agregar()
        {

        }
        public void Borrar()
        {

        }
        public void Consultar()
        {

        }
       
    }
}
