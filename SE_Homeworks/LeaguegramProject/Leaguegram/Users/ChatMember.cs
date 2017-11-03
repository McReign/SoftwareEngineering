
using System;

namespace Liguegram
{
    internal class ChatMember : IChatMember
    {
        public Guid Id { get; }
        public string NickName { get; }
        public ChatMemberRole Role { get; set; }

        public ChatMember(Guid id, string nickName, ChatMemberRole role)
        {
            Id = id;
            NickName = nickName;
            Role = role;
        }
    }
}
