using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp
{
    public class Producto
    {
            public int IdProducto { get; set; }
            public string Marca { get; set; }
            public string Tipo { get; set; }
            public int Valor { get; set; }
            public int Stock { get; set; }
            public int IdProveedor { get; set; }
            public IEnumerable<Proveedor> ListaProveedores { get; set; }


        public static List<Producto> Show()
        {
            List<Producto> listaProductos = new List<Producto>() 
            { 
                new Producto{ IdProducto=1, Marca="Colun", Tipo="Leche", Stock=25, Valor=850, IdProveedor=4, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 100, Nombre = "Walmart", Telefono = 55443322} } },
                new Producto{ IdProducto=2, Marca="Pepsi", Tipo="Bebida", Stock=45, Valor=1300, IdProveedor=2, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 200, Nombre = "Unimark", Telefono = 66009570} } },
                new Producto{ IdProducto=3, Marca="Lays", Tipo="Papas fritas", Stock=53, Valor=1890, IdProveedor=3, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 300, Nombre = "Jumbo", Telefono = 90009424} } },
                new Producto{ IdProducto=4, Marca="Kunstmann", Tipo="Cerveza", Stock=322, Valor=5050, IdProveedor=2, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 400, Nombre = "CCU", Telefono = 55443322} } },
                new Producto{ IdProducto=5, Marca="Carozzi", Tipo="Spaghetti", Stock=500, Valor=1599, IdProveedor=5, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 500, Nombre = "CCU", Telefono = 55443322} } },
                new Producto{ IdProducto=6, Marca="Coca-Cola", Tipo="Bebida", Stock=450, Valor=1620, IdProveedor=2, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 600, Nombre = "Unimark", Telefono = 55443322} } },
                new Producto{ IdProducto=7, Marca="Quillayes", Tipo="Yoghurt", Stock=100, Valor=2290, IdProveedor=1, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 700, Nombre = "CCU", Telefono = 55443322} } },
                new Producto{ IdProducto=8, Marca="Colun", Tipo="Yoghurt", Stock=200, Valor=1030, IdProveedor=1, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 800, Nombre = "Jumbo", Telefono = 55443322} } },
                new Producto{ IdProducto=9, Marca="Vital", Tipo="Agua Mineral", Stock=88, Valor=850, IdProveedor=5, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 900, Nombre = "CCU", Telefono = 55443322} } },
                new Producto{ IdProducto=10, Marca="Kross", Tipo="Cerveza", Stock=145, Valor=1890, IdProveedor=2, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 1000, Nombre = "Walmart", Telefono = 55443322} } },
                new Producto{ IdProducto=11, Marca="Fanta", Tipo="Bebida", Stock=105, Valor=1340, IdProveedor=3, 
                    ListaProveedores = new List<Proveedor>(){ new Proveedor(){ IdProveedor = 1100, Nombre = "Jumbo", Telefono = 55443322} } },
            };

            return listaProductos;
        }

    }
}
