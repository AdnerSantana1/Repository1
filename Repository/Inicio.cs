using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class Inicio
    {
        public static void Main(string[] args)
        {
        
            Empleado empleado = new Empleado
            {
                Nombre = "Juan",
                Edad = 30,
                Salario = 50000
            };

            Estudiante estudiante = new Estudiante
            {
                Nombre = "María",
                Edad = 20,
                Curso = "Desarrollo de Software"
            };

            ExAlumno exAlumno = new ExAlumno
            {
                Nombre = "Carlos",
                Edad = 35,
                CarreraAnterior = "Seguridad Informatica"
            };

            Docente docente = new Docente
            {
                Nombre = "Luis",
                Edad = 40,
                Salario = 60000,
                Materia = "Matemáticas"
            };


            Console.WriteLine("Información del Empleado:");
            empleado.MostrarInformacion();

            Console.WriteLine("\nInformación del Estudiante:");
            estudiante.MostrarInformacion();

            Console.WriteLine("\nInformación del Ex Alumno:");
            exAlumno.MostrarInformacion();

            Console.WriteLine("\nInformación del Docente:");
            docente.MostrarInformacion();



        }
    }
}
