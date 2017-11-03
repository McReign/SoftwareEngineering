using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolver;

namespace EquationSolverTest
{
    [TestClass]
    public class ValidationOfEquationTest
    {
        [TestMethod]
        public void QuadraticEquation_shouldBeCorrect_1()
        {
            string equation = "12x^2-16x-27=0";
            bool expected = true;

            bool validationResult = EquationsSolver.ValidationOfEquation(equation);

            Assert.AreEqual(expected, validationResult);
        }

        [TestMethod]
        public void QuadraticEquation_shouldBeCorrect_2()
        {
            string equation = "12x^2-16y-27=0";
            bool expected = false;

            bool validationResult = EquationsSolver.ValidationOfEquation(equation);

            Assert.AreEqual(expected, validationResult);
        }
    }
}
