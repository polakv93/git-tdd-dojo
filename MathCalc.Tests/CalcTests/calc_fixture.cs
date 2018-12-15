using FluentAssertions;
using System;

namespace MathCalc.Tests.CalcTests
{
    public class calc_fixture
    {
        protected Calc _calc;
        protected Action _action;

        public calc_fixture()
        {
            _calc = new Calc();
        }

        internal void arrange(int? v = null)
        {
            _calc.SetInitial(v);
        }

        internal void act()
        {

        }

        internal void assert_should_be(int v)
        {
            _action.Invoke();
            _calc.Result.Should().Be(v);
        }

        public void assert_should_throw_exception()
        {
            _action.Should().Throw<Exception>();
        }
    }
}
