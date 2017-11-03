using System;
using System.Collections.Generic;

namespace Liguegram
{
    internal class LeagueGram
    {
        public void RegistrationOfUser(string nickName, string mail)
        {
            IUser newUser = new User(Guid.NewGuid(), nickName, mail);
            _users.Add(newUser);
        }

        public void CreatePrivateChat(IChatMember creator, IChatMember invitedUser)
        {
            _privateChats.Add(Guid.NewGuid(), (PrivateChat)factory.CreatePrivateChat(creator, invitedUser));
        }

        public void CreateGroupChat(IChatMember creator)
        {
            _groupChats.Add(Guid.NewGuid(), (Group)factory.CreateGroup(creator));
        }

        public void CreateChannel(IChatMember creator)
        {

            _channels.Add(Guid.NewGuid(), (Channel)factory.CreateChannel(creator));
        }

        public void SendMessage(Guid chatId, IChatMember member, string message)
        {
            for (int i = 0; i < _privateChats.Count; i++)
            {
                if (_privateChats[chatId].ChatId == chatId)
                {
                    _privateChats[chatId].SendMessage(message, member);
                    break;
                }
            }

            for (int i = 0; i < _groupChats.Count; i++)
            {
                if (_groupChats[chatId].ChatId == chatId)
                {
                    _groupChats[chatId].SendMessage(message, member);
                    break;
                }
            }

            for (int i = 0; i < _channels.Count; i++)
            {
                if (_channels[chatId].ChatId == chatId)
                {
                    _channels[chatId].SendMessage(message, member);
                    break;
                }
            }
        }


        public void EditMessage(Guid chatId, IMessage message, string newMessage, IChatMember member)
        {
            for (int i = 0; i < _privateChats.Count; i++)
            {
                if (_privateChats[chatId].ChatId == chatId)
                {
                    _privateChats[chatId].EditMessage(message, newMessage, member);
                    break;
                }
            }

            for (int i = 0; i < _groupChats.Count; i++)
            {
                if (_groupChats[chatId].ChatId == chatId)
                {
                    _groupChats[chatId].EditMessage(message, newMessage, member);
                    break;
                }
            }

            for (int i = 0; i < _channels.Count; i++)
            {
                if (_channels[chatId].ChatId == chatId)
                {
                    _channels[chatId].EditMessage(message, newMessage, member);
                    break;
                }
            }
        }

        public void InviteUser(Guid chatId, IChatMember member, IUser invitedUser)
        {
            for (int i = 0; i < _privateChats.Count; i++)
            {
                if (_privateChats[chatId].ChatId == chatId)
                {
                    _privateChats[chatId].InviteUser(member, invitedUser);
                    break;
                }
            }

            for (int i = 0; i < _groupChats.Count; i++)
            {
                if (_groupChats[chatId].ChatId == chatId)
                {
                    _groupChats[chatId].InviteUser(member, invitedUser);
                    break;
                }
            }

            for (int i = 0; i < _channels.Count; i++)
            {
                if (_channels[chatId].ChatId == chatId)
                {
                    _channels[chatId].InviteUser(member, invitedUser);
                    break;
                }
            }
        }

        public void DeleteMessage(Guid chatId, IChatMember member, IMessage message)
        {
            for (int i = 0; i < _privateChats.Count; i++)
            {
                if (_privateChats[chatId].ChatId == chatId)
                {
                    _privateChats[chatId].DeleteMessage(message, member);
                    break;
                }
            }

            for (int i = 0; i < _groupChats.Count; i++)
            {
                if (_groupChats[chatId].ChatId == chatId)
                {
                    _groupChats[chatId].DeleteMessage(message, member);
                    break;
                }
            }

            for (int i = 0; i < _channels.Count; i++)
            {
                if (_channels[chatId].ChatId == chatId)
                {
                    _channels[chatId].DeleteMessage(message, member);
                    break;
                }
            }
        }

        public void EditRoleOfMember(Guid chatId, ChatMemberRole newRole, IChatMember editor, IChatMember editingPerson)
        {
            for (int i = 0; i < _privateChats.Count; i++)
            {
                if (_privateChats[chatId].ChatId == chatId)
                {
                    _privateChats[chatId].EditRoleOfMember(newRole, editor, editingPerson);
                    break;
                }
            }

            for (int i = 0; i < _groupChats.Count; i++)
            {
                if (_groupChats[chatId].ChatId == chatId)
                {
                    _groupChats[chatId].EditRoleOfMember(newRole, editor, editingPerson);
                    break;
                }
            }

            for (int i = 0; i < _channels.Count; i++)
            {
                if (_channels[chatId].ChatId == chatId)
                {
                    _channels[chatId].EditRoleOfMember(newRole, editor, editingPerson);
                    break;
                }
            }
        }

        private readonly Dictionary<Guid, PrivateChat> _privateChats;
        private readonly Dictionary<Guid, Group> _groupChats;
        private readonly Dictionary<Guid, Channel> _channels;

        private readonly List<IUser> _users;

        private ChatFactory factory;

        public LeagueGram()
        {
            factory = new ChatFactory();
        }

    }
}
