using System;

namespace MusicBox
{
    [Flags]
    public enum Time
    {
        None = 0,
        Whole = 1,
        Half = 2,
        Quarter = 4,
        Octa = 8,
        Sixtheenth = 16,
        Thirtysecond = 32,
        SixtyFourth = 64
    }
}
