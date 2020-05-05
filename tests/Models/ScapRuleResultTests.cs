using Xunit;
using openrmf_upload_api.Models;

namespace tests.Models
{
    public class ScapRuleResultTests
    {
        [Fact]
        public void Test_NewScapRuleResultIsValid()
        {
            SCAPRuleResult scapRuleResult = new SCAPRuleResult();

            // Testing
            Assert.False(scapRuleResult == null);
        }

        [Fact]
        public void Test_ScapRuleResultWithDataIsValid()
        {
            SCAPRuleResult scapRuleResult = new SCAPRuleResult();

            scapRuleResult.ruleId = "id";
            scapRuleResult.result = "a result";

            // Testing
            Assert.True(scapRuleResult.ruleId == "id");
            Assert.True(scapRuleResult.result == "a result");
        }
    }
}
