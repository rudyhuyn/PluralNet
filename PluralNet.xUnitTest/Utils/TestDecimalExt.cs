using Huyn.PluralNet.Utils;

namespace PluralNet.Core.Test.Utils
{
    public class TestDecimalExt
    {
        [Theory]
        [InlineData("1", "1", "5")]
        [InlineData("3", "1", "5")]
        [InlineData("3.5", "1", "5")]
        [InlineData("5", "1", "5")]
        public void IsBetween(string s, string s1, string s2)
        {
            decimal number = Decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
            decimal start = Decimal.Parse(s1, System.Globalization.CultureInfo.InvariantCulture);
            decimal end = Decimal.Parse(s2, System.Globalization.CultureInfo.InvariantCulture);

            Assert.True(number.IsBetween(start, end));
        }

        [Theory]
        [InlineData("0", "1", "5")]
        [InlineData("0.999", "1", "5")]
        [InlineData("5.01", "1", "5")]
        [InlineData("6", "1", "5")]
        public void IsNotBetween(string s, string s1, string s2)
        {
            decimal number = Decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
            decimal start = Decimal.Parse(s1, System.Globalization.CultureInfo.InvariantCulture);
            decimal end = Decimal.Parse(s2, System.Globalization.CultureInfo.InvariantCulture);

            Assert.False(number.IsBetween(start, end));
        }

        [Theory]
        [InlineData("1", "1", "5")]
        [InlineData("3", "1", "5")]
        [InlineData("3.5", "1", "5")]
        public void IsBetweenEndNotIncluded(string s, string s1, string s2)
        {
            decimal number = Decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
            decimal start = Decimal.Parse(s1, System.Globalization.CultureInfo.InvariantCulture);
            decimal end = Decimal.Parse(s2, System.Globalization.CultureInfo.InvariantCulture);

            Assert.True(number.IsBetweenEndNotIncluded(start, end));
        }

        [Theory]
        [InlineData("0", "1", "5")]
        [InlineData("0.999", "1", "5")]
        [InlineData("5", "1", "5")]
        [InlineData("5.01", "1", "5")]
        [InlineData("6", "1", "5")]
        public void IsNotBetweenEndNotIncluded(string s, string s1, string s2)
        {
            decimal number = Decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
            decimal start = Decimal.Parse(s1, System.Globalization.CultureInfo.InvariantCulture);
            decimal end = Decimal.Parse(s2, System.Globalization.CultureInfo.InvariantCulture);

            Assert.False(number.IsBetweenEndNotIncluded(start, end));
        }


        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("3")]
        [InlineData("-3")]
        public void IsInt(string s)
        {
            decimal number = Decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
            Assert.True(((decimal)number).IsInt());
        }

        [Theory]
        [InlineData("0.999")]
        [InlineData("5.01")]
        [InlineData("-0.999")]
        public void IsNotInt(string s)
        {
            decimal number = Decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
            Assert.False(((decimal)number).IsInt());
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 0)]
        [InlineData("3", 0)]
        [InlineData("-3", 0)]
        [InlineData("0.999", 3)]
        [InlineData("5.00", 2)]
        [InlineData("5.01", 2)]
        [InlineData("-0.999", 3)]
        [InlineData("-5.999", 3)]
        public void GetNumberOfDigitsAfterDecimal(string s, uint expected)
        {
            decimal number = Decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
            Assert.Equal(expected, number.GetNumberOfDigitsAfterDecimal());
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 0)]
        [InlineData("3", 0)]
        [InlineData("-3", 0)]
        [InlineData("0.999", 999)]
        [InlineData("5.01", 1)]
        [InlineData("-0.999", 999)]
        [InlineData("-5.999", 999)]
        public void DigitsAfterDecimal(string s, long expected)
        {
            decimal number = Decimal.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
            Assert.Equal(expected, number.DigitsAfterDecimal());
        }

    }
}