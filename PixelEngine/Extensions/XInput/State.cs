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
    /// <p>Represents the state of a controller.</p>
    /// </summary>
    /// <remarks>
    /// <p>The <em>dwPacketNumber</em> member is incremented only if the status of the controller has changed since the controller was last polled. </p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinput_state</doc-id>
    /// <unmanaged>XINPUT_STATE</unmanaged>
    /// <unmanaged-short>XINPUT_STATE</unmanaged-short>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct State
    {
        /// <summary>
        /// <dd> <p>State packet number. The packet number indicates whether there have been any changes in the state of the controller. If the <em>dwPacketNumber</em> member is the same in sequentially returned <strong><see cref="T:PixelEngine.Extensions.XInput.State" /></strong> structures, the controller state has not changed.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_state</doc-id>
        /// <unmanaged>dwPacketNumber</unmanaged>
        /// <unmanaged-short>dwPacketNumber</unmanaged-short>
        public int PacketNumber;

        /// <summary>
        /// <dd> <p> <strong><see cref="T:PixelEngine.Extensions.XInput.Gamepad" /></strong> structure containing the current state of an Xbox 360 Controller.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_state</doc-id>
        /// <unmanaged>Gamepad</unmanaged>
        /// <unmanaged-short>Gamepad</unmanaged-short>
        public Gamepad Gamepad;
    }
}