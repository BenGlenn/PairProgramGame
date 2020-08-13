using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame.NewFolder1
{
    class My_Ideal_President
    {
        private readonly MadLib_Repository _madLibRepository = new MadLib_Repository();
     

        public void MyIdealPresident()
        {
            Console.Write("Enter any number: ");
            _madLibRepository.NumOne = Console.ReadLine();

            Console.Write("That's great. Now enter an Adjective. Like bald, huge, green or itchy: ");
            _madLibRepository.AdjNumOne = Console.ReadLine().ToUpper();

            Console.Write("Excellent! Now enter a Verb. Like Slip, Throw, Wash, or Tolerate: ");
            _madLibRepository.VerbOne = Console.ReadLine().ToUpper();

            Console.Write("Perfect! Now enter a Noun. Like Plate, Ball, or Car: ");
            _madLibRepository.NounNumTwo = Console.ReadLine().ToUpper();

            Console.Write("Now enter another Adjective: ");
            _madLibRepository.AdjNumTwo = Console.ReadLine().ToUpper();

            Console.Write("That's great. Give me another Adjective: ");
            _madLibRepository.AdjNumThree = Console.ReadLine().ToUpper();

            Console.Write("Give me one more Adjective: ");
            _madLibRepository.AdjNumFour = Console.ReadLine().ToUpper();

            Console.Write("Make it two more Adjective: ");
            _madLibRepository.AdjNumFive = Console.ReadLine().ToUpper();

            Console.Write("You are almost done! Now enter a Place. Like Minnesota, Bathroom, Mejier, or Casino: ");
            _madLibRepository.PlaceOne = Console.ReadLine().ToUpper();

            Console.Write("I need another of of those Adjectives: ");
            _madLibRepository.AdjNumSix = Console.ReadLine().ToUpper();

            Console.Write("WOW! You are on a roll. I need a few more from you. Give me a Verb: ");
            _madLibRepository.VerbTwo = Console.ReadLine().ToUpper();

            Console.Write("Now enter a Plurl Noun. For example cars, dishes, mice, or geese: ");
            _madLibRepository.PlurlNounOne = Console.ReadLine().ToUpper();

            Console.Write("Give me another one of those regular Nouns: ");
            _madLibRepository.NounNumThree = Console.ReadLine().ToUpper();

            Console.Write("I need one more Noun. ");
            _madLibRepository.NounNumFour = Console.ReadLine().ToUpper();

            Console.Write("Finally the last one! Give me one more Adjective: ");
            _madLibRepository.AdjNumSeven = Console.ReadLine().ToUpper();

            Console.WriteLine();
            Console.WriteLine("Perfect. Let me add it into my MadLib Mania Machine...");
            Console.WriteLine("DONE! Press any key to see your results...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"{ _madLibRepository.MadLibOne()}");
            Console.WriteLine();
            Console.WriteLine("\t\t\tLETS DO SOME MORE!");
            Console.WriteLine("\t\t\tPress Any Key To Continue");
            Console.ReadKey();

         

       
        }


    }
}
