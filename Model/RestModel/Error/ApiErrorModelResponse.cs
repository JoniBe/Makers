using System;
using System.Collections.Generic;
using System.Text;

namespace Model.RestModel.Error
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
