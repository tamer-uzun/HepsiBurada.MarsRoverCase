using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Businesses
{
    public class MarsBusiness : IPlanetBusiness
    {
        public IRoverBusiness _roverBusiness;
        public IDirectiveBusiness _directiveBusiness;
        public MarsBusiness ()
        {
            _roverBusiness = new RoverBusiness();
            _directiveBusiness = new DirectiveBusiness();
        }
        public List<IVector> GetFinalsVectors(IPlanet mars)
        {
            List<IVector> finalVectorList = new List<IVector>();
            
            foreach (var rover in mars.RoverList)
            {
                Queue<Directive> directiveQueue = _directiveBusiness.GetDirectiveQueue(rover.DirectiveList);

                while (directiveQueue.Count>0)
                {
                    Directive directive = directiveQueue.Dequeue();
                    switch (directive)
                    {
                        case Directive.R:
                            rover.Vector.Direction = _roverBusiness.TurnRight(rover.Vector.Direction);
                            break;
                        case Directive.L:
                            rover.Vector.Direction = _roverBusiness.TurnLeft(rover.Vector.Direction);
                            break;
                        case Directive.M:
                            rover.Vector = _roverBusiness.Move(rover.Vector);
                            break;
                        default:
                            break;
                    }
                }
                finalVectorList.Add(rover.Vector);
            }

            return finalVectorList;
        }

        public static Queue<IRover> BuildRoverQueue(List<IRover> roverList)
        {
            Queue<IRover> operationQueue = new Queue<IRover>();
            roverList.ForEach((x) =>
            {
                operationQueue.Enqueue(x);
            });
            return operationQueue;
        }
    }
}
