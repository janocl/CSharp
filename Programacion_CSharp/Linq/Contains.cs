using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class Contains
    {
        public static void queryContains()
        {

            var query = Producto.Show()
                        .Where(x => x.Tipo.Contains("Bebida"));


            Console.WriteLine("\nContains : Este operador determina si un elemento se encuentra en la colección \ny puede ser llamado en cualquier tipo que implemente IEnumerable\n");
            foreach (var item in query)
            {
                Console.WriteLine("Id = {0}, Marca = {1}, Tipo = {2}", item.IdProducto, item.Marca, item.Tipo );
            }
            Console.ReadKey();
        
        }

    }
}
