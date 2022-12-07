using System.Text;

namespace BmiProject.Tests
{
    public class StringBuilderTests
    {
        [Fact]
        public void Append_ForTwoStrings_ReturnConcatedString()
        {
            //arrange -zmienne
            var sb = new StringBuilder();

            //act -funkconjalna

            sb.Append("test").Append("test2");
            string result = sb.ToString();

            //assert - wyniki

            Assert.Equal("testtest2", result);
        }
    }
} 