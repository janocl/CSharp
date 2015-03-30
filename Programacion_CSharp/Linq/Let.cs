using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class Let
    {

        public static void queryLet()
        {

            var query = from p in Producto.Show()
                        let a = p.Stock * 2
                        where a > 300
                        select new {p.IdProducto, Stock = a};
                        

            Console.WriteLine("\nLet : Este operador resulta util para almacenar el resultado de una\n subexpresión para utilizarlo en cláusulas posteriores \n");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
}
