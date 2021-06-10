using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarius.NetCore.Core.Http
{
    public static partial class Extensions
    {
        public static async Task ResponseAsync(this HttpResponse response, int code, string message, string type, Encoding encoding)
        {
            response.StatusCode = code;
            response.ContentType = string.Join(";", new string[] { type, $"charset={encoding?.WebName ?? Encoding.UTF8.WebName}" });
            await response.WriteAsync(message, encoding ?? Encoding.UTF8);
        }
    }
}
