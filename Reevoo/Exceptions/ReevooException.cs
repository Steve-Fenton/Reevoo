﻿using System;

namespace Reevoo.Exceptions
{
    public class ReevooException : ApplicationException
    {
        public ReevooException(string message) : base(message) { }

        public ReevooException(string message, Exception innerException) : base(message, innerException) { }
    }
}
