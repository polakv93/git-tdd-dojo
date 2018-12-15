using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Math.Tests.CalcTests.calc_exp
{
    class calc_exp_test
    {
        private calc_exp_fixture _fixture;

        public calc_exp_test()
        {
            _fixture = new calc_exp_fixture();
        }

        [Fact]
        public void return_value_1__when__exponentiation_to_0()
        {
            _fixture.arrange(20);

            _fixture.act(0);

            _fixture.assert_should_be(1);

        }

        [Fact]
        public void return_same_value__when__exponentiation_to_1()
        {
            _fixture.arrange(25);

            _fixture.act(1);

            _fixture.assert_should_be(25);
        }

        [Fact]
        public void return_correct_value__when__exponentiation()
        {
            _fixture.arrange(3);

            _fixture.act(4);

            _fixture.assert_should_be(81);
        }
    }
}
