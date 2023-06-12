namespace Surveys.Shared.Domain.Responses
{
    public class ServerErrorResponse: IResponse
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }

        public ServerErrorResponse(string message)
        {
            Id = Guid.NewGuid();
            StatusCode = 500;
            Message = message;
        }
    }
}
