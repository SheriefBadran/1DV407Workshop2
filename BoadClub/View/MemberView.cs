﻿using BoatClub.Model;
using BoatClub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoatClub.Controller
{
    class MemberView
    {

        public enum MenuItem
        {
            Edit,
            Delete,
            AddBoat,
            Return
        }

        private BoatView _boatView;

        public MemberView(BoatView boatView)
        {
            _boatView = boatView;
        }

        public void Render(Member member)
        {

            Console.WriteLine();
            Console.WriteLine("Name: {0}", member.Name);
            Console.WriteLine("Social security number: {0}", member.SocialSecurityNumber);
            Console.WriteLine("Member number: {0}", member.MemberNumber);


            foreach (var boat in member.Boats)
            {
                _boatView.Render(boat);
            }

            Console.WriteLine();
            Console.WriteLine("Press E to edit member.");
            Console.WriteLine("Press D to delete member.");
            Console.WriteLine("Press B to add a boat");
            Console.WriteLine("Press R to return.");
        }

        public MenuItem GetChosenMenuItem()
        {

            var input = String.Empty;

            while (true)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "E":
                    case "e":
                        return MenuItem.Edit;
                    case "D":
                    case "d":
                        return MenuItem.Delete;
                    case "B":
                    case "b":
                        return MenuItem.AddBoat;
                    case "R":
                    case "r":
                        return MenuItem.Return;
                    default:
                        Console.WriteLine("The chosen menu item does not exist");
                        break;
                }
            }
        }
    }
}
