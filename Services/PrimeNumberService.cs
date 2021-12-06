using System;
using System.Collections.Generic;

namespace RSD_II_API.Services
{
    public class PrimeNumberService
    {
        public IList<string> GetNumbers()
        {
            var results = new List<string>();
            var number = 1;

            while (results.Count <= 15000)
            {
                if (IsPrimeNumber(number))
                    results.Add($"{number}");

                number++;
            }

            return results;
        }

        public bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
