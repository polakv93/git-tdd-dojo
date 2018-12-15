using System;
using FluentAssertions;
using Xunit;

namespace MathCalc.Tests.CalcTests.calc_add
{
    public class calc_add_fixture : calc_fixture
    {
        internal void act(int v)
        {
            _action = () => _calc.Add(v);
        }
    }
}