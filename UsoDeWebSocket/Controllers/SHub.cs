using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsoDeWebSocket.Controllers
{
    public class SHub : Hub
    {
        public Task SendMesssage(string user , string message,string tag)
        {
            return Clients.All.SendAsync("ReceiveMessage", "Arturo", "Mensaje en tiempo real");
        }
    }
}
