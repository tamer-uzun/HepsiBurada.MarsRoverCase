using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses;
using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRoverCase.ConsoleApp
{
    public class Processor
    {
        private readonly IPlanet _mars;
        private IVector _vector;
        private List<Directive> _directiveList;
        private readonly List<IRover> _roverList;
        private readonly List<string> _inputLines;
        public Processor()
        {
            _mars = new Mars();
            _vector = new Vector();
            _directiveList = new List<Directive>();
            _roverList = new List<IRover>();
            _inputLines = new List<string>();
        }
        public void ProcessPlateauLine(string plateauLine)
        {
            Validator.ValidatePlateauCoordinatesLine(plateauLine);
            
            IPlateauBusiness plateauBusiness = new PlateauBusiness();
            _mars.Plateau = plateauBusiness.GetPlateau(plateauLine);
            _inputLines.Add(plateauLine);
        }
        public void ProcessVectorLine(string vectorLine)
        {
            Validator.ValidateInitialVectorLine(vectorLine);
            IVectorBusiness vectorBusiness = new VectorBusiness();
            _vector = vectorBusiness.GetVector(vectorLine);
            _inputLines.Add(vectorLine);
        }

        public void ProcessDirectiveLine(string directiveLine)
        {
            Validator.ValidateMovementsLine(directiveLine);
            IDirectiveBusiness directiveBusiness = new DirectiveBusiness();
            _directiveList = directiveBusiness.GetDirectiveList(directiveLine);
            _inputLines.Add(directiveLine);
        }
        public void ProcessQuestionLine(string questionLine)
        {
            Validator.ValidateAnswer(questionLine);
            IRover rover = new Rover()
            {
                Vector = _vector,
                DirectiveList = _directiveList
            };

            _roverList.Add(rover);
        }
        public void ProcessCalculationOfFinalVectors()
        {
            _mars.RoverList = _roverList;
            IPlanetBusiness marsBusiness = new MarsBusiness();
            List<IVector> finalVectorList = marsBusiness.GetFinalsVectors(_mars);
            ConsoleProcessor.WriteTestInput(_inputLines);
            ConsoleProcessor.WriteExpectedOutput(finalVectorList, _mars.Plateau);
        }


    }
}
