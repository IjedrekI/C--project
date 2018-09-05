using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    public class Student : BazaOsoba , IOsob
    {
        
        private int numerLegitymacji; // zakres od 10000 do 3000
        private int rokStudiow;
        private int ocenaZProgramowania;

        public int NumerLegitymacji { get => numerLegitymacji; set => numerLegitymacji = value; }
        public int RokStudiow { get => rokStudiow; set => rokStudiow = value; }
        public int OcenaZProgramowania { get => ocenaZProgramowania; set => ocenaZProgramowania = value; }
        
        public Student(string a, string b, int c, int d, int x, int y, int z)
            :base (a, b, c, d)
        {
            this.numerLegitymacji = x;
            this.rokStudiow = y;
            this.ocenaZProgramowania = z;
        }

        public override string ToString() 
        {
          string temp1 = "Studnent to " ;
          string temp2 = imie + " "  + nazwisko + " " + wiek + " " + pesel + " " + numerLegitymacji + " " + rokStudiow + " " + ocenaZProgramowania;
          return temp1 + temp2; 
        }
    }
}
