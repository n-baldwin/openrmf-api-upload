using Xunit;
using System;
using System.Threading.Tasks;
using openrmf_upload_api.Data;
using openrmf_upload_api.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;

/*
 *  Do note:
 *  These tests will fail without a proper
 *  MongoDB setup locally. Refer to the README
 *  in this repo or https://github.com/Cingulara/openrmf-docs/blob/master/create-users-by-hand.md
 */

namespace tests.Data
{
    public class ArtifactRepositoryTests
    {
        private readonly ArtifactRepository _artifactRepository;

        public ArtifactRepositoryTests()
        {
            Settings settings = new Settings();
            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            _artifactRepository = new ArtifactRepository(Options.Create<Settings>(settings)); 
        }

        [Fact]
        public async Task Test_ArtifactRepositoryIsValid()
        {
            Artifact artifact = new Artifact();
            ObjectId objId = ObjectId.GenerateNewId();

            artifact.InternalId = objId;

            // Testing
            Assert.False(_artifactRepository == null);

            // For most of these, we just need them to run.
            // If they run at all, then we know nothing happened
            // in the background with things such as configuration.
            // If they fail, however, they'll throw an error.
            await _artifactRepository.GetAllArtifacts();
            await _artifactRepository.AddArtifact(artifact);
            await _artifactRepository.GetArtifact(objId.ToString());
            await _artifactRepository.UpdateArtifact(objId.ToString(), artifact);
            await _artifactRepository.RemoveArtifact(objId.ToString());
        }
    }
}
