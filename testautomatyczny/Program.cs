using System;
using System.Text;
using Xunit;

namespace testautomatyczny
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public class StringBuilderTests
        {
            public void Append_ForTwoStingd_ReturnContacenatedString()
            {
                // arrange
                StringBuilder sb = new StringBuilder();

                // act
                sb.Append("Test1").Append("Test2");

                string result = sb.ToString();

                // assert
                Assert.Equal("Test1Test2", result);
            }
        }
    }
}
