using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace calculo_cdb.Controllers
{
    public abstract class ObjectControllerBase : ControllerBase
    {
        protected ObjectResult ProcessRequest(Func<object> serviceExecution, HttpStatusCode statusCode)
        {
            try
            {
                var result = serviceExecution.Invoke();
                return new ObjectResult(result) { StatusCode = GetStatusCodeNumber(statusCode) };
            }
            catch (ArgumentException ex)
            {
                return new ObjectResult(new { message = ex.Message }) { StatusCode = GetStatusCodeNumber(HttpStatusCode.UnprocessableEntity) };
            }
            catch (Exception)
            {
                return new ObjectResult(new { message = "An unexpected error ocurred!" }) { StatusCode = GetStatusCodeNumber(HttpStatusCode.InternalServerError) };
            }
        }

        private int GetStatusCodeNumber(HttpStatusCode statusCode)
        {
            return Convert.ToInt32(statusCode);
        }
    }
}
