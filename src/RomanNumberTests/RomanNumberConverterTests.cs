using NUnit.Framework;
using RomanNumberConverter;

namespace RomanNumberTests
{
    [TestFixture] 
    public class RomanNumberConverterTests
    {
        private NumberConverter _numberConverter;
      
        [SetUp]
        public void  SetUp()
        {
         _numberConverter = new NumberConverter();
        }
     
      [Test]  
      public void ShouldReturnRomanNumberIWhen1IsPassed()
      {
          Assert.That(_numberConverter.ConvertNumberToRomanNumber(1), Is.EqualTo("I"));
      }
        [Test]
        public void ShouldReturnRomanNumberIIWhen2IsPassed()
        {
            Assert.That(_numberConverter.ConvertNumberToRomanNumber(2), Is.EqualTo("II"));
        }

        [Test]
        public void ShouldReturnRomanNumberIIIWhen3IsPassed()
        {
            Assert.That(_numberConverter.ConvertNumberToRomanNumber(3), Is.EqualTo("III"));
        }
    }
}
