﻿using CyborgianStates.Interfaces;
using System;

namespace CyborgianStates.MessageHandling
{
    public class ConsoleInput : IUserInput
    {
        public string GetInput()
        {
            return Console.ReadLine().Trim();
        }
    }

    //// Unit Test
    //public class FakeUserInput : IUserInput
    //{
    //    public string GetInput()
    //    {
    //        return "ABC_123";
    //    }
    //}
}
