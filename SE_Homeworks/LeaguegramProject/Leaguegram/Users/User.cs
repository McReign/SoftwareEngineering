using System;
using System.Collections.Generic;

namespace Liguegram
{
    internal class User : IUser
    {
        public Guid Id { get; }
        public string NickName { get; }
        public List <IChat> Chats { get; set; }
        public string Mail { get; }

        public User(Guid id, string nickName, string mail)
        {
            Id = id;
            NickName = nickName;
            Chats = new List<IChat>();
            Mail = mail;
        }
    }
}
