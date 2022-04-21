﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.SignalR;

namespace ReplyBackSeparateIdentityServer
{
    [Authorize]
    public class MessagingHub : AbpHub
    {
        public async Task SendMessage(string message)
        {
            message = $"{CurrentUser.UserName}: {message}";

            await Clients
                .User(CurrentUser.Id.ToString())
                .SendAsync("MessageBackToBlazor", message);

            //This works for sending to ALL
            //await Clients.All.SendAsync("MessageBackToBlazor", message);
        }
    }
}
