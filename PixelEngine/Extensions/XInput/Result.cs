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
using System.Globalization;
using System.Runtime.InteropServices;

namespace PixelEngine.Extensions.XInput
{
    internal struct Result : IEquatable<Result>
    {
        public static readonly Result Ok = new Result(unchecked((int) 0x00000000));
        public static readonly Result False = new Result(unchecked((int) 0x00000001));

        public static readonly ResultDescriptor Abort = new ResultDescriptor(unchecked((int) 0x80004004), "General",
            "E_ABORT", "Operation aborted", (string) null);

        public static readonly ResultDescriptor AccessDenied = new ResultDescriptor(unchecked((int) 0x80070005),
            "General", "E_ACCESSDENIED", "General access denied error", (string) null);

        public static readonly ResultDescriptor Fail = new ResultDescriptor(unchecked((int) 0x80004005), "General",
            "E_FAIL", "Unspecified error", (string) null);

        public static readonly ResultDescriptor Handle = new ResultDescriptor(unchecked((int) 0x80070006), "General",
            "E_HANDLE", "Invalid handle", (string) null);

        public static readonly ResultDescriptor InvalidArg = new ResultDescriptor(unchecked((int) 0x80070057),
            "General", "E_INVALIDARG", "Invalid Arguments", (string) null);

        public static readonly ResultDescriptor NoInterface = new ResultDescriptor(unchecked((int) 0x80004002),
            "General", "E_NOINTERFACE", "No such interface supported", (string) null);

        public static readonly ResultDescriptor NotImplemented = new ResultDescriptor(unchecked((int) 0x80004001),
            "General", "E_NOTIMPL", "Not implemented", (string) null);

        public static readonly ResultDescriptor OutOfMemory = new ResultDescriptor(unchecked((int) 0x8007000E),
            "General", "E_OUTOFMEMORY", "Out of memory", (string) null);

        public static readonly ResultDescriptor InvalidPointer = new ResultDescriptor(unchecked((int) 0x80004003),
            "General", "E_POINTER", "Invalid pointer", (string) null);

        public static readonly ResultDescriptor UnexpectedFailure = new ResultDescriptor(unchecked((int) 0x8000FFFF),
            "General", "E_UNEXPECTED", "Catastrophic failure", (string) null);

        public static readonly ResultDescriptor WaitAbandoned = new ResultDescriptor(unchecked((int) 0x00000080L),
            "General", "WAIT_ABANDONED", nameof(WaitAbandoned), (string) null);

        public static readonly ResultDescriptor WaitTimeout = new ResultDescriptor(unchecked((int) 0x00000102L),
            "General", "WAIT_TIMEOUT", nameof(WaitTimeout), (string) null);

        public static readonly ResultDescriptor Pending = new ResultDescriptor(unchecked((int) 0x8000000AL), "General",
            "E_PENDING", nameof(Pending), (string) null);

        private int _code;

        public Result(int code)
        {
            this._code = code;
        }

        public Result(uint code)
        {
            this._code = (int) code;
        }

        public int Code
        {
            get { return this._code; }
        }

        public bool Success
        {
            get { return this.Code >= 0; }
        }

        public bool Failure
        {
            get { return this.Code < 0; }
        }

        public static explicit operator int(Result result)
        {
            return result.Code;
        }

        public static explicit operator uint(Result result)
        {
            return (uint) result.Code;
        }

        public static implicit operator Result(int result)
        {
            return new Result(result);
        }

        public static implicit operator Result(uint result)
        {
            return new Result(result);
        }

        public bool Equals(Result other)
        {
            return this.Code == other.Code;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Result))
                return false;
            return this.Equals((Result) obj);
        }

        public override int GetHashCode()
        {
            return this.Code;
        }

        public static bool operator ==(Result left, Result right)
        {
            return left.Code == right.Code;
        }

        public static bool operator !=(Result left, Result right)
        {
            return left.Code != right.Code;
        }

        public override string ToString()
        {
            return string.Format((IFormatProvider) CultureInfo.InvariantCulture, "HRESULT = 0x{0:X}",
                (object) this._code);
        }

        public void CheckError()
        {
            if (this._code < 0)
                throw new SharpDXException(this);
        }

        public static Result GetResultFromException(Exception ex)
        {
            return new Result(Marshal.GetHRForException(ex));
        }

        public static Result GetResultFromWin32Error(int win32Error)
        {
            return (Result) (win32Error <= 0
                ? win32Error
                : (int) ((long) (win32Error & (int) ushort.MaxValue | 458752) | 2147483648L));
        }
    }
}