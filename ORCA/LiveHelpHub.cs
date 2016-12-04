using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ORCA
{
    public class LiveHelpHub : Hub
    {
        public void SendMessage(String username, string message)
        {
            Clients.All.showMessage(username, message);
            //Clients.Group("Expertlist").showMessage(username, "this is your new message");
        }
    }
}