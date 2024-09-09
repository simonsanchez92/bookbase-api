namespace Bookbase.Application.Utilities
{
    public class GenericResult<T>
    {
        public bool Success { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
        public T Data { get; set; }


        public GenericResult(bool success, List<string> messages, T data = default)
        {
            Success = success;
            Messages = messages;
            Data = data;
        }



        public static GenericResult<T> SuccessResult(T data, string message = "")
        {

            return new GenericResult<T>(true, new List<string> { message }, data);
        }


        public static GenericResult<T> FailureResult(List<string> messages)
        {   
            return new GenericResult<T>(false, messages);

        }
    }
}
