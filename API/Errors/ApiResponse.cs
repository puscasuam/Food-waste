using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCod(statusCode);
        }

        public int StatusCode { get; set; }

        public string  Message { get; set; }

        private string GetDefaultMessageForStatusCod(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad request",
                401 => "Authorization required",
                404 => "Page not found",
                500 => "Something went wrong. Internal server error",
                _ => null
            };
        }
    }
}
