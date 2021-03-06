﻿using System;

namespace Liguegram
{
    internal class Message : IMessage
    {
        public Message(Guid messageId, string text, Guid senderId, DateTimeOffset sentOn)
        {
            MessageId = messageId;
            Text = text;
            SenderId = senderId;
            SentOn = sentOn;
        }

        public Guid MessageId { get; }
        public string Text { get; set; }
        public Guid SenderId { get; }
        public DateTimeOffset SentOn { get; }

    }
}
