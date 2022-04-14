using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace calculo_cdb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentController : ObjectControllerBase
    {
        private readonly ICalculationService _calculator;

        public InvestmentController(ICalculationService calculator)
        {
            _calculator = calculator;
        }

        [HttpPost("CDB")]
        public ObjectResult ProcessInvestment(InvestmentDto request)
        {
            return ProcessRequest(
                serviceExecution: () => _calculator.ProcessInvestment(request),
                statusCode: HttpStatusCode.OK);
        }
    }
}
