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
            var query = from proveedor in Proveedor.Show()
                        join producto in Producto.Show()
                        on proveedor.IdProveedor equals producto.IdProducto
                        group proveedor by new
                        {
                            proveedor.IdProveedor,
                            proveedor.Nombre,
                            proveedor.Telefono
                        } into g1
                        select new
                        {
                            provId = g1.Key.IdProveedor,
                            provNombre = g1.Key.Nombre,
                            provTelefono = g1.Key.Telefono,
                            ListaPedidos = from producto in Producto.Show()
                            join pedido in Pedido.Show()
                            on producto.IdProducto equals pedido.IdPedido
                            group pedido by new
                            {
                                pedido.IdPedido,
                                pedido.Fecha,
                                pedido.Destinatario,
                                pedido.Cantidad
                            } into g2

                            select new {
                                provId = g1.Key.IdProveedor,
                                provNombre = g1.Key.Nombre,
                                provTelefono = g1.Key.Telefono,
                                pedId = g2.Key.IdPedido,
                                pedFecha = g2.Key.Fecha,
                                pedDestinatario = g2.Key.Destinatario,
                                pedCantidad = g2.Key.Cantidad
                            }
                        };



            foreach (var item in query)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadKey();
        }
    }
}
