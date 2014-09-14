using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp
{
    public static class Product
    {
        public class Productos
        {
            public int IdProducto { get; set; }
            public string Marca { get; set; }
            public string Tipo { get; set; }
            public int Valor { get; set; }
            public int Stock { get; set; }
            public int IdProveedor { get; set; }
        }

        public static List<Productos> Show()
        {
            List<Productos> listaProductos = new List<Productos>() 
            { new Productos{ IdProducto=1, Marca="Colun", Tipo="Leche", Stock=25, Valor=850 },
              new Productos{ IdProducto=2, Marca="Pepsi", Tipo="Bebida", Stock=45, Valor=1300 },
              new Productos{ IdProducto=3, Marca="Lays", Tipo="Papas fritas", Stock=53, Valor=1890 },
              new Productos{ IdProducto=4, Marca="Kunstmann", Tipo="Cerveza", Stock=322, Valor=5050 },
              new Productos{ IdProducto=5, Marca="Carozzi", Tipo="Spaghetti", Stock=500, Valor=1599 },
              new Productos{ IdProducto=6, Marca="Coca-Cola", Tipo="Bebida", Stock=450, Valor=1620 },
              new Productos{ IdProducto=7, Marca="Quillayes", Tipo="Yoghurt", Stock=100, Valor=2290 },
              new Productos{ IdProducto=8, Marca="Colun", Tipo="Yoghurt", Stock=200, Valor=1030 },
              new Productos{ IdProducto=9, Marca="Vital", Tipo="Agua Mineral", Stock=88, Valor=850 },
              new Productos{ IdProducto=10, Marca="Kross", Tipo="Cerveza", Stock=145, Valor=1890 },
              new Productos{ IdProducto=11, Marca="Fanta", Tipo="Bebida", Stock=105, Valor=1340 },
            };

            return listaProductos;
        }

    }
}
