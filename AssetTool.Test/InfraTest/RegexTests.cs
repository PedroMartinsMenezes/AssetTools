using System.Text.RegularExpressions;

namespace AssetTool.Test.InfraTest
{
    public class RegexTests : TestBase
    {
        [Theory]
        [InlineData("float x[1] (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, true, true)]
        [InlineData("float y (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, false, true)]
        [InlineData("float z[1]", true, true, false)]
        [InlineData("float w", true, false, false)]
        [InlineData("float name with space", true, false, false)]
        public void DetectFloat(string input, bool hasName, bool hasIndex, bool hasGuid)
        {
            var match = Regex.Match(input, FFloatPropertyJson.Pattern);
            Assert.True(match.Success);
            Assert.Equal(hasName, match.Groups[1].Value.Length > 0);
            Assert.Equal(hasIndex, match.Groups[2].Value.Length > 0);
            Assert.Equal(hasGuid, match.Groups[3].Value.Length > 0);
        }
    }
}
