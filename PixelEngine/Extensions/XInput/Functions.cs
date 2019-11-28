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

using PixelEngine.Extensions.XInput;
using System;
using System.Runtime.InteropServices;

namespace PixelEngine.Extensions.XInput
{
    /// <summary>Functions</summary>
    internal static class XInput
    {
        /// <summary>
        /// <p>Retrieves the current state of the specified controller.</p>
        /// </summary>
        /// <param name="dwUserIndex"><dd> <p>Index of the user's controller. Can be a value from 0 to 3. For information about how this value is determined and how the value maps to indicators on the controller, see Multiple Controllers.</p> </dd></param>
        /// <param name="stateRef"><dd> <p>Pointer to an <strong><see cref="T:PixelEngine.Extensions.XInput.State" /></strong> structure that receives the current state of the controller.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p><p>If the controller is not connected, the return value is <strong>ERROR_DEVICE_NOT_CONNECTED</strong>.</p><p>If the function fails, the return value is an error code defined in Winerror.h. The function does not use <strong>SetLastError</strong> to set the calling thread's last-error code.</p></returns>
        /// <remarks>
        /// <p>When <strong>XInputGetState</strong> is used to retrieve controller data, the left and right triggers are each reported separately. For legacy reasons, when DirectInput retrieves controller data, the two triggers share the same axis. The legacy behavior is noticeable in the current Game Device Control Panel, which uses DirectInput for controller state.</p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetstate</doc-id>
        /// <unmanaged>DWORD XInputGetState([In] DWORD dwUserIndex,[Out] XINPUT_STATE* pState)</unmanaged>
        /// <unmanaged-short>XInputGetState</unmanaged-short>
        public static unsafe int XInputGetState(int dwUserIndex, out State stateRef)
        {
            stateRef = new State();
            int state;
            fixed (State* statePtr = &stateRef)
                state = XInputGetState_(dwUserIndex, (void*) statePtr);
            return state;
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputGetState", CallingConvention = CallingConvention.StdCall)]
        private static extern unsafe int XInputGetState_(int param0, void* param1);

        /// <summary>
        /// <p>Sends data to a connected controller. This function is used to activate the vibration function of a controller.</p>
        /// </summary>
        /// <param name="dwUserIndex"><dd> <p>Index of the user's controller. Can be a value from 0 to 3. For information about how this value is determined and how the value maps to indicators on the controller, see Multiple Controllers.</p> </dd></param>
        /// <param name="vibrationRef"><dd> <p>Pointer to an <strong><see cref="T:PixelEngine.Extensions.XInput.Vibration" /></strong> structure containing the vibration information to send to the controller.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p><p>If the controller is not connected, the return value is <strong>ERROR_DEVICE_NOT_CONNECTED</strong>.</p><p>If the function fails, the return value is an error code defined in WinError.h. The function does not use <em>SetLastError</em> to set the calling thread's last-error code.</p></returns>
        /// <doc-id>microsoft.directx_sdk.reference.xinputsetstate</doc-id>
        /// <unmanaged>DWORD XInputSetState([In] DWORD dwUserIndex,[In] XINPUT_VIBRATION* pVibration)</unmanaged>
        /// <unmanaged-short>XInputSetState</unmanaged-short>
        public static unsafe int XInputSetState(int dwUserIndex, ref Vibration vibrationRef)
        {
            Vibration.__Native @ref = new Vibration.__Native();
            vibrationRef.__MarshalTo(ref @ref);
            int num = XInputSetState_(dwUserIndex, (void*) &@ref);
            vibrationRef.__MarshalFree(ref @ref);
            return num;
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputSetState", CallingConvention = CallingConvention.StdCall)]
        private static extern unsafe int XInputSetState_(int param0, void* param1);

        /// <summary>
        /// <p>Retrieves the capabilities and features of a connected controller.</p>
        /// </summary>
        /// <param name="dwUserIndex"><dd> <p>Index of the user's controller. Can be a value in the range 0?3. For information about how this value is determined and how the value maps to indicators on the controller, see Multiple Controllers. </p> </dd></param>
        /// <param name="dwFlags"><dd> <p>Input flags that identify the controller type. If this value is 0, then the capabilities of all controllers connected to the system are returned. Currently, only one value is supported:</p> <table> <tr><th>Value</th><th>Description</th></tr> <tr><td><strong>XINPUT_FLAG_GAMEPAD</strong></td><td>Limit query to devices of Xbox 360 Controller type.</td></tr> </table> <p>?</p> <p>Any value of <em>dwflags</em> other than the above or 0 is illegal and will result in an error break when debugging.</p> </dd></param>
        /// <param name="capabilitiesRef"><dd> <p>Pointer to an <strong><see cref="T:PixelEngine.Extensions.XInput.Capabilities" /></strong> structure that receives the controller capabilities.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p><p>If the controller is not connected, the return value is <strong>ERROR_DEVICE_NOT_CONNECTED</strong>.</p><p>If the function fails, the return value is an error code defined in WinError.h. The function does not use <em>SetLastError</em> to set the calling thread's last-error code.</p></returns>
        /// <remarks>
        /// <strong>Note</strong>??The legacy XINPUT 9.1.0 version (included in Windows?Vista and later) always returned a fixed set of capabilities regardless of attached device.?
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetcapabilities</doc-id>
        /// <unmanaged>DWORD XInputGetCapabilities([In] DWORD dwUserIndex,[In] DWORD dwFlags,[Out] XINPUT_CAPABILITIES* pCapabilities)</unmanaged>
        /// <unmanaged-short>XInputGetCapabilities</unmanaged-short>
        public static unsafe int XInputGetCapabilities(
            int dwUserIndex,
            DeviceQueryType dwFlags,
            out Capabilities capabilitiesRef)
        {
            Capabilities.__Native @ref = new Capabilities.__Native();
            capabilitiesRef = new Capabilities();
            int capabilities = XInputGetCapabilities_(dwUserIndex, (int) dwFlags, (void*) &@ref);
            capabilitiesRef.__MarshalFrom(ref @ref);
            return capabilities;
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputGetCapabilities",
            CallingConvention = CallingConvention.StdCall)]
        private static extern unsafe int XInputGetCapabilities_(int param0, int param1, void* param2);

        /// <summary>
        /// <p>Sets the reporting state of XInput.</p>
        /// </summary>
        /// <param name="enable"><dd> <p>If enable is <strong><see cref="F:SharpDX.Result.False" /></strong>, XInput will only send neutral data in response to <strong>XInputGetState</strong> (all buttons up, axes centered, and triggers at 0). <strong>XInputSetState</strong> calls will be registered but not sent to the device. Sending any value other than <strong><see cref="F:SharpDX.Result.False" /> </strong>will restore reading and writing functionality to normal.</p> </dd></param>
        /// <remarks>
        /// <p>This function is meant to be called when an application gains or loses focus (such as via <strong>WM_ACTIVATEAPP</strong>). Using this function, you will not have to change the XInput query loop in your application as neutral data will always be reported if XInput is disabled.
        /// </p><p>In a controller that supports vibration effects:</p><ul> <li>Passing <strong><see cref="F:SharpDX.Result.False" /></strong> will stop any vibration effects currently playing. In this state, calls to <strong>XInputSetState</strong> will be registered, but not passed to the device.</li> <li>Passing <strong>TRUE</strong> will pass the last vibration request (even if it is 0) sent to <strong>XInputSetState</strong> to the device.</li> </ul>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputenable</doc-id>
        /// <unmanaged>void XInputEnable([In] BOOL enable)</unmanaged>
        /// <unmanaged-short>XInputEnable</unmanaged-short>
        public static void XInputEnable(RawBool enable)
        {
            XInputEnable_(enable);
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputEnable", CallingConvention = CallingConvention.StdCall)]
        private static extern void XInputEnable_(RawBool param0);

        /// <summary>
        /// <p>Retrieves the sound rendering and sound capture audio device IDs that are associated with the headset connected to the specified controller.</p>
        /// </summary>
        /// <param name="dwUserIndex"><dd> <p> Index of the gamer associated with the device.</p> </dd></param>
        /// <param name="renderDeviceIdRef"><dd> <p> Windows Core Audio device ID string for render (speakers).</p> </dd></param>
        /// <param name="renderCountRef"><dd> <p> Size, in wide-chars, of the render device ID string buffer.</p> </dd></param>
        /// <param name="captureDeviceIdRef"><dd> <p>Windows Core Audio device ID string for capture (microphone).</p> </dd></param>
        /// <param name="captureCountRef"><dd> <p>Size, in wide-chars, of capture device ID string buffer.</p> </dd></param>
        /// <returns><p>If the function successfully retrieves the device IDs for render and capture, the return code is <strong>ERROR_SUCCESS</strong>.</p><p>If there is no headset connected to the controller, the function will also retrieve <strong>ERROR_SUCCESS</strong> with <strong><c>null</c></strong> as the values for <em>pRenderDeviceId</em> and <em>pCaptureDeviceId</em>.</p><p>If the controller port device is not physically connected, the function will return <strong>ERROR_DEVICE_NOT_CONNECTED</strong>.</p><p>If the function fails, it will return a valid Win32 error code.</p></returns>
        /// <remarks>
        /// <p>Callers must allocate the memory for the buffers passed to <strong>XInputGetAudioDeviceIds</strong>. The resulting strings can be of arbitrary length.</p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetaudiodeviceids</doc-id>
        /// <unmanaged>DWORD XInputGetAudioDeviceIds([In] DWORD dwUserIndex,[Out, Buffer, Optional] wchar_t* pRenderDeviceId,[InOut, Optional] unsigned int* pRenderCount,[Out, Buffer, Optional] wchar_t* pCaptureDeviceId,[InOut, Optional] unsigned int* pCaptureCount)</unmanaged>
        /// <unmanaged-short>XInputGetAudioDeviceIds</unmanaged-short>
        public static unsafe int XInputGetAudioDeviceIds(
            int dwUserIndex,
            IntPtr renderDeviceIdRef,
            IntPtr renderCountRef,
            IntPtr captureDeviceIdRef,
            IntPtr captureCountRef)
        {
            return XInputGetAudioDeviceIds_(dwUserIndex, (void*) renderDeviceIdRef, (void*) renderCountRef,
                (void*) captureDeviceIdRef, (void*) captureCountRef);
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputGetAudioDeviceIds",
            CallingConvention = CallingConvention.StdCall)]
        private static extern unsafe int XInputGetAudioDeviceIds_(
            int param0,
            void* param1,
            void* param2,
            void* param3,
            void* param4);

        /// <summary>
        /// <p>Retrieves the battery type and charge status of a wireless controller.</p>
        /// </summary>
        /// <param name="dwUserIndex"><dd> <p>Index of the signed-in gamer associated with the device. Can be a value in the range 0?XUSER_MAX_COUNT ? 1.</p> </dd></param>
        /// <param name="devType"><dd> <p>Specifies which device associated with this user index should be queried. Must be <strong>BATTERY_DEVTYPE_GAMEPAD</strong> or <strong>BATTERY_DEVTYPE_HEADSET</strong>.</p> </dd></param>
        /// <param name="batteryInformationRef"><dd> <p>Pointer to an <strong><see cref="T:PixelEngine.Extensions.XInput.BatteryInformation" /></strong> structure that receives the battery information.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p></returns>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetbatteryinformation</doc-id>
        /// <unmanaged>DWORD XInputGetBatteryInformation([In] DWORD dwUserIndex,[In] unsigned char devType,[Out] XINPUT_BATTERY_INFORMATION* pBatteryInformation)</unmanaged>
        /// <unmanaged-short>XInputGetBatteryInformation</unmanaged-short>
        public static unsafe int XInputGetBatteryInformation(
            int dwUserIndex,
            BatteryDeviceType devType,
            out BatteryInformation batteryInformationRef)
        {
            batteryInformationRef = new BatteryInformation();
            int batteryInformation;
            fixed (BatteryInformation* batteryInformationPtr = &batteryInformationRef)
                batteryInformation =
                    XInputGetBatteryInformation_(dwUserIndex, (int) devType, (void*) batteryInformationPtr);
            return batteryInformation;
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputGetBatteryInformation",
            CallingConvention = CallingConvention.StdCall)]
        private static extern unsafe int XInputGetBatteryInformation_(
            int param0,
            int param1,
            void* param2);

        /// <summary>
        /// <p>Retrieves a gamepad input event.</p>
        /// </summary>
        /// <param name="dwUserIndex"><dd> <p>[in] Index of the signed-in gamer associated with the device. Can be a value in the range 0?XUSER_MAX_COUNT ? 1, or XUSER_INDEX_ANY to fetch the next available input event from any user.</p> </dd></param>
        /// <param name="dwReserved"><dd> <p>[in] Reserved</p> </dd></param>
        /// <param name="keystrokeRef"><dd> <p>[out] Pointer to an <strong><see cref="T:PixelEngine.Extensions.XInput.Keystroke" /></strong> structure that receives an input event.</p> </dd></param>
        /// <returns><p>If the function succeeds, the return value is <strong>ERROR_SUCCESS</strong>.</p><p>If no new keys have been pressed, the return value is <strong>ERROR_EMPTY</strong>.</p><p>If the controller is not connected or the user has not activated it, the return value is <strong>ERROR_DEVICE_NOT_CONNECTED</strong>. See the Remarks section below.</p><p>If the function fails, the return value is an error code defined in Winerror.h. The function does not use <strong>SetLastError</strong> to set the calling thread's last-error code.</p></returns>
        /// <remarks>
        /// <p>Wireless controllers are not considered active upon system startup, and calls to any of the <em>XInput</em> functions before a wireless controller is made active return <strong>ERROR_DEVICE_NOT_CONNECTED</strong>. Game titles must examine the return code and be prepared to handle this condition. Wired controllers are automatically activated when they are inserted. Wireless controllers are activated when the user presses the START or Xbox Guide button to power on the controller.</p>
        /// </remarks>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>DWORD XInputGetKeystroke([In] DWORD dwUserIndex,[In] DWORD dwReserved,[Out] XINPUT_KEYSTROKE* pKeystroke)</unmanaged>
        /// <unmanaged-short>XInputGetKeystroke</unmanaged-short>
        public static unsafe int XInputGetKeystroke(
            int dwUserIndex,
            int dwReserved,
            out Keystroke keystrokeRef)
        {
            keystrokeRef = new Keystroke();
            int keystroke;
            fixed (Keystroke* keystrokePtr = &keystrokeRef)
                keystroke = XInputGetKeystroke_(dwUserIndex, dwReserved, (void*) keystrokePtr);
            return keystroke;
        }

        [DllImport("xinput1_4.dll", EntryPoint = "XInputGetKeystroke", CallingConvention = CallingConvention.StdCall)]
        private static extern unsafe int XInputGetKeystroke_(int param0, int param1, void* param2);
    }
}