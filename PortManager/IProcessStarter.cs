using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortManager
{
    public interface IProcessStarter
    {
        public Process Start(ProcessStartInfo startInfo)
        {
            var process = Process.Start(startInfo);
            if (process == null)
            {
                throw new InvalidOperationException("Failed to start the process.");
            }
            return process;
        }
    }
}
