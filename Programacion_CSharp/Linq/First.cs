using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class First
    {

        public static void queryFirst()
        {

            var query = Producto.Show()
                            .Select(x => new { Id = x.IdProducto, Tipo = x.Tipo, Stock = x.Stock})
                                .First(p => p.Stock > 100);



            Console.WriteLine("\nFirst : Este operador devuelve el primer elemento de una secuencia.\n");

            Console.WriteLine(query);
            Console.ReadKey();

        }

    }
}
