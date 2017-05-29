using System;
using System.Collections.Generic;

namespace TroyTrivia.Business.Extensions
{
    public static class ExceptionExtensions
    {
        public static string GetAllExceptionMessages(this Exception exception)
        {
            IList<string> innerExceptions = new List<string>();

            do
            {
                innerExceptions.Add(exception.Message);
                exception = exception.InnerException;

            } while (exception != null);

            return string.Join("; ", innerExceptions);
        }
    }
}
