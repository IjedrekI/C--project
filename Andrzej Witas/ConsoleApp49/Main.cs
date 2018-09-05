using System;
using System.Collections;
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
            Console.Title = "Baza Danych Andrzej Witas";
            ArrayList tablicaStudent = new ArrayList();
            ArrayList tablicaWykladowca = new ArrayList();

            while (true)
            {
                Console.WriteLine("Witam tutaj baza danych, co chcesz zrobic ");
                Console.WriteLine("1.Dodac studenta: ");
                Console.WriteLine("2.Dodac nauczyciela: ");
                Console.WriteLine("3.Wyswieltlic zapisanych studentow: ");
                Console.WriteLine("4.Wyswieltlic nauczycieli: ");
                Console.WriteLine("0.Zakonczyc ");

                int wybor = new int();

                while (true)
                {
                    try
                    {
                        wybor = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Blad");
                    }
                } 


                {
                    if (wybor == 0)
                    {
                        Menu.Wybor0();

                    }
                    if (wybor == 1)  // Student(string a, string b, int c, int d, int x, int y, int z)
                    {
                        Student temp = Menu.Wybor1();
                        string a = temp.ToString();
                        tablicaStudent.Add(temp);
                    }
                    if (wybor == 2)
                    {
                        Wykladowca temp = Menu.Wybor2();
                        string a = temp.ToString();
                        tablicaWykladowca.Add(temp);
                    }
                    if (wybor == 3)
                    {
                        WyswietlanieListyStudent.WyswietStosS(tablicaStudent);
                    }
                    if (wybor == 4)
                    {
                        WyswietlanieListyStudent.WyswietStosS(tablicaWykladowca);
                    }
                }

            }  
   
        }
    }
}
