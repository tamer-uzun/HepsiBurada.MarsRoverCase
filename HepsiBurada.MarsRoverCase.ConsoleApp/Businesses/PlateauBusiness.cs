using HepsiBurada.MarsRoverCase.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Businesses
{
    public class PlateauBusiness : IPlateauBusiness
    {
        public Plateau GetPlateau(string plateauLine)
        {
            string[] coordinates = plateauLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int xCoordinate = Convert.ToInt32(coordinates[0]);
            int yCoordinate = Convert.ToInt32(coordinates[1]);

            return new Plateau(xCoordinate, yCoordinate);
        }
    }
}
