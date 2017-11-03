using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueGram.Domain
{
    public static class PrivateChatExtension
    {
        public static Group ToGroup(this PrivateChat privateChat, Guid actorId)
        {
            return new Group(privateChat.Id, actorId, privateChat.Messages, privateChat.Members);
        }
    }
}
