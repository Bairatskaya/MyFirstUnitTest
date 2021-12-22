using System;
using Xunit;
using calculator._21._12.unit;

namespace test.calculat
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-3, -4, -7)]
        [InlineData(5.99, 4.01, 10.00)]
        public void Test1(double a, double b, double expected)
        {
            double actual = Metod_calculat.Plus(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(10, 9, 1)]
        [InlineData(-10, -5, -5)]
        [InlineData(10.99, 0.99, 10)]
        public void Test2(double a, double b, double expected)
        {
            double actual = Metod_calculat.Minus(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-3, -4, 12)]
        [InlineData(0.6, 0.7, 0.42)]
        public void Test3(double a, double b, double expected)
        {
            double actual = Metod_calculat.Multiply(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-25, -5, 5)]
        [InlineData(0.3, 0.3, 1)]
        public void Test4(double a, double b, double expected)
        {
            double actual = Metod_calculat.Divide(a, b);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(25, 5 )]
        [InlineData(256, 16)]
        [InlineData(0.16, 0.4)]
        public void Test5(double a, double expected)
        {
            double actual = Metod_calculat.Square(a);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test6()
        {
            double a = 20;
            double b = 0;
            Action act = () => Metod_calculat.Divide(a, b);
            Assert.Throws<DivideByZeroException>(act);
           
        }
        [Fact]
        public void Test7()
        {
            double a = -20;
            Action act = () => Metod_calculat.Square(a);
            Assert.Throws<ArgumentException>(act);
           
        }

    }
}
