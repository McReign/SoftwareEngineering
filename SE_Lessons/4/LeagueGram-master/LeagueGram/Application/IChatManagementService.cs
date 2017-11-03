using LeagueGram.Domain;
using System;
using System.Collections.Generic;

namespace LeagueGram.Application
{
  public interface IChatManagementService
  {
    Guid CreatePrivateChat(Guid creatorId, Guid companionId);

    Guid CreateGroup(Guid creatorId);

    Guid CreateChannel(Guid creatorId);

    void UpgradeToGroup(Guid chatId, Guid actorId);

    List<IChat> GetUserChats(Guid userId);
  }
}