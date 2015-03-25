using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    public class JoinAdvanced
    {
        public static void queryJoinAdvanced()
        {
            var query = (from proveedor in Proveedor.Show()
                         join producto in Producto.Show()
                         on proveedor.IdProveedor equals producto.IdProveedor
                         select new
                         {
                             proveedor.IdProveedor,
                             proveedor.Nombre,
                             proveedor.Telefono,
                             producto.IdProducto,
                             producto.Tipo,
                             producto.Marca,
                             producto.Valor
                         } into g1
                             join pedido in Pedido.Show()
                             on g1.IdProducto equals pedido.IdProducto
                                 select new
                                 {
                                     g1.IdProveedor,
                                     g1.Nombre,
                                     g1.Telefono,
                                     g1.IdProducto,
                                     g1.Tipo,
                                     g1.Marca,
                                     g1.Valor,
                                     pedido.Fecha,
                                     pedido.Cantidad,
                                     pedido.Destinatario
                                 }).OrderBy(x=>x.IdProveedor);


            Console.WriteLine("\nCombinación de consulta entre 3 entidades");
            foreach (var item in query)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadKey();
        }
    }
}
