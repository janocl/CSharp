using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class Sum
    {
        public static void querySum()
        {

            var query = Producto.Show().Sum(x=>x.Stock);



            Console.WriteLine("\nSum : Este método de extension en Linq calcula la suma de una secuencia de valores. \n");
            Console.WriteLine("Suma del stock de productos:> {0}",query);
            Console.ReadKey();

        }

    }
}
