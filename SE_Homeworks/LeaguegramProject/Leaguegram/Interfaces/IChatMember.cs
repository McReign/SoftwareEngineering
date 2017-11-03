using System;

namespace Liguegram
{
    internal interface IChatMember
    {
        Guid Id { get; }
        string NickName { get; }
        ChatMemberRole Role { get; set; }
    }
}