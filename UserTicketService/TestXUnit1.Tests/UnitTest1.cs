namespace TestXUnit1.Tests
{
    public class DivisionValue
    {
        [Fact]
        public void ValueOfDivision()
        {
            var division = new Division();
            Assert.True(division.DivisionValue(10, 5) == 2);
        }
        
    }
}