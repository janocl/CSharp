using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp
{
    public class Pedido
    {
            public int IdPedido { get; set; }
            public DateTime Fecha { get; set; }
            public string Destinatario { get; set; }
            public int Cantidad { get; set; }
            public int IdProducto { get; set; }
            public IEnumerable<Producto> ListaProductos { get; set; }

        public static List<Pedido> Show()
        {
            List<Pedido> listaPedidos = new List<Pedido>()
            {
                new Pedido { IdPedido = 1, Fecha = new DateTime(2014, 05, 02), Destinatario = "Isamel Jara", Cantidad = 3, IdProducto = 5, 
                    ListaProductos = new List<Producto>(){new Producto{ IdProducto = 100, Marca = "Coca-Cola", Valor = 1200, Tipo = "Bebida", Stock = 200, ListaProveedores = Proveedor.Show()}} },
                new Pedido { IdPedido = 2, Fecha = new DateTime(2014, 09, 09), Destinatario = "Jose Soto", Cantidad = 12, IdProducto = 3, 
                    ListaProductos = new List<Producto>(){new Producto{ IdProducto = 200, Marca = "Miraflores", Valor = 1600, Tipo = "Aceite", Stock = 344, ListaProveedores = Proveedor.Show()}} },
                new Pedido { IdPedido = 3, Fecha = new DateTime(2014, 03, 22), Destinatario = "David Maldonado", Cantidad = 24, IdProducto = 7, 
                    ListaProductos = new List<Producto>(){new Producto{ IdProducto = 300, Marca = "Nescafe", Valor = 1100, Tipo = "Cafe", Stock = 125, ListaProveedores = Proveedor.Show()}} },
                new Pedido { IdPedido = 4, Fecha = new DateTime(2014, 11, 19), Destinatario = "Sebastian Gonzales", Cantidad = 4, IdProducto = 10, 
                    ListaProductos = new List<Producto>(){new Producto{ IdProducto = 400, Marca = "Heineken", Valor = 1200, Tipo = "Cerveza", Stock = 660, ListaProveedores = Proveedor.Show()}} },
                new Pedido { IdPedido = 5, Fecha = new DateTime(2014, 07, 12), Destinatario = "Pedro Martinez", Cantidad = 8, IdProducto = 1, 
                    ListaProductos = new List<Producto>(){new Producto{ IdProducto = 500, Marca = "Soprole", Valor = 900, Tipo = "Yogurth", Stock = 520, ListaProveedores = Proveedor.Show()}} },
                new Pedido { IdPedido = 6, Fecha = new DateTime(2014, 05, 07), Destinatario = "Angel Vega", Cantidad = 15, IdProducto = 11, 
                    ListaProductos = new List<Producto>(){new Producto{ IdProducto = 600, Marca = "Nestle", Valor = 800,  Tipo = "Leche", Stock = 330, ListaProveedores = Proveedor.Show()}} },
            };

            return listaPedidos;
        }

    }
}
