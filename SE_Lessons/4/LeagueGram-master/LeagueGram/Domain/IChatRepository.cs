using System;
using System.Collections.Generic;

namespace LeagueGram.Domain
{
  public interface IChatRepository
  {
    IChat LoadChat(Guid chatId);
    void SaveChat(IChat chat);
    List<IChat> GetChats();
  }
}