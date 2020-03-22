﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StreamCore.Interfaces
{
    public interface IChatUser
    {
        string Id { get; }
        string Name { get; }
        string Color { get; }
        IChatBadge[] Badges { get; }
    }
}