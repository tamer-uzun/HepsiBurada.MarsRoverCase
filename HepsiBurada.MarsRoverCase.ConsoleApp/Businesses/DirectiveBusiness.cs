using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using HepsiBurada.MarsRoverCase.ConsoleApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Businesses
{
    public class DirectiveBusiness : IDirectiveBusiness
    {
        public List<Directive> GetDirectiveList(string directivesLine)
        {
            List<Directive> directiveList = Splitter.SplitIntoEnumArray(directivesLine);
            return directiveList;
        }

        public Queue<Directive> GetDirectiveQueue(List<Directive> directiveList)
        {
            Queue<Directive> directiveQueue = new Queue<Directive>();
            directiveList.ForEach((directive) =>
            {
                directiveQueue.Enqueue(directive);
            });

            return directiveQueue;
        }
    }
}
