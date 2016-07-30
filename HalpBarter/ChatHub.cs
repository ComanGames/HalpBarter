using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace HalpBarter
{
    public class ChatHub : Hub
    {
        public void Send(string userName, string text)
        {
            Clients.All.send(userName,text);
        }
    }
}