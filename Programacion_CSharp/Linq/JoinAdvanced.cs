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
                        } into productosDeProveedor
                        select new
                        {
                            provId = productosDeProveedor.Key.IdProveedor,
                            provNombre = productosDeProveedor.Key.Nombre,
                            provTelefono = productosDeProveedor.Key.Telefono,
                            ListaPedidos = from producto in Producto.Show()
                                            join pedido in Pedido.Show()
                                            on producto.IdProducto equals pedido.IdPedido
                                            group pedido by new
                                            {
                                                pedido.IdPedido,
                                                pedido.Fecha,
                                                pedido.Destinatario,
                                                pedido.Cantidad
                                            } into pedidos

                                            select new {
                                                provId = productosDeProveedor.Key.IdProveedor,
                                                provNombre = productosDeProveedor.Key.Nombre,
                                                provTelefono = productosDeProveedor.Key.Telefono,
                                                pedId = pedidos.Key.IdPedido,
                                                pedFecha = pedidos.Key.Fecha,
                                                pedDestinatario = pedidos.Key.Destinatario,
                                                pedCantidad = pedidos.Key.Cantidad
                                            }
                        };



            foreach (var item in query)
            {
                Console.WriteLine("{0}", item.ListaPedidos);
            }
            Console.ReadKey();
        }
    }
}
