using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolver;

namespace EquationSolverTest
{
    [TestClass]
    public class CalculatingAnswerTest
    {
        [TestMethod]
        public void Equation_shouldBeEqualRightAnswer()
        {
            string equation = "4x^2+6x+2=0";
            int[] coef = new int[] { 4, 6, 2 };
            string expected = "-0,5 -1";

            string answer = EquationsSolver.CalculatingAnswer
                (EquationsSolver.DescriminantValidation(EquationsSolver.FindDescriminant(coef)), 
                        EquationsSolver.FindDescriminant(coef), EquationsSolver.ParseString(equation));

            Assert.AreEqual(expected, answer);
        }
    }
}
