using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARV_Djur
{
    public class Bulldog : Dog
    {
        string _drool;

        public Bulldog(string Drool,double Height, string Name, string Colour, double Age, int Legs, string Food, string Sound) : base(Height, Name, Colour, Age, Legs, Food, Sound)
        {
            _drool = Drool;

            
        }                 
          public void GetDrool()
        {
            Console.WriteLine("The bulldog is {0}", _drool);
        }
    }
}

