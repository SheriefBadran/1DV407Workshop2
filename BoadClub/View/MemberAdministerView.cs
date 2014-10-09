using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class MemberAdministerView
    {

        public void Administer(Member member)
        {

            string input;
            Console.WriteLine("Enter name: [{0}]", member.Name);
            do
            {
                input = Console.ReadLine();

                if (input == String.Empty)
                {
                    input = member.Name;
                }

                try
                {
                    member.Name = input;
                    break;
                }
                catch
                {
                    Console.WriteLine("You must fill in a name.");
                } 
            } while (true);

            do
            {
                Console.WriteLine("Enter social security number: [{0}]", member.SocialSecurityNumber);
                input = Console.ReadLine();

                if (input == String.Empty)
                {
                    input = member.SocialSecurityNumber;
                }

                try
                {
                    member.SocialSecurityNumber = input;
                    break;
                }
                catch
                {
                    Console.WriteLine("You fill in a social security number.");
                }
            } while (true);
        }

        public string input { get; set; }
    }
}
