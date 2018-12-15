using System;
using FluentAssertions;

namespace MathCalc.Tests.CalcTests.calc_init
{
    internal class calc_init_fixture
    {
        private Calc _calc;
        public calc_init_fixture()
        {
            _calc = new Calc();
        }

        internal void act()
        {

        }

        internal void arrange(int? v = null)
        {
            _calc.SetInitial(v);
        }

        internal void assert()
        {
            _calc.Result.Should().Be(0);
        }
    }
}