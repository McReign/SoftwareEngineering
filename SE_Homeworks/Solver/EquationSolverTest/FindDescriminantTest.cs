using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolver;

namespace EquationSolverTest
{
    [TestClass]
    public class FindDescriminantTest
    {
        [TestMethod]
        public void ThreeCoefficients_shouldBeEqualTheRightDescriminant()
        {
            var coef = new int[]{1,2,3};
            var expected = -8;

            var discriminant = EquationsSolver.FindDescriminant(coef);

            Assert.AreEqual(expected, discriminant);
        }
    }
}
