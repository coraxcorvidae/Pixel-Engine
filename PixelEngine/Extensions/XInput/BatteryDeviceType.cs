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

namespace PixelEngine.Extensions.XInput
{
    /// <summary>
    /// <p>Retrieves the battery type and charge status of a wireless controller.</p>
    /// </summary>
    /// <doc-id>microsoft.directx_sdk.reference.xinputgetbatteryinformation</doc-id>
    /// <unmanaged>BATTERY_DEVTYPE</unmanaged>
    /// <unmanaged-short>BATTERY_DEVTYPE</unmanaged-short>
    internal enum BatteryDeviceType
    {
        /// <summary>
        /// <dd> <p>Index of the signed-in gamer associated with the device. Can be a value in the range 0?XUSER_MAX_COUNT ? 1.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetbatteryinformation</doc-id>
        /// <unmanaged>BATTERY_DEVTYPE_GAMEPAD</unmanaged>
        /// <unmanaged-short>BATTERY_DEVTYPE_GAMEPAD</unmanaged-short>
        Gamepad,

        /// <summary>
        /// <dd> <p>Specifies which device associated with this user index should be queried. Must be <strong>BATTERY_DEVTYPE_GAMEPAD</strong> or <strong>BATTERY_DEVTYPE_HEADSET</strong>.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetbatteryinformation</doc-id>
        /// <unmanaged>BATTERY_DEVTYPE_HEADSET</unmanaged>
        /// <unmanaged-short>BATTERY_DEVTYPE_HEADSET</unmanaged-short>
        Headset,
    }
}