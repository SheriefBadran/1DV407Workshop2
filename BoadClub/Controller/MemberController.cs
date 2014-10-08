using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class MemberController
    {

        private MemberView _memberView;

        public MemberController(MemberView memberView)
        {
            _memberView = memberView;
        }

        public void Run(Member member)
        {

            _memberView.Render(member);
        }
    }
}
