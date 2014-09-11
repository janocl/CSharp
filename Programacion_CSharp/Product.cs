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
            public string nombre { get; set; }
            public string marca { get; set; }
            public int valor { get; set; }
            public int stock { get; set; }

        }

        public static List<Productos> Show()
        {
            List<Productos> listaProductos = new List<Productos>() 
            { new Productos{ id=1, marca="Colun", nombre="leche descremada", stock=25, valor=850 },
              new Productos{ id=2, marca="Pepsi", nombre="Bebida", stock=45, valor=1300 },
              new Productos{ id=3, marca="Lays", nombre="Papas fritas", stock=53, valor=1890 },
              new Productos{ id=4, marca="Kunstmann", nombre="Cerveza Rubia", stock=322, valor=5050 },
              new Productos{ id=5, marca="Carozzi", nombre="Pack 3 Spaghetti", stock=500, valor=1599 },
            };

            return listaProductos;
        }

    }
}
