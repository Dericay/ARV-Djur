namespace ARV_Djur
{
    internal class Program                              //Anton Larsson SUT23
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(45.6, "Tax", "Brown", 4.5, 4, "Meat", "Woof!");          //Calling on the constructor
            Cat cat1 = new Cat(20, "Bengal", "Black", 7, 4, "Meat", "Meow!");
            Mouse M1 = new Mouse("Mouse", "Gray", 1.5, 4, "cheese", "Meeep!", true);
            JackRussel Jack1 = new JackRussel(true, 34.4, "Jack Russel", "Brown and white", 8, 4, "Chew bone", "Woof!");
            Bulldog Bull1 = new Bulldog("drooling", 43.3, "Bulldog", "White", 2, 4, "Meat", "Woof!");


            
            dog1.makeSound();       //Calling diffrent methods
            dog1.GetHeight();
            Console.WriteLine();

            
            cat1.makeSound();
            cat1.GetClaws();
            Console.WriteLine();

            
            M1.makeSound();
            M1.GetScared();
            Console.WriteLine();

            
            Jack1.makeSound();
            Jack1.GetHeight();
            Console.WriteLine();

            
            Bull1.makeSound();
            Bull1.GetHeight();
            Console.WriteLine();

            
        }
    }
}