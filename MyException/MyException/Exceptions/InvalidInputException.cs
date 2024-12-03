namespace MyExceptionProject
{
    public class InvalidInputException : MyBaseException
    {
        public InvalidInputException(string input)
            : base($"Invalid input provided: {input}")
        {
        }
    }
}
