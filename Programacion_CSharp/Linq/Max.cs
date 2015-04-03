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

            var query = Producto.Show().Max(o=>o.Stock);

            Console.WriteLine("\nMax : El operador Max devuelve el valor máximo de una colección de registros. \n");
            
            Console.WriteLine("El mayor Stock es:>{0}", query);
            Console.ReadKey();

        }

    }
}
