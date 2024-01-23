using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCansDeviceSimulator.Models
{
    internal class RPC
    {
        public class RPCRequest
        {
            public string method { get; set; }
            public bool @params { get; set; }
        }
    }
}
