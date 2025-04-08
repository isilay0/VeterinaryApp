namespace VeterinaryApp.WebApi.Core.Response
{
    public class ResponseModel(bool success, object? result = null, string? message = null)
    {
        public bool Success { get; set; } = success;
        public object? Result { get; set; } = result;
        public string? Message { get; } = message;
    }
}
