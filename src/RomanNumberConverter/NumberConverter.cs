namespace RomanNumberConverter
{
    public class NumberConverter
    {
        public string ConvertNumberToRomanNumber(int number)
        {
            if(number ==1 )
            {
                return "I";
            }
            return number == 2 ? "II" : "III";
        }
    }
}