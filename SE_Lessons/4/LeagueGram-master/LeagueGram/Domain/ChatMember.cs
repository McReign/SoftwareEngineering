using System;

namespace LeagueGram.Domain
{
  public class ChatMember
  {
    public ChatMember(Guid id, string nickName, ChatMemberRole role)
    {
      Id = id;
      NickName = nickName;
      Role = role;
    }

    public Guid Id { get; }

    public string NickName { get; }

    public ChatMemberRole Role { get; private set; }

    public ChatMember PromoteToAdmin()
    {
        return new ChatMember(Id, NickName, ChatMemberRole.Admin);
    }

    public ChatMember DemoteFromAdmin()
    {
        return new ChatMember(Id, NickName, ChatMemberRole.User);
    }
  }
}
