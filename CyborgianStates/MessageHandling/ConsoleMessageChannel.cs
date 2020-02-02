﻿using CyborgianStates.CommandHandling;
using CyborgianStates.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CyborgianStates.MessageHandling
{
    public class ConsoleMessageChannel : IMessageChannel
    {
        public ConsoleMessageChannel(bool isPrivate)
        {
            IsPrivate = isPrivate;
        }
        public bool IsPrivate { get; }

        public Task WriteToAsync(bool responseIsPublic, string message)
        {
            Console.WriteLine(message);
            return Task.CompletedTask;
        }

        public Task WriteToAsync(bool responseIsPublic, CommandResponse response)
        {
            if(response is null)
            {
                throw new ArgumentNullException(nameof(response));
            }
            Console.WriteLine(response.Content);
            return Task.CompletedTask;
        }
    }
}
