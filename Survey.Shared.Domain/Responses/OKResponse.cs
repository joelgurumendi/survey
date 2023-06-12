namespace Surveys.Shared.Domain.Responses
{
    public class OKResponse : IResponse
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }

        public OKResponse()
        {
            Id = Guid.NewGuid();
            StatusCode = 200;
            Message = null;
        }
    }

    public class OKResponse<T>: IResponse<T>
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public T? Result { get; set; }

        public OKResponse(T result)
        {
            Id = Guid.NewGuid();
            StatusCode = 200;
            Message = null;
            Result = result;
        }        
    }
}
