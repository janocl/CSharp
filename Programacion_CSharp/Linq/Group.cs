using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    class Group
    {

        public static void queryGropup()
        {
            var query = from p in Producto.Show()
                        group p by p.Tipo;



            Console.WriteLine("\nQue Marcas de Cada Tipo de Producto Existen...\n");
            
            foreach (var _tipo in query)
            {
                Console.WriteLine("Tipo >> {0}", _tipo.Key);

                foreach (var grupo in _tipo)
                {
                    Console.WriteLine("\t Marca = {0}", grupo.Marca);
                }

            }

            Console.ReadKey();
        
        }

    }
}
