using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces
{
    public interface IDirectiveBusiness
    {
        public List<Directive> GetDirectiveList(string directivesLine);
        Queue<Directive> GetDirectiveQueue(List<Directive> directiveList);
    }
}
