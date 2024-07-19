using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortManager
{
    public class PortInfo
    {
        public string Protocol { get; set; } = string.Empty;
        public string LocalAddress { get; set; } = string.Empty;
        public string LocalPort { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PID { get; set; } = string.Empty;
        public string ProcessName { get; set; } = string.Empty;
    }
}
