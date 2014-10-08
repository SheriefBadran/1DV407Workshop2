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
            foreach (var member in memberList)
            {
                Console.WriteLine(member.MemberNumber);
                Console.WriteLine(member.Name);
                Console.WriteLine(member.Boats.Count);
            }
        }

        public void RenderDetailed(IEnumerable<Member> memberList)
        {

            int count = 0;
            foreach (var member in memberList)
            {
                count++;
                Console.WriteLine("Member {0}:", count);
                Console.WriteLine("{0}({1}): {2}", member.Name, member.SocialSecurityNumber, member.MemberNumber);

                foreach (var boat in member.Boats)
                {
                    _boatView.Render(boat);
                }
            }
        }

        public Member GetChosenMember(List<Member> memberList)
        {

            var input = String.Empty;
            int selected;
            var validInput = false;

            Console.WriteLine("Enter a number to view corresponding member.");
            do
            {   
                input = Console.ReadLine();
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
