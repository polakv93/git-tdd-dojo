using System;
using FluentAssertions;

namespace MathCalc.Tests.CalcTests.calc_init
{
    internal class calc_init_fixture : calc_fixture
    {
        internal void assert()
        {
            _calc.Result.Should().Be(0);
        }
    }
}