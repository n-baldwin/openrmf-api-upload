using Xunit;
using openrmf_upload_api.Models;
using System;

namespace tests.Models
{
    public class AuditTests
    {
        [Fact]
        public void Test_NewAuditIsValid()
        {
            Audit audit = new Audit();

            // Testing
            Assert.False(audit == null);
        }

        [Fact]
        public void Test_AuditWithDataIsValid()
        {
            Audit audit = new Audit();

            audit.program = "A program";
            audit.created = DateTime.Now;
            audit.action = "An action";
            audit.userid = "User id";
            audit.username = "username";
            audit.fullname = "fullname";
            audit.email = "email";
            audit.url = "url";
            audit.message = "message";

            // Testing
            Assert.True(audit.program == "A program");
            Assert.True(audit.action == "An action");
            Assert.True(audit.userid == "User id");
            Assert.True(audit.username == "username");
            Assert.True(audit.fullname == "fullname");
            Assert.True(audit.email == "email");
            Assert.True(audit.url == "url");
            Assert.True(audit.message == "message");
            Assert.False(audit.created == null);
        }
    }
}
