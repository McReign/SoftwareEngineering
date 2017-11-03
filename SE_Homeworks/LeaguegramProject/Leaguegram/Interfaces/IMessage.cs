using System;

namespace Liguegram
{
    internal interface IMessage
    {
        Guid MessageId { get; }
        string Text { get; set; }
        Guid SenderId { get; }
        DateTimeOffset SentOn { get; }
    }
}