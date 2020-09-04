using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleRoyalle.Hubs
{
    public class CommandHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task AdicionarComando(string user, string message)
        {
            await Clients.All.SendAsync("ReceberComando", user, message);
        }
    }
}