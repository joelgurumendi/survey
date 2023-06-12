namespace Surveys.Shared.Domain.Exceptions
{
    public class ValueIsEmptyException: Exception
    {
        public ValueIsEmptyException(): base("The value cannot be empty"){}
    }
}
