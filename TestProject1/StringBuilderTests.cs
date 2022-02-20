using System;
using System.Text;
using Xunit;

namespace TestProject1
{

        public class StringBuilderTests
        {
            [Fact]
            public void Append_ForTwoStingd_ReturnContacenatedString()
            {
                // arrange
                StringBuilder sb = new StringBuilder();

                // act
                sb.Append("Test1").Append("Test2");

                string result = sb.ToString();

                // assert
                Assert.Equal("TestTest2", result);
            }
        }    
}
