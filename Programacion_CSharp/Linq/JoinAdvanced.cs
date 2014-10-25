using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    class JoinAdvanced
    {
        public static void queryJoinAdvanced()
        {
            var query = from p in Producto.Show()
                        join a in Proveedor.Show()
                        on p.IdProducto equals a.IdProveedor
                        select new { id = p.IdProducto, tipo = p.Tipo, 
                                    valor = p.Valor, proveedor = a.Nombre, 
                                    fono = a.Telefono };


            foreach (var item in query)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadKey();
    }
}
