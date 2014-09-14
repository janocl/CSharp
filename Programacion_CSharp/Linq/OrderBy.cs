﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    class OrderBy
    {
        public static void queryOrderBy()
        {
            var query = from p in Product.Show()
                        where p.id > 0
                        orderby p.marca ascending
                        select p;

            Console.WriteLine("\nMarcas Ordenadas Alfabeticamente.");
            foreach (var item in query)
            {
                Console.WriteLine("Marca > {0}", item.marca);
            }

            Console.ReadKey();
        }

    }
}
