using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Utilities
{
    public static class Splitter
    {
        public static string[] SplitIntoStringArray(string splittingString)
        {
            return splittingString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }

        public static char[] SplitIntoCharArray(string splittingString)
        {
            return splittingString.ToCharArray();
        }

        public static List<Directive> SplitIntoEnumArray(string splittingString)
        {
            List<Directive> directiveList = new List<Directive>();
            foreach (var directive in splittingString)
            {
                string directiveString = directive.ToString();
                directiveList.Add((Directive)Enum.Parse(typeof(Directive), directiveString));
            }
            return directiveList;
        }
    }
}
