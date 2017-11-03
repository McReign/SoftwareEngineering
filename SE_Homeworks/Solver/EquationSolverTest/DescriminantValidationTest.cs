using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolver;

namespace EquationSolverTest
{
    [TestClass]
    public class DescriminantValidationTest
    {
        [TestMethod]
        public void Descriminant_shouldHaveRightTypeOfDescriminant_1()
        {
            int descriminant = 16;
            int expected = 2;

            int typeOfDesc = EquationsSolver.DescriminantValidation(descriminant);

            Assert.AreEqual(typeOfDesc, expected);
        }

        [TestMethod]
        public void Descriminant_shouldHaveRightTypeOfDescriminant_2()
        {
            int descriminant = -45;
            int expected = 0;

            int typeOfDesc = EquationsSolver.DescriminantValidation(descriminant);

            Assert.AreEqual(typeOfDesc, expected);
        }

        [TestMethod]
        public void Descriminant_shouldHaveRightTypeOfDescriminant_3()
        {
            int descriminant = 0;
            int expected = 1;

            int typeOfDesc = EquationsSolver.DescriminantValidation(descriminant);

            Assert.AreEqual(typeOfDesc, expected);
        }
    }
}
