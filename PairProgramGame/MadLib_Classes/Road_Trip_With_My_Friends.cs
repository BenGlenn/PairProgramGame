using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame.NewFolder1
{
    class Road_Trip_With_My_Friends
    {
        private readonly MadLib_Repository _madLibRepo = new MadLib_Repository();

        public void MyRoadTrip()
        {
            Console.Write("Enter an adjective: ");
            _madLibRepo.AdjNumOne = Console.ReadLine().ToUpper();
            Console.Write("Enter a place: ");
            _madLibRepo.PlaceOne = Console.ReadLine().ToUpper();
            Console.Write("Enter another adjective: ");
            _madLibRepo.AdjNumTwo = Console.ReadLine().ToUpper();
            Console.Write("Enter another adjective: ");
            _madLibRepo.AdjNumThree = Console.ReadLine().ToUpper();
            Console.Write("Enter a plural noun: ");
            _madLibRepo.PlurlNounOne = Console.ReadLine().ToUpper();
            Console.Write("Enter another plural noun: ");
            _madLibRepo.PlurlNounTwo = Console.ReadLine().ToUpper();
            Console.Write("Enter a noun: ");
            _madLibRepo.NounNumOne = Console.ReadLine().ToUpper();
            Console.Write("Enter a verb: ");
            _madLibRepo.VerbOne = Console.ReadLine().ToUpper();
            Console.Write("Enter another noun: ");
            _madLibRepo.NounNumTwo = Console.ReadLine().ToUpper();
            Console.Write("Enter another verb: ");
            _madLibRepo.VerbTwo = Console.ReadLine().ToUpper();
            Console.Write("Enter an action verb: ");
            _madLibRepo.ActVerbOne = Console.ReadLine().ToUpper();
            Console.Write("Enter another plural noun: ");
            _madLibRepo.PlurlNounThree = Console.ReadLine().ToUpper();
            Console.Write("Enter another noun: ");
            _madLibRepo.NounNumThree = Console.ReadLine().ToUpper();
            Console.Write("Enter a verb that ends with -ing: ");
            _madLibRepo.VerbThree = Console.ReadLine().ToUpper();
            Console.Write("Enter another noun: ");
            _madLibRepo.NounNumFour = Console.ReadLine().ToUpper();
            Console.Write("Enter a time: ");
            _madLibRepo.TimeOne = Console.ReadLine().ToUpper();
            Console.Write("Enter another adjective: ");
            _madLibRepo.AdjNumFour = Console.ReadLine().ToUpper();
            Console.Write("Enter another action verb: ");
            _madLibRepo.ActVerbTwo = Console.ReadLine().ToUpper();
            Console.Write("Enter another verb: ");
                _madLibRepo.VerbFour = Console.ReadLine().ToUpper();
            Console.Write("Enter another adjective: ");
            _madLibRepo.AdjNumFive = Console.ReadLine().ToUpper();
            Console.Write("Enter a possessive noun: ");
            _madLibRepo.PossessNounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Ready to read your MadLib?");
            Console.WriteLine();
            Console.WriteLine($"{_madLibRepo.MadLibTwo()}");
        }
    }
}
