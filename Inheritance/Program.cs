using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var emperorPenguin = new Bird();
            emperorPenguin.CanFly = false;
            emperorPenguin.HasTalons = false;
            Console.WriteLine($"It is {emperorPenguin.CanFly} that an emperor penguin can fly. It has {emperorPenguin.Legs} legs.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var saltwaterCroc = new Reptile();
            saltwaterCroc.Legs = 4;
            saltwaterCroc.IsVenomous = false;
            saltwaterCroc.CanSwim = true;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"It is {saltwaterCroc.CanSwim} that a saltwater crocodile can swim, and it has {saltwaterCroc.Eyes} eyes.");
        }
    }
}
