using BoatClub.Model;
using BoatClub.Model.Repositories;
using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class MemberAdministerController
    {
        private MemberAdministerView _memberAdministerView;
        private MemberRepository _memberRepository;

        public MemberAdministerController(MemberAdministerView memberAdministerView, MemberRepository memberRespository)
        {
            _memberAdministerView = memberAdministerView;
            _memberRepository = memberRespository;
        }

        public void Run(Member member=null)
        {
            if (member == null)
            {
                member = new Member();
            }

            var oldMember = (Member)member.Clone();
            var updatedMember = _memberAdministerView.AdministerMember(member);
            _memberRepository.Save(oldMember, updatedMember);
        }
    }
}
