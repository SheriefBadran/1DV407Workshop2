using BoatClub.Controller;
using BoatClub.Model;
using BoatClub.Model.Repositories;
using BoatClub.View;
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

            var memberRepository = new MemberRepository();

            var boatView = new BoatView();
            var memberListView = new MemberListView(boatView);
            var memberListController = new MemberListController(memberRepository, memberListView);

            memberListController.Run();
        }
    }
}
