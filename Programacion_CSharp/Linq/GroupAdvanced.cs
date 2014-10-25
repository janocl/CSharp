using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    class GroupAdvanced
    {
        public static void queryGroupAdvanced()
        {
            var query = from p in Producto.Show()
                        where p.IdProveedor != -1
                        group p by new {p.Tipo, p.Marca} into g1
                        orderby g1.Key.Tipo
                        select new {tipo = g1.Key.Tipo, marca = g1.Key.Marca};
                        
            
            foreach (var item in query)
            {
                Console.WriteLine("{0}-{1}",item.tipo, item.marca);
            }

            Console.ReadKey();
        
        
        }
    }
}
