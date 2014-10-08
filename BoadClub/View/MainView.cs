using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class MainView
    {
        public enum MenuItem
        {
            CompactList,
            DetailedList,
            Quit
        }

        public MenuItem GetChosenMenuItem()
        {

            var input = String.Empty;
            Console.WriteLine("Enter a number to make a member choice.");

            while (true)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return MenuItem.CompactList;
                    case "2":
                        return MenuItem.DetailedList;
                    case "Q":
                    case "q":
                        return MenuItem.Quit;
                    default:
                        Console.WriteLine("The chosen menu item does not exist");
                        break;
                } 
            }
        }

        public void Render() 
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. View Compact Memberlist.");
            Console.WriteLine("2. View Detailed Memberlist.");
            Console.WriteLine("3. Add New Member.");
            Console.WriteLine("Q. Quit");
        }
    }
}
