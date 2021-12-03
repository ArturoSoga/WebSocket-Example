using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsoDeWebSocket.Controllers
{
    public class SocketHub : ControllerBase
    {

        [Route("api/HUB")]
        [HttpPost]
        public string HUB(string message , string tag , string user)
        {
            var socket = new SHub();
            socket.SendMesssage(message,tag,user);

            return null;
        }

    }
}
