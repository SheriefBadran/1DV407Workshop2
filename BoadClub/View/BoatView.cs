using BoatClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatClub.View
{
    class BoatView
    {
        private readonly Dictionary<BoatType, string> _boatTypeNames =
            new Dictionary<BoatType, string> {
                {BoatType.Canoe , "Canoe"},
                {BoatType.Motorboat , "Motorboat"},
                {BoatType.Motorsailor, "Motorsailor"},
                {BoatType.Other, "Oter"},
                {BoatType.Sailboat, "Sailboat"}
            };

        public BoatView()
        {
            int enumLength = Enum.GetNames(typeof(BoatType)).Count();
            if (enumLength != _boatTypeNames.Count())
            {
                throw new Exception("Boattypes enum length must equal boatTypeNames dictionary lenght.");
            }
        }

        public void Render(Boat boat)
        {

            Console.WriteLine(_boatTypeNames[boat.Type]);
            Console.WriteLine(boat.Length);
        }
    }
}
