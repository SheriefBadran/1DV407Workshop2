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
            foreach (var member in memberList)
            {
                Console.WriteLine(member.MemberNumber);
                Console.WriteLine(member.SocialSecurityNumber);
                Console.WriteLine(member.Name);

                foreach (var boat in member.Boats)
                {
                    _boatView.Render(boat);
                }
            }
        }
        
    }
}
