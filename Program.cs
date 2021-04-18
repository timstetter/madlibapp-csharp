using System;

namespace MadLibApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tim's MadLib App\nPlease enter words as requested and the story will print out as you go along! ");


            //Get the inputs
            Console.WriteLine("\nPlease enter an adjective:");
            string adjective1 = Console.ReadLine();

            Console.WriteLine("Please enter an noun:");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Please enter a verb: past tense");
            string verb1 = Console.ReadLine();

            Console.WriteLine("Please enter an adverb:");
            string adverb1 = Console.ReadLine();

            Console.WriteLine("Please enter an adjective:");
            string adjective2 = Console.ReadLine();

            Console.WriteLine("Please enter an noun:");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Please enter an noun:");
            string noun3 = Console.ReadLine();

            Console.WriteLine("Please enter an adjective:");
            string adjective3 = Console.ReadLine();

            Console.WriteLine("Please enter a verb:");
            string verb2 = Console.ReadLine();

            Console.WriteLine("Please enter an adverb:");
            string adverb2 = Console.ReadLine();

            Console.WriteLine("Please enter a verb: past tense");
            string verb3 = Console.ReadLine();

            Console.WriteLine("Please enter an adjective:\n");
            string adjective4 = Console.ReadLine();


            //Print the story
            Console.WriteLine($"Today I went to the zoo.  I saw a {adjective1} {noun1} jumping up and down in its tree.");
            Console.WriteLine($"He {verb1} {adverb1} through the large tunnel that led to its {adjective2} {noun2}.");
            Console.WriteLine($"I got some peanuts and passed them through the cage to a gigantic gray {noun3} towering above my head.");
            Console.WriteLine("Feeding that animal made me hungry.");
            Console.WriteLine($"I went to get a {adjective3} scoop of ice cream.");
            Console.WriteLine("It filled my stomach");
            Console.WriteLine($"Afterwards I had to {verb2} {adverb2} to catch our bus.");
            Console.WriteLine($"When I got home I {verb3} my mom for a {adjective4} day at the zoo");
            //Keep the console open
            Console.ReadLine();
        }
    }
}
