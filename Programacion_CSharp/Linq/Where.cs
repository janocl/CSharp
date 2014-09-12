﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    class Where
    {
        public static void queryWhere()
        {

            var query = from p in Product.Show()
                        where p.stock < 100 && p.valor > 1000
                        select p;




            foreach (var item in query)
            {
                Console.WriteLine("id = {0}, Tipo = {1}, Marca = {2}, Valor = {3}, Stock = {4}",
                                    item.id, item.tipo, item.marca, item.valor, item.stock);
            }

            Console.ReadKey();

        }

    }
}
