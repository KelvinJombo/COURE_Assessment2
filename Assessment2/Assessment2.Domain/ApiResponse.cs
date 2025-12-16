namespace Assessment2.Domain
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }   
        public T Data { get; set; }           
        public ApiError Error { get; set; }   

        public static ApiResponse<T> Ok(T data, string message = "OK")
        {
            return new ApiResponse<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static ApiResponse<T> Fail(string message, string code, object details = null)
        {
            return new ApiResponse<T>
            {
                Success = false,
                Message = message,
                Error = new ApiError
                {
                    ErrorCode = code,
                    Details = details
                }
            };
        }
    }

}
