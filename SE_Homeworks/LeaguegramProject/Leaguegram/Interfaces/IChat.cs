using System;
using System.Collections.Generic;
using System.Linq;

namespace Liguegram
{
    internal interface IChat
    {
        Guid ChatId { get; }
        IMessage[] Messages { get; set; }
        IChatMember[] Members { get; set; }

        void SendMessage(string messageText, IChatMember member);
        
        void EditMessage(IMessage message, string newMesssage, IChatMember member);

        void DeleteMessage(IMessage message, IChatMember member);

        void InviteUser(IChatMember member, IUser invitedPerson);

        bool CanSendMessage(IChatMember member);

        bool IsParticipant(IChatMember member);

        bool IsHavingRights(IChatMember member, IMessage message);

        void EditRoleOfMember(ChatMemberRole newRole, IChatMember editor, IChatMember editingPerson);
    }
}
