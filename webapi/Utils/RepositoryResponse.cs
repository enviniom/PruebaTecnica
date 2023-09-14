namespace webapi.Utils
{
    public class RepositoryResponse<TValue>
    {
        public bool Success { get; set; } = true;
        public string Error { get; set; } = string.Empty;
        public int StatusCode { get; set; }
        public TValue? Data { get; set; }

        public RepositoryResponse(int statusCode, string error, bool success)
        {
            Success = success;
            Error = error;
            StatusCode = statusCode;
        }
        public RepositoryResponse(int statusCode, TValue data)
        {
            Data = data;
            StatusCode = statusCode;
        }
    }
}
