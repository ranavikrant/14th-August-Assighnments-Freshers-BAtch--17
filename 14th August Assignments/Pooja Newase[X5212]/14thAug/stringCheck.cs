﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _14thAug
{
    class stringCheck
    {
        public void checkChar()
        {
            String input = "adxgjfvhkfyhjgswtgcdhncgsdeaskihkmvbgsdfart";
            Hashtable charTable = new Hashtable();
            var watch = System.Diagnostics.Stopwatch.StartNew();

            while (input.Length > 0)
            {
                Console.Write(input[0] + " : ");
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[0] == input[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }
            watch.Stop();

            Console.WriteLine("Time taken : " + watch.Elapsed);

        }
    }
}
