using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - DONE
            // give this class 4 members that all Animals have in common - DONE


            // Create a class Bird - DONE
            // give this class 4 members that are specific to Bird - DONE
            // Set this class to inherit from your Animal Class - DONE

            // Create a class Reptile - DONE
            // give this class 4 members that are specific to Reptile - DONE
            // Set this class to inherit from your Animal Class - DONE




            /*Create an object of your Bird class - DONE
             *  give values to your members using the object of your Bird class - DONE
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class - DONE
             *  give values to your members using the object of your Reptile class - DONE
             *  
             * Creatively display the class member values 
             */

            Console.WriteLine("Facts about the Ostrich:");
            
            var ostrich = new Bird()
            {
                NumberOfLegs = 2,
                BeakSize = "large",
                LaysEggs = true,
                CanFly = false
            };

            Console.WriteLine($"The Ostrich has {ostrich.NumberOfLegs} legs and a {ostrich.BeakSize} beak.");
            Console.WriteLine($"T/F: The ostrich lays eggs?: {ostrich.LaysEggs}\nT/F: The ostrich can fly?: {ostrich.CanFly}");

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Facts about the Crocodile.");

            var crocodile = new Reptile()
            {
                IsColdBlooded = true,
                HasScales = true,
                NumberOfLegs = 4,
                NumberOfLungs = 2
            };

            Console.WriteLine($"The Crocodile has {crocodile.NumberOfLegs} legs and {crocodile.NumberOfLungs} lungs.");
            Console.WriteLine($"T/F: The crocodile is coldblooded?: {crocodile.IsColdBlooded}\nT/F: The crocodile has scales?: {crocodile.HasScales}");
        }
    }
}
