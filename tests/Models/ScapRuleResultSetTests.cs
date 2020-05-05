using Xunit;
using openrmf_upload_api.Models;

namespace tests.Models
{
    public class ScapRuleResultSetTests
    {
        [Fact]
        public void Test_NewScapRuleResultSetIsValid()
        {
            SCAPRuleResultSet scapRuleResultSet = new SCAPRuleResultSet();

            // Testing
            Assert.False(scapRuleResultSet == null);
        }

        [Fact]
        public void Test_ScapRuleResultSetWithDataIsValid()
        {
            SCAPRuleResultSet scapRuleResultSet = new SCAPRuleResultSet();

            scapRuleResultSet.title = "title";
            scapRuleResultSet.hostname = "hostname";
            scapRuleResultSet.ipaddress = "address";

            // Testing
            Assert.True(scapRuleResultSet.title == "title");
            Assert.True(scapRuleResultSet.hostname == "hostname");
            Assert.True(scapRuleResultSet.ipaddress == "address");
            Assert.False(scapRuleResultSet.ruleResults == null);
        }
    }
}
