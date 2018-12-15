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

            _fixture.acts();

            _fixture.assert();
        }

        [Fact]
        public void increase_new_value__when__add_value_to_earlier_value()
        {
            _fixture.arrange_with_initial_data(5);

            _fixture.act_add_to_earlier_value(12);

            _fixture.assert_should_be(17);
        }

        [Fact]
        public void throw_exception__when__overflow_max_value_for_type()
        {
            _fixture.arrange_with_initial_data(int.MaxValue);

            _fixture.act_add_to_earlier_value(1);

            _fixture.assert_throw_exception();
        }
    }
}