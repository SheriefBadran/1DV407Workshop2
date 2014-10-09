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
            bool creating = false;

            if (member == null)
            {
                member = new Member();
                creating = true;
            }

            var oldMember = (Member)member.Clone();
            _memberAdministerView.AdministerMember(member);

            if (creating)
            {
                _memberRepository.Add(member);
            }
            else
            {
                _memberRepository.Update(oldMember, member);
            }
        }

        public void Delete(Member member)
        {

            _memberRepository.Delete(member);
        }
    }
}
