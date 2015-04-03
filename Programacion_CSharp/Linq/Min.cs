using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class Min
    {
        public static void queryMin()
        {

            var query = Producto.Show().Min(o => o.Stock);

            Console.WriteLine("\nMin : El operador Mix devuelve el valor minimo de una colección de registros. \n");

            Console.WriteLine("El valor minimo de Stock es:>{0} ", query);
            Console.ReadKey();

        }

    }
}
