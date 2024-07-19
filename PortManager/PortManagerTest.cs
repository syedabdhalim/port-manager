using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortManager;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework.Legacy;
using Moq;

namespace PortManager
{
    [TestFixture]
    public class PortManagerTests
    {
        private Mock<IProcessStarter>? _processStarterMock;
        private Mock<IProcessRetriever>? _processRetrieverMock;
        private PortManager? _portManager;

        [SetUp]
        public void SetUp()
        {
            _processStarterMock = new Mock<IProcessStarter>();
            _processRetrieverMock = new Mock<IProcessRetriever>();
            _portManager = new PortManager(_processStarterMock.Object, _processRetrieverMock.Object);
        }
        [Test]
        public void ParseNetstatOutput_ValidOutput_ReturnsCorrectPortInfo()
        {
            // Arrange
            string netstatOutput = @"
  Proto  Local Address          Foreign Address        State           PID
  TCP    0.0.0.0:80             0.0.0.0:0              LISTENING       1234
  TCP    127.0.0.1:443          0.0.0.0:0              LISTENING       5678";

            var expectedPorts = new List<PortInfo>
            {
                new PortInfo { Protocol = "TCP", LocalAddress = "0.0.0.0", LocalPort = "80", State = "LISTENING", PID = "1234", ProcessName = "N/A" },
                new PortInfo { Protocol = "TCP", LocalAddress = "127.0.0.1", LocalPort = "443", State = "LISTENING", PID = "5678", ProcessName = "N/A" }
            };

            var result = _portManager?.ParseNetstatOutput(netstatOutput)?.ToList();
            ClassicAssert.AreEqual(expectedPorts.Count, result?.Count);
            for (int i = 0; i < expectedPorts.Count; i++)
            {
                ClassicAssert.AreEqual(expectedPorts[i].Protocol, result?[i].Protocol);
                ClassicAssert.AreEqual(expectedPorts[i].LocalAddress, result?[i].LocalAddress);
                ClassicAssert.AreEqual(expectedPorts[i].LocalPort, result?[i].LocalPort);
                ClassicAssert.AreEqual(expectedPorts[i].State, result?[i].State);
                ClassicAssert.AreEqual(expectedPorts[i].PID, result?[i].PID);
            }
        }

        [Test]
        public void KillProcessById_InvalidPid_ThrowsException()
        {
            int invalidPid = -1;
            _processRetrieverMock?.Setup(p => p.GetProcessById(invalidPid)).Throws(new ArgumentException("Invalid PID"));
            ClassicAssert.Throws<ArgumentException>(() => _portManager?.KillProcessById(invalidPid));
        }
    }
}