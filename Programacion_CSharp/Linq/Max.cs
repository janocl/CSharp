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

            var query = from p in Producto.Show()
                        let max = Producto.Show().Select(x => x.Stock).Max()
                        select new { Marca = p.Marca, Stock = max };

            Console.WriteLine("\nMax : El operador Max devuelve el máximo valor de una colección de registros. \n");
            //Console.WriteLine("El producto con mayor stock:> {0}", query);
            //Console.ReadKey();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }

    }
}
