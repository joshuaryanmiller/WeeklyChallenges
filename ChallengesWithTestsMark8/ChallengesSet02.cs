using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Count() % 2 == 0)
            {
                return true;
            }    
            else
            { 
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Sum() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            if (length1 < length2)
            {
                return length1;
            }
            else
            {
                return length2;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Sum() == 0)
            {
                return 0;
            }
            else
            {
                int sumOfEvens = 0;
                foreach (int i in numbers)
                {
                    if ((i % 2) == 0)
                    {
                        sumOfEvens += i;
                    }
                    else
                    {
                        continue;
                    }
                }
                return sumOfEvens;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum() == 0)
            {
                return false; ;
            }
            else if (numbers.Sum()%2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else if (number % 2 == 0)
            {
                return number / 2;
            }
            else
            {
                return (number -= 1) / 2;
            }
        }
    }
}