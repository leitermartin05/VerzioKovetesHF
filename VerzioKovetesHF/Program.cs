﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKovetesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Klrem, adjon megy egy számot: ");
                tomb[i]= Convert.ToInt32(Console.ReadLine());

            }
        }

        

      
    }
}
