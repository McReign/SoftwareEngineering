
namespace Liguegram
{
    internal class ChatFactory
    {
        public IChat CreatePrivateChat(IChatMember creatorUser, IChatMember invitedUser)
        {
            IChat privateChat = new PrivateChat(new IChatMember[] { creatorUser, invitedUser });
            
            return privateChat;
        }

        public IChat CreateGroup(IChatMember creatorUser)
        {
            IChat group = new Group(creatorUser);
            return group;
        }
        public IChat CreateChannel(IChatMember creatorUser)
        {
            IChat channel = new Channel(creatorUser);
            return channel;
        }
    }
}
