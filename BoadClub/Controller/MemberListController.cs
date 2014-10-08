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
        private MemberController _memberController;

        
        public MemberListController(MemberRepository memberRepository, 
                                    MemberListView memberListView, 
                                    MemberController memberController) 
        {
            _memberRepository = memberRepository;
            _memberListView = memberListView;
            _memberController = memberController;
        }
        
        public void Run(bool detailed = false)
        {

            while (true)
            {
                var memberList = _memberRepository.GetAll();

                if (detailed)
                {
                    _memberListView.RenderDetailed(memberList);
                }
                else
                {
                    _memberListView.RenderCompact(memberList);
                }
                var member = _memberListView.GetChosenMember(memberList.ToList());

                if (member != null)
                {
                    _memberController.Run(member);
                }
                else 
                {
                    return;
                } 
            }
        }
    }
}
