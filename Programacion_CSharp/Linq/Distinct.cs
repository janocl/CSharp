using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class Distinct
    {


        public static void queryDistinct()
        {
            var query = (from p in Producto.Show()
                        group p by p.Tipo into g1
                        select new
                        {
                            g1.First().IdProducto,
                            g1.First().Tipo
                        }).Distinct();
                        



            Console.WriteLine("\nDistinct : Este operador sirve para eliminar elementos duplicados de una secuencia. \n");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        
        }
        
        
    }
}
