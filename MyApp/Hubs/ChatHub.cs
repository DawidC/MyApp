using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MyApp.Hubs
{
    [HubName("chat")]
    public class ChatHub : Hub<IClientHandler>
    {
        public void Hello()
        {

        }
        public override Task OnConnected()
        {
            this.Clients.Caller.Hello("Hello from server");
            return base.OnConnected();
        }
    }

    public interface IClientHandler
    {
        void Hello(string msg);
    }
}