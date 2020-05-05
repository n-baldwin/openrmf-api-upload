using Xunit;
using openrmf_upload_api.Data;
using openrmf_upload_api.Models;
using Microsoft.Extensions.Options;

/*
 *  Do note:
 *  These tests will fail without a proper
 *  MongoDB setup locally. Refer to the README
 *  in this repo or https://github.com/Cingulara/openrmf-docs/blob/master/create-users-by-hand.md
 */

namespace tests.Data
{
    public class ArtifactContextTests
    {
        private readonly ArtifactContext _artifactContext;

        public ArtifactContextTests()
        {
            Settings settings = new Settings();
            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            _artifactContext = new ArtifactContext(Options.Create<Settings>(settings));
        }

        [Fact]
        public void Test_ArtifactContextIsValid()
        {
            // Testing
            Assert.False(_artifactContext == null);
            Assert.False(_artifactContext.Artifacts == null);
        }
    }
}
