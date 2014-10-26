using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp
{
    public static class Pedido
    {
        public class Pedidos
        {
            public int IdPedido { get; set; }
            public DateTime Fecha { get; set; }
            public string Destinatario { get; set; }
            public int Cantidad { get; set; }
        }

        public static List<Pedidos> Show()
        {
            List<Pedidos> listaPedidos = new List<Pedidos>();
            {
                new Pedidos { IdPedido = 1, Fecha = new DateTime(01 - 05 - 2014), Destinatario = "Isamel Jara", Cantidad = 3 };
                new Pedidos { IdPedido = 2, Fecha = new DateTime(00 - 08 - 2014), Destinatario = "Jose Soto", Cantidad = 12 };
                new Pedidos { IdPedido = 3, Fecha = new DateTime(23 - 10 - 2014), Destinatario = "David Maldonado", Cantidad = 24 };
                new Pedidos { IdPedido = 4, Fecha = new DateTime(17 - 07 - 2014), Destinatario = "Sebastian Gonzales", Cantidad = 4 };
                new Pedidos { IdPedido = 5, Fecha = new DateTime(23 - 12 - 2014), Destinatario = "Pedro Martinez", Cantidad = 8 };
                new Pedidos { IdPedido = 6, Fecha = new DateTime(09 - 05 - 2014), Destinatario = "Angel Vega", Cantidad = 15 };
            };

            return listaPedidos;
        }

    }
}
