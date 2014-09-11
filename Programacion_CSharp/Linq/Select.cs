﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_CSharp.Linq
{
    class Select
    {
        public static void querySelect()
        {

            var query = from p in Product.Show()
                        select p;




            foreach (var item in query)
            {
                Console.WriteLine("id = {0}, Nombre = {1}, Marca = {2}, Valor = {3}, Stock = {4}",
                                    item.id, item.nombre, item.marca, item.valor, item.stock);
            }

            Console.ReadKey();

        }



    }
}
