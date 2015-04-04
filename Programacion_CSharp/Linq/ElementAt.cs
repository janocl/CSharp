using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    class ElementAt
    {

        public static void queryElementAt()
        {

            var query = Producto.Show()
                            .Select(s => new { s.IdProducto, s.Marca, s.Tipo })
                                .ElementAt(5);

            Console.WriteLine("\nElementAt : Con este operador podemos extraer un elemento de una secuencia dado su índice. \n");

            Console.WriteLine("{0}", query);
            Console.ReadKey();
        
        
        }

    }
}
