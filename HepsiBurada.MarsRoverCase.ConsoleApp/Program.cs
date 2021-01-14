using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses;
using HepsiBurada.MarsRoverCase.ConsoleApp.Businesses.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Enums;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models;
using HepsiBurada.MarsRoverCase.ConsoleApp.Models.Interfaces;
using HepsiBurada.MarsRoverCase.ConsoleApp.Utilities;
using System;
using System.Collections.Generic;

namespace HepsiBurada.MarsRoverCase.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            
            bool done = false;
            int roverCount = 1;
            string lineReaded;
            int lineNumberReaded = 0;

            Processor processor = new Processor();
            while (!done)
            {
                lineNumberReaded += 1;
                try
                {
                    switch (lineNumberReaded)
                    {
                        case 1:
                            lineReaded = ConsoleProcessor.ProcessLine("Please Enter the Coordinates of Plateau");
                            processor.ProcessPlateauLine(lineReaded);
                            break;
                        case 2:
                            lineReaded = ConsoleProcessor.ProcessLine($"Please Enter the {roverCount}. Initial Vector Informations");
                            processor.ProcessVectorLine(lineReaded);
                            break;
                        case 3:
                            lineReaded = ConsoleProcessor.ProcessLine($"Please Enter the {roverCount}. Movement Directives");
                            processor.ProcessDirectiveLine(lineReaded);
                            break;
                        case 4:
                            lineReaded = ConsoleProcessor.ProcessLine("Would You Like to Start Process or Continue to Enter? Y/N");
                            processor.ProcessQuestionLine(lineReaded);
                            
                            if (lineReaded == "Y")
                            {
                                processor.ProcessCalculationOfFinalVectors();
                                done = true;
                            }
                            else if (lineReaded == "N")
                            {
                                lineNumberReaded = 1;
                                roverCount += 1;
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    ConsoleProcessor.WriteError(ex.Message);
                    lineNumberReaded -= 1;
                }
            }
            
            Console.ReadKey();
        }
    }
}
