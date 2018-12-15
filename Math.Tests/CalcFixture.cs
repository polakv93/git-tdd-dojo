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

        public void arrange_initial_data()
        {
            calc.SetInitial(0);
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