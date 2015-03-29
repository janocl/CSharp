using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp
{
    public class Pedido
    {
        public class Pedidos
        {
            public int IdPedido { get; set; }
            public DateTime Fecha { get; set; }
            public string Destinatario { get; set; }
            public int Cantidad { get; set; }
            public int IdProducto { get; set; }
        }

        public static List<Pedidos> Show()
        {
            List<Pedidos> listaPedidos = new List<Pedidos>()
            {
                new Pedidos { IdPedido = 1, Fecha = new DateTime(2014, 05, 02), Destinatario = "Isamel Jara", Cantidad = 3, IdProducto = 5 },
                new Pedidos { IdPedido = 2, Fecha = new DateTime(2014, 09, 09), Destinatario = "Jose Soto", Cantidad = 12, IdProducto = 3 },
                new Pedidos { IdPedido = 3, Fecha = new DateTime(2014, 03, 22), Destinatario = "David Maldonado", Cantidad = 24, IdProducto = 7 },
                new Pedidos { IdPedido = 4, Fecha = new DateTime(2014, 11, 19), Destinatario = "Sebastian Gonzales", Cantidad = 4, IdProducto = 10 },
                new Pedidos { IdPedido = 5, Fecha = new DateTime(2014, 07, 12), Destinatario = "Pedro Martinez", Cantidad = 8, IdProducto = 1 },
                new Pedidos { IdPedido = 6, Fecha = new DateTime(2014, 05, 07), Destinatario = "Angel Vega", Cantidad = 15, IdProducto = 11 },
            };

            return listaPedidos;
        }

    }
}
