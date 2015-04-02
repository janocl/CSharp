using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class Max
    {
        public static void queryMax()
        {

            var query = Producto.Show()
                        .GroupBy(s=>s.Marca)
                            .Select(s => new { Marca = s.Key,
                                                Stock = s.Max(x=>x.Stock)}).ToList();

            Console.WriteLine("\nMax : El operador Max devuelve el máximo valor de una colección de registros. \n");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }

    }
}
