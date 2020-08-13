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
            Console.Write("Enter any number. ");
            _madLibRepository.NumOne = Console.ReadLine();
            Console.Write("That's great. Now enter an Adjective. ");
            _madLibRepository.AdjNumOne = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter a Verb. ");
            _madLibRepository.VerbOne = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter a Noun. ");
            _madLibRepository.NounNumTwo = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter an Adjective. ");
            _madLibRepository.AdjNumThree = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter an Adjective. ");
            _madLibRepository.AdjNumFour = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter an Adjective. ");
            _madLibRepository.AdjNumFive = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter a Place. ");
            _madLibRepository.PlaceOne = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter an Adjective. ");
            _madLibRepository.AdjNumSix = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter a Verb. ");
            _madLibRepository.VerbTwo = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter a Plurl Noun. ");
            _madLibRepository.PlurlNounOne = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter a Noun. ");
            _madLibRepository.NounNumThree = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter a Noun. ");
            _madLibRepository.NounNumFour = Console.ReadLine().ToUpper();
            Console.Write("That's great. Now enter an Adjective. ");
            _madLibRepository.AdjNumSeven = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine("Perfect. Let me add it into my madlib");
            Console.Clear();
            Console.WriteLine($"{ _madLibRepository.MadLibOne()}");
            Console.WriteLine("LETS DO SOME MORE!");
            Console.WriteLine("Select from the following options:|n" +
                "\t 1. Try a NEW Madlib.\n" +
                "\t 2. Try this one again.\n");


            Console.ReadLine();
        }


    }
}
