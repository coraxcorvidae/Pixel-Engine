﻿// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
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

using PixelEngine.Extensions.XInput;
using System;

namespace PixelEngine.Extensions.XInput
{
    /// <summary>
    /// Common interface for XInput to allow using XInput 1.4, 1.3 or 9.1.0.
    /// </summary>
    internal interface IXInput
    {
        int XInputSetState(int dwUserIndex, Vibration vibrationRef);

        int XInputGetState(int dwUserIndex, out State stateRef);

        int XInputGetAudioDeviceIds(
            int dwUserIndex,
            IntPtr renderDeviceIdRef,
            IntPtr renderCountRef,
            IntPtr captureDeviceIdRef,
            IntPtr captureCountRef);

        void XInputEnable(RawBool enable);

        int XInputGetBatteryInformation(
            int dwUserIndex,
            BatteryDeviceType devType,
            out BatteryInformation batteryInformationRef);

        int XInputGetKeystroke(int dwUserIndex, int dwReserved, out Keystroke keystrokeRef);

        int XInputGetCapabilities(
            int dwUserIndex,
            DeviceQueryType dwFlags,
            out Capabilities capabilitiesRef);
    }
}