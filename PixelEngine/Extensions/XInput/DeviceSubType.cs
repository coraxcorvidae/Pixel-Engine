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
    /// <p>A table of controller subtypes available in XInput.</p>
    /// </summary>
    /// <doc-id>hh405050</doc-id>
    /// <unmanaged>XINPUT_DEVSUBTYPE</unmanaged>
    /// <unmanaged-short>XINPUT_DEVSUBTYPE</unmanaged-short>
    internal enum DeviceSubType : byte
    {
        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_UNKNOWN</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_UNKNOWN</unmanaged-short>
        Unknown = 0,

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_GAMEPAD</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_GAMEPAD</unmanaged-short>
        Gamepad = 1,

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_WHEEL</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_WHEEL</unmanaged-short>
        Wheel = 2,

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_ARCADE_STICK</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_ARCADE_STICK</unmanaged-short>
        ArcadeStick = 3,

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_FLIGHT_STICK</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_FLIGHT_STICK</unmanaged-short>
        FlightStick = 4,

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_DANCE_PAD</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_DANCE_PAD</unmanaged-short>
        DancePad = 5,

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_GUITAR</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_GUITAR</unmanaged-short>
        Guitar = 6,

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE</unmanaged-short>
        GuitarAlternate = 7,

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_DRUM_KIT</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_DRUM_KIT</unmanaged-short>
        DrumKit = 8,

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_GUITAR_BASS</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_GUITAR_BASS</unmanaged-short>
        GuitarBass = 11, // 0x0B

        /// <summary>No documentation.</summary>
        /// <doc-id>hh405050</doc-id>
        /// <unmanaged>XINPUT_DEVSUBTYPE_ARCADE_PAD</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_ARCADE_PAD</unmanaged-short>
        ArcadePad = 19, // 0x13
    }
}