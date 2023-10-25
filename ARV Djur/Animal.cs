using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ARV_Djur
{
    public class Animal
    {
        public string _name;
        public string _colour;
        public double _age;
        public int _legs;
        public string _food;
        public string _sound;
        public void GetLegs()
        {
            Console.WriteLine("The animal has {0} legs", _legs);
        }
        public void GetFood()
        {
            Console.WriteLine("The animal eats {0}", _food);
        }
        public void GetAge()
        {
            Console.WriteLine("The age of the animal is {0} years", _age);
        }

    }
        

    
}  

