using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortManager
{
    public interface IProcessRetriever
    {
        Process GetProcessById(int pid);
    }
}
