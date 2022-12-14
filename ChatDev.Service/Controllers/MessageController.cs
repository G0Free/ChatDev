using ChatDev.Models;
using ChatDev.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace ChatDev.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : Controller
    {
        IHubContext<SignalRHub> hub;
        public MessageController(IHubContext<SignalRHub> hub)
        {
            this.hub = hub;
        }

        [HttpPost]
        public void Create([FromBody] Message value)
        {
            //this.logic.Create(value);
            this.hub.Clients.All.SendAsync("ActorCreated", value);
        }
    }
}
