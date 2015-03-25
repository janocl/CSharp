using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class Any
    {
        public static void queryAny()
        {

            var query = from p in Producto.Show()
                        group p by p.Marca into prodGroup
                        where prodGroup.Any(x => x.IdProveedor == 2)
                        select new 
                        { 
                            Id = prodGroup.First().IdProducto, 
                            prodGroup.First().IdProveedor, 
                            Marca = prodGroup.Key 
                        };



            Console.WriteLine("\nAny : Este operador se utiliza para determinar si existe un elemento \ndentro de una secuencia que cumpla una condición expecífica.\n");
            foreach (var item in query)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadKey();
        }
    }
}
