using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Liguegram;

namespace LeagueGramTests
{
    [TestClass]
    public class ChannelTests
    {
        [TestMethod]
        public void CreatorTryingToDeleteMessage_ItShouldBePossible()
        {
            //Arrange
            IChatMember firstUser = new ChatMember(Guid.NewGuid(), "gfdg", ChatMemberRole.Creator);
            IChat channel = new Channel(firstUser);
            var expected = 0;
            //Act
            channel.SendMessage("fgdgfdhf", firstUser);
            channel.DeleteMessage(channel.Messages[0], firstUser);

            //Assert
            Assert.AreEqual(channel.Messages.Length, expected);
        }

        [TestMethod]
        public void CreatorTryingToSendMessage_HisMessageShouldBeAdded()
        {
            //Arrange
            IChatMember firstUser = new ChatMember(Guid.NewGuid(), "gfdg", ChatMemberRole.Creator);
            IChat channel = new Channel(firstUser);
            var expected = 1;

            //Act
            channel.SendMessage("dfsfsdfs", firstUser);

            //Assert
            Assert.AreEqual(expected, channel.Messages.Length);
        }
    }
}
