using System.Collections.Generic;
using System.Linq;

namespace RomanNumberConverter
{
    public class NumberConverter
    {
        public string ConvertNumberToRomanNumber(int number)
        {
            return Map(number);
        }

        private string Map(int number)
        {
            var mapper = new Dictionary<int, string>();
            mapper.Add(1, "I");
            mapper.Add(2, "II");
            mapper.Add(3, "III");
            mapper.Add(4, "IV");
            mapper.Add(5, "V");

            return (from x in mapper where x.Key == number select x.Value).First();
        }
    }
}