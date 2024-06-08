using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXUnit1.Tests
{
    public class DivisionOnZero
    {
        [Fact]
        public void DivisionMustReturnException()
        {
            var division = new Division();
            Assert.Throws<DivideByZeroException>(()=>division.DivisionOnZero(10,0));
        }
    }
}
