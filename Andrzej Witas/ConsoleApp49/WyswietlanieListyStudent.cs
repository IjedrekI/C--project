using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp49
{
    public static class WyswietlanieListyStudent 
    {
        public static void WyswietStosS (ArrayList a)
        {
            //Console.WriteLine(a.Count());
            if (a.Count == 0)
            {
                Console.WriteLine("Pusta lista ");
            }

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            } 
        }
    }
}
