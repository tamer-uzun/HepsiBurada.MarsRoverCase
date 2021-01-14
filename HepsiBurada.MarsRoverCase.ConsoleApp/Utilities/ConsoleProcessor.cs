using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp.Utilities
{
    public static class ConsoleProcessor
    {
        public static string ProcessLine(string message)
        {
            Console.ResetColor();
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        internal static void WriteTestInput(List<string> inputLines)
        {
            Console.Clear();
            Console.WriteLine($"Test Input: \n");
            inputLines.ForEach((x) =>
            {
                Console.WriteLine($"{x}");
            });
        }

        public static void WriteExpectedOutput(List<IVector> finalVectors, IPlateau plateau)
        {
            Console.WriteLine($"Expected Output: \n");
            finalVectors.ForEach((finalVector) =>
            {
                if (finalVector.XCoordinate < 0 || finalVector.XCoordinate > plateau.XLenght || finalVector.YCoordinate < 0 || finalVector.YCoordinate > plateau.YLenght)
                {
                    WriteError($"Final Rover is Outside Of The Plateau => {finalVector.XCoordinate} {finalVector.YCoordinate} {finalVector.Direction}");
                }
                else
                    Console.WriteLine($"{finalVector.XCoordinate} {finalVector.YCoordinate} {finalVector.Direction}");
            });
        }
        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
