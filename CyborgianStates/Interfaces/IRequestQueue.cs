﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CyborgianStates.Interfaces
{
    public interface IRequestQueue
    {
        Task Enqueue(Request request);
    }
}
