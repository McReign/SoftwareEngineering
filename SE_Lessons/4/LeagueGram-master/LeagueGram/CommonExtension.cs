using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueGram
{
    public static class CommonExtension
    {
        public static int ToInt(this string str)
        {
            var number = str.ToInt();

            return number;
        }

        public static int Pow(this int number, int power)
        {
            var answer = Math.Pow((double)number, (double) power);

            return (int)answer;
        }

        public static T[] VieldArray<T>(this T input)
        {
            var array = new T[] { input };
            return array;
        }

        public static T[] Add<T>(this T[] input, T item)
        {
            List<T> list = new List<T>(input);
            list.Add(item);
            return list.ToArray();
        }
    }
}
