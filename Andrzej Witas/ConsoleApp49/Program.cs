using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam tutaj baza danych, co chcesz zrobic ");
            Console.WriteLine("1.Dodac studenta ");
            Console.WriteLine("2.Dodac nauczyciela ");
            Console.WriteLine("3.Inny pracownik ");
            Console.WriteLine("4.Dodac osobe to kolejki w dziekanacie");// maksymalnie 5 osobo jesli wchodzi nastepna zwalnia sie miejsce
            Console.WriteLine("Zapisac do pliku txt ");

            Console.WriteLine("Zakonczyc ");

            Int16 a = 0;

            a = Convert.ToInt16(Console.ReadLine());

            /* ###### TEST ###### */

            Student x = new Student();

            x.Imie = "Andrzej";


         

        }
    }

 }