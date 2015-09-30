using System;

namespace Reevoo.Exceptions
{
    [Serializable]
    public class ReevooException : ApplicationException
    {
        public ReevooException(string message) : base(message) { }

        public ReevooException(string message, Exception innerException) : base(message, innerException) { }
    }
}
