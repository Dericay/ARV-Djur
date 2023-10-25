using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ARV_Djur
{
    public class Dog : Animal           //Dog is child class to Animals
    {
               
       public double _height;

       public Dog(double Height, string Name, string Colour, double Age, int Legs, string Food, string Sound)
        {
           _height = Height;        //Constructor
           _name = Name;
           _colour = Colour;
           _age = Age;
           _legs = Legs;
           _food = Food;
           _sound = Sound;
       }

        public void GetHeight()
        {
            Console.WriteLine("The dog is {0} cm high", _height);
        }

       public void makeSound()
       {
            Console.WriteLine(_sound);
       }
        
    }
}
