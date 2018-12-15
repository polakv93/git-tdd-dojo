using Xunit;

namespace Math.Tests.CalcTests.calc_init
{
    public class calc_init_test
    {
        private calc_init_fixture _fixture;

        public calc_init_test()
        {
            _fixture = new calc_init_fixture();
        }

        [Fact]
        public void return_0__when__set_initial_data_to_0_and_expression_contains_only_init_data()
        {
            _fixture.arrange(0);

            
            _fixture.act();


            _fixture.assert();
        }

        [Fact]
        public void default_set_to_0__when__init_without_initial_data()
        {
            _fixture.arrange();

            _fixture.act();

            _fixture.assert();
        }
    }
}