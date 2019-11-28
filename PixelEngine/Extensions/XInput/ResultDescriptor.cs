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

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PixelEngine.Extensions.XInput
{
    internal sealed class ResultDescriptor
    {
        private static readonly object LockDescriptor = new object();
        private static readonly List<Type> RegisteredDescriptorProvider = new List<Type>();

        private static readonly Dictionary<Result, ResultDescriptor> Descriptors =
            new Dictionary<Result, ResultDescriptor>();

        private const string UnknownText = "Unknown";

        public ResultDescriptor(
            Result code,
            string module,
            string nativeApiCode,
            string apiCode,
            string description = null)
        {
            this.Result = code;
            this.Module = module;
            this.NativeApiCode = nativeApiCode;
            this.ApiCode = apiCode;
            this.Description = description;
        }

        public Result Result { get; private set; }

        public int Code
        {
            get { return this.Result.Code; }
        }

        public string Module { get; private set; }

        public string NativeApiCode { get; private set; }

        public string ApiCode { get; private set; }

        public string Description { get; set; }

        public bool Equals(ResultDescriptor other)
        {
            if ((object) other == null)
                return false;
            if ((object) this == (object) other)
                return true;
            return other.Result.Equals(this.Result);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if ((object) this == obj)
                return true;
            if (obj.GetType() != typeof(ResultDescriptor))
                return false;
            return this.Equals((ResultDescriptor) obj);
        }

        public override int GetHashCode()
        {
            return this.Result.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("HRESULT: [0x{0:X}], Module: [{1}], ApiCode: [{2}/{3}], Message: {4}",
                (object) this.Result.Code, (object) this.Module, (object) this.NativeApiCode, (object) this.ApiCode,
                (object) this.Description);
        }

        public static implicit operator Result(ResultDescriptor result)
        {
            return result.Result;
        }

        public static explicit operator int(ResultDescriptor result)
        {
            return result.Result.Code;
        }

        public static explicit operator uint(ResultDescriptor result)
        {
            return (uint) result.Result.Code;
        }

        public static bool operator ==(ResultDescriptor left, Result right)
        {
            if ((object) left == null)
                return false;
            return left.Result.Code == right.Code;
        }

        public static bool operator !=(ResultDescriptor left, Result right)
        {
            if ((object) left == null)
                return false;
            return left.Result.Code != right.Code;
        }

        public static void RegisterProvider(Type descriptorsProviderType)
        {
            lock (LockDescriptor)
            {
                if (RegisteredDescriptorProvider.Contains(descriptorsProviderType))
                    return;
                RegisteredDescriptorProvider.Add(descriptorsProviderType);
            }
        }

        public static ResultDescriptor Find(Result result)
        {
            ResultDescriptor resultDescriptor;
            lock (LockDescriptor)
            {
                if (RegisteredDescriptorProvider.Count > 0)
                {
                    foreach (Type type in RegisteredDescriptorProvider)
                        AddDescriptorsFromType(type);
                    RegisteredDescriptorProvider.Clear();
                }

                if (!Descriptors.TryGetValue(result, out resultDescriptor))
                    resultDescriptor = new ResultDescriptor(result, "Unknown", "Unknown", "Unknown", (string) null);
                if (resultDescriptor.Description == null)
                {
                    string descriptionFromResultCode = GetDescriptionFromResultCode(result.Code);
                    resultDescriptor.Description = descriptionFromResultCode ?? "Unknown";
                }
            }

            return resultDescriptor;
        }

        private static void AddDescriptorsFromType(Type type)
        {
            foreach (FieldInfo declaredField in type.GetTypeInfo().DeclaredFields)
            {
                if (declaredField.FieldType == typeof(ResultDescriptor) && declaredField.IsPublic &&
                    declaredField.IsStatic)
                {
                    ResultDescriptor resultDescriptor = (ResultDescriptor) declaredField.GetValue((object) null);
                    if (!Descriptors.ContainsKey(resultDescriptor.Result))
                        Descriptors.Add(resultDescriptor.Result, resultDescriptor);
                }
            }
        }

        private static string GetDescriptionFromResultCode(int resultCode)
        {
            IntPtr zero = IntPtr.Zero;
            int num = (int) FormatMessageW(4864, IntPtr.Zero, resultCode, 0, ref zero, 0, IntPtr.Zero);
            string stringUni = Marshal.PtrToStringUni(zero);
            Marshal.FreeHGlobal(zero);
            return stringUni;
        }

        [DllImport("kernel32.dll")]
        private static extern uint FormatMessageW(
            int dwFlags,
            IntPtr lpSource,
            int dwMessageId,
            int dwLanguageId,
            ref IntPtr lpBuffer,
            int nSize,
            IntPtr Arguments);
    }
}