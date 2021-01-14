using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses;
using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HepsiBurada.MarsRoverCase.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestExpectedOutput()
        {
            List<string> inputLineList = new List<string>() {
            "5 5",
            "1 2 N",
            "LMLMLMLMM"
        };

            IPlanet mars = new Mars();
            IPlateauBusiness plateauBusiness = new PlateauBusiness();
            mars.Plateau = plateauBusiness.GetPlateau(inputLineList[0]);

            IVectorBusiness vectorBusiness = new VectorBusiness();
            IVector vector = vectorBusiness.GetVector(inputLineList[1]);

            IDirectiveBusiness directiveBusiness = new DirectiveBusiness();
            List<Directive> directiveList = directiveBusiness.GetDirectiveList(inputLineList[2]);


            IRover rover = new Rover()
            {
                Vector = vector,
                DirectiveList = directiveList
            };

            mars.RoverList = new List<IRover>() { rover };
            IPlanetBusiness marsBusiness = new MarsBusiness();
            List<IVector> finalRoverVectorList = marsBusiness.GetFinalsVectors(mars);



            string finalVectorOutput = finalRoverVectorList[0].XCoordinate + " " + finalRoverVectorList[0].YCoordinate + " " + finalRoverVectorList[0].Direction;

            Assert.AreEqual("1 3 N", finalVectorOutput);
        }

        [TestMethod]
        public void TestWhetherIfExpectedOutputIsOutside()
        {
            List<string> inputLineList = new List<string>() {
            "5 5",
            "4 4 N",
            "MMMMMM"
        };

            IPlanet mars = new Mars();
            IPlateauBusiness plateauBusiness = new PlateauBusiness();
            mars.Plateau = plateauBusiness.GetPlateau(inputLineList[0]);

            IVectorBusiness vectorBusiness = new VectorBusiness();
            IVector vector = vectorBusiness.GetVector(inputLineList[1]);

            IDirectiveBusiness directiveBusiness = new DirectiveBusiness();
            List<Directive> directiveList = directiveBusiness.GetDirectiveList(inputLineList[2]);


            IRover rover = new Rover()
            {
                Vector = vector,
                DirectiveList = directiveList
            };

            mars.RoverList = new List<IRover>() { rover };
            IPlanetBusiness marsBusiness = new MarsBusiness();
            List<IVector> finalRoverVectorList = marsBusiness.GetFinalsVectors(mars);

            bool hasError = finalRoverVectorList[0].XCoordinate < 0 || finalRoverVectorList[0].XCoordinate > mars.Plateau.XLenght || finalRoverVectorList[0].YCoordinate < 0 || finalRoverVectorList[0].YCoordinate > mars.Plateau.YLenght;

            Assert.IsTrue(hasError);
        }
    }
}
