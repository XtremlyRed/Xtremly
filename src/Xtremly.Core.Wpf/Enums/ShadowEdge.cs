﻿using System;

namespace Xtremly.Core
{
    [Flags]
    public enum ShadowEdge
    {
        None = 0,
        Left = 1,
        Top = 2,
        Right = 4,
        Bottom = 8,
        All = Left | Top | Right | Bottom
    }



    public enum ShadowDepth
    {
        Depth0,
        Depth1,
        Depth2,
        Depth3,
        Depth4,
        Depth5
    }
}
