using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Businesses
{
    public class VectorBusiness : IVectorBusiness
    {
        public Vector GetVector(string vectorLine)
        {
            string[] vectorArray = Splitter.SplitIntoStringArray(vectorLine);
            Direction direction = (Direction)Enum.Parse(typeof(Direction), vectorArray[2]);
            Vector vector = new Vector()
            {
                XCoordinate = Convert.ToInt32(vectorArray[0]),
                YCoordinate = Convert.ToInt32(vectorArray[1]),
                Direction = direction
            };
            return vector;
        }
    }
}
