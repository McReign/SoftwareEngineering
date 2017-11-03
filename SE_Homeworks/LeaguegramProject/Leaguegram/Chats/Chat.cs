using System;
using System.Collections.Generic;
using System.Linq;

namespace Liguegram
{
    internal abstract class Chat : IChat
    {
        public abstract Guid ChatId { get; }
        public abstract IMessage[] Messages { get; set; }
        public abstract IChatMember[] Members { get; set; }

        public abstract bool CanSendMessage(IChatMember member);

        public abstract void DeleteMessage(IMessage message, IChatMember member);

        public void EditMessage(IMessage message, string newMesssage, IChatMember member)
        {
            if (IsHavingRights(member, message))
            {
                message.Text = newMesssage;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public abstract void EditRoleOfMember(ChatMemberRole newRole, IChatMember editor, IChatMember editingPerson);

        public virtual void InviteUser(IChatMember member, IUser invitedPerson)
        {
            if ((member.Role == ChatMemberRole.Creator || member.Role == ChatMemberRole.Admin))
            {
                List<IChatMember> listOfMembers = Members.ToList();
                listOfMembers.Add(new ChatMember(invitedPerson.Id, invitedPerson.NickName, ChatMemberRole.User));
                Members = listOfMembers.ToArray();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public abstract bool IsHavingRights(IChatMember member, IMessage message);

        public bool IsParticipant(IChatMember member) {

            foreach (var chatMember in Members)
            {
                if (chatMember.Id == member.Id)
                {
                    return true;
                }
            }

            return false;
        }

        public void SendMessage(string messageText, IChatMember member)
        {
            if (CanSendMessage(member))
            {
                Message newMessage = new Message(Guid.NewGuid(), messageText, member.Id, DateTimeOffset.Now);
                List<IMessage> listOfMessages = Messages.ToList();
                listOfMessages.Add(newMessage);
                Messages = listOfMessages.ToArray();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
