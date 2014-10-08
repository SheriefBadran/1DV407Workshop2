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
        private MainView _mainView;

        public MainController(MemberListController memberListController, MainView mainView) 
        {
            _memberListController = memberListController;
            _mainView = mainView;
        }

        public void Run()
        {
            _mainView.Render();

            switch (_mainView.GetChosenMenuItem())
            {
                case MainView.MenuItem.CompactList:
                    break;
                case MainView.MenuItem.DetailedList:
                    break;
                case MainView.MenuItem.Quit:
                    break;
                default:
                    throw new NotImplementedException("Menu item not implemented in MainController.");
            }
        }
    }
}
