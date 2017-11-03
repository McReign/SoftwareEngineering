using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolver;

namespace EquationSolverTest
{
    [TestClass]
    public class ParseStringTest
    {
        [TestMethod]
        public void Equation_shouldGiveRightArguments_1()
        {
            string equation = "2x^2+7x-22=0";
            int[] expected = { 2, 7, -22 };

            int[] coef = EquationsSolver.ParseString(equation);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected[i], coef[i]);
            }
        }

        [TestMethod]
        public void Equation_shouldGiveRightArguments_2()
        {
            string equation = "-8x^2+7x-22=0";
            int[] expected = { -8, 7, -22 };

            int[] coef = EquationsSolver.ParseString(equation);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected[i], coef[i]);
            }
        }

        [TestMethod]
        public void Equation_shouldGiveRightArguments_3()
        {
            string equation = "2x^2+7x-0=0";
            int[] expected = { 2, 7, 0 };

            int[] coef = EquationsSolver.ParseString(equation);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected[i], coef[i]);
            }
        }

        [TestMethod]
        public void Equation_shouldGiveRightArguments_4()
        {
            string equation = "1x^2+7x+-22=0";
            int[] expected = { 1, 7, -22 };

            int[] coef = EquationsSolver.ParseString(equation);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected[i], coef[i]);
            }
        }

        [TestMethod]
        public void Equation_shouldGiveRightArguments_5()
        {
            string equation = "19x^2+0x-22=0";
            int[] expected = { 19, 0, -22 };

            int[] coef = EquationsSolver.ParseString(equation);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected[i], coef[i]);
            }
        }
    }
}
