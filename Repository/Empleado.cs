using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Repository 
{
    internal class Empleado : MiembroDeLaComunidad
    {

        public decimal Salario { get; set; }

        public void MostrarInformacion()
        {
            base.MostrarInformacion(); 
            Console.WriteLine($"Salario: {Salario}");
        }


    }

}
