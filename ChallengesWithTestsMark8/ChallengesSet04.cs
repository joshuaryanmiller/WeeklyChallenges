using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (int n in numbers) if (n%2 == 0){result += n;} else {result -= n;}
            return result;
        }
       
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] stringLengths = {str1.Length, str2.Length, str3.Length, str4.Length};
            return stringLengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public string ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            return biz.Name;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] numbers = {sideLength1, sideLength2, sideLength3};
            int sumOfTwoSmallestSides = numbers.Sum() - numbers.Max();
            if (sumOfTwoSmallestSides <= numbers.Max()) return false;
            else { return true; }

        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out _);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            foreach (object element in objs) if (element == null) nullCount = nullCount += 1;
            if (nullCount > (objs.Count() - nullCount)) return true;
            else { return false; }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            List<double> evensList = new List<double>();
            foreach (double i in numbers) if (i%2==0) evensList.Add(i);
            if (evensList == null) return 0;
            else if (evensList.Count > 0) return evensList.Average();
            else { return 0;}
        }

        public int Factorial(int number)
        {
            int n = Convert.ToInt32(number);
            if (number < 0) throw new ArgumentOutOfRangeException();
            else if (number == 0) return 1;
            else { return n * Factorial(n - 1); }
        }
    }
}
