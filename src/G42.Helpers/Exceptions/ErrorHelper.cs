using System.Text;

namespace G42.Helpers.Exceptions
{
    public static class ErrorHelper
    {
        public static string GetInnerExceptions(System.Exception exception)
        {
            var sb = new StringBuilder();

            if (exception != null)
            {
                sb.AppendLine(exception.Message);

                GetInnerExceptions(exception.InnerException);
            }

            return sb.ToString();
        }
    }
}
