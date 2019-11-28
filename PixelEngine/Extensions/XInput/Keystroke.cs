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
    /// <p>Specifies keystroke data returned by <strong>XInputGetKeystroke</strong>.</p>
    /// </summary>
    /// <remarks>
    /// <p>Future devices may return HID codes and virtual key values that are not supported on current devices, and are currently undefined. Applications should ignore these unexpected values. </p><p>A <em>virtual-key</em> code is a byte value that represents a particular physical key on the keyboard, not the character or characters (possibly none) that the key can be mapped to based on keyboard state. The keyboard state at the time a virtual key is pressed modifies the character reported. For example, VK_4 might represent a "4" or a "$", depending on the state of the SHIFT key. </p><p>A reported keyboard event includes the virtual key that caused the event, whether the key was pressed or released (or is repeating), and the state of the keyboard at the time of the event. The keyboard state includes information about whether any CTRL, ALT, or SHIFT keys are down. </p><p>If the keyboard event represents an Unicode character (for example, pressing the "A" key), the <em>Unicode</em> member will contain that character. Otherwise, <em>Unicode</em> will contain the value zero. </p><p>The valid virtual-key (VK_xxx) codes are defined in XInput.h. In addition to codes that indicate key presses, the following codes indicate controller input. </p><table> <tr><th>Value</th><th>Description</th></tr> <tr><td>VK_PAD_A</td><td><strong>A</strong> button?</td></tr> <tr><td>VK_PAD_B</td><td><strong>B</strong> button?</td></tr> <tr><td>VK_PAD_X</td><td><strong>X</strong> button?</td></tr> <tr><td>VK_PAD_Y</td><td><strong>Y</strong> button?</td></tr> <tr><td>VK_PAD_RSHOULDER</td><td>Right shoulder button?</td></tr> <tr><td>VK_PAD_LSHOULDER</td><td>Left shoulder button?</td></tr> <tr><td>VK_PAD_LTRIGGER</td><td>Left trigger?</td></tr> <tr><td>VK_PAD_RTRIGGER</td><td>Right trigger?</td></tr> <tr><td>VK_PAD_DPAD_UP</td><td>Directional pad up?</td></tr> <tr><td>VK_PAD_DPAD_DOWN</td><td>Directional pad down?</td></tr> <tr><td>VK_PAD_DPAD_LEFT</td><td>Directional pad left?</td></tr> <tr><td>VK_PAD_DPAD_RIGHT</td><td>Directional pad right?</td></tr> <tr><td>VK_PAD_START</td><td><strong>START</strong> button?</td></tr> <tr><td>VK_PAD_BACK</td><td><strong>BACK</strong> button?</td></tr> <tr><td>VK_PAD_LTHUMB_PRESS</td><td>Left thumbstick click?</td></tr> <tr><td>VK_PAD_RTHUMB_PRESS</td><td>Right thumbstick click?</td></tr> <tr><td>VK_PAD_LTHUMB_UP</td><td>Left thumbstick up?</td></tr> <tr><td>VK_PAD_LTHUMB_DOWN</td><td>Left thumbstick down?</td></tr> <tr><td>VK_PAD_LTHUMB_RIGHT</td><td>Left thumbstick right?</td></tr> <tr><td>VK_PAD_LTHUMB_LEFT</td><td>Left thumbstick left?</td></tr> <tr><td>VK_PAD_LTHUMB_UPLEFT</td><td>Left thumbstick up and left?</td></tr> <tr><td>VK_PAD_LTHUMB_UPRIGHT</td><td>Left thumbstick up and right?</td></tr> <tr><td>VK_PAD_LTHUMB_DOWNRIGHT</td><td>Left thumbstick down and right?</td></tr> <tr><td>VK_PAD_LTHUMB_DOWNLEFT</td><td>Left thumbstick down and left?</td></tr> <tr><td>VK_PAD_RTHUMB_UP</td><td>Right thumbstick up?</td></tr> <tr><td>VK_PAD_RTHUMB_DOWN</td><td>Right thumbstick down?</td></tr> <tr><td>VK_PAD_RTHUMB_RIGHT</td><td>Right thumbstick right?</td></tr> <tr><td>VK_PAD_RTHUMB_LEFT</td><td>Right thumbstick left?</td></tr> <tr><td>VK_PAD_RTHUMB_UPLEFT</td><td>Right thumbstick up and left?</td></tr> <tr><td>VK_PAD_RTHUMB_UPRIGHT</td><td>Right thumbstick up and right?</td></tr> <tr><td>VK_PAD_RTHUMB_DOWNRIGHT</td><td>Right thumbstick down and right?</td></tr> <tr><td>VK_PAD_RTHUMB_DOWNLEFT</td><td>Right thumbstick down and left?</td></tr> </table><p>?</p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinput_keystroke</doc-id>
    /// <unmanaged>XINPUT_KEYSTROKE</unmanaged>
    /// <unmanaged-short>XINPUT_KEYSTROKE</unmanaged-short>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct Keystroke
    {
        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_keystroke</doc-id>
        /// <unmanaged>VirtualKey</unmanaged>
        /// <unmanaged-short>VirtualKey</unmanaged-short>
        public GamepadKeyCode VirtualKey;

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_keystroke</doc-id>
        /// <unmanaged>Unicode</unmanaged>
        /// <unmanaged-short>Unicode</unmanaged-short>
        public char Unicode;

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_keystroke</doc-id>
        /// <unmanaged>Flags</unmanaged>
        /// <unmanaged-short>Flags</unmanaged-short>
        public KeyStrokeFlags Flags;

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_keystroke</doc-id>
        /// <unmanaged>UserIndex</unmanaged>
        /// <unmanaged-short>UserIndex</unmanaged-short>
        public UserIndex UserIndex;

        /// <summary>No documentation.</summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_keystroke</doc-id>
        /// <unmanaged>HidCode</unmanaged>
        /// <unmanaged-short>HidCode</unmanaged-short>
        public byte HidCode;
    }
}