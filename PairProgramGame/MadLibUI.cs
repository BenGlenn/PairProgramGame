using PairProgramGame.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame
{
    class MadLibUI
    {
        private bool _isRunning = true;
        private readonly My_Ideal_President _My_Ideal_President = new My_Ideal_President();
        private readonly Road_Trip_With_My_Friends _Road_Trip = new Road_Trip_With_My_Friends();

        public void Start()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            while (_isRunning)
            {
                string userImput = GetMenuSelection();
                OpenMenuItem(userImput);
            }

        }

        public string GetMenuSelection()
        {
            Console.Clear();
            Console.WriteLine(
                       "Welcome to MadLib Mania!!!\n" +
                       "Select from the menu below:\n" +
                       "1. My Ideal President.\n" +
                       "2. Road Trip with my Friend.\n" +
                       "3. COMMING SOON.\n" +
                       "4. Exit Game.");

            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    _My_Ideal_President.MyIdealPresident();
                    break;
                case "2":
                    _Road_Trip.MyRoadTrip();
                    break;

            }
            Console.ReadKey();
            return;

        }

    }

}

