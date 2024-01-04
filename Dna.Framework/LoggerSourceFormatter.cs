namespace Dna.Framework
{
    public static class LoggerSourceFormatter
    {
        public static string Format(object[] state, Exception exception)
        {
            var origin = (string)state[0];
            var filePath = (string)state[1];
            var lineNumber = (string)state[2];
            var message = (string)state[3];

            var exceptionMessage = exception?.ToString();

            if (exceptionMessage != null)
                exceptionMessage = Environment.NewLine + exception;

            return $"{message} [{Path.GetFileName(filePath)} > {origin}() > {lineNumber}]{exceptionMessage}";
        }
    }
}
