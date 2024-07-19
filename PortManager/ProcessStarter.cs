using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortManager
{
    internal class ProcessStarter:IProcessStarter
    {
        public Process Start(ProcessStartInfo startInfo)
        {
            return Process.Start(startInfo);
        }
    }
}
