
namespace VeterinaryApp.Http.Model
{
    public class ResponseModel
    {
        public bool Success { get; set; } 
        public object Result { get; set; }
        public string Message { get; set; }
    }
}
