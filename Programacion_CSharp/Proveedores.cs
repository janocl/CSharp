using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp
{
    public static class Proveedor
    {
        public class Proveedores 
        {
            public int IdProveedor { get; set; }
            public string Nombre { get; set; }
            public int Telefono { get; set; }
        
        }

        public static List<Proveedores> Show()
        {
            List<Proveedores> listaProveedores = new List<Proveedores>()
            {
                new Proveedores{ IdProveedor=1, Nombre="Walmart", Telefono=86985478 },
                new Proveedores{ IdProveedor=2, Nombre="CCU", Telefono=98152773 },
                new Proveedores{ IdProveedor=3, Nombre="Unimark", Telefono=72937400 },
                new Proveedores{ IdProveedor=4, Nombre="Moserrat", Telefono=83002319 },
                new Proveedores{ IdProveedor=5, Nombre="Jumbo", Telefono=77390812 },
            };

            return listaProveedores;
        
        }


     
    }
}
