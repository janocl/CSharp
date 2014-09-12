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
            public int id { get; set; }
            public string tipo { get; set; }
            public string marca { get; set; }
            public int valor { get; set; }
            public int stock { get; set; }

        }

        public static List<Productos> Show()
        {
            List<Productos> listaProductos = new List<Productos>() 
            { new Productos{ id=1, marca="Colun", tipo="Leche", stock=25, valor=850 },
              new Productos{ id=2, marca="Pepsi", tipo="Bebida", stock=45, valor=1300 },
              new Productos{ id=3, marca="Lays", tipo="Papas fritas", stock=53, valor=1890 },
              new Productos{ id=4, marca="Kunstmann", tipo="Cerveza", stock=322, valor=5050 },
              new Productos{ id=5, marca="Carozzi", tipo="Spaghetti", stock=500, valor=1599 },
              new Productos{ id=6, marca="Coca-Cola", tipo="Bebida", stock=450, valor=1620 },
              new Productos{ id=7, marca="Quillayes", tipo="Yoghurt", stock=100, valor=2290 },
              new Productos{ id=8, marca="Colun", tipo="Yoghurt", stock=200, valor=1030 },
              new Productos{ id=9, marca="Vital", tipo="Agua Mineral", stock=88, valor=850 },
              new Productos{ id=10, marca="Kross", tipo="Cerveza", stock=145, valor=1890 },
            };

            return listaProductos;
        }

    }
}
