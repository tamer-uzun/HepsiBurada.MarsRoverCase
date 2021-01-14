using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces
{
    public interface IPlanet
    {
        public IPlateau Plateau { get; set; }
        public List<IRover> RoverList{ get; set; }
    }
}
