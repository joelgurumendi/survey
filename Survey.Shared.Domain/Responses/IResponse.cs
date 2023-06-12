namespace Surveys.Shared.Domain.Responses
{
    public interface IResponse
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
    }

    public interface IResponse<T>
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public T? Result { get; set; }
    }
}
