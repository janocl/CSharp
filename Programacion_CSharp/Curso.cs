using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp
{
    public class Curso { }
    public class Notas
    {
        public double Nota { get; set; }

        private List<Notas> listanotas;
        public List<Notas> ListaNotas
        {
            get { return listanotas; }
            set { listanotas = value; }
        }
        

        public static List<Notas> Show()
        {
            List<Notas> lista = new List<Notas>() 
            { 
                new Notas { Nota = 5.5}, 
                new Notas { Nota = 6.3}, 
                new Notas { Nota = 6.7}
            };
            return lista;
        }
    }

    public class Asignaturas
    {
        public string Asignatura { get; set; }
        public IEnumerable<Notas> listaNotas { get; set; }

    }

    public class Alumno
    {
        public string Nombre { get; set; }
        public IEnumerable<Asignaturas> listaAsignaturas { get; set; }
    
    }
    

}
