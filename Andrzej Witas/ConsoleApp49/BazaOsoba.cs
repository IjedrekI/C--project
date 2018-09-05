using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    abstract public class BazaOsoba  // abstrakcyjna
    {
        protected string imie;
        protected string nazwisko;
        protected int wiek;
        protected UInt32 pesel;
        static Int16 licznik;
 

        public BazaOsoba(string a, string b, int c, int d) // Konstruktor 
        {
            this.imie = a;
            this.nazwisko = b;
            this.wiek = c;
            this.pesel = d;
            licznik++;
         }


        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int Wiek { get => wiek; set => wiek = value; }
        public Int64 Pesel { get => pesel; set => pesel = value; }
    }
}
