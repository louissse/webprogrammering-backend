using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace WebSocketsApp.Middlewares
{
    public class CommunicationMiddleware
    {
        private readonly RequestDelegate _next;

        public CommunicationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);
        }

    }
}
