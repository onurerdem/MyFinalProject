using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResults
    {
        //private bool v1;
        //private string v2;

        public Result(bool success, string message):this(success)
        {
            //this.v1 = v1;
            //this.v2 = v2;
            Message = message;
            //Success = success;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
