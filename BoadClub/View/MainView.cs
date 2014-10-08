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
            NewMember,
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
                    case "3":
                        return MenuItem.NewMember;
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
            Console.WriteLine("Boat Club Main Menu");
            Console.WriteLine("1. View compact memberlist.");
            Console.WriteLine("2. View detailed memberlist.");
            Console.WriteLine("3. Add new member.");
            Console.WriteLine("Q. Quit");
        }
    }
}
