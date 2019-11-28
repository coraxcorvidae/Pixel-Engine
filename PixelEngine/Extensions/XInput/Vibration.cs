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
    /// <p>Specifies motor speed levels for the vibration function of a controller.</p>
    /// </summary>
    /// <remarks>
    /// <p>The left motor is the low-frequency rumble motor. The right motor is the high-frequency rumble motor. The two motors are not the same, and they create different vibration effects.</p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinput_vibration</doc-id>
    /// <unmanaged>XINPUT_VIBRATION</unmanaged>
    /// <unmanaged-short>XINPUT_VIBRATION</unmanaged-short>
    internal struct Vibration
    {
        /// <summary>
        /// <dd> <p>Speed of the left motor. Valid values are in the range 0 to 65,535. Zero signifies no motor use; 65,535 signifies 100 percent motor use.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_vibration</doc-id>
        /// <unmanaged>wLeftMotorSpeed</unmanaged>
        /// <unmanaged-short>wLeftMotorSpeed</unmanaged-short>
        public ushort LeftMotorSpeed;

        /// <summary>
        /// <dd> <p>Speed of the right motor. Valid values are in the range 0 to 65,535. Zero signifies no motor use; 65,535 signifies 100 percent motor use.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_vibration</doc-id>
        /// <unmanaged>wRightMotorSpeed</unmanaged>
        /// <unmanaged-short>wRightMotorSpeed</unmanaged-short>
        public ushort RightMotorSpeed;

        internal void __MarshalFree(ref Vibration.__Native @ref)
        {
        }

        internal void __MarshalFrom(ref Vibration.__Native @ref)
        {
            this.LeftMotorSpeed = (ushort) @ref.LeftMotorSpeed;
            this.RightMotorSpeed = (ushort) @ref.RightMotorSpeed;
        }

        internal void __MarshalTo(ref Vibration.__Native @ref)
        {
            @ref.LeftMotorSpeed = (short) this.LeftMotorSpeed;
            @ref.RightMotorSpeed = (short) this.RightMotorSpeed;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct __Native
        {
            public short LeftMotorSpeed;
            public short RightMotorSpeed;
        }
    }
}