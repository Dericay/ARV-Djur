using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARV_Djur
{
    public class Mouse : Animal
    {
        bool _Scared;

        public Mouse(string Name, string Colour, double Age, int Legs, string Food, string Sound, bool Scared)
        {
            _Scared = Scared;
            _name = Name;
            _colour = Colour;
            _age = Age;
            _legs = Legs;
            _food = Food;
            _sound = Sound;
        }

        public void GetScared()
        {
            if (_Scared == true)
            {
                Console.WriteLine("The Mouse is scared!");
            }
            else
            {
                Console.WriteLine("The Mouse is not scared!");
            }
        }

        public void makeSound()
        {
            Console.WriteLine(_sound);
        }
    }
}
