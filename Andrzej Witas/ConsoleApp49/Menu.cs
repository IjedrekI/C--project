using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    static class Menu
    {
        static public void Wybor0() //Case 0
        {           
            System.Diagnostics.Process.GetCurrentProcess().Kill(); // Konczy dzialanie programu
        }
        static public Student Wybor1() // Case 1
        {
            string imie, nazwisko;
            int wiek, pesel, numerLegitymacji, rokStudiow, ocenaZProgramowania;
            Console.WriteLine("STUDENT");
            Console.WriteLine("Podaj imie "); imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko "); nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj wiek "); wiek = Convert.ToInt32(Console.ReadLine());// wyjatek
            Console.WriteLine("Podaj pesel "); pesel = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Podaj numer legitymacji "); numerLegitymacji = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj rok studiów "); rokStudiow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ocenę z programowania "); ocenaZProgramowania = Convert.ToInt32(Console.ReadLine());

            Student tempStudent = new Student(imie, nazwisko, wiek, pesel, numerLegitymacji, rokStudiow, ocenaZProgramowania);
            return tempStudent;
        }
        static public Wykladowca Wybor2() // Case 2
        {
            string imie, nazwisko, tytulNaukowy;
            int wiek, pesel, numerLegitymacji;
            Console.WriteLine("WYKLADOWCA");
            Console.WriteLine("Podaj imie "); imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko "); nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj wiek "); wiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj pesel "); pesel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj numer legitymacji "); numerLegitymacji = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj tytul naukowy "); tytulNaukowy = Console.ReadLine();

            Wykladowca tempWykladowca = new Wykladowca(imie, nazwisko, wiek, pesel, numerLegitymacji, tytulNaukowy); // Konstruktor
            return tempWykladowca;
        }
    }
}
