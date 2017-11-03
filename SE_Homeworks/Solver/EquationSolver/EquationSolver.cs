using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EquationSolver
{
    public static class EquationsSolver
    {

        public static bool ValidationOfEquation(string equation)
        {
            equation = equation.Replace(" ", String.Empty);

            Regex regex = new Regex(@"([+-]?\d+)x\^2([+-]?\d+)x([+-]?\d+)=0");

            if (regex.IsMatch(equation))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int[] ParseString(string equation)
        {
            int[] coef = new int[3];

            equation = equation.Replace("x^2", " ");
            equation = equation.Replace("+", String.Empty);
            equation = equation.Replace("x", " ");
            equation = equation.Replace("  ", " ");
            equation = equation.Substring(0, equation.Length - 2);

            string[] stringCoef = equation.Split(' ');
            for(int i=0; i < 3; i++)
            {
                coef[i] = int.Parse(stringCoef[i]);
            }
            
            return coef;
        }

        public static int FindDescriminant(int[] coefficient)
        {
            int descriminant = coefficient[1] * coefficient[1] - 4 * coefficient[0] * coefficient[2];

            return descriminant;
        }

        public static int DescriminantValidation(int descriminant)
        {
            int typeOfDescriminant;

            if(descriminant < 0)
            {
                typeOfDescriminant = 0;
            }
            else if (descriminant > 0)
            {
                typeOfDescriminant = 2;
            }
            else
            {
                typeOfDescriminant = 1;
            }

            return typeOfDescriminant;
        }


        public static string CalculatingAnswer(int typeOfDescriminant, int descriminant, int[] coefficient)
        {
            double x_1 = (-coefficient[1] + Math.Sqrt(descriminant)) / (2 * coefficient[0]);
            double x_2 = (-coefficient[1] - Math.Sqrt(descriminant)) / (2 * coefficient[0]);
            string answer = "";
            

            if ((typeOfDescriminant == 1) || (typeOfDescriminant == 2))
            {
                answer = x_1 + " " + x_2;

                return answer;
            }
            else
            {
                return answer;
            }
            
        }

        public static string[] OutputOfAnswer(string answer)
        {
            if (answer != "")
            {
                string[] answerList = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                return answerList;
            }
            else
            {
                return new string[]{ "_","_"};
            }
        }
    }
}
