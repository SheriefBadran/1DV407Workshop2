using BoatClub.Model;
using BoatClub.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class BoatAdministerController
    {

        private BoatAdministerView _boatAdministerView;
        private MemberRepository _memberRepository;        

        public BoatAdministerController(MemberRepository memberRepository, BoatAdministerView boatAdministerView)
        {
            _boatAdministerView = boatAdministerView;
            _memberRepository = memberRepository;
        }

        public void Add(Member member)
        {
            Boat boat = new Boat();
            var oldMember = (Member)member.Clone();

            member.Boats.Add(boat);
            _boatAdministerView.Administer(boat);


            _memberRepository.Update(oldMember, member);
        }

        public void Update(Member member, Boat boat)
        {
 
        }

        public void Delete(Member member, Boat boat)
        {

            _memberRepository.Delete(member);
        }
    }
}
