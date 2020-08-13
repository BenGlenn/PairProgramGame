using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame
{
    class MadLib_Repository
    {
        public string NumOne { get; set; }
        public string NumTwo { get; set; }
        public string PlurlNounOne { get; set; }
        public string PlurlNounTwo { get; set; }
        public string PlurlNounThree { get; set; }
        public string NounNumOne { get; set; }
        public string NounNumTwo { get; set; }
        public string NounNumThree { get; set; }
        public string NounNumFour { get; set; }
        public string AdjNumOne { get; set; }
        public string AdjNumTwo { get; set; }
        public string AdjNumThree { get; set; }
        public string AdjNumFour { get; set; }
        public string AdjNumFive { get; set; }
        public string AdjNumSix { get; set; }
        public string AdjNumSeven { get; set; }
        public string OccNumOne { get; set; }
        public string OccNumTwo { get; set; }
        public string VerbOne { get; set; }
        public string VerbTwo { get; set; }
        public string VerbThree { get; set; }
        public string VerbFour { get; set; }
        public string PlaceOne { get; set; }
        public string PlaceTwo { get; set; }
        public string ActVerbOne { get; set; }
        public string ActVerbTwo { get; set; }
        public string TimeOne { get; set; }
        public string TimeTwo { get; set; }
        public string PossessNounOne { get; set; }

        public string MadLibOne()
        {
            string madLibOne = $"\n" +
                $"\n" +
                $"\n" +
                $"\t\t\tNY IDEAL PRESIDENT\n" +
                $"\n" +
                $"\t There are {NumOne} qualities I admire in a leader.\n" +
                $"\t First, he or she must be {AdjNumOne} Because {VerbOne}\n" +
                $"\t the {NounNumTwo} is a sign of {AdjNumTwo} character.\n" +
                $"\t Second, a good President should be {AdjNumThree}, always\n" +
                $"\t making sure people feel {AdjNumFour} and {AdjNumFive} .\n" +
                $"\t Third, a President represents our Country around the\n " +
                $"\t {PlaceOne} and should be {AdjNumSix} when {VerbTwo} with\n" +
                $"\t other world {PlurlNounOne}.Strength of {NounNumThree},\n" +
                $"\t a good sense of {NounNumFour}, and {AdjNumSeven}\n" +
                $"\t leadership are all things my ideal president would have.\n" +
                $"\n" +
                $"\n" +
                $"\t\t\t\tNICE JOB!";

            return madLibOne;

        }

        public string MadLibTwo()
        {
            string madLibTwo = $"\n" +
                $"\n" +
                $"\n" +
                $"\t\t\tROAD TRIP WITH MY FRIEND\n" +
                $"\n" +
                $"\t  On the {AdjNumOne} trip to {PlaceOne}, my {AdjNumTwo} friend and\n" +
                $"\t  I decided to invent a game. Since this would be a rather {AdjNumThree}\n" +
                $"\t  trip, it would need to be a game with {PlurlNounOne} and {PlurlNounTwo}.\n" +
                $"\t  Using our {NounNumOne} to {VerbOne}, we tried to get the {NounNumTwo}\n" +
                $"\t  next to us to play too, but they just {VerbTwo}ed at us and {ActVerbOne}\n" +
                $"\t  a way. After a few rounds, we thought the game could use some\n" +
                $"\t  {PlurlNounThree} so we turned on the {NounNumThree} and started\n" +
                $"\t  {VerbThree} to the {NounNumFour} that came on. This lasted for\n" +
                $"\t  {TimeOne} before I got {AdjNumFour} and decided to {ActVerbTwo}.\n" +
                $"\t  I'll never {VerbFour} that trip, it was the {AdjNumFive}\n" +
                $"\t  road trip of my {PossessNounOne}.\n" +
                $"\n" +
                $"\n" +
                $"\t\t\t\tNICE JOB!";

            return madLibTwo;

        }

    }

}


