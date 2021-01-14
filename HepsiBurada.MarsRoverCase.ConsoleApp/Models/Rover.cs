using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Models
{
    public sealed class Rover : IRover
    {
        public IVector Vector { get; set; }
        public List<Directive> DirectiveList { get; set; }
    }
}
