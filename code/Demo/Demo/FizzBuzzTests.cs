﻿using FluentAssertions;
using Xunit;

namespace Demo
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzz _sut;

        public FizzBuzzTests()
        {
            _sut = new FizzBuzz();
        }
        
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        public void FizzBuzz_should_return_correct_result(int input, string expectedResult)
        {
            _sut.Parse(input).Should().Be(expectedResult);
        }
    }
}