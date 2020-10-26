using System;

namespace statementsEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to continue?");
            var answer = Console.ReadLine();

            if (answer == "yes") 
            {
                Console.WriteLine("Continue"); 
            }
            else 
            {
                Console.WriteLine("end program");
            }

            Console.WriteLine("what is your grade in math?");
            int grade =Convert.ToInt32(Console.ReadLine());
            

            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }

            Console.WriteLine("which animal is your favorit? n/ Cat, Dog, Mouse, Bird, Rabbit, Fox");
            String value = Console.ReadLine();

            switch (value)
            {
                case "Cat":
                    Console.WriteLine("meow");
                    break;

                case "Dog":
                    Console.WriteLine("Bark");
                    break;

                case "mouse":
                    Console.WriteLine("scweeeeeek");
                    break;

                case "Bird":
                    Console.WriteLine("tweet");
                    break;
                case "Rabbit":
                    Console.WriteLine("bounce");
                    break;
                case "Fox":
                    Console.WriteLine("nothing");
                    break;


            }
        }
    }
}
