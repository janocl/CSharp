using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class All
    {
        public static void queryAll()
        {

            var query = Producto.Show()
                        .All(x => x.Stock > 0);


            Console.WriteLine("\nAll : El operador 'All' se utiliza para determinar si todos los elementos\n de una colección cumplen con una condición específica devolviendo 'true'.\n");

            if (query.Equals(true))
            {
                Console.WriteLine("Se cumple la condición, ya que existe stock: [{0}]", query);
            }
            else
            {
                Console.WriteLine("No se cumple la condición: [{0}]", query);
            }
            

            Console.ReadKey();
        
        }
    }
}
