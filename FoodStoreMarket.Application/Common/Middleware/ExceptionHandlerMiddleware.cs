using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FoodStoreMarket.Domain.Exceptions;

namespace FoodStoreMarket.Application.Common.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public Task InvokeAsync(HttpContext httpContext, Exception exception)
        {
            var code = HttpStatusCode.NotFound;

            var result = string.Empty;

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)code;

            switch (exception)
            {
                case ObjectNotExistInDbException _:
                    code = HttpStatusCode.BadRequest;
                    break;
            }

            if (result == string.Empty)
            {
                result = JsonConvert.SerializeObject(new { error = exception.Message });
            }

            return httpContext.Response.WriteAsync(result);
        }
    }
}
