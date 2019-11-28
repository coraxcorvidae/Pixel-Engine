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
    /// <p>Describes the capabilities of a connected controller. The <strong>XInputGetCapabilities</strong> function returns <strong><see cref="T:PixelEngine.Extensions.XInput.Capabilities" /></strong>. </p>
    /// </summary>
    /// <remarks>
    /// <p> <strong>XInputGetCapabilities</strong> returns <strong><see cref="T:PixelEngine.Extensions.XInput.Capabilities" /></strong> to indicate the characteristics and available functionality of a specified controller. </p><p> <strong>XInputGetCapabilities</strong> sets the structure members to indicate which inputs the device supports. For binary state controls, such as digital buttons, the corresponding bit reflects whether or not the control is supported by the device. For proportional controls, such as thumbsticks, the value indicates the resolution for that control. Some number of the least significant bits may not be set, indicating that the control does not provide resolution to that level. </p><p>The <em>SubType</em> member indicates the specific subtype of controller present. Games may detect the controller subtype and tune their handling of controller input or output based on subtypes that are well suited to their game genre. For example, a car racing game might check for the presence of a wheel controller to provide finer control of the car being driven. However, titles must not disable or ignore a device based on its subtype. Subtypes not recognized by the game or for which the game is not specifically tuned should be treated as a standard Xbox 360 Controller (XINPUT_DEVSUBTYPE_GAMEPAD). </p><p>Older XUSB Windows drivers report incomplete capabilities information, particularly for wireless devices. The latest XUSB Windows driver provides full support for wired and wireless devices, and more complete and accurate capabilties flags. </p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinput_capabilities</doc-id>
    /// <unmanaged>XINPUT_CAPABILITIES</unmanaged>
    /// <unmanaged-short>XINPUT_CAPABILITIES</unmanaged-short>
    internal struct Capabilities
    {
        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_capabilities</doc-id>
        /// <unmanaged>Type</unmanaged>
        /// <unmanaged-short>Type</unmanaged-short>
        public DeviceType Type;

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_capabilities</doc-id>
        /// <unmanaged>SubType</unmanaged>
        /// <unmanaged-short>SubType</unmanaged-short>
        public DeviceSubType SubType;

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_capabilities</doc-id>
        /// <unmanaged>Flags</unmanaged>
        /// <unmanaged-short>Flags</unmanaged-short>
        public CapabilityFlags Flags;

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_capabilities</doc-id>
        /// <unmanaged>Gamepad</unmanaged>
        /// <unmanaged-short>Gamepad</unmanaged-short>
        public Gamepad Gamepad;

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_capabilities</doc-id>
        /// <unmanaged>Vibration</unmanaged>
        /// <unmanaged-short>Vibration</unmanaged-short>
        public Vibration Vibration;

        internal void __MarshalFree(ref Capabilities.__Native @ref)
        {
            this.Vibration.__MarshalFree(ref @ref.Vibration);
        }

        internal void __MarshalFrom(ref Capabilities.__Native @ref)
        {
            this.Type = @ref.Type;
            this.SubType = @ref.SubType;
            this.Flags = @ref.Flags;
            this.Gamepad = @ref.Gamepad;
            this.Vibration.__MarshalFrom(ref @ref.Vibration);
        }

        internal void __MarshalTo(ref Capabilities.__Native @ref)
        {
            @ref.Type = this.Type;
            @ref.SubType = this.SubType;
            @ref.Flags = this.Flags;
            @ref.Gamepad = this.Gamepad;
            this.Vibration.__MarshalTo(ref @ref.Vibration);
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct __Native
        {
            public DeviceType Type;
            public DeviceSubType SubType;
            public CapabilityFlags Flags;
            public Gamepad Gamepad;
            public Vibration.__Native Vibration;
        }
    }
}