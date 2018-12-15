using System;
using System.Collections.Generic;
using System.Text;

namespace MathCalc.Tests.CalcTests.calc_percent
{
    class calc_percent_fixture : calc_fixture
    {
        public void act(int v)
        {
            _action = () => _calc.Percent(v);
        }
    }
}
