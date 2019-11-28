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
    /// <p>Retrieves a gamepad input event.</p>
    /// </summary>
    /// <remarks>
    /// <p>Wireless controllers are not considered active upon system startup, and calls to any of the <em>XInput</em> functions before a wireless controller is made active return <strong>ERROR_DEVICE_NOT_CONNECTED</strong>. Game titles must examine the return code and be prepared to handle this condition. Wired controllers are automatically activated when they are inserted. Wireless controllers are activated when the user presses the START or Xbox Guide button to power on the controller.</p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
    /// <unmanaged>XUSER_INDEX</unmanaged>
    /// <unmanaged-short>XUSER_INDEX</unmanaged-short>
    internal enum UserIndex : byte
    {
        /// <summary>
        /// <dd> <p>[in] Reserved</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_ONE</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_ONE</unmanaged-short>
        One = 0,

        /// <summary>
        /// <dd> <p>[out] Pointer to an <strong><see cref="T:PixelEngine.Extensions.XInput.Keystroke" /></strong> structure that receives an input event.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_TWO</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_TWO</unmanaged-short>
        Two = 1,

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_THREE</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_THREE</unmanaged-short>
        Three = 2,

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_FOUR</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_FOUR</unmanaged-short>
        Four = 3,

        /// <summary>
        /// <dd> <p>[in] Index of the signed-in gamer associated with the device. Can be a value in the range 0?XUSER_MAX_COUNT ? 1, or XUSER_INDEX_ANY to fetch the next available input event from any user.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_ANY</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_ANY</unmanaged-short>
        Any = 255, // 0xFF
    }
}