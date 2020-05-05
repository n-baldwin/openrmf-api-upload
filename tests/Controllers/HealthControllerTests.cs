using System;
using Xunit;
using openrmf_upload_api.Controllers;
using openrmf_upload_api.Data;
using openrmf_upload_api.Models;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;

namespace tests.Controllers
{

    public class HealthControllerTests
    {
        private readonly Mock<ILogger<HealthController>> _mockLogger;
        private readonly HealthController _healthController; 
        private readonly Mock<ISystemGroupRepository> _mocksystemGroupRepo;

        public HealthControllerTests() {
            Settings settings = new Settings();
            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            SystemGroupRepository sysGroupRepo = new SystemGroupRepository(Options.Create<Settings>(settings));

            _mockLogger = new Mock<ILogger<HealthController>>();
            _healthController = new HealthController(sysGroupRepo, _mockLogger.Object);
        }

        [Fact]
        public void Test_HealthControllerIsValid()
        {
            Assert.True(_healthController != null);
        }

        [Fact]
        public void Test_HealthControllerGetIsValid()
        {
            var result = _healthController.Get();
            Assert.True(_healthController != null);
            //Assert.Equal(200, ((Microsoft.AspNetCore.Mvc.ObjectResult)result.Result).StatusCode); // returns a status code HTTP 200
        }
    }
}
