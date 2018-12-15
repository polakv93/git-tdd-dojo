using System;
using FluentAssertions;
using Xunit;

namespace Math.Tests.CalcTests.calc_divide
{
    public class calc_divide_fixture
    {
        private Calc _calc;
        private Action _action;

        public calc_divide_fixture()
        {
            _calc = new Calc();
        }

        internal void arrange(int v)
        {
            _calc.SetInitial(v);
        }

        internal void act(int v)
        {
            _calc.Divide(v);
        }

        internal void assert_should_be(int v)
        {
            _calc.Result.Should().Be(v);
        }
    }
}