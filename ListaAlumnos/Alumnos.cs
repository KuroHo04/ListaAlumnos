using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumnos
{
    class Alumno
    {
        public string matricula { get; set; }
        public string nombre { get; set; }
        public string carrera { get; set; }

        public override string ToString()
        {
            return $"Matricula: {matricula}, Nombre: {nombre}, Carrera: {carrera}";
        }
    }
}
