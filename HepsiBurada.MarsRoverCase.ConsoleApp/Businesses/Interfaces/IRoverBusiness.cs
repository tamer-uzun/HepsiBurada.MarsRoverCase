using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces
{
    public interface IRoverBusiness
    {
        public Direction TurnRight(Direction direction);
        public Direction TurnLeft(Direction direction);
        public IVector Move(IVector nextVector);
    }
}
