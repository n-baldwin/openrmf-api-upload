using Xunit;
using openrmf_upload_api.Models;

namespace tests.Models
{
    public class UploadResultTests
    {
        [Fact]
        public void Test_NewUploadResultIsValid()
        {
            UploadResult uploadResult = new UploadResult();

            // Testing
            Assert.False(uploadResult == null);
        }

        [Fact]
        public void Test_UploadResultWithDataIsValid()
        {
            UploadResult uploadResult = new UploadResult();

            uploadResult.successful = 1;
            uploadResult.failed = 1;

            // Testing
            Assert.True(uploadResult.successful == 1);
            Assert.True(uploadResult.failed == 1);
            Assert.False(uploadResult.failedUploads == null);
        }
    }
}
