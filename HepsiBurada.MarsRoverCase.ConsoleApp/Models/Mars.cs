using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Models
{
    public sealed class Mars : IPlanet
    {
        public IPlateau Plateau { get; set; }
        public List<IRover> RoverList { get; set; }
        public Mars()
        {
            RoverList = new List<IRover>();
        }
    }
}
