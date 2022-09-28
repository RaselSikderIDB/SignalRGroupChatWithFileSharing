using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupChatWithFileSharing
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void Send(string name, string message, string path)
        {
            Clients.All.addNewMessageToPage(name, message, path);
        }
    }
}