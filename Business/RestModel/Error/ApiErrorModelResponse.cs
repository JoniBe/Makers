using System;
using System.Collections.Generic;
using System.Text;

namespace Business.RestModel
{
    public class ApiErrorModelResponse
    {
        public ApiErrorModelResponse() { }
        public ApiErrorModelResponse(string m, int i)
        {
            message = m;
            code = i;
        }

        public string message { get; set; }
        public int code { get; set; }
    }
}
