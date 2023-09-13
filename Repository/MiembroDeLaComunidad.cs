using System;

namespace Repository
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
        }

    }

}