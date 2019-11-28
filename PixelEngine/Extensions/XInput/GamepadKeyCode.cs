// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace PixelEngine.Extensions.XInput
{
    [Flags]
    internal enum GamepadKeyCode : short
    {
        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_A</unmanaged>
        /// <unmanaged-short>VK_PAD_A</unmanaged-short>
        A = 22528, // 0x5800

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_B</unmanaged>
        /// <unmanaged-short>VK_PAD_B</unmanaged-short>
        B = 22529, // 0x5801

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_X</unmanaged>
        /// <unmanaged-short>VK_PAD_X</unmanaged-short>
        X = 22530, // 0x5802

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_Y</unmanaged>
        /// <unmanaged-short>VK_PAD_Y</unmanaged-short>
        Y = 22531, // 0x5803

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RSHOULDER</unmanaged>
        /// <unmanaged-short>VK_PAD_RSHOULDER</unmanaged-short>
        RightShoulder = 22532, // 0x5804

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LSHOULDER</unmanaged>
        /// <unmanaged-short>VK_PAD_LSHOULDER</unmanaged-short>
        LeftShoulder = 22533, // 0x5805

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTRIGGER</unmanaged>
        /// <unmanaged-short>VK_PAD_LTRIGGER</unmanaged-short>
        LeftTrigger = 22534, // 0x5806

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTRIGGER</unmanaged>
        /// <unmanaged-short>VK_PAD_RTRIGGER</unmanaged-short>
        RightTrigger = 22535, // 0x5807

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_DPAD_UP</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_UP</unmanaged-short>
        DPadUp = 22544, // 0x5810

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_DPAD_DOWN</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_DOWN</unmanaged-short>
        DPadDown = 22545, // 0x5811

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_DPAD_LEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_LEFT</unmanaged-short>
        DPadLeft = 22546, // 0x5812

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_DPAD_RIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_RIGHT</unmanaged-short>
        DPadRight = 22547, // 0x5813

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_START</unmanaged>
        /// <unmanaged-short>VK_PAD_START</unmanaged-short>
        Start = 22548, // 0x5814

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_BACK</unmanaged>
        /// <unmanaged-short>VK_PAD_BACK</unmanaged-short>
        Back = 22549, // 0x5815

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTHUMB_PRESS</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_PRESS</unmanaged-short>
        LeftThumbPress = 22550, // 0x5816

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTHUMB_PRESS</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_PRESS</unmanaged-short>
        RightThumbPress = 22551, // 0x5817

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTHUMB_UP</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_UP</unmanaged-short>
        LeftThumbUp = 22560, // 0x5820

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTHUMB_DOWN</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_DOWN</unmanaged-short>
        LeftThumbDown = 22561, // 0x5821

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTHUMB_RIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_RIGHT</unmanaged-short>
        LeftThumbRight = 22562, // 0x5822

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTHUMB_LEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_LEFT</unmanaged-short>
        LeftThumbLeft = 22563, // 0x5823

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTHUMB_UPLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_UPLEFT</unmanaged-short>
        RightThumbUpLeft = 22564, // 0x5824

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTHUMB_UPRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_UPRIGHT</unmanaged-short>
        LeftThumbUpright = 22565, // 0x5825

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTHUMB_DOWNRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_DOWNRIGHT</unmanaged-short>
        LeftThumbDownright = 22566, // 0x5826

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_LTHUMB_DOWNLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_DOWNLEFT</unmanaged-short>
        RightThumbDownLeft = 22567, // 0x5827

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTHUMB_UP</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_UP</unmanaged-short>
        RightThumbUp = 22576, // 0x5830

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTHUMB_DOWN</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_DOWN</unmanaged-short>
        RightThumbDown = 22577, // 0x5831

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTHUMB_RIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_RIGHT</unmanaged-short>
        RightThumbRight = 22578, // 0x5832

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTHUMB_LEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_LEFT</unmanaged-short>
        RightThumbLeft = 22579, // 0x5833

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTHUMB_UPLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_UPLEFT</unmanaged-short>
        RightThumbUpleft = 22580, // 0x5834

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTHUMB_UPRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_UPRIGHT</unmanaged-short>
        RightThumbUpRight = 22581, // 0x5835

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTHUMB_DOWNRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_DOWNRIGHT</unmanaged-short>
        RightThumbDownRight = 22582, // 0x5836

        /// <summary>No documentation.</summary>
        /// <unmanaged>VK_PAD_RTHUMB_DOWNLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_DOWNLEFT</unmanaged-short>
        RightThumbDownleft = 22583, // 0x5837

        /// <summary>None</summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = 0,
    }
}