using Xunit;
using openrmf_upload_api.Models;
using System;
using MongoDB.Bson;

namespace test.Models
{
    public class SystemGroupTests
    {
        [Fact]
        public void Test_NewSystemGroupIsValid()
        {
            SystemGroup sysGroup = new SystemGroup();

            // Testing
            Assert.False(sysGroup == null);
        }

        [Fact]
        public void Test_SystemGroupWithDataIsValid()
        {
            SystemGroup sysGroup = new SystemGroup();

            sysGroup.InternalId = ObjectId.GenerateNewId();
            sysGroup.title = "title";
            sysGroup.description = "description";
            sysGroup.numberOfChecklists = 5;
            sysGroup.rawNessusFile = "A raw file";
            sysGroup.lastComplianceCheck = DateTime.Now;
            sysGroup.created = DateTime.Now;
            sysGroup.updatedOn = DateTime.Now;
            sysGroup.createdBy = Guid.NewGuid();
            sysGroup.updatedBy = Guid.NewGuid();

            // Testing
            Assert.True(sysGroup.title == "title");
            Assert.True(sysGroup.description == "description");
            Assert.True(sysGroup.numberOfChecklists == 5);
            Assert.True(sysGroup.rawNessusFile == "A raw file");
            Assert.False(sysGroup.InternalId == null);
            Assert.False(sysGroup.lastComplianceCheck == null);
            Assert.False(sysGroup.created == null);
            Assert.False(sysGroup.updatedOn == null);
            Assert.False(sysGroup.createdBy == null);
            Assert.False(sysGroup.updatedBy == null);
        }
    }
}
