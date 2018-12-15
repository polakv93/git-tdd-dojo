using System;
using FluentAssertions;
using Xunit;

namespace Math.Tests
{
    public class CalcFixture
    {
        private Action _action;
        private Calc _calc;

        public CalcFixture()
        {
            _calc = new Calc();
        }        

        public void arrange_with_initial_data(int initial)
        {
            _calc.SetInitial(initial);
        }

        public void arrange_without_initial_data() {
            
        }

        public void act()
        {
        }

        public void assert()
        {
            _calc.Result.Should().Be(0);
        }

        internal void assert_should_be(int v)
        {
            _calc.Result.Should().Be(v);
        }

        internal void act_add_to_earlier_value(int v)
        {
            _action = () => _calc.Add(v);
        }

        internal void assert_throw_exception()
        {
            Assert.Throws<Exception>(() => _action.Invoke());
        }
    }
}