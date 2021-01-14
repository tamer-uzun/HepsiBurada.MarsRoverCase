using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Models
{
    public sealed class Plateau : IPlateau
    {
        public int XLenght { get; set; }
        public int YLenght { get; set; }
        public Plateau(int xLength, int yLength)
        {
            XLenght = xLength;
            YLenght = yLength;
        }

        
    }
}
