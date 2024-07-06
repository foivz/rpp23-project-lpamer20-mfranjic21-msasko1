using System;
using System.Runtime.Serialization;

namespace DataAccessLayer.Repositories
{
    [Serializable]
    public class CustomerSupportException : Exception
    {
        public CustomerSupportException()
        {
        }

        public CustomerSupportException(string message) : base(message)
        {
        }

        public CustomerSupportException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomerSupportException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}