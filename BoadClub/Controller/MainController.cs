using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.Controller
{
    class MainController
    {
        private MemberListController _memberListController;
        private MemberAdministerController _memberAdministerController;
        private MainView _mainView;

        public MainController(MemberListController memberListController, 
                              MemberAdministerController memberAdministerController, 
                              MainView mainView) 
        {
            _memberListController = memberListController;
            _memberAdministerController = memberAdministerController;
            _mainView = mainView;
        }

        public void Run()
        {
            do
            {
                _mainView.Render();

                switch (_mainView.GetChosenMenuItem())
                {
                    case MainView.MenuItem.CompactList:
                        _memberListController.Run();
                        break;
                    case MainView.MenuItem.DetailedList:
                        _memberListController.Run(detailed: true);
                        break;
                    case MainView.MenuItem.NewMember:
                        _memberAdministerController.Run();
                        break;
                    case MainView.MenuItem.Quit:
                        return;
                    default:
                        throw new NotImplementedException("Menu item not implemented in MainController.");
                } 
            } while (true);
        }
    }
}
