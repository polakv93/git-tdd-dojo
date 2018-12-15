using Xunit;

namespace Math.Tests.CalcTests.calc_divide
{
    public class calc_divide_test
    {
        private calc_divide_fixture _fixture;

        public calc_divide_test()
        {
            _fixture = new calc_divide_fixture();
        }

        [Fact]
        public void value_must_be_correct__when__division_value_with_new_value()
        {
            _fixture.arrange(20);

            _fixture.act(5);

            _fixture.assert_should_be(4);

        }
    }
}