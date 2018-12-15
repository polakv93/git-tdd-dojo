using Xunit;

namespace Math.Tests
{
    public class CalcTests
    {
        private CalcFixture _fixture;
        public CalcTests()  
        {
            _fixture = new CalcFixture();
        }

        [Fact]
        public void return_0__when__set_initial_data_to_0_and_expression_contains_only_init_data()
        {
            _fixture.arrange_with_initial_data();

            
            _fixture.act();


            _fixture.assert();
        }

        [Fact]
        public void default_set_to_0__when__init_without_initial_data()
        {
            _fixture.arrange_without_initial_data();

            _fixture.act();

            _fixture.assert();
        }
    }
}