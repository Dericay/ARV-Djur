using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ARV_Djur
{
    public class JackRussel : Dog       //JackRussel is child class to Dog
    {
        bool _mood;

        public JackRussel(bool Mood, double Height, string Name, string Colour, double Age, int Legs, string Food, string Sound) : base(Height, Name, Colour, Age, Legs, Food, Sound)
        {
            _mood = Mood;
        
        }

        public void GetMood()
        {
            _mood = true;
            Console.WriteLine("Jack russel is happy");
        }
    }
}
