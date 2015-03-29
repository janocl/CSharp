using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp
{
    public class Proveedor
    {
            public int IdProveedor { get; set; }
            public string Nombre { get; set; }
            public int Telefono { get; set; }

        public static List<Proveedor> Show()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>()
            {
                new Proveedor{ IdProveedor=1, Nombre="Walmart", Telefono=86985478 },
                new Proveedor{ IdProveedor=2, Nombre="CCU", Telefono=98152773 },
                new Proveedor{ IdProveedor=3, Nombre="Unimark", Telefono=72937400 },
                new Proveedor{ IdProveedor=4, Nombre="Moserrat", Telefono=83002319 },
                new Proveedor{ IdProveedor=5, Nombre="Jumbo", Telefono=77390812 },
            };

            return listaProveedores;
        
        }


     
    }
}
