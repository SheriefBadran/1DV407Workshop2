using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoatClub.Controller
{
    class MemberView
    {


        public void Render(Member member)
        {

            Console.WriteLine(member.SocialSecurityNumber);
            Console.WriteLine(member.MemberNumber);
            Console.WriteLine(member.Name);


            foreach (var boat in member.Boats)
            {
                Console.WriteLine(boat);
            }
        }
    }
}
