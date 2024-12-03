namespace MyExceptionProject
{
    public class OperationFailedException : MyBaseException
    {
        public string OperationName { get; }
        public OperationFailedException(string operationName)
            : base($"Operation '{operationName}' failed due to an error.")
        {
            OperationName = operationName;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Operation: {OperationName}";
        }
    }
}
