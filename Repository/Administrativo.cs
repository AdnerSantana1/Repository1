using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Repository
{
    internal class Administrativo : Empleado
    {
        public string Departamento { get; set; }
    }
}
