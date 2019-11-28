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

namespace PixelEngine.Extensions.XInput
{
    internal class SharpDXException : Exception
    {
        private ResultDescriptor descriptor;

        public SharpDXException()
            : base("A SharpDX exception occurred.")
        {
            this.descriptor = ResultDescriptor.Find((Result) Result.Fail);
            this.HResult = (int) Result.Fail;
        }

        public SharpDXException(Result result)
            : this(ResultDescriptor.Find(result))
        {
            this.HResult = (int) result;
        }

        public SharpDXException(ResultDescriptor descriptor)
            : base(descriptor.ToString())
        {
            this.descriptor = descriptor;
            this.HResult = (int) descriptor.Result;
        }

        public SharpDXException(Result result, string message)
            : base(message)
        {
            this.descriptor = ResultDescriptor.Find(result);
            this.HResult = (int) result;
        }

        public SharpDXException(Result result, string message, params object[] args)
            : base(string.Format((IFormatProvider) CultureInfo.InvariantCulture, message, args))
        {
            this.descriptor = ResultDescriptor.Find(result);
            this.HResult = (int) result;
        }

        public SharpDXException(string message, params object[] args)
            : this((Result) Result.Fail, message, args)
        {
        }

        public SharpDXException(string message, Exception innerException, params object[] args)
            : base(string.Format((IFormatProvider) CultureInfo.InvariantCulture, message, args), innerException)
        {
            this.descriptor = ResultDescriptor.Find((Result) Result.Fail);
            this.HResult = (int) Result.Fail;
        }

        public Result ResultCode
        {
            get { return this.descriptor.Result; }
        }

        public ResultDescriptor Descriptor
        {
            get { return this.descriptor; }
        }
    }
}