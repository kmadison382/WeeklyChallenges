using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var nextNumber = startNumber + 1;
            while (nextNumber % n != 0)
            {
                nextNumber++;
            }
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers is null)
            {
                return false;
            }
            else if (numbers.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers is null)
            {
                return 0;
            }
            
            var summed = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    summed += numbers[i];
                }
            }
            return summed;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words is null || words.Length < 1)
            {
                return "";
            }

            var sentence = "";
            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            sentence = sentence.Trim();

            if (sentence.Length > 0)
            {
                sentence += ".";
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements is null || elements.Count < 1)
            {
                return new double[0];
            }
            List<double> fourths = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                fourths.Add(elements[i]);
            }
            return fourths.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
