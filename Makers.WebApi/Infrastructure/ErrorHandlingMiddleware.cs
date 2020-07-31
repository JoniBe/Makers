using Microsoft.AspNetCore.Http;
using Business.RestModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Makers.WebApi.Infrastructure
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _Next;

        public ErrorHandlingMiddleware (RequestDelegate next)
        {
            this._Next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _Next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        public static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError;
            var message = exception.Message;

            var responseModel = new ApiErrorModelResponse(message, (int)code);

            var result = JsonConvert.SerializeObject(responseModel);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }
}
