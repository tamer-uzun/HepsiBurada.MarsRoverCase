using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp
{
    public class Validator
    {
        public static void ValidatePlateauCoordinatesLine(string plateauCoordinatesLine)
        {
            if (string.IsNullOrWhiteSpace(plateauCoordinatesLine) || plateauCoordinatesLine.Length < 3)
                throw new Exception("Plateau Coordinates Line Must Include X Length,Y Length Informations with White-Spaces Between Them");
            else if (plateauCoordinatesLine.StartsWith(" "))
                throw new Exception("Plateau Coordinates Line Must Start with X Lenght Information");
            else if (plateauCoordinatesLine.EndsWith(" "))
                throw new Exception("Plateau Coordinates Line Must End with Y Lenght Information");
            else if (plateauCoordinatesLine.Substring(0, 1).Any(x => char.IsLetter(x)))
                throw new Exception("X Coordinate Must Be Digit");
            else if (plateauCoordinatesLine.Substring(plateauCoordinatesLine.Length - 1, 1).Any(x => char.IsLetter(x)))
                throw new Exception("Y Coordinate Must Be Digit");
            else if (!plateauCoordinatesLine.Contains(" "))
                throw new Exception("Plateau Coordinates Line Must Contain Only X Length, White-Space Between and Y Length");
            else if (plateauCoordinatesLine.Count(x => char.IsWhiteSpace(x)) > 1)
                throw new Exception("Plateau Coordinates Line Must Contain only 1 White-Space Between Coordinate X Length and Y Length");
        }
        public static void ValidateInitialVectorLine(string startingVectorLine)
        {
            if (string.IsNullOrWhiteSpace(startingVectorLine) || startingVectorLine.Length < 5)
                throw new Exception("Initial Vector Line Must Include X,Y Position and Direction Informations with White-Spaces Between Them");
            else if (startingVectorLine.StartsWith(" "))
                throw new Exception("Initial Vector Line Must Start with X Information");
            else if (startingVectorLine.EndsWith(" "))
                throw new Exception("Initial Vector Line Must End with Y Information");
            else if (startingVectorLine.Substring(0, 1).Any(x => char.IsLetter(x)))
                throw new Exception("Initial X Coordinate Must Be Digit");
            else
            {
                string lastLetter = startingVectorLine.Substring(startingVectorLine.Length - 1, 1);
                if (lastLetter.Any(x => char.IsDigit(x)))
                    throw new Exception("The Direction Must Be Letter");
                if (lastLetter != lastLetter.ToUpper())
                    throw new Exception("The Direction Letter Must Be Capital");
            }
            if (!startingVectorLine.Contains(" "))
                throw new Exception("Initial Vector Line Must Contain White-Space Between X,Y Starting Points and Directions");
            else if (startingVectorLine.Count(x => char.IsWhiteSpace(x)) != 2)
                throw new Exception("Initial Vector Line Must Contain only 2 White-Spaces");
        }
        public static void ValidateMovementsLine(string movementsLine)
        {
            if (string.IsNullOrWhiteSpace(movementsLine))
                throw new Exception("Movements Line Must Include Directives of M,R or L");
            else if (movementsLine.Contains(" "))
                throw new Exception("Movements Line Must Not Contain White-Spaces");
            else if (movementsLine.Any(x => char.IsDigit(x)))
                throw new Exception("Movements Line Must Include Only Letter");
            else if (movementsLine != movementsLine.ToUpper())
                throw new Exception("The Movement Directives Must Be Capital");
            else
            {
                foreach (var movement in movementsLine)
                {
                    string movementString = movement.ToString();
                    if (!Enum.IsDefined(typeof(Directive), movementString))
                        throw new Exception("Movements Line Must Include Only Directives Of R,L,M");
                }

            }
        }
        public static void ValidateAnswer(string answer)
        {
            if (string.IsNullOrWhiteSpace(answer) || answer.Contains(" ") || answer.Length != 1 || (answer != "Y" && answer != "N"))
                throw new Exception("Please Enter Only Capital 'Y' or 'N'");
        }
    }
}
