using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Repository
{
    internal abstract class Administrador : Docente
    {
        public string Responsabilidades { get; set; }
    }
}
