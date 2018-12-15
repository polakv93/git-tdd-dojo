using Xunit;

namespace MathCalc.Tests.CalcTests.calc_add
{
    public class calc_add_test
    {
        private calc_add_fixture _fixture;

        public calc_add_test()
        {
            _fixture = new calc_add_fixture();
        }

        [Fact]
        public void increase_new_value__when__add_value_to_earlier_value()
        {
            _fixture.arrange(5);

            _fixture.act(12);

            _fixture.assert_should_be(17);
        }

        [Fact]
        public void throw_exception__when__overflow_max_value_for_type()
        {
            _fixture.arrange(int.MaxValue);

            _fixture.act(1);

            _fixture.assert_throw_exception();
        }

        [Fact]
        public void throw_exception__when__overflow_min_value_for_type()
        {
            _fixture.arrange(int.MinValue);

            _fixture.act(-1);

            _fixture.assert_throw_exception();
        }
    }
}