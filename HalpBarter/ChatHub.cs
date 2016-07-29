using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace HalpBarter
{
    public class ChatHub : Hub
    {
        public void Send(string name, string text)
        {
            Clients.All.send(name,text);
        }
    }
}