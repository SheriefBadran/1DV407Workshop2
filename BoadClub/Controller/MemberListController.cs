using BoatClub.Model.Repositories;
using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class MemberListController
    {
        private MemberRepository _memberRepository;
        private MemberListView _memberListView;

        
        public MemberListController(MemberRepository memberRepository, MemberListView memberListView) 
        {
            _memberRepository = memberRepository;
            _memberListView = memberListView;
        }
        
        public void Run()
        {

            var memberList =_memberRepository.GetAll();
            //_memberListView.RenderCompact(memberList);
            _memberListView.RenderDetailed(memberList);
        }
    }
}
