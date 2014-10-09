using Autofac;
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

            var builder = new ContainerBuilder();
            builder.RegisterType<BoatView>();
            builder.RegisterType<MemberView>();
            builder.RegisterType<MemberListView>();
            builder.RegisterType<MemberController>();
            builder.RegisterType<MemberListController>();
            builder.RegisterType<MemberRepository>();
            builder.RegisterType<MainController>();
            builder.RegisterType<MainView>();
            builder.RegisterType<MemberAdministerView>();
            builder.RegisterType<MemberAdministerController>();
            builder.RegisterType<BoatAdministerController>();
            builder.RegisterType<BoatAdministerView>();
            var injector = builder.Build();

            var mainContoller = injector.Resolve<MainController>();
            mainContoller.Run();
            var memberRepository = new MemberRepository();

            //var boatView = new BoatView();
            //var memberView = new MemberView();
            //var memberListView = new MemberListView(boatView);
            //var memberController = new MemberController(memberView);
            //var memberListController = new MemberListController(memberRepository, memberListView, memberController);
            
            //memberListController.Run();
        }
    }
}
