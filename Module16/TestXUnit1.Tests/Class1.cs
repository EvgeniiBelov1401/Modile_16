﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestXUnit1.Tests
{
    public class Class1
    {
        [Fact]
        public void TestVoid()
        {
            Assert.True(100==100);
        }
    }
}
