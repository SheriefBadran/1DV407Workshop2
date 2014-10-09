using BoatClub.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class MemberListView
    {

        private BoatView _boatView;

        public MemberListView(BoatView boatView)
        {
            _boatView = boatView;
        }

        public void RenderCompact(IEnumerable<Member> memberList)
        {
            int count = 0;
            foreach (var member in memberList)
            {
                count++;
                Console.WriteLine("Member {0}:", count);
                Console.WriteLine("MemberID: {0}", member.MemberNumber);
                Console.WriteLine("Name: {0}", member.Name);
                Console.WriteLine("Boats: {0}", member.Boats.Count);
                Console.WriteLine();
            }
        }

        public void RenderDetailed(IEnumerable<Member> memberList)
        {

            int count = 0;
            foreach (var member in memberList)
            {
                count++;
                Console.WriteLine("Member {0}:", count);
                Console.WriteLine("Name: {0}", member.Name);
                Console.WriteLine("Social security number: {0}", member.SocialSecurityNumber);
                Console.WriteLine("Member number: {0}", member.MemberNumber);

                foreach (var boat in member.Boats)
                {
                    _boatView.Render(boat);
                }

                Console.WriteLine();
            }
        }

        public Member GetChosenMember(List<Member> memberList)
        {

            var input = String.Empty;
            int selected;
            var validInput = false;

            Console.WriteLine("Enter a number to view corresponding member.");
            Console.WriteLine("Press R to return.");
            do
            {   
                input = Console.ReadLine();

                if (input == "r" || input == "R")
                {
                    return null;
                }

                if (int.TryParse(input, out selected))
                {
                    if (selected <= memberList.Count() || selected > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Chosen member does not exist");
                    }
                }
                else
                {
                    validInput = false;
                    Console.WriteLine("You need to write a number");
                }
            } while (!validInput);

            return memberList[selected - 1];

        }
        
    }
}
