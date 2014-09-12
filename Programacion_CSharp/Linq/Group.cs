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
            var query = from p in Product.Show()
                        group p by p.tipo;



            Console.WriteLine("Que Marcas de Cada Tipo de Producto Existen...\n");

            foreach (var GruposTipoDeMarcas in query)
            {
                Console.WriteLine("Tipo >> {0}", GruposTipoDeMarcas.Key);

                foreach (var b in GruposTipoDeMarcas)
                {
                    Console.WriteLine("\t Marca = {0}", b.marca);
                }

            }

            Console.ReadKey();
        
        }

    }
}
