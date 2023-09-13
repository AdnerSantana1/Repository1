using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Repository
{
    internal class Docente : Empleado
    {
        public string Materia { get; set; }

        public void MostrarInformacion()
        {
            base.MostrarInformacion(); 
            Console.WriteLine($"Materia: {Materia}");
        }


    }
}
