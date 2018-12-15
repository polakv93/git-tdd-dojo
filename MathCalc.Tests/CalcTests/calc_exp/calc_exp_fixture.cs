using FluentAssertions;
using System;

namespace MathCalc.Tests.CalcTests.calc_exp
{
    class calc_exp_fixture
    {
        private Calc _calc;
        private Action _action;

        public calc_exp_fixture()
        {
            _calc = new Calc();
        }

        internal void arrange(int v)
        {
            _calc.SetInitial(v);
        }

        internal void act(int v)
        {
            _action = () => _calc.Exp(v);
        }

        internal void assert_should_be(int v)
        {
            _action.Invoke();
            _calc.Result.Should().Be(v);
        }

        internal void assert_should_throw_exceptin()
        {
            _action.Should().Throw<Exception>();
        }
    }
}
