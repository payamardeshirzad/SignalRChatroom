using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR_ChatRoom.Hubs
{
    public class chathub : Hub
    {
        static int numofonlines = 0;
        public void Send(string name, string message)
        {
            Clients.All.addnewmessage(name, message,++numofonlines);
        }
    }
}