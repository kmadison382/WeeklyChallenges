using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                var mod = number % 2;
                result = (mod == 0) ? result += number : result -= number;
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] listStrings = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };
            return listStrings.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new int[] { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] sides = new int[] { sideLength1, sideLength2, sideLength3 }.OrderBy(side => side).ToArray();
            if (sides.Contains(0)) { return false; }
            var triangle = sides[0] + sides[1] > sides[2];
            return triangle;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _) == true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        { 
            var objGroups = objs.GroupBy(obj => obj).OrderByDescending(g => g.Count()).ToList();
            var isNull = false;
            if (objGroups.Count > 1)
            {
                isNull = objGroups[0].Count() != objGroups[1].Count() && objGroups[0].Key == null;
            }
            else if (objGroups[0].Key == null)
            {
                isNull = true;
            }
            return isNull;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) { return 0; }
            var onlyEvens = numbers.Where(number => number % 2 == 0);
            return onlyEvens.DefaultIfEmpty().Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var answer = 1;
            while (number > 0)
            {
                answer *= number;
                number--;
            }
            return answer;
        }
    }
}
