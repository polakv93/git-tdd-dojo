using FluentAssertions;
using System;

namespace MathCalc.Tests.CalcTests.calc_exp
{
    class calc_exp_fixture : calc_fixture
    {
        internal void act(int v)
        {
            _action = () => _calc.Exp(v);
        }
    }
}
