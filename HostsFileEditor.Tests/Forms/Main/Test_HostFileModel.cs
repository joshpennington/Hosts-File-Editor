using System.Net;
using System.Security.Policy;

using HostsFileEditor.Forms.Main;
using HostsFileEditor.Tests.Properties;

using NUnit.Framework;

namespace HostsFileEditor.Tests.Forms.Main
{
    /// <summary>
    /// Test fixture for the HostsFileModel.
    /// </summary>
    [TestFixture]
    public sealed class Test_HostFileModel
    {
        public IHostFileModel Model
        {
            get;
            set;
        }

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            this.Model = new HostFileModel(Resources.hosts);
        }

        [Test]
        public void AddEntry()
        {
            var ipAddress = IPAddress.Parse("127.0.0.1");
            var url = new Url("http://localhost/");

            this.Model.AddEntry(ipAddress, url);
            Assert.That(this.Model.ContainsEntry(ipAddress, url));
            Assert.That(this.Model.IndexOf(ipAddress, url), Is.EqualTo(this.Model.Length - 1));
        }
    }
}