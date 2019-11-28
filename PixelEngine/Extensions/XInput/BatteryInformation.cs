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

using System.Runtime.InteropServices;

namespace PixelEngine.Extensions.XInput
{
    /// <summary>
    /// <p>Contains information on battery type and charge state.</p>
    /// </summary>
    /// <doc-id>microsoft.directx_sdk.reference.xinput_battery_information</doc-id>
    /// <unmanaged>XINPUT_BATTERY_INFORMATION</unmanaged>
    /// <unmanaged-short>XINPUT_BATTERY_INFORMATION</unmanaged-short>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct BatteryInformation
    {
        /// <summary>
        /// <dd> <p>The type of battery. <em>BatteryType</em> will be one of the following values. </p> <table> <tr><th>Value</th><th>Description</th></tr> <tr><td>BATTERY_TYPE_DISCONNECTED</td><td>The device is not connected.?</td></tr> <tr><td>BATTERY_TYPE_WIRED</td><td>The device is a wired device and does not have a battery.?</td></tr> <tr><td>BATTERY_TYPE_ALKALINE</td><td>The device has an alkaline battery.?</td></tr> <tr><td>BATTERY_TYPE_NIMH</td><td>The device has a nickel metal hydride battery.?</td></tr> <tr><td>BATTERY_TYPE_UNKNOWN</td><td>The device has an unknown  battery type.?</td></tr> </table> <p>?</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_battery_information</doc-id>
        /// <unmanaged>BatteryType</unmanaged>
        /// <unmanaged-short>BatteryType</unmanaged-short>
        public BatteryType BatteryType;

        /// <summary>
        /// <dd> <p>The charge state of the battery. This value is only valid for wireless devices with a known battery type. <em>BatteryLevel</em> will be one of the following values. </p> <table> <tr><th>Value</th></tr> <tr><td>BATTERY_LEVEL_EMPTY</td></tr> <tr><td>BATTERY_LEVEL_LOW</td></tr> <tr><td>BATTERY_LEVEL_MEDIUM</td></tr> <tr><td>BATTERY_LEVEL_FULL</td></tr> </table> <p>?</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_battery_information</doc-id>
        /// <unmanaged>BatteryLevel</unmanaged>
        /// <unmanaged-short>BatteryLevel</unmanaged-short>
        public BatteryLevel BatteryLevel;
    }
}