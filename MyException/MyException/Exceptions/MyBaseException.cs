using System;

namespace MyExceptionProject
{
    public class MyBaseException : Exception
    {
        public DateTime Timestamp { get; }
        public MyBaseException(string message) : base(message)
        {
            Timestamp = DateTime.Now;
        }
        public override string ToString()
        {
            return $"[{Timestamp}] {Message}";
        }
    }
}
