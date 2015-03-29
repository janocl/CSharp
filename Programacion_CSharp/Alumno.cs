using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp
{

    public class Notas
    {
        public static List<double> Notas()
        {
            return new List<double> { 5.5, 6.0, 5.2, 6.6, 6.9};
        }
    }

    public class Asignatura
    {
        public string Asignatura { get; set; }
        public List<Notas> listaNotas { get; set; }

    
    }
    public class Alumno
    {
        public string Nombre { get; set; }
        public List<Asignatura> listaAsignaturas { get; set; }
    
    }
    

}
