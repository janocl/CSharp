using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    class OrderBy
    {
        public static void queryOrderBy()
        {
            var query = from p in Producto.Show()
                        where p.IdProducto > 0
                        orderby p.Marca ascending
                        select p;

            Console.WriteLine("\nMarcas Ordenadas Alfabeticamente.");
            foreach (var item in query)
            {
                Console.WriteLine("Marca > {0}", item.Marca);
            }
            Console.ReadKey();
        }

    }
}
