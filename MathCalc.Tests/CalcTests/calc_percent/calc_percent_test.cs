using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MathCalc.Tests.CalcTests.calc_percent
{
    class calc_percent_test
    {
        private calc_percent_fixture _fixture = new calc_percent_fixture();
        
        [Fact]
        public void return_same_value__when__calculate_100_percent()
        {
            _fixture.arrange(150);

            _fixture.act(100);

            _fixture.assert_should_be(150);
        }

        [Fact]
        public void return_zero__when__calculate_0_percent()
        {
            _fixture.arrange(100);

            _fixture.act(0);

            _fixture.assert_should_be(0);
        }

        [Fact]
        public void throw_exception__when__try_calculate_less_0_value()
        {
            _fixture.arrange(100);

            _fixture.act(-50);

            _fixture.assert_should_throw_exception();
        }

        [Fact]
        public void throw_exception__when__try_calculate_greater_than_100_percent()
        {
            _fixture.arrange(100);

            _fixture.act(200);

            _fixture.assert_should_throw_exception();
        }
    }
}
