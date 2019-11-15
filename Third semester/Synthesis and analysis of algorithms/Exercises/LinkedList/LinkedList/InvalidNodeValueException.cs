using System;

namespace LinkedList
{
    public class InvalidNodeValueException : Exception
    {
        private const string ExceptionMessage = "Previous node cannot be null.";

        public InvalidNodeValueException()
        {

        }

        public InvalidNodeValueException(string message)
            :base(ExceptionMessage)
        {

        }
    }
}
