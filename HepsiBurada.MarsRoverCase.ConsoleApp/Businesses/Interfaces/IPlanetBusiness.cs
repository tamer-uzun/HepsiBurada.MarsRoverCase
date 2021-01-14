using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces
{
    public interface IPlanetBusiness
    {
        public List<IVector> GetFinalsVectors(IPlanet mars);
    }
}
