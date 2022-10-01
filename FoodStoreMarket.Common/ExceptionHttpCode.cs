using FoodStoreMarket.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreMarket.Common
{
    public static class ExceptionHttpCode
    {
        public static HttpStatusCode GetHttpCodeFormException(Exception exception)
        {
            HttpStatusCode code = HttpStatusCode.InternalServerError;

            switch (exception)
            {
                case ObjectNotExistInDbException _:
                    code = HttpStatusCode.BadRequest;
                    break;
                case DbUpdateException _:
                    code = HttpStatusCode.InternalServerError;
                    break;
                case ValidationException _:
                    code = HttpStatusCode.BadRequest;
                    break;
            }

            return code;
        }
    }
}
