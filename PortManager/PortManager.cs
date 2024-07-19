using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortManager
{
    internal class PortManager
    {
        internal readonly IProcessStarter _processStarter;
        internal readonly IProcessRetriever _processRetriever;

        public PortManager(IProcessStarter processStarter, IProcessRetriever processRetriever)
        {
            _processStarter = processStarter;
            _processRetriever = processRetriever;
        }
        public IEnumerable<PortInfo> GetUsedPorts()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "netstat.exe",
                Arguments = "-a -n -o",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = _processStarter.Start(startInfo);
            if (process == null)
            {
                throw new InvalidOperationException("Failed to start netstat process.");
            }

            using var reader = process.StandardOutput;
            var output = reader.ReadToEnd();

            return ParseNetstatOutput(output);
        }

        public IEnumerable<PortInfo> ParseNetstatOutput(string output)
        {
            var lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                              .SkipWhile(line => !line.StartsWith("  Proto"))
                              .Skip(1);

            return lines.Select(line =>
            {
                var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var protocol = parts[0];
                var localAddressParts = parts[1].Split(':');
                var localAddress = localAddressParts[0];
                var localPort = localAddressParts[1];
                var state = parts.Length > 3 ? parts[3] : "N/A";
                var pid = parts[^1];
                string processName = "N/A";
                try
                {
                    Process process = _processRetriever.GetProcessById(int.Parse(pid));
                    processName = process.ProcessName;
                }
                catch { }
                return new PortInfo
                {
                    Protocol = protocol,
                    LocalAddress = localAddress,
                    LocalPort = localPort,
                    State = state,
                    PID = pid,
                    ProcessName = processName
                };
            }).ToArray();
        }

        public void KillProcessById(int pid)
        {
            Process process = _processRetriever.GetProcessById(pid);
            process.Kill();
        }
    }
}
