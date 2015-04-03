using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class OrderByDescending
    {
        public static void queryOrderByDescending()
        {

            var query = Producto.Show()
                        .GroupBy(s => s.Marca)
                            .Select(s => new
                            {
                                Stock = s.Max(x => x.Stock),
                                Id = s.First().IdProducto,
                                Marca = s.Key
                            }).OrderByDescending(x => x.Stock);

            Console.WriteLine("\nOrderByDescending : El operador nos va a permitir ordenar un conjunto de datos de forma descendiente.\n");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }

    }
}
