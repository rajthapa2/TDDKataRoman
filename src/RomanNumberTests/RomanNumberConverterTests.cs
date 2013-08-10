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
     
      [TestCase(1,"I")]  
      [TestCase(2,"II")]  
      [TestCase(3,"III")]  
      [TestCase(4,"IV")]  
      public void ShouldMapNumberToRomanNumber(int number, string romanNumber)
      {
          Assert.That(_numberConverter.ConvertNumberToRomanNumber(number), Is.EqualTo(romanNumber));
      }
//        [Test]
//        public void ShouldReturnRomanNumberIIWhen2IsPassed()
//        {
//            Assert.That(_numberConverter.ConvertNumberToRomanNumber(2), Is.EqualTo("II"));
//        }
//
//        [Test]
//        public void ShouldReturnRomanNumberIIIWhen3IsPassed()
//        {
//            Assert.That(_numberConverter.ConvertNumberToRomanNumber(3), Is.EqualTo("III"));
//        }
//
//        [Test]
//        public void ShouldReturnEmptyStringWhenInvalidNumberIsPassed()
//        {
//            Assert.That(_numberConverter.ConvertNumberToRomanNumber(4),Is.EqualTo(""));
//        }
    }
}
