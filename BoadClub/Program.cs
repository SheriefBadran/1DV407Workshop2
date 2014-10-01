using BoatClub.Model;
using BoatClub.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member("Sherief", "19800124-5052", 12345);

            member.Name = "Sherief";
            member.MemberNumber = 123456;
            member.SocialSecurityNumber = "19800124-5052";
            member.Boats.Add(new Boat(9.0, Boat.BoatType.Motorsailor));

            MemberRepository memberRep = new MemberRepository();
            memberRep.Add(member);
            

            //MemberRepository memberRep = new MemberRepository();
            //var names = memberRep.GetAll().Select(m=>m.Name);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
