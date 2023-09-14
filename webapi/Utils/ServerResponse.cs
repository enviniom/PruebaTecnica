namespace webapi.Utils
{
    public class ServerResponse<T>
    {
        public string Error { get; set; } = string.Empty;
        public int StatusCode { get; set; }
        public T? Data { get; set; }
    }
}
