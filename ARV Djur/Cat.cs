using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARV_Djur
{
    public class Cat : Animal       //Cat its child class to Animal
    {
        public int _claws;


        public Cat(int Claws, string Name, string Colour, double Age, int Legs, string Food, string Sound)
        {
            _claws = Claws;             //Constructor
            _name = Name;
            _colour = Colour;
            _age = Age;
            _legs = Legs;
            _food = Food;
            _sound = Sound;
        }

        public void GetClaws()  
        {
            Console.WriteLine("The cat has {0} claws", _claws);
        }

        public void makeSound()
        {
            Console.WriteLine(_sound);
        }
    }
}
