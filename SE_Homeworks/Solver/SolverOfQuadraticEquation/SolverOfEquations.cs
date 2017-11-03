using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationSolver;

namespace SolverOfQuadraticEquation
{
    class SolverOfEquations
    {
        static void Main(string[] args)
        {
            string equation;
            string solveTheNextEquation = "next";

            while (solveTheNextEquation.Equals("next"))
            {
                solveTheNextEquation = "-";
                Console.Write("Введите квадратное уравнение в виде ax^2+bx+c=0 : ");
                equation = Console.ReadLine();
                if (EquationsSolver.ValidationOfEquation(equation))
                {
                    int[] coefficient = EquationsSolver.ParseString(equation);

                    if (coefficient[0] != 0)
                    {
                        int descriminant = EquationsSolver.FindDescriminant(coefficient);
                        int typeOfDesc = EquationsSolver.DescriminantValidation(descriminant);
                        string stringAnswer = EquationsSolver.CalculatingAnswer(typeOfDesc, descriminant, coefficient);
                        string[] answer = EquationsSolver.OutputOfAnswer(stringAnswer);

                        if (typeOfDesc == 0)
                        {
                            Console.WriteLine("Нет корней.");
                        }
                        else if (typeOfDesc == 1)
                        {
                            Console.WriteLine("\nУравнение имеет два одинаковых корня : ");
                        }
                        else if (typeOfDesc == 2)
                        {
                            Console.WriteLine("\nУравнение имеет два различных корня : ");
                        }

                        if(!answer[0].Equals("_") && !answer[1].Equals("_"))
                        {
                            Console.WriteLine("\nПервый корень = " + answer[0]);
                            Console.WriteLine("Второй корень = " + answer[1]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не квадратное уравнение!");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели уравнение неверно!");
                }
                Console.WriteLine("\nДля решения следующего уравнения введите 'next'");
                solveTheNextEquation = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
