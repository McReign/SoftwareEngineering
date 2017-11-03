using System;
using System.Collections.Generic;

namespace Liguegram
{
    internal interface IUser
    {
        Guid Id { get; }
        string NickName { get; }
        List <IChat> Chats { get; set; }
        string Mail { get; }
    }
}