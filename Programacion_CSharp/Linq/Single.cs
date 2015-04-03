using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class Single
    {
        public static void singleQuery()
        {
            var query = Producto.Show()
                            .Select(p => new { p.IdProducto, p.Tipo, p.Valor })
                                .Single(x=>x.IdProducto == 5);

            Console.WriteLine("\nSingle : Este operador devuelve el único elemento de una secuencia. \nSi hay más de un elemento dará una excepción. Si no hay elementos también dará excepción. \n");

            Console.WriteLine("El elemento encontrado es:> {0}", query);
            Console.ReadKey();
        }

    }
}
