﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaVjezbu2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1900; i <= 2100; i++)
            {
                if(i % 4 == 0 && i % 100 != 0 || i % 400 == 0 )
                {
                    Console.WriteLine(i + " je prijestupna godina.");
                }
            }

            Console.ReadKey();
        }
    }
}
