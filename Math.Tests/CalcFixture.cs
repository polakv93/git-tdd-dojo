using FluentAssertions;

namespace Math.Tests
{
    public class CalcFixture
    {
        private Calc calc;

        public CalcFixture()
        {
            calc = new Calc();
        }        

        public void arrange_with_initial_data()
        {
            calc.SetInitial(0);
        }

        public void arrange_without_initial_data() {
            
        }

        public void act()
        {

        }

        public void assert()
        {
            calc.Result.Should().Be(0);
        }
    }
}