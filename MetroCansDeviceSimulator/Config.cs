using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCansDeviceSimulator
{
    public class Config
    {
        public static string DeviceName = "00000000-0000-0000-0000-000000000000";
    }

    public class MQTTConfig
    {
        public static string Host = "localhost";
        public static int Port = 8080;
        public static string Topic_Telemetry = "v1/devices/me/telemetry";
        public static string Topic_Attributes = "v1/devices/me/attributes";
        public static string Topic_RPC_Request = "v1/devices/me/rpc/request/+";
        public static string Topic_RPC_Response = "v1/devices/me/rpc/response/";
        public static string Username = "001";
    }
}
