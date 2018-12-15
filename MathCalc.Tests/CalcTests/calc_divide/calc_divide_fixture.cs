using System;
using FluentAssertions;
using Xunit;

namespace MathCalc.Tests.CalcTests.calc_divide
{
    public class calc_divide_fixture : calc_fixture
    {
        internal void act(int v)
        {
            _action = () => _calc.Divide(v);
        }
    }
}