using System;
using FluentAssertions;
using Xunit;

namespace Math.Tests.CalcTests.calc_add
{
    public class calc_add_fixture
    {
        private Calc _calc;
        private Action _action;

        public calc_add_fixture()
        {
            _calc = new Calc();
        }

        internal void arrange(int v)
        {
            _calc.SetInitial(v);
        }

        internal void act(int v)
        {
            _action = () => _calc.Add(v);
        }

        internal void assert_should_be(int v)
        {
            _action.Invoke();
            _calc.Result.Should().Be(v);
        }

        internal void assert_throw_exception()
        {
            _action.Should().ThrowExactly<OverflowException>();
        }
    }
}