using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
