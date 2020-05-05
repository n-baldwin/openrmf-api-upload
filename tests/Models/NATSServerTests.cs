using NATS.Client;
using System;
using Xunit;
using openrmf_upload_api.Models;

/*
 * This test will only compile and
 * run successfully if a nats-server
 * is running on the local machine
 * (or however you wish to set it
 * up).
 */

namespace tests.Models
{
    public class NATSServerTests
    {
        [Fact]
        public void Test_NewNATSServerIsValid()
        {
            NATSServer nServer = new NATSServer();
            ConnectionFactory cf = new ConnectionFactory();

            nServer.connection = cf.CreateConnection();

            // Testing
            Assert.False(nServer == null);
            Assert.False(nServer.connection == null);
        }
    }
}
