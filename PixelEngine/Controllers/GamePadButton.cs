using System;

namespace PixelEngine
{
    [Flags]
    public enum GamePadButtonFlags : ushort
    {
        None = 0,
        DPadUp = 1,
        DPadDown = 2,
        DPadLeft = 4,
        DPadRight = 8,
        Start = 16,
        Back = 32,
        LeftThumb = 64,
        RightThumb = 128,
        LeftShoulder = 256,
        RightShoulder = 512,
        A = 4096,
        B = 8192,
        X = 16384,
        Y = 32768
    }
}