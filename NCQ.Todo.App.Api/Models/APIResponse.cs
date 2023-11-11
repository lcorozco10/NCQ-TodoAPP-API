namespace NCQ.Todo.App.Api.Models
{
    public class ErrorDetailValidation
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public string[]? Errors { get; set; }
    }

    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
    }

    public class OkResultData<T>
    {
        public int StatusCode { get; set; }
        public T? Data { get; set; }
    }
}
