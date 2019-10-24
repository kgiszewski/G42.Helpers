using System.Text;

namespace G42.Helpers.Exceptions
{
    public static class ErrorHelper
    {
        public static (string, string) GetInnerExceptions(System.Exception exception)
        {
            var messageSb = new StringBuilder();
            var traceSb = new StringBuilder();

            if (exception != null)
            {
                messageSb.AppendLine(exception.Message);
                traceSb.AppendLine(exception.StackTrace);

                GetInnerExceptions(exception.InnerException);
            }

            return (messageSb.ToString(), traceSb.ToString());
        }
    }
}
