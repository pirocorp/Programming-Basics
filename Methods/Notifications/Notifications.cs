using System;

namespace Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string finalMessage = "";
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine(ReadAndProcessMessage());
                finalMessage += ReadAndProcessMessage();
                finalMessage += "\n";
            }
            Console.Write(finalMessage);
        }

        static string ReadAndProcessMessage()
        {
            string finalMessage = "";
            var messageType = Console.ReadLine();

            if (messageType == "success")
            {
                var message = Console.ReadLine();
                var operation = Console.ReadLine();
                finalMessage += ShowSuccessMessage(message, operation);
                finalMessage += "\n";
            }
            else if (messageType == "warning")
            {
                var message = Console.ReadLine();
                finalMessage += ShowWarningMessage(message);
                finalMessage += "\n";
            }
            else if (messageType == "error")
            {
                var operation = Console.ReadLine();
                var message = Console.ReadLine();
                var errorCode = Console.ReadLine();
                finalMessage += ShowErrorMessage(operation, message, errorCode);
                finalMessage += "\n";
            }

            return finalMessage;
        }

        static string ShowSuccessMessage(string message, string operation)
        {
            string successPartOfFinalMessage = $"Successfully executed {message}.";
            string graphicEqualsPartOfFinalMessage = new string('=', successPartOfFinalMessage.Length);
            string operationPartOfFinalMessage = $"{operation}.";
            string finalMessage = successPartOfFinalMessage + "\n" + graphicEqualsPartOfFinalMessage + "\n" + operationPartOfFinalMessage;
            return finalMessage;
        }

        static string ShowWarningMessage(string message)
        {
            string warningPartOfFinalMessage = $"Warning: {message}.";
            string graphicEqualsPartOfFinalMessage = new string('=', warningPartOfFinalMessage.Length);
            string finalMessage = warningPartOfFinalMessage + "\n" + graphicEqualsPartOfFinalMessage;
            return finalMessage;
        }

        static string ShowErrorMessage(string operation, string message, string errorCode)
        {
            string errorPartOfFinalMessage = $"Error: Failed to execute {operation}.";
            string graphicEqualsPartOfFinalMessage = new string('=', errorPartOfFinalMessage.Length);
            string messagePartOfFinalMessage = $"Reason: {message}.";
            string errorCodeOfFinalMessage = $"Error code: {errorCode}.";
            string finalMessage = errorPartOfFinalMessage + "\n" + graphicEqualsPartOfFinalMessage + "\n" + messagePartOfFinalMessage + "\n" + errorCodeOfFinalMessage;
            return finalMessage;
        }
    }
}
