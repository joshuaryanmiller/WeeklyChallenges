using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int i = startNumber+1;
            while (i % n != 0) i += 1;
            return i;
        }
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0) business.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }
         
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sumFollingAnEven = 0;
            if (numbers == null || numbers.Length == 0) return 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumFollingAnEven += numbers[i + 1];
                }
                else { continue; }
            }
            return sumFollingAnEven;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";
            StringBuilder sentence = new StringBuilder();
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i].Trim().Length == 0) continue;
                else
                {
                    sentence.Append(words[i].Trim());
                    sentence.Append(' ');
                }
            }
            if (sentence.ToString().Length == 0) return "";
            else
            {
                sentence.Append(words[words.Length - 1].Trim());
                sentence.Append(".");
                return sentence.ToString();

            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();
            if (elements != null)
            {
                for (int i = 3; i < elements.Count; i += 4)
                {
                    result.Add(elements[i]);
                }
                return result.ToArray();
            }
            else
            {
                return Array.Empty<double>();
            }
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < (nums.Length - 1); i++)
            {
                for (int j = (i + 1); j < nums.Length; j++)
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
