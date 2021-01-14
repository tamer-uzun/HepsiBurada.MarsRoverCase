using HepsiBurada.MarsRoverCase.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Businesses
{
    public interface IPlateauBusiness
    {
        public Plateau GetPlateau(string plateauLine);
    }
}
