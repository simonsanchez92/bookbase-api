using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookbase.Application.Utilities
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
        public T Data { get; set; }


        public Result(bool success, List<string> messages, T data = default)
        {
            Success = success;
            Messages = messages;
            Data = data;
        }



        public static Result<T> SuccessResult(T data, string message = "")
        {

            return new Result<T>(true, new List<string> { message }, data);
        }


        public static Result<T> FailureResult(List<string> messages)
        {   
            return new Result<T>(false, messages);

        }
    }
}
