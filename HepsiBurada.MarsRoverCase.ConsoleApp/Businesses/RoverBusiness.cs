using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Businesses
{
    public class RoverBusiness : IRoverBusiness
    {
        public IVector Move(IVector nextVector)
        {
            switch (nextVector.Direction)
            {
                case Direction.N:
                    nextVector.YCoordinate += 1; 
                    break;
                case Direction.E:
                    nextVector.XCoordinate += 1;
                    break;
                case Direction.S:
                    nextVector.YCoordinate -= 1;
                    break;
                case Direction.W:
                    nextVector.XCoordinate -= 1;
                    break;
                default:
                    break;
            }
            return nextVector;
        }

        public Direction TurnLeft(Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    direction = Direction.W;
                    break;
                case Direction.E:
                    direction = Direction.N;
                    break;
                case Direction.S:
                    direction = Direction.E;
                    break;
                case Direction.W:
                    direction = Direction.S;
                    break;
                default:
                    break;
            }
            return direction;
        }

        public Direction TurnRight(Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    direction = Direction.E;
                    break;
                case Direction.E:
                    direction = Direction.S;
                    break;
                case Direction.S:
                    direction = Direction.W;
                    break;
                case Direction.W:
                    direction = Direction.N;
                    break;
                default:
                    break;
            }
            return direction;
        }
    }
}
