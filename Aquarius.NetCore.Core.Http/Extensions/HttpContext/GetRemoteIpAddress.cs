using Microsoft.AspNetCore.Http;
using System.Net;

namespace Aquarius.NetCore.Core.Http
{
    public static partial class Extensions
    {
        public static IPAddress? GetRemoteIpAddress(this HttpContext context)
        {
            return context?.Connection.RemoteIpAddress;
        }
    }
}
