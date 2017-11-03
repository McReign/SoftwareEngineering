
using System;
using System.Collections.Generic;
using System.Linq;

namespace Liguegram
{
    internal class PrivateChat : Chat
    {
        public override Guid ChatId { get; }
        public override IMessage[] Messages { get; set; }
        public override IChatMember[] Members { get; set; }

        public PrivateChat(IChatMember[] members)
        {
            Members = members;
            Messages = new Message[0];
            ChatId = Guid.NewGuid();

            foreach (var member in Members)
            {
                member.Role = ChatMemberRole.Admin;
            }
        }

        public override bool CanSendMessage(IChatMember member)
        {
            return (IsParticipant(member));
            
        }

        public override void DeleteMessage(IMessage message, IChatMember member)
        {
            if(IsHavingRights(member, message))
            {
                List<IMessage> listOfMessages = Messages.ToList();
                listOfMessages.Remove(message);
                Messages = listOfMessages.ToArray();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public override void InviteUser(IChatMember member, IUser invitedPerson)
        {
            throw new NotImplementedException();
        }

        public override bool IsHavingRights(IChatMember member, IMessage message)
        {
            foreach (var chatMessage in Messages)
            {
                if (IsParticipant(member) && message.SenderId == member.Id && message.MessageId == chatMessage.MessageId)
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        public override void EditRoleOfMember(ChatMemberRole newRole, IChatMember editor, IChatMember editingPerson)
        {
                throw new NotImplementedException();
        }
    }
}
