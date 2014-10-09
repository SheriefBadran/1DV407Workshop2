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
        private MemberAdministerController _memberAdministerController;
        public MemberController(MemberView memberView, MemberAdministerController memberAdministerController)
        {
            _memberView = memberView;
            _memberAdministerController = memberAdministerController;
        }

        public void Run(Member member)
        {
            do
            {
                _memberView.Render(member);

                switch (_memberView.GetChosenMenuItem())
                {
                    case MemberView.MenuItem.Edit:
                        _memberAdministerController.Run(member);
                        break;
                    case MemberView.MenuItem.Delete:
                        _memberAdministerController.Delete(member);
                        return;
                    case MemberView.MenuItem.Return:
                        return;
                    default:
                        throw new NotImplementedException("Menu item not implemented in MemberController.");
                }
            } while (true);
        }
    }
}
