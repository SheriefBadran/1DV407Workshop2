using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoatClub.Controller
{
    class BoatAdministerView
    {
        internal Boat Administer(Boat boat)
        {

            string input;
            Console.WriteLine("Enter type of boat: [{0}]", boat.Type);
            boat.Type = BoatType.Canoe;
            //do
            //{
            //    input = Console.ReadLine();

            //    if (input == String.Empty)
            //    {
            //        input = boat;
            //    }

            //    try
            //    {
            //        member.Name = input;
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("You must fill in a name.");
            //    }
            //} while (true);

            do
            {
                Console.WriteLine("Enter boat length: [{0}]", boat.Length);
                input = Console.ReadLine();

                if (input == String.Empty)
                {
                    input = boat.Length.ToString();
                }

                try
                {
                    boat.Length = double.Parse(input);
                    break;
                }
                catch
                {
                    Console.WriteLine("You fill in a social security number.");
                }
            } while (true);

            return boat;
        }
    }
}
