using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortManager
{
    internal class ProcessRetriever: IProcessRetriever
    {
        public Process GetProcessById(int pid)
        {
            return Process.GetProcessById(pid);
        }
    }
}
