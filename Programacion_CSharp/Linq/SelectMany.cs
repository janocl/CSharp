using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class SelectMany
    {
        public static void querySelectMany()
        {

            var query = Pedido.Show()
                        .SelectMany(ped => ped.ListaProductos
                            .Select(prod => prod.ListaProveedores
                                .Select(prov => new { prov.IdProveedor, prov.Nombre })))
                        .First();




            Console.WriteLine("\nSelectMany : Este operador toma cada elemento que proyecta, lo convierte en una enumeración, \ny luego concatena todas las enumeraciones. \n");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }



    }
}
