using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var containsWord = false;

            if (words == null)
            {
                return containsWord;
            }

            foreach (var item in words)
            {
                if (item == null)
                {
                    continue;
                }

                if (!ignoreCase)
                {
                    if (item == word)
                    {
                        containsWord = true;
                    }
                }
                else
                {
                    if (item.ToLower() == word.ToLower())
                    {
                        containsWord = true;
                    }
                }
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            var isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var uIndex = -1;
            for (int i = 0; i < str.Length; i++)
            {
                var unique = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        unique = false;
                    }
                }

                if (unique)
                {
                    uIndex = i;
                }
            }

            return uIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var countTwo = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        countTwo++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (countTwo > count)
                {
                    count = countTwo;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n < 1)
            {
                return new double[] {};
            }

            List<double> nthElements = new List<double>();
            
            for (int i = n - 1; i < elements.Count; i+=n)
            {
                nthElements.Add(elements[i]);
            }
            return nthElements.ToArray();
        }
    }
}
