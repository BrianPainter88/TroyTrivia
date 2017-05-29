using System;

namespace TroyTrivia.Business.Exceptions
{
    public class InvalidGameParameterException : Exception
    {
        public InvalidGameParameterException()
        {

        }

        public InvalidGameParameterException(string message) : base(message)
        {

        }
    }
}
