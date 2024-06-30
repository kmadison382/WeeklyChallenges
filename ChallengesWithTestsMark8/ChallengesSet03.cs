using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool result = false;
            foreach (bool val in vals)
            {
                if (val == false)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int oddSum = 0;
            foreach (int num in numbers)
            {
                if (num %2 != 0)
                {
                    oddSum += num;
                }
            }
            bool result = oddSum % 2 != 0;
            return result;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (char letter in password)
            {
                if(Char.IsUpper(letter))
                {
                    hasUpper = true;
                }
                else if(Char.IsLower(letter))
                {
                    hasLower = true;
                }
                else if(Char.IsNumber(letter))
                {
                    hasNumber = true;
                }
            }

            if (hasUpper == true && hasLower == true && hasNumber == true)
            {
                return true;
            }
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] oddsArray = new int[50];
            int index = 0;
            for (int i = 1; i < 100; i += 2)
            {
                oddsArray[index] = i;
                index++;
            }
            return oddsArray;
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            return words;
        }
    }
}
