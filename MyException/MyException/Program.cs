using System;

namespace MyExceptionProject
{
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; }

        public MyCustomException(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        public override string ToString()
        {
            return $"Error: {Message}, Code: {ErrorCode}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = -1;
                if (value < 0)
                {
                    throw new MyCustomException("Value cannot be negative!", 1001);
                }
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine("Caught a custom exception!");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Cleanup logic can go here.");
            }
        }
    }
}
