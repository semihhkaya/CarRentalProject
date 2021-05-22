using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        //Operasyonlar Get olmalarına rağmen (Read only) yani sadece return edilebilen değerler olmasına rağmen
        //Constructor yapılarla biz bunları set edebiliriz. //Yukarıda olduğu gibi
        public bool Success { get; }

        public string Message { get; }
    }
}
