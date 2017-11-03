
using System;
using System.Collections.Generic;
using System.Linq;

namespace Liguegram
{
    internal class Channel : Chat
    {
        public override Guid ChatId { get; }
        public override IMessage[] Messages { get; set; }
        public override IChatMember[] Members { get; set; }

        public Channel(IChatMember creator)
        {
            Members = new ChatMember[1];
            Members[0] = creator;
            Messages = new Message[0];
            ChatId = Guid.NewGuid();
        }

        public override bool CanSendMessage(IChatMember member)
        {
            if (IsParticipant(member) && member.Role == ChatMemberRole.Admin)
            {
                return true;
            }

            return false;
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

        public override bool IsHavingRights(IChatMember member, IMessage message)
        {
            foreach (var chatMessage in Messages)
            {
                if (IsParticipant(member) && (member.Role == ChatMemberRole.Creator || member.Role == ChatMemberRole.Admin)
                    && message.MessageId == chatMessage.MessageId)
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        public override void EditRoleOfMember(ChatMemberRole newRole, IChatMember editor, IChatMember editingPerson)
        {
            if(editor.Role == ChatMemberRole.Creator && IsParticipant(editingPerson))
            {
                editingPerson.Role = newRole;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
